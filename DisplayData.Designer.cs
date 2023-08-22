
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtStatGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxBreed = new System.Windows.Forms.ComboBox();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.cbxMode = new System.Windows.Forms.ComboBox();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.nudGraphLength = new System.Windows.Forms.NumericUpDown();
            this.rtbSummaryText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGraphLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chtStatGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chtStatGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtStatGraph.Legends.Add(legend2);
            this.chtStatGraph.Location = new System.Drawing.Point(127, 43);
            this.chtStatGraph.Name = "chtStatGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtStatGraph.Series.Add(series2);
            this.chtStatGraph.Size = new System.Drawing.Size(998, 669);
            this.chtStatGraph.TabIndex = 1;
            this.chtStatGraph.Text = "chart1";
            // 
            // cbxBreed
            // 
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(734, 758);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(121, 21);
            this.cbxBreed.TabIndex = 2;
            this.cbxBreed.SelectedIndexChanged += new System.EventHandler(this.cbxBreed_SelectedIndexChanged);
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(569, 759);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(121, 21);
            this.cbxSpecies.TabIndex = 3;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // cbxMode
            // 
            this.cbxMode.FormattingEnabled = true;
            this.cbxMode.Location = new System.Drawing.Point(261, 759);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Size = new System.Drawing.Size(121, 21);
            this.cbxMode.TabIndex = 4;
            this.cbxMode.SelectedIndexChanged += new System.EventHandler(this.cbxMode_SelectedIndexChanged);
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(419, 759);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxGroup.TabIndex = 5;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // nudGraphLength
            // 
            this.nudGraphLength.Location = new System.Drawing.Point(894, 759);
            this.nudGraphLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGraphLength.Name = "nudGraphLength";
            this.nudGraphLength.Size = new System.Drawing.Size(120, 20);
            this.nudGraphLength.TabIndex = 6;
            this.nudGraphLength.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudGraphLength.ValueChanged += new System.EventHandler(this.nudGraphLength_SelectedValueChanged);
            // 
            // rtbSummaryText
            // 
            this.rtbSummaryText.Location = new System.Drawing.Point(1201, 184);
            this.rtbSummaryText.Name = "rtbSummaryText";
            this.rtbSummaryText.Size = new System.Drawing.Size(637, 528);
            this.rtbSummaryText.TabIndex = 7;
            this.rtbSummaryText.Text = "";
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.rtbSummaryText);
            this.Controls.Add(this.nudGraphLength);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.cbxMode);
            this.Controls.Add(this.cbxSpecies);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.chtStatGraph);
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "DisplayData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chtStatGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGraphLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStatGraph;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.ComboBox cbxMode;
        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.NumericUpDown nudGraphLength;
        private System.Windows.Forms.RichTextBox rtbSummaryText;
    }
}