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
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppV2
{
    public partial class DoomHolder : Form
    {
        Process doom;
        LivestockManager lm;
        PrivateFontCollection pfc;
        Thread checkProcessThread;
        private volatile bool stopThread = false;

        public DoomHolder(LivestockManager lm, PrivateFontCollection pfc)
        {
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;

            // Specify the file name and the destination path in the Resources folder (More string manipulation than in the actual program)
            string destinationPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "gzdoom-4-10-0-Windows-64bit", "gzdoom.exe");
            destinationPath = destinationPath.Replace('\u005C', '\u002F');

            // Starts process
            doom = Process.Start(destinationPath);
            doom.WaitForInputIdle();

            while (doom.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
                doom.Refresh();
            }
            Win32Methods.SetParent(doom.MainWindowHandle, this.Handle);
        }

        private void button1_Click(object sender, EventArgs e) // This should not say "button1", But it does because of vs glitches. IF ERROR, LOOK HERE.
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(lm,pfc);
            myNewForm.FormClosed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
