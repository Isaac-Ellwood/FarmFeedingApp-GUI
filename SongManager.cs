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

        // Constructs a Song Manager object
        public SongManager()
        {

        }

        public void playSong(bool random, string songT)
        {
            string songTitle;
            if (random)
            {
                // Fun code in here lolll
                songTitle = songT;// For now
            }
            else
            {
                songTitle = songT;
            }

            // Gets the destination path (thanks Isaac)
            string destinationPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Songs", songTitle+".wav");
            destinationPath = destinationPath.Replace('\u005C', '\u002F');

            // plays the song
            song = new SoundPlayer(destinationPath);
            song.Play();
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
    }
}
