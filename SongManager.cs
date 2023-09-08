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
    public class SongManager
    {
        // Attributes
        public SoundPlayer song;
        private List<string> songList = new List<string>();
        private List<int> songPlayCount;
        private int highPlayCount = 0;

        // Constructs a Song Manager object
        public SongManager()
        {
            addSongs();
        }

        private void addSongs()
        {
            // Makes destination path string
            string destinationPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Songs"); //Assuming Test is your Folder
            destinationPath = destinationPath.Replace('\u005C', '\u002F');
            // Makes it a directoryinfo thing
            DirectoryInfo d = new DirectoryInfo(destinationPath);

            FileInfo[] Files = d.GetFiles("*.wav"); //Getting .wav files

            foreach (FileInfo file in Files)
            {
                songList.Add(file.Name);
                songPlayCount.Add(0);
            }
        }

        // Plays a song from the list, with autoplay
        public void playSong(bool random, string songT)
        {
            string songTitle;
            if (random)
            {
                // Selects a random song
                var rdm = new Random();
                int index = rdm.Next(songList.Count);
                songTitle = songList[index];
                songPlayCount[index]++;
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
                MessageBox.Show("Finished. Now you can run your code here");
            }
        }
    }
}
