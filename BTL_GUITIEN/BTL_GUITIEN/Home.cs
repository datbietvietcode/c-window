using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_GUITIEN
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH kh = new KH();
            kh.Show();
        }

        private void kỳHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KyHan h = new KyHan();
            h.Show();
        }

        private void loạiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiTien lt = new LoaiTien();
            lt.Show();
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiNhanh cn = new ChiNhanh();
            cn.Show();
        }

        private void lãiSuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laisuat ls = new Laisuat();
            ls.Show();
        }

        private void mởSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoTK stk = new SoTK();
            stk.Show();
        }

        private void gửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiTien gt = new GuiTien();
            gt.Show();
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_map rt = new txt_map();
            rt.Show();
        }

        private void hóaĐơnGửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonGT gt = new HoaDonGT();
            gt.Show();
        }

        private void hóaĐơnRútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonRT rt = new HoaDonRT();
            rt.Show();
        }

        private void inSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            In_STK stk = new In_STK();
            stk.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
        }

        private void thốngKêHóaĐơnGửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKTG tg = new TKTG();
            tg.Show();
        }

        private void thốngKêHóaĐơnRútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKRT rt = new TKRT();
            rt.Show();
        }
    }
}
