namespace WindowsFormsApp1
{
    partial class Timkiemnv
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.cbcalam = new System.Windows.Forms.ComboBox();
            this.checksex = new System.Windows.Forms.CheckBox();
            this.ListDT = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.btn_exits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(284, 55);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(219, 22);
            this.txt_manv.TabIndex = 4;
            // 
            // cbcalam
            // 
            this.cbcalam.FormattingEnabled = true;
            this.cbcalam.Location = new System.Drawing.Point(284, 96);
            this.cbcalam.Name = "cbcalam";
            this.cbcalam.Size = new System.Drawing.Size(219, 24);
            this.cbcalam.TabIndex = 5;
            // 
            // checksex
            // 
            this.checksex.AutoSize = true;
            this.checksex.Location = new System.Drawing.Point(284, 143);
            this.checksex.Name = "checksex";
            this.checksex.Size = new System.Drawing.Size(59, 21);
            this.checksex.TabIndex = 6;
            this.checksex.Text = "Nam";
            this.checksex.UseVisualStyleBackColor = true;
            // 
            // ListDT
            // 
            this.ListDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDT.Location = new System.Drawing.Point(107, 218);
            this.ListDT.Name = "ListDT";
            this.ListDT.RowHeadersWidth = 51;
            this.ListDT.RowTemplate.Height = 24;
            this.ListDT.Size = new System.Drawing.Size(591, 150);
            this.ListDT.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(162, 402);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(359, 402);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 9;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // btn_exits
            // 
            this.btn_exits.Location = new System.Drawing.Point(573, 402);
            this.btn_exits.Name = "btn_exits";
            this.btn_exits.Size = new System.Drawing.Size(75, 23);
            this.btn_exits.TabIndex = 10;
            this.btn_exits.Text = "Đóng";
            this.btn_exits.UseVisualStyleBackColor = true;
            this.btn_exits.Click += new System.EventHandler(this.btn_exits_Click);
            // 
            // Timkiemnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.ListDT);
            this.Controls.Add(this.checksex);
            this.Controls.Add(this.cbcalam);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Timkiemnv";
            this.Text = "Timkiemnv";
            this.Load += new System.EventHandler(this.Timkiemnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.ComboBox cbcalam;
        private System.Windows.Forms.CheckBox checksex;
        private System.Windows.Forms.DataGridView ListDT;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button btn_exits;
    }
}