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
    public partial class EditCategories : Form
    {
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;
        public EditCategories(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            // Initialises and stuff
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;

            cbxGroup.DataSource = new List<string>() {"Species","Breed"};
            cbxSpecies.DataSource = lm.GetSpeciesList();
            cbxBreed.DataSource = lm.GetBreedsList()[cbxSpecies.SelectedIndex];
        }

        // Shows/Hides Breed combo box based on choice
        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedIndex == 0)
            {
                cbxBreed.Hide();
            }
            else if (cbxGroup.SelectedIndex == 1)
            {
                cbxBreed.Show();
            }
        }

        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpecies.SelectedIndex < 0)
            {
                // Changes source to be none
                List<string> emptyString = new List<string>() { "" };
                cbxBreed.DataSource = emptyString;
            }
            else
            {
                // Changes to be in line with species
                cbxBreed.DataSource = lm.GetBreedsList()[cbxSpecies.SelectedIndex];
            }
        }

        private void cbxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string breed = cbxBreed.Text;

            if (cbxGroup.SelectedIndex == 0)
            {
                breed = "";
            }

            lm.AddSpeciesBreedType(cbxSpecies.SelectedIndex, cbxSpecies.Text, breed);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
