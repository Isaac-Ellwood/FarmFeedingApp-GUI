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
            for (int i = 0; i < cbx; i++)
            {

            }
        }
    }
}
