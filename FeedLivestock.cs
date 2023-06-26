using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppV2
{
    public partial class FeedLivestock : Form
    {
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;

        public FeedLivestock(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            // Initialises and stuff
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;
            this.cbxGroup.DataSource = new List<string>() {"All","By species","By breed","By ID"};
            this.cbxFood.DataSource = lm.GetFoodList();
        }

        // Changes SpeciesOrID combo box based on choice
        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedIndex == 0)
            {
                cbxSpeciesOrID.Hide();
                cbxBreed.Hide();
            }
            else if (cbxGroup.SelectedIndex == 1)
            {
                cbxSpeciesOrID.Show();
                cbxBreed.Hide();
                cbxSpeciesOrID.DataSource = lm.GetSpeciesList();
            }
            else if (cbxGroup.SelectedIndex == 2)
            {
                cbxSpeciesOrID.Show();
                cbxBreed.Show();
                cbxSpeciesOrID.DataSource = lm.GetSpeciesList();
                cbxSpeciesOrID.DataSource = lm.GetBreedsList();
            }
            else
            {
                cbxSpeciesOrID.Show();
                cbxBreed.Hide();
                cbxSpeciesOrID.DataSource = lm.GetIDList();
            }
        }

        private void cbxSpeciesOrID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
