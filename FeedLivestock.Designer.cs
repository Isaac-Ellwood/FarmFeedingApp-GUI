
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGroup
            // 
            this.cbxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(250, 325);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(279, 39);
            this.cbxGroup.TabIndex = 0;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // cbxSpeciesOrID
            // 
            this.cbxSpeciesOrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSpeciesOrID.FormattingEnabled = true;
            this.cbxSpeciesOrID.Location = new System.Drawing.Point(250, 450);
            this.cbxSpeciesOrID.Name = "cbxSpeciesOrID";
            this.cbxSpeciesOrID.Size = new System.Drawing.Size(279, 39);
            this.cbxSpeciesOrID.TabIndex = 1;
            this.cbxSpeciesOrID.SelectedIndexChanged += new System.EventHandler(this.cbxSpeciesOrID_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBreed.FormattingEnabled = true;
            this.cbxBreed.Location = new System.Drawing.Point(250, 558);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(279, 39);
            this.cbxBreed.TabIndex = 2;
            // 
            // cbxFood
            // 
            this.cbxFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFood.FormattingEnabled = true;
            this.cbxFood.Location = new System.Drawing.Point(592, 325);
            this.cbxFood.Name = "cbxFood";
            this.cbxFood.Size = new System.Drawing.Size(236, 39);
            this.cbxFood.TabIndex = 3;
            // 
            // nudFoodAmount
            // 
            this.nudFoodAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFoodAmount.Location = new System.Drawing.Point(855, 326);
            this.nudFoodAmount.Name = "nudFoodAmount";
            this.nudFoodAmount.Size = new System.Drawing.Size(186, 38);
            this.nudFoodAmount.TabIndex = 4;
            // 
            // btnFeedLivestock
            // 
            this.btnFeedLivestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedLivestock.Location = new System.Drawing.Point(1139, 430);
            this.btnFeedLivestock.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedLivestock.Name = "btnFeedLivestock";
            this.btnFeedLivestock.Size = new System.Drawing.Size(217, 79);
            this.btnFeedLivestock.TabIndex = 5;
            this.btnFeedLivestock.Text = "Feed Livestock";
            this.btnFeedLivestock.UseVisualStyleBackColor = true;
            this.btnFeedLivestock.Click += new System.EventHandler(this.btnFeedLivestock_Click);
            // 
            // dtpFeedDate
            // 
            this.dtpFeedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFeedDate.Location = new System.Drawing.Point(592, 448);
            this.dtpFeedDate.Name = "dtpFeedDate";
            this.dtpFeedDate.Size = new System.Drawing.Size(473, 38);
            this.dtpFeedDate.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHome.Location = new System.Drawing.Point(1551, 753);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 85);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSaveAndExit.Location = new System.Drawing.Point(1551, 844);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(225, 85);
            this.btnSaveAndExit.TabIndex = 8;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(246, 416);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(111, 31);
            this.lblSpecies.TabIndex = 10;
            this.lblSpecies.Text = "Species";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(246, 291);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(89, 31);
            this.lblGroup.TabIndex = 11;
            this.lblGroup.Text = "Group";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreed.Location = new System.Drawing.Point(246, 524);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(86, 31);
            this.lblBreed.TabIndex = 12;
            this.lblBreed.Text = "Breed";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(849, 291);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(216, 31);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity (grams)";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(586, 291);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(76, 31);
            this.lblFood.TabIndex = 14;
            this.lblFood.Text = "Food";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(590, 414);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 31);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(244, 416);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 31);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // FeedLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnHome);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.ComboBox cbxSpeciesOrID;
        private System.Windows.Forms.ComboBox cbxBreed;
        private System.Windows.Forms.ComboBox cbxFood;
        private System.Windows.Forms.NumericUpDown nudFoodAmount;
        private System.Windows.Forms.Button btnFeedLivestock;
        private System.Windows.Forms.DateTimePicker dtpFeedDate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
    }
}