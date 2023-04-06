namespace Quanlybanhang
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem,
            this.inHóaĐơnTheoThángToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngSảnPhẩmToolStripMenuItem,
            this.bảngKháchHàngToolStripMenuItem,
            this.bảngHóaĐơnToolStripMenuItem});
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // bảngSảnPhẩmToolStripMenuItem
            // 
            this.bảngSảnPhẩmToolStripMenuItem.Name = "bảngSảnPhẩmToolStripMenuItem";
            this.bảngSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngSảnPhẩmToolStripMenuItem.Text = "Bảng sản phẩm";
            this.bảngSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.bảngSảnPhẩmToolStripMenuItem_Click);
            // 
            // bảngKháchHàngToolStripMenuItem
            // 
            this.bảngKháchHàngToolStripMenuItem.Name = "bảngKháchHàngToolStripMenuItem";
            this.bảngKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngKháchHàngToolStripMenuItem.Text = "Bảng khách hàng";
            this.bảngKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.bảngKháchHàngToolStripMenuItem_Click);
            // 
            // bảngHóaĐơnToolStripMenuItem
            // 
            this.bảngHóaĐơnToolStripMenuItem.Name = "bảngHóaĐơnToolStripMenuItem";
            this.bảngHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngHóaĐơnToolStripMenuItem.Text = "Bảng hóa đơn";
            this.bảngHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.bảngHóaĐơnToolStripMenuItem_Click);
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // inHóaĐơnTheoThángToolStripMenuItem
            // 
            this.inHóaĐơnTheoThángToolStripMenuItem.Name = "inHóaĐơnTheoThángToolStripMenuItem";
            this.inHóaĐơnTheoThángToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.inHóaĐơnTheoThángToolStripMenuItem.Text = "In hóa đơn theo tháng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 364);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnTheoThángToolStripMenuItem;
    }
}

