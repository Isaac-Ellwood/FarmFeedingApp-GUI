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
                cbxBreed.DataSource = lm.GetBreedsList()[cbxSpeciesOrID.SelectedIndex];
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
            // Updates the breed combo box, if feeding anything except ID
            // It would error before, but it's fixed :)
            // Hopefully
            if (cbxGroup.SelectedIndex <= 2)
            {
                cbxBreed.DataSource = lm.GetBreedsList()[cbxSpeciesOrID.SelectedIndex];
            }
        }

        private void btnFeedLivestock_Click(object sender, EventArgs e)
        {
            // Passes it all into the livestock manager
            int fedLivestock = lm.FeedLivestock(cbxGroup.SelectedIndex, cbxSpeciesOrID.SelectedIndex, cbxBreed.SelectedIndex, cbxFood.SelectedIndex, Decimal.ToInt32(nudFoodAmount.Value), dtpFeedDate.Value);

            // Shows message box based on sucess or failure
            // TODO: change error messages
            string title;
            string caption;

            if (fedLivestock > 0)
            {
                title = "Success!";
                caption = $"{fedLivestock} livestock have been fed sucessfully";
            }
            else
            {
                title = "Error";
                caption = "Not enough animals in selected class";
            }
            MessageBox.Show(caption, title);
        }

        public override string ToString()
        {
            return "";
        }
    }
}
