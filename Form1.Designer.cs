
namespace FarmFeedingAppV2
{
    partial class HomeForm
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
            this.btnAddLivestock = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnFeedLivestock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddLivestock
            // 
            this.btnAddLivestock.Location = new System.Drawing.Point(154, 261);
            this.btnAddLivestock.Name = "btnAddLivestock";
            this.btnAddLivestock.Size = new System.Drawing.Size(208, 73);
            this.btnAddLivestock.TabIndex = 0;
            this.btnAddLivestock.Text = "Add Livestock";
            this.btnAddLivestock.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(480, 297);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(208, 73);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "View Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFeedLivestock
            // 
            this.btnFeedLivestock.Location = new System.Drawing.Point(154, 340);
            this.btnFeedLivestock.Name = "btnFeedLivestock";
            this.btnFeedLivestock.Size = new System.Drawing.Size(208, 73);
            this.btnFeedLivestock.TabIndex = 2;
            this.btnFeedLivestock.Text = "Feed Livestock";
            this.btnFeedLivestock.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFeedLivestock);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnAddLivestock);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddLivestock;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnFeedLivestock;
    }
}

