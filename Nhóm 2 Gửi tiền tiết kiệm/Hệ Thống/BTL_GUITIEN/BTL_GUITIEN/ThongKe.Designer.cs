﻿namespace BTL_GUITIEN
{
    partial class ThongKe
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
            this.cbngayms = new System.Windows.Forms.ComboBox();
            this.reportTK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbthanghh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbngayms
            // 
            this.cbngayms.FormattingEnabled = true;
            this.cbngayms.Location = new System.Drawing.Point(267, 73);
            this.cbngayms.Name = "cbngayms";
            this.cbngayms.Size = new System.Drawing.Size(359, 24);
            this.cbngayms.TabIndex = 0;
            // 
            // reportTK
            // 
            this.reportTK.Location = new System.Drawing.Point(116, 226);
            this.reportTK.Name = "reportTK";
            this.reportTK.Size = new System.Drawing.Size(768, 284);
            this.reportTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tháng mở sổ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "In thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn tháng hết hạn";
            // 
            // cbthanghh
            // 
            this.cbthanghh.FormattingEnabled = true;
            this.cbthanghh.Location = new System.Drawing.Point(267, 114);
            this.cbthanghh.Name = "cbthanghh";
            this.cbthanghh.Size = new System.Drawing.Size(359, 24);
            this.cbthanghh.TabIndex = 6;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 586);
            this.Controls.Add(this.cbthanghh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportTK);
            this.Controls.Add(this.cbngayms);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbngayms;
        private Microsoft.Reporting.WinForms.ReportViewer reportTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbthanghh;
    }
}