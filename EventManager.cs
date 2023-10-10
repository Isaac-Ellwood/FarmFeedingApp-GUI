using Microsoft.VisualStudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmFeedingAppV2
{
    public class EventManager
    {
        // Attributes
        public SoundPlayer song;
        private List<string> songList = new List<string>();
        private bool[] songPlayed;

        // Constructs a Song Manager object
        public EventManager()
        {
            addSongs();
        }

        private void addSongs()
        {
            // Makes destination path string
            string destinationPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Songs");
            destinationPath = destinationPath.Replace('\u005C', '\u002F');
            // Makes it a directoryinfo thing
            DirectoryInfo d = new DirectoryInfo(destinationPath);

            FileInfo[] Files = d.GetFiles("*.wav"); //Getting .wav files

            int fileCount = 0;
            foreach (FileInfo file in Files)
            {
                songList.Add(file.Name);
                fileCount++;
            }
            songPlayed = new bool[fileCount];
            for (int i = 0; i < songPlayed.Length; i++)
            {
                songPlayed[i] = false;
            }
        }

        // Plays a song from the list, with autoplay
        public void playSong(bool random, string songT)
        {
            string songTitle;
            if (random)
            {
                bool allPlayed = true;
                // Checks if they are all played
                for (int i = 0; i < songPlayed.Length; i++)
                {
                    if (songPlayed[i] == false)
                    {
                        allPlayed = false;
                        break;
                    }
                }
                // If all played, will set all to unplayed
                if (allPlayed == true)
                {
                    for (int i = 0; i < songPlayed.Length; i++)
                    {
                        songPlayed[i] = false;
                    }
                }
                // Selects a random unplayed song (inefficient but functional)
                while (true)
                {
                    var rdm = new Random();
                    int index = rdm.Next(songList.Count);
                    if (songPlayed[index] == false)
                    {
                        songTitle = songList[index];
                        songPlayed[index] = true;
                        break;
                    }
                }
            }
            else
            {
                songTitle = songT;
            }

            // Gets the destination path (thanks Isaac)
            string destinationPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Songs", songTitle);
            destinationPath = destinationPath.Replace('\u005C', '\u002F');

            // plays the song
            song = new SoundPlayer(destinationPath);
            song.Play();
            Thread thread = new Thread(SongEndTrigger);
            thread.Start();
        }

        // Stops the song
        public void stopSong()
        {
            try
            {
                song.Stop();
            }
            catch
            {

            }
        }

        async void SongEndTrigger()
        {
            using (song)
            {
                await Task.Run(() => { song.Load(); song.PlaySync(); });
                //Finished. Now you can run your code here :)
                playSong(true, ""); // Plays next random song
            }
        }

        // Sets all fonts on a page to this. DOESNT WORK FOR BUTTONS BUT NEVERMIND LOLLLL
        public void SetAllControlsFont(System.Windows.Forms.Control.ControlCollection ctrls, PrivateFontCollection pfc)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls, pfc);
            }
        }
    }
}
