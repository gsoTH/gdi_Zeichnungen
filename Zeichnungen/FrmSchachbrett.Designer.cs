﻿namespace Zeichnungen
{
    partial class FrmSchachbrett
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchachbrett));
            this.cbxShowGoal = new System.Windows.Forms.CheckBox();
            this.pbxGoal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxShowGoal
            // 
            this.cbxShowGoal.AutoSize = true;
            this.cbxShowGoal.Location = new System.Drawing.Point(12, 8);
            this.cbxShowGoal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxShowGoal.Name = "cbxShowGoal";
            this.cbxShowGoal.Size = new System.Drawing.Size(98, 19);
            this.cbxShowGoal.TabIndex = 0;
            this.cbxShowGoal.Text = "Ziel anzeigen ";
            this.cbxShowGoal.UseVisualStyleBackColor = true;
            this.cbxShowGoal.CheckedChanged += new System.EventHandler(this.cbxShowGoal_CheckedChanged);
            // 
            // pbxGoal
            // 
            this.pbxGoal.Image = ((System.Drawing.Image)(resources.GetObject("pbxGoal.Image")));
            this.pbxGoal.Location = new System.Drawing.Point(10, 36);
            this.pbxGoal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbxGoal.Name = "pbxGoal";
            this.pbxGoal.Size = new System.Drawing.Size(561, 370);
            this.pbxGoal.TabIndex = 1;
            this.pbxGoal.TabStop = false;
            this.pbxGoal.Visible = false;
            // 
            // FrmSchachbrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 419);
            this.Controls.Add(this.pbxGoal);
            this.Controls.Add(this.cbxShowGoal);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmSchachbrett";
            this.Text = "Schachbrett";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmSchachbrett_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxShowGoal;
        private System.Windows.Forms.PictureBox pbxGoal;
    }
}