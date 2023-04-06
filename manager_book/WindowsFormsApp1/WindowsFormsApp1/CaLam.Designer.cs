namespace WindowsFormsApp1
{
    partial class CaLam
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
            this.txt_maca = new System.Windows.Forms.TextBox();
            this.txt_tenca = new System.Windows.Forms.TextBox();
            this.ListDT = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ca làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ca làm";
            // 
            // txt_maca
            // 
            this.txt_maca.Location = new System.Drawing.Point(251, 69);
            this.txt_maca.Name = "txt_maca";
            this.txt_maca.Size = new System.Drawing.Size(317, 22);
            this.txt_maca.TabIndex = 2;
            // 
            // txt_tenca
            // 
            this.txt_tenca.Location = new System.Drawing.Point(251, 132);
            this.txt_tenca.Name = "txt_tenca";
            this.txt_tenca.Size = new System.Drawing.Size(317, 22);
            this.txt_tenca.TabIndex = 3;
            // 
            // ListDT
            // 
            this.ListDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDT.Location = new System.Drawing.Point(102, 215);
            this.ListDT.Name = "ListDT";
            this.ListDT.RowHeadersWidth = 51;
            this.ListDT.RowTemplate.Height = 24;
            this.ListDT.Size = new System.Drawing.Size(611, 150);
            this.ListDT.TabIndex = 4;
            this.ListDT.Click += new System.EventHandler(this.ListDT_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(102, 415);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(213, 415);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(323, 415);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(425, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(533, 415);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 9;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(638, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.ListDT);
            this.Controls.Add(this.txt_tenca);
            this.Controls.Add(this.txt_maca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CaLam";
            this.Text = "CaLam";
            this.Load += new System.EventHandler(this.CaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maca;
        private System.Windows.Forms.TextBox txt_tenca;
        private System.Windows.Forms.DataGridView ListDT;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button button6;
    }
}