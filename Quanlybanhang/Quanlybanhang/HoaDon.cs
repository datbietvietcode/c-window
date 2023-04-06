using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlybanhang
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            SP sp = new SP();
            sp.Hienthi(list_sp,"select * from Sanpham");
            HD hd = new HD();
            hd.Hienthi(list_hd,"select * from Hoadon");
            cbmakh.DataSource = hd.Load_Table("select * from Khachhang");
            cbmakh.DisplayMember = "Tenkh";
            cbmakh.ValueMember = "Makh";
            cbmakh.SelectedIndex = -1;

            cbmasp.DataSource = hd.Load_Table("select * from Sanpham");
            cbmasp.DisplayMember = "Tensp";
            cbmasp.ValueMember = "Masp";
            cbmasp.SelectedIndex = -1;
        }

        private void list_hd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_hd.SelectedItems)
            {
                
                txt_mahd.Text = item.SubItems[1].Text;
                txt_sl.Text = item.SubItems[4].Text;
                txt_dongia.Text = item.SubItems[5].Text;
                txt_ngaymua.Text = item.SubItems[6].Text;
            }
        }

        private void cbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmasp.SelectedValue == null)
            {
                return;
            }
            else {

                HD ob = new HD();
                DataTable dt = new DataTable();
                dt = ob.Load_Table("select Dongia from GiaSP where Masp = '" + cbmasp.SelectedValue.ToString() + "'");
                foreach (DataRow row in dt.Rows)
                {

                    txt_dongia.Text = row["Dongia"].ToString();
                }
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbmasp.SelectedValue == null) { return; }
            else {

                HD hd = new HD();
                string sql = "select Soluong from Sanpham where Masp = '" + cbmasp.SelectedValue.ToString() + "'";
                DataTable dt = new DataTable();
                dt = hd.Load_Table(sql);
                string sl1 = "";
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = row["Soluong"].ToString();
                }
                if (float.Parse((txt_sl.Text)) > float.Parse(sl1))
                {
                    MessageBox.Show("Không dủ để bán");
                }
                else {

                    HD ob = new HD(txt_mahd.Text,cbmakh.SelectedValue.ToString(),cbmasp.SelectedValue.ToString(),float.Parse(txt_sl.Text),float.Parse(txt_dongia.Text),Convert.ToDateTime(txt_ngaymua.Text));
                    ob.insert(ob);
                    float sl = float.Parse(sl1) - float.Parse(txt_sl.Text);
                    string sql1 = "update Sanpham set Soluong ="+sl+" where Masp='"+cbmasp.SelectedValue.ToString()+"'";
                    ob.Excecute(sql1);
                    HoaDon_Load(sender,e);
                }
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (cbmasp.SelectedValue == null) { return; }
            else {

                HD hd = new HD();
                string sql = "select Soluong from Sanpham where Masp = '" + cbmasp.SelectedValue.ToString() + "'";
                DataTable dt = new DataTable();
                dt = hd.Load_Table(sql);
                string sl1 = "";
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = row["Soluong"].ToString();
                }

                    HD ob = new HD(txt_mahd.Text,cbmakh.SelectedValue.ToString(),cbmasp.SelectedValue.ToString(),float.Parse(txt_sl.Text),float.Parse(txt_dongia.Text),Convert.ToDateTime(txt_ngaymua.Text));
                    ob.delete(ob);
                    float sl = float.Parse(sl1) + float.Parse(txt_sl.Text);
                    string sql1 = "update Sanpham set Soluong =" + sl + " where Masp='" + cbmasp.SelectedValue.ToString() + "'";
                    ob.Excecute(sql1);
                    HoaDon_Load(sender,e);
                }
           }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (cbmasp.SelectedValue == null) { return; }
            else
            {

               
                string sql = "select Soluong from Sanpham where Masp = '" + cbmasp.SelectedValue.ToString() + "'";
                HD hd = new HD();
                DataTable dt = new DataTable();
                dt = hd.Load_Table(sql);
                float sl1 = 0,sl2 = 0;
                foreach (DataRow row in dt.Rows)
                {

                    sl1 = float.Parse(row["Soluong"].ToString());
                }

                string sql1 = "select Soluong from Hoadon where Mahd = '"+txt_mahd.Text+"'";
                DataTable dt1 = new DataTable();
                dt1 = hd.Load_Table(sql1);
                foreach(DataRow row in dt1.Rows){
                    sl2 = float.Parse(row["Soluong"].ToString()); 
                }
                HD ob = new HD(txt_mahd.Text, cbmakh.SelectedValue.ToString(), cbmasp.SelectedValue.ToString(), float.Parse(txt_sl.Text), float.Parse(txt_dongia.Text), Convert.ToDateTime(txt_ngaymua.Text));
                 ob.update(ob);
                float sl = sl1 + sl2 - float.Parse(txt_sl.Text);
                string sql3 = "update Sanpham set Soluong =" + sl + " where Masp='" + cbmasp.SelectedValue.ToString() + "'";
                ob.Excecute(sql3);
                HoaDon_Load(sender, e);
            }
        
        }
    }
}
