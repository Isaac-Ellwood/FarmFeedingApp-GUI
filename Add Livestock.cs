using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppV2
{
    public partial class Add_Livestock : Form
    {
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;

        public Add_Livestock(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            // Initialises and stuff
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;
            this.cbxSpecies.DataSource = lm.GetSpeciesList();
            this.cbxSpecies.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxSpecies.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Changes Breed combo box to display breeds for each species
        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxBreed.DataSource = lm.GetBreedsList()[cbxSpecies.SelectedIndex];
        }

        private void btnAddLivestock_Click(object sender, EventArgs e)
        {
            // Checks that it has valid data in combo boxes
            // Leaving invalid strings in will result in an index of -1
            if (cbxSpecies.SelectedIndex >= 0 && cbxBreed.SelectedIndex >= 0)
            {
                for (int i = 0; i < nudLivestockCount.Value; i++)
                {
                    lm.AddLivestockHolder(cbxSpecies.SelectedIndex, cbxBreed.SelectedIndex);
                }

                this.Hide();
                HomeForm myNewForm = new HomeForm(lm, pfc, sm);
                myNewForm.FormClosed += (s, args) => this.Close();
                myNewForm.Show();
            }
            else
            {
                // Cool string error mesasges.
                string caption = "Data Error";
                string text = "";
                if (cbxSpecies.SelectedIndex < 0)
                {
                    text += "Species";
                    if (cbxBreed.SelectedIndex < 0)
                    {
                        text += " and Breed are ";
                    }
                    else
                    {
                        text += " is ";
                    }
                    text += "invalid";
                }
                else
                {
                    text += "Breed is invalid";
                }
                text += "\n Try again";
                MessageBox.Show(text, caption);
            }
        }
    }
}
