using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FarmFeedingAppV2
{
    public class LivestockManager
    {
        // Attributes
        List<LivestockHolder> livestockHolders = new List<LivestockHolder>();

        // Sets the current date and time
        // TODO: alow manual changing of date
        DateTime currentDate = DateTime.Today;

        List<string> foods = new List<string>();
        List<float> foodPrices = new List<float>();
        List<string> speciesList = new List<string>();
        List<List<string>> breedsList = new List<List<string>>();
        
        // Should be false until it loads saved or default data
        public bool holdsData = false;

        // Constructs a Livestock Manager object
        public LivestockManager()
        {
        }

        // Sets livestock manager data to defaults
        public void SetDefaultData()
        {
            // Sets lists with default data
            speciesList = new List<string>()
            {
                "Cows (dairy)",
                "Cows (beef)",
                "Sheep"
            };

            breedsList = new List<List<string>>()
            {
                // Cows (dairy) breeds
                new List<string>()
                {
                    "Ayrshire",
                    "Brown Swiss",
                    "Fleckvieh",
                    "Guernsey",
                    "Holstein Friesian",
                    "Jersey",
                    "Milking Shorthorn"
                },
                // Cows (beef) breeds
                new List<string>()
                {
                    "Angus",
                    "Aubrac",
                    "Belgian Blue",
                    "Blonde D’aquitane",
                    "Charolais",
                    "Dexter",
                    "Belted Galloway",
                    "Brahman",
                    "Gelbvieh",
                    "Hereford",
                    "Highland",
                    "Holstein Friesian",
                    "Limousin",
                    "Lowline",
                    "Murray Grey",
                    "Piedmontese",
                    "Red Devon",
                    "Red Poll",
                    "Salers",
                    "Santa Gertrudis",
                    "Shorthorn",
                    "Simmental",
                    "South Devon",
                    "Speckle Park",
                    "Wagyu",
                    "Welsh Black"
                },
                // Sheep breeds
                new List<string>()
                {
                    "Borderdale",
                    "Border Leicester",
                    "Cheviot",
                    "Coopworth",
                    "Corriedale",
                    "Dorper",
                    "Dorset Down",
                    "Dorset Horn",
                    "Drysdale",
                    "East Friesian",
                    "English Leicester",
                    "Finnsheep",
                    "Hampshire",
                    "Lincoln",
                    "Merino",
                    "Oxford",
                    "Perendale",
                    "Poll Dorset",
                    "Polwarth",
                    "Romney",
                    "Ryeland",
                    "Shropshire",
                    "Southdown",
                    "South Dorset",
                    "South Suffolk",
                    "Suffolk",
                    "Texel",
                    "Wiltshire Horn"
                }
            };
            foods = new List<string>
            {
                // CHANGE THIS PLACEHOLDER LIST LATER
                "Grain",
                "Pellets"
            };
            foodPrices = new List<float>
            {
                // CHANGE THIS PLACEHOLDER LIST LATER
                2.5f,
                1.5f
            };
        }

        // Adds a livestock holder into livestockHolders list
        public void AddLivestockHolder(int species, int breed)
        {
            LivestockHolder lh = new LivestockHolder(species, breed, IDGenerator(species,breed));
            livestockHolders.Add(lh);
        }

        // Make IDs better and stuff. If u want lol
        // THanks future Isaav
        public string IDGenerator(int species, int breed)
        {
            return ($"{species}-{breed}#{livestockHolders.Count}");
        }

        // Returns IDs
        public List<string> GetIDList()
        {
            List<string> IDList = new List<string>();
            for (int i = 0; i < livestockHolders.Count; i++)
            {
                IDList.Add(livestockHolders[i].ID);
            }
            return IDList;
        }

        // Returns food list
        public List<string> GetFoodList()
        {
            return foods;
        }

        // Returns livestockHolders length
        public int GetLivestockHoldersLength()
        {
            return livestockHolders.Count;
        }

        // Returns species list
        public List<string> GetSpeciesList()
        {
            return speciesList;
        }

        // Sets species list
        public void SetSpeciesList(List<string> speciesList)
        {
            this.speciesList = speciesList;
        }

        // Returns list of breed list
        public List<List<string>> GetBreedsList()
        {
            return breedsList;
        }

        // Sets breed list
        public void SetBreedsList(List<List<string>> breedsList)
        {
            this.breedsList = breedsList;
        }

        // Feeds livestock
        public int FeedLivestock(int mode, int speciesOrID, int breed, int foodType, int foodQuantity, DateTime date)
        {
            int count = 0;
            // Modes 0-3 in the same order {"All","By species","By breed","By ID"}
            if (mode == 0)
            {
                // Loop through all livestock holders and feed all of them
                for (int i = 0; i < livestockHolders.Count; i++)
                {
                    livestockHolders[i].Feed(foodType, foodQuantity, date);
                    count++;
                }
            }
            else if (mode == 1)
            {
                for (int i = 0; i < livestockHolders.Count; i++)
                {
                    // Loop through all livestock holders and feed them if they are in the right species
                    if (livestockHolders[i].species == speciesOrID)
                    {
                        livestockHolders[i].Feed(foodType, foodQuantity, date);
                        count++;
                    }
                }
            }
            else if (mode == 2)
            {
                for (int i = 0; i < livestockHolders.Count; i++)
                {
                    // Loop through all livestock holders and feed them if they are in the right species AND breed
                    if (livestockHolders[i].species == speciesOrID && livestockHolders[i].breed == breed)
                    {
                        livestockHolders[i].Feed(foodType, foodQuantity, date);
                        count++;
                    }
                }
            }
            else
            {
                // Just the ID Index, whoch should be equal to the livestockHolders index for the same object.
                // TODO: Check if this works
                livestockHolders[speciesOrID].Feed(foodType, foodQuantity, date);
                count++;
            }

            return count;
        }

        // Returns history list
        public float[,] ReturnHistoryArray(int group, int length, int species, int breed)
        {
            float[] quantityArray = new float[length];
            float[] costArray = new float[length];
            
            // FOR ALL LIVESTOCK
            if (group == 0)
            {
                foreach (LivestockHolder lh in livestockHolders)
                {
                    for (int i = 0; i < lh.dates.Count; i++)
                    {
                        for (int dateIndex = -length; dateIndex < 1; dateIndex++)
                        {
                            if (lh.dates[i].Date == currentDate.AddDays(dateIndex))
                            {
                                quantityArray[i] += (lh.foodQuantity[i]);
                                costArray[i] += (lh.foodQuantity[i] * foodPrices[lh.foodType[i]]);
                            }
                        }
                    }
                }
            }
            // FOR A SINGLE BREED
            else if (group == 2)
            {
                foreach (LivestockHolder lh in livestockHolders)
                {
                    // Checks same breed and same species
                    if (lh.species == species && lh.breed == breed)
                    {
                        for (int i = 0; i < lh.dates.Count; i++)
                        {
                            // 
                            for (int dateIndex = -length; dateIndex < 1; dateIndex++)
                            {
                                if (lh.dates[i].Date == currentDate.AddDays(dateIndex))
                                {
                                    quantityArray[i] += (lh.foodQuantity[i]);
                                    costArray[i] += (lh.foodQuantity[i] * foodPrices[lh.foodType[i]]);
                                }
                            }
                        }
                    }
                }
            }
            // FOR A SINGLE SPECIES
            else if (group == 1)
            {
                foreach (LivestockHolder lh in livestockHolders)
                {
                    // Checks same species
                    if (lh.species == species)
                    {
                        for (int i = 0; i < lh.dates.Count; i++)
                        {
                            // 
                            for (int dateIndex = -length; dateIndex < 1; dateIndex++)
                            {
                                if (lh.dates[i].Date == currentDate.AddDays(dateIndex))
                                {
                                    quantityArray[i] += (lh.foodQuantity[i]);
                                    costArray[i] += (lh.foodQuantity[i] * foodPrices[lh.foodType[i]]);
                                }
                            }
                        }
                    }
                }
            }
            float[,] historyArray = new float[2,length];
            for (int i = 0; i < length; i++)
            {
                historyArray[0, i] = quantityArray[i];
            }
            for (int i = 0; i < length; i++)
            {
                historyArray[1, i] = costArray[i];
            }
            return historyArray;
        }

        // Add species/breed type
        public void AddSpeciesBreedType(int speciesIndex, string species, string breed)
        {
            if (breed == "")
            {
                // Just new Species
                if (speciesList.Contains(species))
                {
                    return;
                }
                else
                {
                    speciesList.Add(species);
                    breedsList.Add(new List<string>() { });
                }
            }
            else
            {
                // Just new breed!
                // Will add if species exists and breed does not
                if (speciesList.Contains(species) && BreedCheckExists(breed) == false)
                {
                    try
                    {
                        breedsList[speciesIndex].Add(breed);
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
                // New species, new breed!!!
                else
                {
                    // Redundant checks tbh, but it's okay.
                    if (speciesList.Contains(species) && BreedCheckExists(breed) == true)
                    {
                        return;
                    }
                    else
                    {
                        speciesList.Add(species);
                        List<string> newBreedString = new List<string>() { breed };
                        breedsList.Add(newBreedString);
                    }
                }
            }
        }

        public void RemoveSpeciesBreedType(int group, int speciesIndex, int breedIndex)
        {
            // Removing species
            if (group == 0 && speciesIndex >= 0)
            {
                speciesList.RemoveAt(speciesIndex);
                breedsList.RemoveAt(speciesIndex);
            }
            // Removing breed
            else if (group == 1 && speciesIndex >= 0 && breedIndex >= 0)
            {
                breedsList[speciesIndex].RemoveAt(breedIndex);
            }
            // Failed
            else
            {

            }
        }

        // Checks if breed already exists across all stored breeds currently.
        // True = it exists
        // False = it does not exist
        bool BreedCheckExists(string breedToCheck)
        {
            for (int speciesIndex = 0; speciesIndex < speciesList.Count; speciesIndex++)
            {
                // Try catch will work, it checks it correctly. (hopefully)
                try
                {
                    // Couldv'e just used List.Contains, but that would be boring lol.
                    for (int breedIndex = 0; breedIndex < breedsList[speciesIndex].Count; breedIndex++)
                    {
                        if (breedsList[speciesIndex][breedIndex] == breedToCheck)
                        {
                            return true;
                        }
                    }
                }
                catch
                {
                    return false;
                }
                
            }
            return false;
        }

        // Deserialises and sets save data
        public void DeserialiseSaveData()
        {
            // Deserialises Save Data
            string fileName = "SaveData.json";
            string jsonString = File.ReadAllText(fileName);
            SaveData saveData = JsonSerializer.Deserialize<SaveData>(jsonString)!;


            // Sorts livestockHolders list into a serialisable format

            // Makes lots of lists
            // 2d lists
            for (int i = 0; i < saveData.lHoldersID.Count; i++)
            {
                // Creates livestockholder and adds it to livestock holder list
                LivestockHolder livestockHolder = new LivestockHolder(saveData.lHoldersSpecies[i], saveData.lHoldersBreed[i], saveData.lHoldersID[i]);
                livestockHolders.Add(livestockHolder);

                // Pulls livestock data from 2d lists (prone to fails, so in try catch statements for now)
                // Update: 8/06/2023 they are behaving themselves and are currently free from their try catch statements
                livestockHolders[livestockHolders.Count - 1].foodQuantity = saveData.fQuantityListList[i];
                livestockHolders[livestockHolders.Count - 1].foodType = saveData.fTypeListList[i];
                livestockHolders[livestockHolders.Count - 1].dates = saveData.fDateListList[i];

                Console.WriteLine($"Deserialising {i + 1}/{saveData.lHoldersID.Count}");
            }

            // Sets lists with deserialised data
            foods = saveData.fList;
            foodPrices = saveData.fPriceList;
            speciesList = saveData.sList;
            breedsList = saveData.bList;
        }

        // Serialises and saves save data
        public void SerialiseSaveData()
        {
            // Sorts livestockHolders list into a serialisable format

            // Makes lots of lists
            List<int> livestockHoldersSpecies = new List<int>();
            List<int> livestockHoldersBreed = new List<int>();
            List<string> livestockHoldersID = new List<string>();
            // 2d lists
            List<List<float>> foodQuantityListList = new List<List<float>>();
            List<List<int>> foodTypeListList = new List<List<int>>();
            List<List<DateTime>> datesListList = new List<List<DateTime>>();

            for (int i = 0; i < livestockHolders.Count; i++)
            {
                // Adds livestock data to lists
                livestockHoldersSpecies.Add(livestockHolders[i].species);
                livestockHoldersBreed.Add(livestockHolders[i].breed);
                livestockHoldersID.Add(livestockHolders[i].ID);
                // 2d lists
                foodQuantityListList.Add(livestockHolders[i].foodQuantity);
                foodTypeListList.Add(livestockHolders[i].foodType);
                datesListList.Add(livestockHolders[i].dates);

                Console.WriteLine($"Serialising {i + 1}/{livestockHolders.Count}");
            }

            // Declares new SaveData and sets it
            var saveData = new SaveData
            {
                fList = foods,
                fPriceList = foodPrices,
                sList = speciesList,
                bList = breedsList,
                lHoldersSpecies = livestockHoldersSpecies,
                lHoldersBreed = livestockHoldersBreed,
                lHoldersID = livestockHoldersID,
                fQuantityListList = foodQuantityListList,
                fTypeListList = foodTypeListList,
                fDateListList = datesListList
            };

            // Serialises data and saves to \bin\Debug\net5.0
            string fileName = "SaveData.json";
            string jsonString = JsonSerializer.Serialize(saveData);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
