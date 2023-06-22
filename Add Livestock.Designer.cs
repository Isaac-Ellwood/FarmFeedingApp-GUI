
namespace FarmFeedingAppV2
{
    partial class Add_Livestock
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
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.cbxBreed = new System.Windows.Forms.ComboBox();
            this.nudLivestockCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddLivestock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLivestockCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.AllowDrop = true;
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(402, 291);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(121, 21);
            this.cbxSpecies.TabIndex = 0;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.AllowDrop = true;
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(585, 290);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(121, 21);
            this.cbxBreed.TabIndex = 1;
            // 
            // nudLivestockCount
            // 
            this.nudLivestockCount.Location = new System.Drawing.Point(787, 291);
            this.nudLivestockCount.Name = "nudLivestockCount";
            this.nudLivestockCount.Size = new System.Drawing.Size(120, 20);
            this.nudLivestockCount.TabIndex = 2;
            // 
            // btnAddLivestock
            // 
            this.btnAddLivestock.Location = new System.Drawing.Point(976, 326);
            this.btnAddLivestock.Name = "btnAddLivestock";
            this.btnAddLivestock.Size = new System.Drawing.Size(182, 48);
            this.btnAddLivestock.TabIndex = 3;
            this.btnAddLivestock.Text = "Add Livestock";
            this.btnAddLivestock.UseVisualStyleBackColor = true;
            this.btnAddLivestock.Click += new System.EventHandler(this.btnAddLivestock_Click);
            // 
            // Add_Livestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.btnAddLivestock);
            this.Controls.Add(this.nudLivestockCount);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.cbxSpecies);
            this.Name = "Add_Livestock";
            this.Text = "Add_Livestock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudLivestockCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.NumericUpDown nudLivestockCount;
        private System.Windows.Forms.Button btnAddLivestock;
    }
}