using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bảngSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangSp sp = new BangSp();
            sp.Show();
        }

        private void bảngKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void bảngHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InHoaDon ihd = new InHoaDon();
            ihd.Show();
        }
    }
}
