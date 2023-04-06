namespace hanghoa
{
    partial class combobox
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
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.cbsp = new System.Windows.Forms.ComboBox();
            this.txt_tenb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(87, 96);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(121, 24);
            this.cbnv.TabIndex = 0;
            // 
            // cbsp
            // 
            this.cbsp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbsp.FormattingEnabled = true;
            this.cbsp.Location = new System.Drawing.Point(87, 157);
            this.cbsp.Name = "cbsp";
            this.cbsp.Size = new System.Drawing.Size(121, 24);
            this.cbsp.TabIndex = 1;
            this.cbsp.SelectedIndexChanged += new System.EventHandler(this.combobox_Load);
            this.cbsp.SelectedValueChanged += new System.EventHandler(this.combobox_Load);
            this.cbsp.TextChanged += new System.EventHandler(this.combobox_Load);
            // 
            // txt_tenb
            // 
            this.txt_tenb.Location = new System.Drawing.Point(87, 213);
            this.txt_tenb.Name = "txt_tenb";
            this.txt_tenb.Size = new System.Drawing.Size(100, 22);
            this.txt_tenb.TabIndex = 2;
            this.txt_tenb.TextChanged += new System.EventHandler(this.cbSanpham);
            // 
            // combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 383);
            this.Controls.Add(this.txt_tenb);
            this.Controls.Add(this.cbsp);
            this.Controls.Add(this.cbnv);
            this.Name = "combobox";
            this.Text = "combobox";
            this.Load += new System.EventHandler(this.combobox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.ComboBox cbsp;
        private System.Windows.Forms.TextBox txt_tenb;
    }
}