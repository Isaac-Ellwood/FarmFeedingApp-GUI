
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
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLivestockCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.AllowDrop = true;
            this.cbxSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(358, 386);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(325, 39);
            this.cbxSpecies.TabIndex = 0;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.AllowDrop = true;
            this.cbxBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(757, 386);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(340, 39);
            this.cbxBreed.TabIndex = 1;
            // 
            // nudLivestockCount
            // 
            this.nudLivestockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nudLivestockCount.Location = new System.Drawing.Point(1167, 387);
            this.nudLivestockCount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudLivestockCount.Name = "nudLivestockCount";
            this.nudLivestockCount.Size = new System.Drawing.Size(158, 38);
            this.nudLivestockCount.TabIndex = 2;
            // 
            // btnAddLivestock
            // 
            this.btnAddLivestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddLivestock.Location = new System.Drawing.Point(1167, 488);
            this.btnAddLivestock.Name = "btnAddLivestock";
            this.btnAddLivestock.Size = new System.Drawing.Size(182, 48);
            this.btnAddLivestock.TabIndex = 3;
            this.btnAddLivestock.Text = "Add Livestock";
            this.btnAddLivestock.UseVisualStyleBackColor = true;
            this.btnAddLivestock.Click += new System.EventHandler(this.btnAddLivestock_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSaveAndExit.Location = new System.Drawing.Point(1551, 844);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(225, 85);
            this.btnSaveAndExit.TabIndex = 6;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHome.Location = new System.Drawing.Point(1551, 753);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 85);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSpecies.Location = new System.Drawing.Point(352, 338);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(119, 31);
            this.lblSpecies.TabIndex = 7;
            this.lblSpecies.Text = "Species:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBreed.Location = new System.Drawing.Point(751, 338);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(94, 31);
            this.lblBreed.TabIndex = 8;
            this.lblBreed.Text = "Breed:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuantity.Location = new System.Drawing.Point(1161, 338);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // Add_Livestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnAddLivestock);
            this.Controls.Add(this.nudLivestockCount);
            this.Controls.Add(this.cbxBreed);
            this.Controls.Add(this.cbxSpecies);
            this.Name = "Add_Livestock";
            this.Text = "Add_Livestock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudLivestockCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSpecies;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.NumericUpDown nudLivestockCount;
        private System.Windows.Forms.Button btnAddLivestock;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblQuantity;
    }
}