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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            KH ob = new KH();
            ob.Hienthi(list_kh, "select * from Khachhang");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txt_mak.Text,txt_tenk.Text,txt_diachi.Text);
            if (ob.KT_check(txt_mak.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else
            {
                ob.insert(ob);
                KhachHang_Load(sender, e);
            }

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txt_mak.Text, txt_tenk.Text, txt_diachi.Text);
            ob.update(ob);
            KhachHang_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txt_mak.Text, txt_tenk.Text, txt_diachi.Text);
            ob.delete(ob);
            KhachHang_Load(sender, e);
        }

        private void list_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_kh.SelectedItems)
            {
                txt_mak.Text = item.SubItems[1].Text;
                txt_tenk.Text = item.SubItems[2].Text;
                txt_diachi.Text = item.SubItems[3].Text;
            }
        }
    }
}
