namespace BTL_GUITIEN
{
    partial class In_STK
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.printSTK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbso = new System.Windows.Forms.ComboBox();
            this.reportSTK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã sổ";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(367, 108);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(375, 22);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(818, 107);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(956, 107);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(92, 23);
            this.exits.TabIndex = 3;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // printSTK
            // 
            this.printSTK.Location = new System.Drawing.Point(890, 150);
            this.printSTK.Name = "printSTK";
            this.printSTK.Size = new System.Drawing.Size(75, 23);
            this.printSTK.TabIndex = 4;
            this.printSTK.Text = "In STK";
            this.printSTK.UseVisualStyleBackColor = true;
            this.printSTK.Click += new System.EventHandler(this.printSTK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn sổ";
            // 
            // cbso
            // 
            this.cbso.FormattingEnabled = true;
            this.cbso.Location = new System.Drawing.Point(367, 149);
            this.cbso.Name = "cbso";
            this.cbso.Size = new System.Drawing.Size(375, 24);
            this.cbso.TabIndex = 6;
            // 
            // reportSTK
            // 
            this.reportSTK.Location = new System.Drawing.Point(158, 259);
            this.reportSTK.Name = "reportSTK";
            this.reportSTK.Size = new System.Drawing.Size(930, 269);
            this.reportSTK.TabIndex = 7;
            // 
            // In_STK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 604);
            this.Controls.Add(this.reportSTK);
            this.Controls.Add(this.cbso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printSTK);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Name = "In_STK";
            this.Text = "In_STK";
            this.Load += new System.EventHandler(this.In_STK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.Button printSTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbso;
        private Microsoft.Reporting.WinForms.ReportViewer reportSTK;
    }
}