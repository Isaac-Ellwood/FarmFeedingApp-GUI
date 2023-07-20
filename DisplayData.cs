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
        Chart chart;
        LivestockManager lm;
        PrivateFontCollection pfc;
        SongManager sm;

        public DisplayData()
        {
            InitializeComponent();
        }

        private void UpdateChart(int length)
        {
            lm.ReturnHistoryList(1, length);

            for (int i = 0; i < length; i++)
            {
                //chart.Series["seriesname"].Points.AddXY();
            }
        }
    }
}
