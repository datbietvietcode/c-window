namespace BTL_GUITIEN
{
    partial class HoaDonGT
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbphieu = new System.Windows.Forms.ComboBox();
            this.reportGT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(363, 107);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(278, 22);
            this.txt_search.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hd
            // 
            this.hd.Location = new System.Drawing.Point(718, 157);
            this.hd.Name = "hd";
            this.hd.Size = new System.Drawing.Size(135, 23);
            this.hd.TabIndex = 4;
            this.hd.Text = "In hóa đơn";
            this.hd.UseVisualStyleBackColor = true;
            this.hd.Click += new System.EventHandler(this.hd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm mã phiếu";
            // 
            // cbphieu
            // 
            this.cbphieu.FormattingEnabled = true;
            this.cbphieu.Location = new System.Drawing.Point(363, 157);
            this.cbphieu.Name = "cbphieu";
            this.cbphieu.Size = new System.Drawing.Size(278, 24);
            this.cbphieu.TabIndex = 6;
            // 
            // reportGT
            // 
            this.reportGT.Location = new System.Drawing.Point(141, 265);
            this.reportGT.Name = "reportGT";
            this.reportGT.Size = new System.Drawing.Size(856, 271);
            this.reportGT.TabIndex = 7;
            // 
            // HoaDonGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 612);
            this.Controls.Add(this.reportGT);
            this.Controls.Add(this.cbphieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HoaDonGT";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.HoaDonGT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbphieu;
        private Microsoft.Reporting.WinForms.ReportViewer reportGT;
    }
}