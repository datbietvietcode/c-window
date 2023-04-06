namespace BTL_GUITIEN
{
    partial class HoaDonRT
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
            this.cbchonhd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mhd = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.reportHDRT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "In  hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn mã hóa đơn rút tiền";
            // 
            // cbchonhd
            // 
            this.cbchonhd.FormattingEnabled = true;
            this.cbchonhd.Location = new System.Drawing.Point(331, 163);
            this.cbchonhd.Name = "cbchonhd";
            this.cbchonhd.Size = new System.Drawing.Size(324, 24);
            this.cbchonhd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm mã hóa đơn";
            // 
            // txt_mhd
            // 
            this.txt_mhd.Location = new System.Drawing.Point(331, 102);
            this.txt_mhd.Name = "txt_mhd";
            this.txt_mhd.Size = new System.Drawing.Size(324, 22);
            this.txt_mhd.TabIndex = 4;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(698, 101);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Tìm kiếm";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // reportHDRT
            // 
            this.reportHDRT.Location = new System.Drawing.Point(141, 273);
            this.reportHDRT.Name = "reportHDRT";
            this.reportHDRT.Size = new System.Drawing.Size(808, 293);
            this.reportHDRT.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HoaDonRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportHDRT);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_mhd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbchonhd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HoaDonRT";
            this.Text = "HoaDonRT";
            this.Load += new System.EventHandler(this.HoaDonRT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbchonhd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mhd;
        private System.Windows.Forms.Button search;
        private Microsoft.Reporting.WinForms.ReportViewer reportHDRT;
        private System.Windows.Forms.Button button2;
    }
}