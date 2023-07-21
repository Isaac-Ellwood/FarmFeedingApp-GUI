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

            for (int i = 0; i < length; i++)
            {
                series[series.Count - 1].Points.Add(i,chartList[i]);
            }

            chtStatGraph.Update();
        }

        private void btnUpdateGraph_Click(object sender, EventArgs e)
        {
            UpdateChart(5);
        }
    }
}
