namespace WindowsFormsApp1
{
    partial class Timkiemsachtruyencs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tens = new System.Windows.Forms.TextBox();
            this.cbnxb = new System.Windows.Forms.ComboBox();
            this.cbtg = new System.Windows.Forms.ComboBox();
            this.cblv = new System.Windows.Forms.ComboBox();
            this.ListDT = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lĩnh vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà xuất bản";
            // 
            // txt_tens
            // 
            this.txt_tens.Location = new System.Drawing.Point(204, 82);
            this.txt_tens.Name = "txt_tens";
            this.txt_tens.Size = new System.Drawing.Size(158, 22);
            this.txt_tens.TabIndex = 6;
            // 
            // cbnxb
            // 
            this.cbnxb.FormattingEnabled = true;
            this.cbnxb.Location = new System.Drawing.Point(538, 134);
            this.cbnxb.Name = "cbnxb";
            this.cbnxb.Size = new System.Drawing.Size(153, 24);
            this.cbnxb.TabIndex = 7;
            // 
            // cbtg
            // 
            this.cbtg.FormattingEnabled = true;
            this.cbtg.Location = new System.Drawing.Point(204, 134);
            this.cbtg.Name = "cbtg";
            this.cbtg.Size = new System.Drawing.Size(158, 24);
            this.cbtg.TabIndex = 8;
            // 
            // cblv
            // 
            this.cblv.FormattingEnabled = true;
            this.cblv.Location = new System.Drawing.Point(538, 80);
            this.cblv.Name = "cblv";
            this.cblv.Size = new System.Drawing.Size(153, 24);
            this.cblv.TabIndex = 9;
            // 
            // ListDT
            // 
            this.ListDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDT.Location = new System.Drawing.Point(89, 221);
            this.ListDT.Name = "ListDT";
            this.ListDT.RowHeadersWidth = 51;
            this.ListDT.RowTemplate.Height = 24;
            this.ListDT.Size = new System.Drawing.Size(602, 150);
            this.ListDT.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(117, 399);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(330, 399);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 12;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(538, 399);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 13;
            this.exits.Text = "Đóng";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // Timkiemsachtruyencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.ListDT);
            this.Controls.Add(this.cblv);
            this.Controls.Add(this.cbtg);
            this.Controls.Add(this.cbnxb);
            this.Controls.Add(this.txt_tens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Timkiemsachtruyencs";
            this.Text = "Timkiemsachtruyencs";
            this.Load += new System.EventHandler(this.Timkiemsachtruyencs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tens;
        private System.Windows.Forms.ComboBox cbnxb;
        private System.Windows.Forms.ComboBox cbtg;
        private System.Windows.Forms.ComboBox cblv;
        private System.Windows.Forms.DataGridView ListDT;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
    }
}