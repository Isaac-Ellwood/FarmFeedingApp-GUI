using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppV2
{
    public partial class HomeForm : Form
    {
        LivestockManager lm;
        public HomeForm(LivestockManager lm)
        {
            InitializeComponent();
            this.lm = lm;

            if (File.Exists("SaveData.json"))
            {
                DialogResult res = MessageBox.Show("Save data detected. Would you like to load existing save data?", "Save Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("You have clicked Ok Button");

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
                    MessageBox.Show("You have clicked Cancel Button");

                    lm.SetDefaultData();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("You have clicked Cancel Button");

                    this.Close();
                }
            }
            else
            {
                lm.SetDefaultData();
            }

            
        }

        

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            lm.SerialiseSaveData();
            this.Close();
        }
    }
}
