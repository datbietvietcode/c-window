namespace BTL_GUITIEN
{
    partial class KyHan
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
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_loaikh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataKH = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.rdco = new System.Windows.Forms.RadioButton();
            this.rdkhong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkCo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(205, 77);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(220, 22);
            this.txt_makh.TabIndex = 0;
            // 
            // txt_loaikh
            // 
            this.txt_loaikh.Location = new System.Drawing.Point(205, 121);
            this.txt_loaikh.Name = "txt_loaikh";
            this.txt_loaikh.Size = new System.Drawing.Size(220, 22);
            this.txt_loaikh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã kỳ hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại kỳ hạn";
            // 
            // dataKH
            // 
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Location = new System.Drawing.Point(97, 184);
            this.dataKH.Name = "dataKH";
            this.dataKH.RowTemplate.Height = 24;
            this.dataKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKH.Size = new System.Drawing.Size(674, 150);
            this.dataKH.TabIndex = 4;
            this.dataKH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.stt);
            this.dataKH.Click += new System.EventHandler(this.GetTable);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(97, 352);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(216, 352);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 6;
            this.btn_up.Text = "Sửa ";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(335, 352);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(459, 352);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(575, 352);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 9;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(696, 352);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 10;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // rdco
            // 
            this.rdco.AutoSize = true;
            this.rdco.Location = new System.Drawing.Point(548, 80);
            this.rdco.Name = "rdco";
            this.rdco.Size = new System.Drawing.Size(46, 21);
            this.rdco.TabIndex = 11;
            this.rdco.TabStop = true;
            this.rdco.Text = "Có";
            this.rdco.UseVisualStyleBackColor = true;
            // 
            // rdkhong
            // 
            this.rdkhong.AutoSize = true;
            this.rdkhong.Location = new System.Drawing.Point(548, 122);
            this.rdkhong.Name = "rdkhong";
            this.rdkhong.Size = new System.Drawing.Size(70, 21);
            this.rdkhong.TabIndex = 12;
            this.rdkhong.TabStop = true;
            this.rdkhong.Text = "Không";
            this.rdkhong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trả góp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kỳ hạn";
            // 
            // checkCo
            // 
            this.checkCo.AutoSize = true;
            this.checkCo.Location = new System.Drawing.Point(696, 83);
            this.checkCo.Name = "checkCo";
            this.checkCo.Size = new System.Drawing.Size(47, 21);
            this.checkCo.TabIndex = 15;
            this.checkCo.Text = "Có";
            this.checkCo.UseVisualStyleBackColor = true;
            // 
            // KyHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 409);
            this.Controls.Add(this.checkCo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdkhong);
            this.Controls.Add(this.rdco);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loaikh);
            this.Controls.Add(this.txt_makh);
            this.Name = "KyHan";
            this.Text = "KyHan";
            this.Load += new System.EventHandler(this.KyHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_loaikh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataKH;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.RadioButton rdco;
        private System.Windows.Forms.RadioButton rdkhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkCo;
    }
}