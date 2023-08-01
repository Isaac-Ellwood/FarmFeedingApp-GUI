
namespace FarmFeedingAppV2
{
    partial class FeedLivestock
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
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.cbxSpeciesOrID = new System.Windows.Forms.ComboBox();
            this.cbxBreed = new System.Windows.Forms.ComboBox();
            this.cbxFood = new System.Windows.Forms.ComboBox();
            this.nudFoodAmount = new System.Windows.Forms.NumericUpDown();
            this.btnFeedLivestock = new System.Windows.Forms.Button();
            this.dtpFeedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(255, 302);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxGroup.TabIndex = 0;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // cbxSpeciesOrID
            // 
            this.cbxSpeciesOrID.FormattingEnabled = true;
            this.cbxSpeciesOrID.Location = new System.Drawing.Point(413, 284);
            this.cbxSpeciesOrID.Name = "cbxSpeciesOrID";
            this.cbxSpeciesOrID.Size = new System.Drawing.Size(121, 21);
            this.cbxSpeciesOrID.TabIndex = 1;
            this.cbxSpeciesOrID.SelectedIndexChanged += new System.EventHandler(this.cbxSpeciesOrID_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(579, 284);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(121, 21);
            this.cbxBreed.TabIndex = 2;
            // 
            // cbxFood
            // 
            this.cbxFood.FormattingEnabled = true;
            this.cbxFood.Location = new System.Drawing.Point(844, 302);
            this.cbxFood.Name = "cbxFood";
            this.cbxFood.Size = new System.Drawing.Size(121, 21);
            this.cbxFood.TabIndex = 3;
            // 
            // nudFoodAmount
            // 
            this.nudFoodAmount.Location = new System.Drawing.Point(718, 303);
            this.nudFoodAmount.Name = "nudFoodAmount";
            this.nudFoodAmount.Size = new System.Drawing.Size(120, 20);
            this.nudFoodAmount.TabIndex = 4;
            // 
            // btnFeedLivestock
            // 
            this.btnFeedLivestock.Location = new System.Drawing.Point(993, 302);
            this.btnFeedLivestock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFeedLivestock.Name = "btnFeedLivestock";
            this.btnFeedLivestock.Size = new System.Drawing.Size(132, 19);
            this.btnFeedLivestock.TabIndex = 5;
            this.btnFeedLivestock.Text = "Feed Livestock";
            this.btnFeedLivestock.UseVisualStyleBackColor = true;
            this.btnFeedLivestock.Click += new System.EventHandler(this.btnFeedLivestock_Click);
            // 
            // dtpFeedDate
            // 
            this.dtpFeedDate.Location = new System.Drawing.Point(712, 386);
            this.dtpFeedDate.Name = "dtpFeedDate";
            this.dtpFeedDate.Size = new System.Drawing.Size(272, 20);
            this.dtpFeedDate.TabIndex = 7;
            // 
            // FeedLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.dtpFeedDate);
            this.Controls.Add(this.btnFeedLivestock);
            this.Controls.Add(this.nudFoodAmount);
            this.Controls.Add(this.cbxFood);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.cbxSpeciesOrID);
            this.Controls.Add(this.cbxGroup);
            this.Name = "FeedLivestock";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.ComboBox cbxSpeciesOrID;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.ComboBox cbxFood;
        private System.Windows.Forms.NumericUpDown nudFoodAmount;
        private System.Windows.Forms.Button btnFeedLivestock;
        private System.Windows.Forms.DateTimePicker dtpFeedDate;
    }
}