namespace BTL_GUITIEN
{
    partial class ChiNhanh
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
            this.cbquanly = new System.Windows.Forms.ComboBox();
            this.txt_tencn = new System.Windows.Forms.TextBox();
            this.txt_macn = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.dataCN = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chi nhánh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngươi quản lý";
            // 
            // cbquanly
            // 
            this.cbquanly.FormattingEnabled = true;
            this.cbquanly.Location = new System.Drawing.Point(614, 173);
            this.cbquanly.Name = "cbquanly";
            this.cbquanly.Size = new System.Drawing.Size(193, 24);
            this.cbquanly.TabIndex = 4;
            // 
            // txt_tencn
            // 
            this.txt_tencn.Location = new System.Drawing.Point(250, 177);
            this.txt_tencn.Name = "txt_tencn";
            this.txt_tencn.Size = new System.Drawing.Size(197, 22);
            this.txt_tencn.TabIndex = 5;
            // 
            // txt_macn
            // 
            this.txt_macn.Location = new System.Drawing.Point(250, 130);
            this.txt_macn.Name = "txt_macn";
            this.txt_macn.Size = new System.Drawing.Size(197, 22);
            this.txt_macn.TabIndex = 6;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(614, 128);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(193, 22);
            this.txt_diachi.TabIndex = 7;
            // 
            // dataCN
            // 
            this.dataCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCN.Location = new System.Drawing.Point(141, 263);
            this.dataCN.Name = "dataCN";
            this.dataCN.RowTemplate.Height = 24;
            this.dataCN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCN.Size = new System.Drawing.Size(666, 176);
            this.dataCN.TabIndex = 8;
            this.dataCN.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.stt);
            this.dataCN.Click += new System.EventHandler(this.getTable);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(141, 484);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(260, 484);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 10;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(381, 484);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(496, 484);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(614, 484);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 13;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(732, 484);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 14;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 548);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataCN);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_macn);
            this.Controls.Add(this.txt_tencn);
            this.Controls.Add(this.cbquanly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiNhanh";
            this.Text = "ChiNhanh";
            this.Load += new System.EventHandler(this.ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbquanly;
        private System.Windows.Forms.TextBox txt_tencn;
        private System.Windows.Forms.TextBox txt_macn;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.DataGridView dataCN;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
    }
}