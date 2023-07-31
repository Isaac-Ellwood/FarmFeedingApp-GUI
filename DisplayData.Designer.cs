
namespace FarmFeedingAppV2
{
    partial class DisplayData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnUpdateGraph = new System.Windows.Forms.Button();
            this.chtStatGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateGraph
            // 
            this.btnUpdateGraph.Location = new System.Drawing.Point(314, 385);
            this.btnUpdateGraph.Name = "btnUpdateGraph";
            this.btnUpdateGraph.Size = new System.Drawing.Size(184, 23);
            this.btnUpdateGraph.TabIndex = 0;
            this.btnUpdateGraph.Text = "Update Graph";
            this.btnUpdateGraph.UseVisualStyleBackColor = true;
            this.btnUpdateGraph.Click += new System.EventHandler(this.btnUpdateGraph_Click);
            // 
            // chtStatGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chtStatGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtStatGraph.Legends.Add(legend1);
            this.chtStatGraph.Location = new System.Drawing.Point(127, 43);
            this.chtStatGraph.Name = "chtStatGraph";
            series1.ChartArea = "ChartArea1";
            //
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtStatGraph.Series.Add(series1);
            this.chtStatGraph.Size = new System.Drawing.Size(547, 300);
            this.chtStatGraph.TabIndex = 1;
            this.chtStatGraph.Text = "chart1";
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chtStatGraph);
            this.Controls.Add(this.btnUpdateGraph);
            this.Name = "DisplayData";
            this.Text = "DisplayData";
            ((System.ComponentModel.ISupportInitialize)(this.chtStatGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStatGraph;
    }
}