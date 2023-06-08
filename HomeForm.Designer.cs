
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
            this.btnStartNew = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnLoadSaveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartNew
            // 
            this.btnStartNew.Location = new System.Drawing.Point(154, 340);
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.Size = new System.Drawing.Size(249, 85);
            this.btnStartNew.TabIndex = 0;
            this.btnStartNew.Text = "Start New";
            this.btnStartNew.UseVisualStyleBackColor = true;
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
            // btnLoadSaveData
            // 
            this.btnLoadSaveData.Location = new System.Drawing.Point(154, 447);
            this.btnLoadSaveData.Name = "btnLoadSaveData";
            this.btnLoadSaveData.Size = new System.Drawing.Size(249, 85);
            this.btnLoadSaveData.TabIndex = 2;
            this.btnLoadSaveData.Text = "Load Save Data";
            this.btnLoadSaveData.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.btnLoadSaveData);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnStartNew);
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartNew;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnLoadSaveData;
    }
}

