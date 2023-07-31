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

        List<Series> series;


        public DisplayData(LivestockManager lm, PrivateFontCollection pfc, SongManager sm)
        {
            InitializeComponent();
            this.lm = lm;
            this.pfc = pfc;
            this.sm = sm;

            series = new List<Series>();
        }

        private void DisplayData_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateChart(int length)
        {
            series.Add(new Series());

            List<int> chartList = lm.ReturnHistoryList(1, length);
            //List<int> chartList = new List<int>() {100,2,6,6,7,7,6,5,5,4,4,6,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,100 };

            for (int i = 0; i < chartList.Count; i++)
            {
                series[series.Count - 1].Points.Add(chartList[i],i);
            }
            series[series.Count-1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chtStatGraph.Series.Add(series[series.Count - 1]);

            chtStatGraph.Update();
        }

        private void btnUpdateGraph_Click(object sender, EventArgs e)
        {
            // Updates chart to the right length :) very handy.
            // I know, thanks. I also made sure that it works with lengths that are too high, as it defaults to the highest value.
            UpdateChart(100);
        }
    }
}
