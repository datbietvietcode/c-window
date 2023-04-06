namespace Quanlybanhang
{
    partial class InHoaDon
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
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.report_hd = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(245, 68);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(340, 24);
            this.cbkhachhang.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(636, 69);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(121, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "In hóa đơn";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng";
            // 
            // report_hd
            // 
            this.report_hd.Location = new System.Drawing.Point(88, 205);
            this.report_hd.Name = "report_hd";
            this.report_hd.Size = new System.Drawing.Size(669, 246);
            this.report_hd.TabIndex = 3;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 529);
            this.Controls.Add(this.report_hd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.cbkhachhang);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer report_hd;
    }
}