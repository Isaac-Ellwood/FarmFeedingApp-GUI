﻿using System;
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
        List<string> livestockGroupIDs = new List<string>();
        List<LivestockHolder> livestockHolders = new List<LivestockHolder>();

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

        // Returns food history as string for the last (time) days
        public string foodHistory(int animal, int time)
        {
            // Creates temp lists
            List<float> foodQuantityHistory = new List<float>();
            List<int> foodTypeHistory = new List<int>();
            List<DateTime> datesHistory = new List<DateTime>();

            float totalFoodCost = 0f;

            // Adds food history to temp lists
            for (int i = 0; i < time; i++)
            {
                foodQuantityHistory.Add(livestockHolders[animal].foodQuantity[livestockHolders[animal].foodQuantity.Count - time + i]);
                foodTypeHistory.Add(livestockHolders[animal].foodType[livestockHolders[animal].foodType.Count - time + i]);
                datesHistory.Add(livestockHolders[animal].dates[livestockHolders[animal].dates.Count - time + i]);
            }


            // Converts lists to string and returns
            string foodHistory = "";

            foodHistory += $"Species: {speciesList[livestockHolders[animal].species]}\n" +
                $"Breed: {breedsList[livestockHolders[animal].species][livestockHolders[animal].breed]}\n" +
                $"ID: {livestockHolders[animal].ID}\n";

            for (int i = 0; i < time; i++)
            {
                foodHistory += $"Date: {datesHistory[i].Day}/{datesHistory[i].Month}/{datesHistory[i].Year} Type: {this.foods[foodTypeHistory[i]]} Quanitity: {foodQuantityHistory[i]}g\n";

                totalFoodCost += (foodQuantityHistory[i] * foodPrices[foodTypeHistory[i]]);
            }

            foodHistory += ($"Total cost: ${totalFoodCost}");

            return foodHistory;
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
