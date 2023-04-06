namespace hanghoa
{
    partial class Form1
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
            this.txt_picture = new System.Windows.Forms.TextBox();
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.ListDT = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.btn_exits = new System.Windows.Forms.Button();
            this.cbmamau = new System.Windows.Forms.ComboBox();
            this.btn_op = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã màu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian bảo hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ảnh";
            // 
            // txt_picture
            // 
            this.txt_picture.Location = new System.Drawing.Point(559, 154);
            this.txt_picture.Name = "txt_picture";
            this.txt_picture.Size = new System.Drawing.Size(168, 22);
            this.txt_picture.TabIndex = 6;
            // 
            // txt_mahh
            // 
            this.txt_mahh.Location = new System.Drawing.Point(181, 49);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Size = new System.Drawing.Size(228, 22);
            this.txt_mahh.TabIndex = 7;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(181, 88);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(228, 22);
            this.txt_ten.TabIndex = 8;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(181, 149);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(228, 22);
            this.txt_sl.TabIndex = 10;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(181, 190);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(228, 22);
            this.txt_time.TabIndex = 11;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(559, 45);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(168, 98);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 12;
            this.picBox.TabStop = false;
            // 
            // ListDT
            // 
            this.ListDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDT.Location = new System.Drawing.Point(52, 260);
            this.ListDT.Name = "ListDT";
            this.ListDT.RowTemplate.Height = 24;
            this.ListDT.Size = new System.Drawing.Size(683, 204);
            this.ListDT.TabIndex = 13;
            this.ListDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDT_CellContentClick);
            this.ListDT.Click += new System.EventHandler(this.ListDT_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(52, 500);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(181, 500);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(309, 500);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 16;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(440, 500);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(550, 500);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 18;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // btn_exits
            // 
            this.btn_exits.Location = new System.Drawing.Point(652, 500);
            this.btn_exits.Name = "btn_exits";
            this.btn_exits.Size = new System.Drawing.Size(75, 23);
            this.btn_exits.TabIndex = 19;
            this.btn_exits.Text = "Thoát";
            this.btn_exits.UseVisualStyleBackColor = true;
            this.btn_exits.Click += new System.EventHandler(this.btn_exits_Click);
            // 
            // cbmamau
            // 
            this.cbmamau.FormattingEnabled = true;
            this.cbmamau.Location = new System.Drawing.Point(181, 119);
            this.cbmamau.Name = "cbmamau";
            this.cbmamau.Size = new System.Drawing.Size(228, 24);
            this.cbmamau.TabIndex = 20;
            this.cbmamau.SelectedIndexChanged += new System.EventHandler(this.cbmamau_SelectedIndexChanged);
            // 
            // btn_op
            // 
            this.btn_op.Location = new System.Drawing.Point(559, 195);
            this.btn_op.Name = "btn_op";
            this.btn_op.Size = new System.Drawing.Size(168, 23);
            this.btn_op.TabIndex = 21;
            this.btn_op.Text = "Open";
            this.btn_op.UseVisualStyleBackColor = true;
            this.btn_op.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.btn_op);
            this.Controls.Add(this.cbmamau);
            this.Controls.Add(this.btn_exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.ListDT);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_mahh);
            this.Controls.Add(this.txt_picture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).EndInit();
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
        private System.Windows.Forms.TextBox txt_picture;
        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.DataGridView ListDT;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button btn_exits;
        private System.Windows.Forms.ComboBox cbmamau;
        private System.Windows.Forms.Button btn_op;
    }
}

