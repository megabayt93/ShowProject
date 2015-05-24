﻿namespace Show
{
    partial class Opening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening));
            this.pharmaPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerYatech = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pharmaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmaPic
            // 
            this.pharmaPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pharmaPic.Image = global::Show.Properties.Resources.yatech;
            this.pharmaPic.Location = new System.Drawing.Point(246, 4);
            this.pharmaPic.Name = "pharmaPic";
            this.pharmaPic.Size = new System.Drawing.Size(63, 64);
            this.pharmaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pharmaPic.TabIndex = 1;
            this.pharmaPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gathering System Information...";
            // 
            // backgroundWorkerYatech
            // 
            this.backgroundWorkerYatech.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerYatech_DoWork);
            this.backgroundWorkerYatech.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerYatech_RunWorkerCompleted);
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(322, 73);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pharmaPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening";
            this.Load += new System.EventHandler(this.Opening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pharmaPic;
        private System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker backgroundWorkerYatech;
    }
}