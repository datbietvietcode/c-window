namespace BTL_GUITIEN
{
    partial class TKTG
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
            this.print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exits = new System.Windows.Forms.Button();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.reportTKGT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(648, 138);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 23);
            this.print.TabIndex = 0;
            this.print.Text = "In thống kê";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tháng";
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(769, 138);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 3;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // cbthang
            // 
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Location = new System.Drawing.Point(259, 138);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(362, 24);
            this.cbthang.TabIndex = 5;
            // 
            // reportTKGT
            // 
            this.reportTKGT.Location = new System.Drawing.Point(101, 277);
            this.reportTKGT.Name = "reportTKGT";
            this.reportTKGT.Size = new System.Drawing.Size(788, 260);
            this.reportTKGT.TabIndex = 6;
            // 
            // TKTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 619);
            this.Controls.Add(this.reportTKGT);
            this.Controls.Add(this.cbthang);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.print);
            this.Name = "TKTG";
            this.Text = "TKTG";
            this.Load += new System.EventHandler(this.TKTG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.ComboBox cbthang;
        private Microsoft.Reporting.WinForms.ReportViewer reportTKGT;
    }
}