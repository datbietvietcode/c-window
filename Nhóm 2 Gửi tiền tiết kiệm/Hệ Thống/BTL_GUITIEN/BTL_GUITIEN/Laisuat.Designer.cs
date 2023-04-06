namespace BTL_GUITIEN
{
    partial class Laisuat
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
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.txt_ls = new System.Windows.Forms.TextBox();
            this.txt_th = new System.Windows.Forms.TextBox();
            this.txt_mals = new System.Windows.Forms.TextBox();
            this.cbtien = new System.Windows.Forms.ComboBox();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.dataLS = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lãi suất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lãi suất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày cập nhật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại kỳ hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại tiền";
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(631, 104);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(212, 22);
            this.txt_ns.TabIndex = 6;
            // 
            // txt_ls
            // 
            this.txt_ls.Location = new System.Drawing.Point(241, 184);
            this.txt_ls.Name = "txt_ls";
            this.txt_ls.Size = new System.Drawing.Size(149, 22);
            this.txt_ls.TabIndex = 7;
            // 
            // txt_th
            // 
            this.txt_th.Location = new System.Drawing.Point(241, 147);
            this.txt_th.Name = "txt_th";
            this.txt_th.Size = new System.Drawing.Size(213, 22);
            this.txt_th.TabIndex = 8;
            // 
            // txt_mals
            // 
            this.txt_mals.Location = new System.Drawing.Point(241, 104);
            this.txt_mals.Name = "txt_mals";
            this.txt_mals.Size = new System.Drawing.Size(213, 22);
            this.txt_mals.TabIndex = 9;
            // 
            // cbtien
            // 
            this.cbtien.FormattingEnabled = true;
            this.cbtien.Location = new System.Drawing.Point(631, 186);
            this.cbtien.Name = "cbtien";
            this.cbtien.Size = new System.Drawing.Size(212, 24);
            this.cbtien.TabIndex = 10;
            // 
            // cbkh
            // 
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(631, 149);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(212, 24);
            this.cbkh.TabIndex = 11;
            // 
            // dataLS
            // 
            this.dataLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLS.Location = new System.Drawing.Point(151, 252);
            this.dataLS.Name = "dataLS";
            this.dataLS.RowTemplate.Height = 24;
            this.dataLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLS.Size = new System.Drawing.Size(692, 193);
            this.dataLS.TabIndex = 12;
            this.dataLS.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.stt);
            this.dataLS.Click += new System.EventHandler(this.GetTable);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(151, 489);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(274, 489);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 14;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(402, 489);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(530, 489);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(652, 489);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 17;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(768, 489);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 18;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "(%/năm)";
            // 
            // Laisuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 578);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataLS);
            this.Controls.Add(this.cbkh);
            this.Controls.Add(this.cbtien);
            this.Controls.Add(this.txt_mals);
            this.Controls.Add(this.txt_th);
            this.Controls.Add(this.txt_ls);
            this.Controls.Add(this.txt_ns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Laisuat";
            this.Text = "Laisuatcs";
            this.Load += new System.EventHandler(this.Laisuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLS)).EndInit();
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
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.TextBox txt_ls;
        private System.Windows.Forms.TextBox txt_th;
        private System.Windows.Forms.TextBox txt_mals;
        private System.Windows.Forms.ComboBox cbtien;
        private System.Windows.Forms.ComboBox cbkh;
        private System.Windows.Forms.DataGridView dataLS;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button exits;
        private System.Windows.Forms.Label label7;
    }
}