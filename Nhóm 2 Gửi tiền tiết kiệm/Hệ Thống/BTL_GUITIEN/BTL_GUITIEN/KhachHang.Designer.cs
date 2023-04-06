namespace BTL_GUITIEN
{
    partial class KH
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.gtNam = new System.Windows.Forms.RadioButton();
            this.gtNu = new System.Windows.Forms.RadioButton();
            this.dataKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(134, 557);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(268, 557);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 1;
            this.btn_up.Text = "sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(405, 557);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(546, 557);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(678, 557);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 4;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(811, 557);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 5;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày sinh";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(651, 104);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(235, 22);
            this.txt_sdt.TabIndex = 14;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(651, 189);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(235, 22);
            this.txt_diachi.TabIndex = 15;
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(242, 241);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(218, 22);
            this.txt_ns.TabIndex = 16;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(651, 146);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(235, 22);
            this.txt_cmnd.TabIndex = 17;
            this.txt_cmnd.Text = " ";
            this.txt_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(242, 144);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(218, 22);
            this.txt_tenkh.TabIndex = 18;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(242, 104);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(218, 22);
            this.txt_makh.TabIndex = 19;
            // 
            // gtNam
            // 
            this.gtNam.AutoSize = true;
            this.gtNam.Location = new System.Drawing.Point(242, 192);
            this.gtNam.Name = "gtNam";
            this.gtNam.Size = new System.Drawing.Size(58, 21);
            this.gtNam.TabIndex = 20;
            this.gtNam.TabStop = true;
            this.gtNam.Text = "Nam";
            this.gtNam.UseVisualStyleBackColor = true;
            // 
            // gtNu
            // 
            this.gtNu.AutoSize = true;
            this.gtNu.Location = new System.Drawing.Point(316, 192);
            this.gtNu.Name = "gtNu";
            this.gtNu.Size = new System.Drawing.Size(47, 21);
            this.gtNu.TabIndex = 21;
            this.gtNu.TabStop = true;
            this.gtNu.Text = "Nữ";
            this.gtNu.UseVisualStyleBackColor = true;
            // 
            // dataKH
            // 
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Location = new System.Drawing.Point(134, 326);
            this.dataKH.Name = "dataKH";
            this.dataKH.RowTemplate.Height = 24;
            this.dataKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKH.Size = new System.Drawing.Size(752, 191);
            this.dataKH.TabIndex = 22;
            this.dataKH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.stt);
            this.dataKH.Click += new System.EventHandler(this.GetTable);
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 612);
            this.Controls.Add(this.dataKH);
            this.Controls.Add(this.gtNu);
            this.Controls.Add(this.gtNam);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_ns);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Name = "KH";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.RadioButton gtNam;
        private System.Windows.Forms.RadioButton gtNu;
        private System.Windows.Forms.DataGridView dataKH;
    }
}