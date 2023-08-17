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
using System.Windows.Forms.DataVisualization.Charting;

namespace FarmFeedingAppV2
{
    public partial class DisplayData : Form
    {
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;

        DateTime currentDate = DateTime.Today;

        public DisplayData(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;

            cbxMode.DataSource = new List<string>() { "1.", "2.", "3." };
            cbxGroup.DataSource = new List<string>() { "All", "Species", "Breed" };
            cbxSpecies.DataSource = lm.GetSpeciesList();
            // Changes to be in line with species
            try
            {
                cbxBreed.DataSource = lm.GetBreedsList()[cbxSpecies.SelectedIndex];
            }
            catch (Exception)
            {
                // Changes source to be none
                List<string> emptyString = new List<string>() { "" };
                cbxBreed.DataSource = emptyString;
            }
        }

        private void DisplayData_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateChart()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            int[] chartArray = lm.ReturnHistoryArray(cbxMode.SelectedIndex, cbxGroup.SelectedIndex, (int)nudGraphLength.Value, cbxSpecies.SelectedIndex,cbxBreed.SelectedIndex);

            Array.Reverse(chartArray);

            for (int i = 0; i < chartArray.Length; i++)
            {
                series.Points.Add(chartArray[i], i);
            }

            // Out with the old series, in with the new one.
            chtStatGraph.Series.RemoveAt(0);
            chtStatGraph.Series.Add(series);

            // Displays dates on x axis
            for (int i = 0; i < chartArray.Length; i++)
            {
                chtStatGraph.Series[0].Points[i].AxisLabel = $"{currentDate.AddDays(-(int)nudGraphLength.Value + i).Day}/{currentDate.AddDays(-(int)nudGraphLength.Value + i).Month}";
            }

            chtStatGraph.Update();
        }

        private void cbxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Shows/Hides Breed combo box based on choice
        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedIndex == 0)
            {
                cbxSpecies.Hide();
                cbxBreed.Hide();
            }
            else if (cbxGroup.SelectedIndex == 1)
            {
                cbxSpecies.Show();
                cbxBreed.Hide();
            }
            else if (cbxGroup.SelectedIndex == 2)
            {
                cbxSpecies.Show();
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
                try
                {
                    cbxBreed.DataSource = lm.GetBreedsList()[cbxSpecies.SelectedIndex];
                    cbxBreed.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    // Changes source to be none
                    List<string> emptyString = new List<string>() { "" };
                    cbxBreed.DataSource = emptyString;
                    cbxBreed.SelectedIndex = 0;
                }
            }
        }

        private void cbxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudGraphLength_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateGraph_Click(object sender, EventArgs e)
        {
            // Updates chart to the right length :) very handy.
            UpdateChart();
        }
    }
}
