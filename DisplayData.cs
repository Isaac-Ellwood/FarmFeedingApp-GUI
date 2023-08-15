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
            // Gets rid of legend
            chtStatGraph.Legends.RemoveAt(0);

            //
            cbxMode.DataSource = new List<string>() { "Total Food Quanitity", "Food Quantity by Breed", "Food Quantity by Species", "Total Food Cost", "Food Cost by Breed", "Food Cost by Species"};
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

        private void UpdateChart(int length)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            float[] chartArray = lm.ReturnHistoryArray(3, length, 3, 0);

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
                chtStatGraph.Series[0].Points[i].AxisLabel = $"{currentDate.AddDays(-length + i).Day}/{currentDate.AddDays(-length + i).Month}";
            }

            chtStatGraph.Update();
        }

        private void btnUpdateGraph_Click(object sender, EventArgs e)
        {
            // Updates chart to the right length :) very handy.
            UpdateChart(5);
        }
        private void cbxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMode.SelectedIndex == 0 | cbxMode.SelectedIndex == 3)
            {
                cbxSpecies.Hide();
                cbxBreed.Hide();
            }
            else if (cbxMode.SelectedIndex == 1 | cbxMode.SelectedIndex == 4)
            {
                cbxSpecies.Show();
                cbxBreed.Show();
            }
            else
            {
                cbxSpecies.Show();
                cbxBreed.Hide();
            }
        }
        private void cbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
