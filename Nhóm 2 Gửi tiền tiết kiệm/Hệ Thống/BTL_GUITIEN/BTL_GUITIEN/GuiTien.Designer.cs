namespace BTL_GUITIEN
{
    partial class GuiTien
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.cbmso = new System.Windows.Forms.ComboBox();
            this.txt_ngaygui = new System.Windows.Forms.TextBox();
            this.txt_tiengui = new System.Windows.Forms.TextBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.dataGT = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.txt_khachhang = new System.Windows.Forms.TextBox();
            this.txt_tien = new System.Windows.Forms.TextBox();
            this.txt_cv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền gửi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày gửi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tìm kiếm sổ";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(283, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(304, 22);
            this.txt_search.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(622, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(220, 146);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(214, 22);
            this.txt_mp.TabIndex = 9;
            // 
            // cbmso
            // 
            this.cbmso.FormattingEnabled = true;
            this.cbmso.Location = new System.Drawing.Point(220, 190);
            this.cbmso.Name = "cbmso";
            this.cbmso.Size = new System.Drawing.Size(214, 24);
            this.cbmso.TabIndex = 11;
            this.cbmso.SelectedIndexChanged += new System.EventHandler(this.khachhang);
            // 
            // txt_ngaygui
            // 
            this.txt_ngaygui.Location = new System.Drawing.Point(579, 232);
            this.txt_ngaygui.Name = "txt_ngaygui";
            this.txt_ngaygui.Size = new System.Drawing.Size(254, 22);
            this.txt_ngaygui.TabIndex = 12;
            // 
            // txt_tiengui
            // 
            this.txt_tiengui.Location = new System.Drawing.Point(579, 192);
            this.txt_tiengui.Name = "txt_tiengui";
            this.txt_tiengui.Size = new System.Drawing.Size(138, 22);
            this.txt_tiengui.TabIndex = 13;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(579, 144);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(138, 24);
            this.cbnhanvien.TabIndex = 14;
            this.cbnhanvien.SelectedIndexChanged += new System.EventHandler(this.chucvu);
            // 
            // dataGT
            // 
            this.dataGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGT.Location = new System.Drawing.Point(129, 308);
            this.dataGT.Name = "dataGT";
            this.dataGT.RowTemplate.Height = 24;
            this.dataGT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGT.Size = new System.Drawing.Size(704, 199);
            this.dataGT.TabIndex = 15;
            this.dataGT.Click += new System.EventHandler(this.GetTable);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(129, 543);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(220, 543);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 17;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(320, 543);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(421, 543);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(521, 543);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 20;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(622, 543);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 21;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // txt_khachhang
            // 
            this.txt_khachhang.Location = new System.Drawing.Point(220, 234);
            this.txt_khachhang.Name = "txt_khachhang";
            this.txt_khachhang.Size = new System.Drawing.Size(214, 22);
            this.txt_khachhang.TabIndex = 22;
            // 
            // txt_tien
            // 
            this.txt_tien.Location = new System.Drawing.Point(723, 192);
            this.txt_tien.Name = "txt_tien";
            this.txt_tien.Size = new System.Drawing.Size(110, 22);
            this.txt_tien.TabIndex = 23;
            // 
            // txt_cv
            // 
            this.txt_cv.Location = new System.Drawing.Point(723, 146);
            this.txt_cv.Name = "txt_cv";
            this.txt_cv.Size = new System.Drawing.Size(110, 22);
            this.txt_cv.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cv);
            this.Controls.Add(this.txt_tien);
            this.Controls.Add(this.txt_khachhang);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGT);
            this.Controls.Add(this.cbnhanvien);
            this.Controls.Add(this.txt_tiengui);
            this.Controls.Add(this.txt_ngaygui);
            this.Controls.Add(this.cbmso);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuiTien";
            this.Text = "GuiTien";
            this.Load += new System.EventHandler(this.GuiTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.ComboBox cbmso;
        private System.Windows.Forms.TextBox txt_ngaygui;
        private System.Windows.Forms.TextBox txt_tiengui;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.DataGridView dataGT;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.TextBox txt_khachhang;
        private System.Windows.Forms.TextBox txt_tien;
        private System.Windows.Forms.TextBox txt_cv;
        private System.Windows.Forms.Button button1;
    }
}