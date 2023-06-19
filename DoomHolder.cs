using Microsoft.VisualStudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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

            doom = Process.Start("C:/Users/kingi/Downloads/gzdoom-4-10-0-Windows-64bit/gzdoom.exe");
            doom.WaitForInputIdle();

            while (doom.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
                doom.Refresh();
            }
            Win32Methods.SetParent(doom.MainWindowHandle, this.Handle);

            // Start a separate thread to check if the process is still running
            checkProcessThread = new Thread(CheckProcessStatus);
            checkProcessThread.Start();
        }

        private void CheckProcessStatus()
        {
            while (!stopThread)
            {
                if (doom.HasExited)
                {
                    stopThread = true;
                }
                Thread.Sleep(1000); // Adjust the interval as needed
            }

            // The "doom" process has exited
        }

        private void button1_Click(object sender, EventArgs e) // This should not say "button1"
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(lm,pfc);
            myNewForm.FormClosed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
