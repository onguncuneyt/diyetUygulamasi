﻿
namespace diyetUygulamasi
{
    partial class urunlerim
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
            this.dgUrunlerim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunlerim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUrunlerim
            // 
            this.dgUrunlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunlerim.Location = new System.Drawing.Point(12, 12);
            this.dgUrunlerim.Name = "dgUrunlerim";
            this.dgUrunlerim.Size = new System.Drawing.Size(345, 278);
            this.dgUrunlerim.TabIndex = 0;
            // 
            // urunlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 303);
            this.Controls.Add(this.dgUrunlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunlerim";
            this.Text = "urunlerim";
            this.Load += new System.EventHandler(this.urunlerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunlerim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUrunlerim;
    }
}