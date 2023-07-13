
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
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(340, 372);
            this.cbxGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(160, 24);
            this.cbxGroup.TabIndex = 0;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // cbxSpeciesOrID
            // 
            this.cbxSpeciesOrID.FormattingEnabled = true;
            this.cbxSpeciesOrID.Location = new System.Drawing.Point(551, 350);
            this.cbxSpeciesOrID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSpeciesOrID.Name = "cbxSpeciesOrID";
            this.cbxSpeciesOrID.Size = new System.Drawing.Size(160, 24);
            this.cbxSpeciesOrID.TabIndex = 1;
            this.cbxSpeciesOrID.SelectedIndexChanged += new System.EventHandler(this.cbxSpeciesOrID_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(772, 350);
            this.cbxBreed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(160, 24);
            this.cbxBreed.TabIndex = 2;
            // 
            // cbxFood
            // 
            this.cbxFood.FormattingEnabled = true;
            this.cbxFood.Location = new System.Drawing.Point(1125, 372);
            this.cbxFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFood.Name = "cbxFood";
            this.cbxFood.Size = new System.Drawing.Size(160, 24);
            this.cbxFood.TabIndex = 3;
            // 
            // nudFoodAmount
            // 
            this.nudFoodAmount.Location = new System.Drawing.Point(957, 373);
            this.nudFoodAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFoodAmount.Name = "nudFoodAmount";
            this.nudFoodAmount.Size = new System.Drawing.Size(160, 22);
            this.nudFoodAmount.TabIndex = 4;
            // 
            // btnFeedLivestock
            // 
            this.btnFeedLivestock.Location = new System.Drawing.Point(1324, 372);
            this.btnFeedLivestock.Name = "btnFeedLivestock";
            this.btnFeedLivestock.Size = new System.Drawing.Size(176, 23);
            this.btnFeedLivestock.TabIndex = 5;
            this.btnFeedLivestock.Text = "Feed Livestock";
            this.btnFeedLivestock.UseVisualStyleBackColor = true;
            this.btnFeedLivestock.Click += new System.EventHandler(this.btnFeedLivestock_Click);
            // 
            // FeedLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnFeedLivestock);
            this.Controls.Add(this.nudFoodAmount);
            this.Controls.Add(this.cbxFood);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.cbxSpeciesOrID);
            this.Controls.Add(this.cbxGroup);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}