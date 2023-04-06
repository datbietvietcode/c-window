namespace Quanlybanhang
{
    partial class KhachHang
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
            this.txt_mak = new System.Windows.Forms.TextBox();
            this.txt_tenk = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.list_kh = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_mak
            // 
            this.txt_mak.Location = new System.Drawing.Point(263, 84);
            this.txt_mak.Name = "txt_mak";
            this.txt_mak.Size = new System.Drawing.Size(245, 22);
            this.txt_mak.TabIndex = 3;
            // 
            // txt_tenk
            // 
            this.txt_tenk.Location = new System.Drawing.Point(263, 136);
            this.txt_tenk.Name = "txt_tenk";
            this.txt_tenk.Size = new System.Drawing.Size(245, 22);
            this.txt_tenk.TabIndex = 4;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(263, 185);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(245, 22);
            this.txt_diachi.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(550, 83);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(550, 135);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(550, 184);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // list_kh
            // 
            this.list_kh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Makh,
            this.Tenkh,
            this.Diachi});
            this.list_kh.FullRowSelect = true;
            this.list_kh.GridLines = true;
            this.list_kh.Location = new System.Drawing.Point(86, 289);
            this.list_kh.Name = "list_kh";
            this.list_kh.Size = new System.Drawing.Size(623, 175);
            this.list_kh.TabIndex = 9;
            this.list_kh.UseCompatibleStateImageBehavior = false;
            this.list_kh.View = System.Windows.Forms.View.Details;
            this.list_kh.SelectedIndexChanged += new System.EventHandler(this.list_kh_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 80;
            // 
            // Makh
            // 
            this.Makh.Text = "Mã khách hàng";
            this.Makh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Makh.Width = 150;
            // 
            // Tenkh
            // 
            this.Tenkh.Text = "Tên khách hàng";
            this.Tenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tenkh.Width = 150;
            // 
            // Diachi
            // 
            this.Diachi.Text = "Địa chỉ ";
            this.Diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Diachi.Width = 200;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 522);
            this.Controls.Add(this.list_kh);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_tenk);
            this.Controls.Add(this.txt_mak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mak;
        private System.Windows.Forms.TextBox txt_tenk;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ListView list_kh;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Makh;
        private System.Windows.Forms.ColumnHeader Tenkh;
        private System.Windows.Forms.ColumnHeader Diachi;
    }
}