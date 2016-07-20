namespace mailGonder
{
    partial class AliciEkle
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
            this.chkLstKisiler = new System.Windows.Forms.CheckedListBox();
            this.chkTumunuSec = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkLstKisiler
            // 
            this.chkLstKisiler.FormattingEnabled = true;
            this.chkLstKisiler.Location = new System.Drawing.Point(31, 42);
            this.chkLstKisiler.Name = "chkLstKisiler";
            this.chkLstKisiler.Size = new System.Drawing.Size(216, 349);
            this.chkLstKisiler.TabIndex = 0;
            // 
            // chkTumunuSec
            // 
            this.chkTumunuSec.AutoSize = true;
            this.chkTumunuSec.Location = new System.Drawing.Point(40, 19);
            this.chkTumunuSec.Name = "chkTumunuSec";
            this.chkTumunuSec.Size = new System.Drawing.Size(87, 17);
            this.chkTumunuSec.TabIndex = 2;
            this.chkTumunuSec.Text = "Tümünü Seç";
            this.chkTumunuSec.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AliciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkTumunuSec);
            this.Controls.Add(this.chkLstKisiler);
            this.Name = "AliciEkle";
            this.Text = "AliciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkLstKisiler;
        private System.Windows.Forms.CheckBox chkTumunuSec;
        private System.Windows.Forms.Button button1;
    }
}