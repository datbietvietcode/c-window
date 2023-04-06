namespace WindowsFormsApp1
{
    partial class TinhTrangcs
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
            this.txt_matt = new System.Windows.Forms.TextBox();
            this.txt_tentt = new System.Windows.Forms.TextBox();
            this.ListDT = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_bq = new System.Windows.Forms.Button();
            this.btn_exits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tình trạng";
            // 
            // txt_matt
            // 
            this.txt_matt.Location = new System.Drawing.Point(261, 70);
            this.txt_matt.Name = "txt_matt";
            this.txt_matt.Size = new System.Drawing.Size(318, 22);
            this.txt_matt.TabIndex = 2;
            // 
            // txt_tentt
            // 
            this.txt_tentt.Location = new System.Drawing.Point(261, 119);
            this.txt_tentt.Name = "txt_tentt";
            this.txt_tentt.Size = new System.Drawing.Size(318, 22);
            this.txt_tentt.TabIndex = 3;
            // 
            // ListDT
            // 
            this.ListDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDT.Location = new System.Drawing.Point(115, 206);
            this.ListDT.Name = "ListDT";
            this.ListDT.RowHeadersWidth = 51;
            this.ListDT.RowTemplate.Height = 24;
            this.ListDT.Size = new System.Drawing.Size(587, 150);
            this.ListDT.TabIndex = 4;
            this.ListDT.Click += new System.EventHandler(this.ListDT_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(115, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(212, 401);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(310, 401);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "Sửa";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(416, 401);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_bq
            // 
            this.btn_bq.Location = new System.Drawing.Point(518, 401);
            this.btn_bq.Name = "btn_bq";
            this.btn_bq.Size = new System.Drawing.Size(75, 23);
            this.btn_bq.TabIndex = 9;
            this.btn_bq.Text = "Bỏ qua";
            this.btn_bq.UseVisualStyleBackColor = true;
            this.btn_bq.Click += new System.EventHandler(this.btn_bq_Click);
            // 
            // btn_exits
            // 
            this.btn_exits.Location = new System.Drawing.Point(627, 401);
            this.btn_exits.Name = "btn_exits";
            this.btn_exits.Size = new System.Drawing.Size(75, 23);
            this.btn_exits.TabIndex = 10;
            this.btn_exits.Text = "Thoát";
            this.btn_exits.UseVisualStyleBackColor = true;
            this.btn_exits.Click += new System.EventHandler(this.btn_exits_Click);
            // 
            // TinhTrangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exits);
            this.Controls.Add(this.btn_bq);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.ListDT);
            this.Controls.Add(this.txt_tentt);
            this.Controls.Add(this.txt_matt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TinhTrangcs";
            this.Text = "TinhTrangcs";
            this.Load += new System.EventHandler(this.TinhTrangcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matt;
        private System.Windows.Forms.TextBox txt_tentt;
        private System.Windows.Forms.DataGridView ListDT;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_bq;
        private System.Windows.Forms.Button btn_exits;
    }
}