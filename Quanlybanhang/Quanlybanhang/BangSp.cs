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
    public partial class BangSp : Form
    {
        public BangSp()
        {
            InitializeComponent();
        }

        private void BangSp_Load(object sender, EventArgs e)
        {
            SP ob = new SP();
            ob.Hienthi(list_Sp,"select * from Sanpham");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SP ob = new SP(txt_masp.Text,txt_tensp.Text,float.Parse(txt_sl.Text),float.Parse(txt_dongia.Text));
            if (ob.KT_check(txt_masp.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else {
                ob.insert(ob);
                BangSp_Load(sender, e);
            }
        }

        private void list_Sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_Sp.SelectedItems)
            {
                txt_masp.Text = item.SubItems[1].Text;
                txt_tensp.Text = item.SubItems[2].Text;
                txt_sl.Text = item.SubItems[3].Text;
                txt_dongia.Text = item.SubItems[4].Text;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            SP ob = new SP(txt_masp.Text, txt_tensp.Text, float.Parse(txt_sl.Text), float.Parse(txt_dongia.Text));
            ob.update(ob);
            BangSp_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            SP ob = new SP(txt_masp.Text, txt_tensp.Text, float.Parse(txt_sl.Text), float.Parse(txt_dongia.Text));
            ob.delete(ob);
            BangSp_Load(sender, e);
        }
    }
}
