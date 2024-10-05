
namespace QUANLYBANMAYTINH
{
    partial class frm_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanlynhavienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlykhachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlythietbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlynhavienToolStripMenuItem,
            this.quanlykhachhangToolStripMenuItem,
            this.quanlythietbiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlynhavienToolStripMenuItem
            // 
            this.quanlynhavienToolStripMenuItem.Name = "quanlynhavienToolStripMenuItem";
            this.quanlynhavienToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.quanlynhavienToolStripMenuItem.Text = "QUẢN LÝ NHÂN VIÊN";
            this.quanlynhavienToolStripMenuItem.Click += new System.EventHandler(this.quanlynhavienToolStripMenuItem_Click);
            // 
            // quanlykhachhangToolStripMenuItem
            // 
            this.quanlykhachhangToolStripMenuItem.Name = "quanlykhachhangToolStripMenuItem";
            this.quanlykhachhangToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.quanlykhachhangToolStripMenuItem.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.quanlykhachhangToolStripMenuItem.Click += new System.EventHandler(this.quanlykhachhangToolStripMenuItem_Click);
            // 
            // quanlythietbiToolStripMenuItem
            // 
            this.quanlythietbiToolStripMenuItem.Name = "quanlythietbiToolStripMenuItem";
            this.quanlythietbiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.quanlythietbiToolStripMenuItem.Text = "QUẢN LÝ THIẾT BỊ";
            this.quanlythietbiToolStripMenuItem.Click += new System.EventHandler(this.quanlythietbiToolStripMenuItem_Click);
            // 
            // frm_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 576);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MAIN";
            this.Text = "frm_MAIN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlynhavienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlykhachhangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlythietbiToolStripMenuItem;
    }
}