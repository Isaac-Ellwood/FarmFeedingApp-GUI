
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
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnFeedLivestock = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddLivestock
            // 
            this.btnAddLivestock.Location = new System.Drawing.Point(154, 340);
            this.btnAddLivestock.Name = "btnAddLivestock";
            this.btnAddLivestock.Size = new System.Drawing.Size(249, 85);
            this.btnAddLivestock.TabIndex = 0;
            this.btnAddLivestock.Text = "Add Livestock";
            this.btnAddLivestock.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(1551, 844);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(225, 85);
            this.btnSaveAndExit.TabIndex = 1;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnFeedLivestock
            // 
            this.btnFeedLivestock.Location = new System.Drawing.Point(154, 447);
            this.btnFeedLivestock.Name = "btnFeedLivestock";
            this.btnFeedLivestock.Size = new System.Drawing.Size(249, 85);
            this.btnFeedLivestock.TabIndex = 2;
            this.btnFeedLivestock.Text = "Feed Livestock";
            this.btnFeedLivestock.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(154, 554);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(249, 85);
            this.btn.TabIndex = 3;
            this.btn.Text = "Edit Livestock And Food Categories";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnFeedLivestock);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnAddLivestock);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddLivestock;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnFeedLivestock;
        private System.Windows.Forms.Button btn;
    }
}

