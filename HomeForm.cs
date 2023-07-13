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
    public partial class HomeForm : Form
    {
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;
        bool saved = false;

        public HomeForm(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            // Initialises and stuff
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;

            // Plays a fun tune
            sm.playSong(true, "chillin39-20915");

            // Sets font
            lblTitle.Font = new Font(pfc.Families[2], lblTitle.Font.Size);

            System.Drawing.FontFamily btnFont = pfc.Families[0];
            float btnSize = btnAddLivestock.Font.Size;
            btnAddLivestock.Font = new Font(btnFont, btnSize);
            btnFeedLivestock.Font = new Font(btnFont, btnSize);
            btnEditLivestockAndFoodCategories.Font = new Font(btnFont, btnSize);

            // Save data handling and checks
            if (lm.holdsData == false)
            {
                if (File.Exists("SaveData.json"))
                {
                    DialogResult res = MessageBox.Show("Save data detected. Would you like to load existing save data?", "Save Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        // Either deserialises save data or sets data to defaults
                        try
                        {
                            lm.DeserialiseSaveData();
                        }
                        catch
                        {
                            lm.SetDefaultData();
                        }
                    }
                    if (res == DialogResult.No)
                    {
                        MessageBox.Show("Previous save data has been deleted");

                        // Delete the file and set defualt data
                        File.Delete("SaveData.json");
                        lm.SetDefaultData();
                    }
                    if (res == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    lm.SetDefaultData();
                }
                lm.holdsData = true;
            }
        }

        // Makes sure user doesn't lose all their save data with the big juicy X in the corner.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Checks that the data hasn't already been saved
            if(saved == false)
            {
                // Check if the form is being closed by the user
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    // Display a message box with custom text and buttons
                    DialogResult result = MessageBox.Show("Do you want to save your changes?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Saves data before closing
                        lm.SerialiseSaveData();
                    }
                    if (result == DialogResult.No)
                    {
                        // Does nothing, and form closes
                    }
                    if (result == DialogResult.Cancel)
                    {
                        // Cancel the form closing event
                        e.Cancel = true;
                    }
                }
            }
            
            base.OnFormClosing(e);
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            lm.SerialiseSaveData();
            saved = true;
            this.Close();
        }

        private void btnEditLivestockAndFoodCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoomHolder myNewForm = new DoomHolder(lm, pfc, sm);
            myNewForm.FormClosed += (s, args) => this.Close();
            myNewForm.Show();
        }

        

        private void btnFeedLivestock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedLivestock myNewForm = new FeedLivestock(lm, pfc, sm);
            myNewForm.FormClosed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnAddLivestock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Livestock myNewForm = new Add_Livestock(lm, pfc, sm);
            myNewForm.FormClosed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
