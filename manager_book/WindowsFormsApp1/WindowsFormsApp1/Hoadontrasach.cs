using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hoadontrasach : Form
    {
        public Hoadontrasach()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void Hoadontrasach_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            btn_add.Enabled = true;
            btn_save.Enabled = false;
            btn_del.Enabled = false;
            btn_print.Enabled = false;
            txt_dongia.ReadOnly = true;
            txt_ngaythue.ReadOnly = true;
            txt_tennv.ReadOnly = true;
            txt_thanhtien.ReadOnly = true;
            txt_tens.ReadOnly = true;
            txt_tien.ReadOnly = true;
            Class.Functions.FillCombo("SELECT * FROM tblthuesach",cbmathue, "mathue", "mathue");
            cbmathue.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblnhanvien", cboManhanvien, "manv", "manv");
            cboManhanvien.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblvipham", cbvipham, "mavipham", "tenvipham");
            cbvipham.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblsachtruyen", cbmasach, "masach", "masach");
            cbmasach.SelectedIndex = -1;
            txt_mat.Enabled = false;
        }
        private void Load_DT()
        {
            string sql = "select * from ";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã trả";
            ListDT.Columns[1].HeaderText = "Mã thuê";
            ListDT.Columns[2].HeaderText = "Mã nhân viên";
            ListDT.Columns[3].HeaderText = "Ngày trả";
            ListDT.Columns[4].HeaderText = "Tổng tiền";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbmanv(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "") txt_tennv.Text = "";
            str = "select tennv from tblnhanvien where manv = '"+cboManhanvien.SelectedValue+"'";
            txt_tennv.Text = Class.Functions.GetFieldValues(str);
        }

        private void cbsach(object sender, EventArgs e)
        {
            string str,st;
            if (cbmasach.Text == "") txt_tens.Text = ""; txt_dongia.Text = "";
            str = "select tensach from tblsachtruyen where masach = '" + cbmasach.SelectedValue + "'";
            txt_tens.Text = Class.Functions.GetFieldValues(str);
            st = "select dongia from tblsachtruyen where masach = '" + cbmasach.SelectedValue + "'";
            txt_dongia.Text = Class.Functions.GetFieldValues(st);

        }



        private void chonvipham(object sender, EventArgs e)
        {
            string str;
            if (cbvipham.Text == "") txt_tien.Text = "";
            str = "select tienphat from tblvipham where mavipham = '" + cbvipham.SelectedValue + "'";
            txt_tien.Text = Class.Functions.GetFieldValues(str);
        }

        private void chonmathue(object sender, EventArgs e)
        {
            string str;
            if (cbvipham.Text == "") txt_ngaythue.Text = "";
            str = "select ngaythue from tblthuesach where mathue = '" + cbmathue.SelectedValue + "'";
            txt_ngaythue.Text = Class.Functions.GetFieldValues(str);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            txt_mat.Enabled = true;
            txt_mat.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql = "", sql2 = "";
            //sql = "insert into tbltrasach values('"+txt_mat.Text+"','"+cbmathue.SelectedValue.ToString()+"','"+cboManhanvien.SelectedValue.ToString()+"','"+Class.Functions.ConvertDateTime(txt_ngaytra.Text)+"',)";
            sql2 = "insert into tblchitiettrasach values('"+txt_mat.Text+"','"+cbmasach.SelectedValue.ToString()+"','"+cbvipham.SelectedValue.ToString()+"',"+thanhtien(Class.Functions.ConvertDateTime(txt_ngaythue.Text), Class.Functions.ConvertDateTime(txt_ngaytra.Text)) +")";
           // Class.Functions.runSql(sql);
            Class.Functions.runSql(sql2);
            Load_DT();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_mat.Enabled = false;
        }

        private string thanhtien(string d1, string d2)
        {
            string dg = "select dongia from tblsachtruyen where masach = '" + cbmasach.SelectedValue + "'";
            string kq = Class.Functions.GetFieldValues(dg);
            string result = "";
            string[] parts1 = d1.Split('/');
            string[] parts2 = d2.Split('/');
            if(int.Parse(parts2[2]) == int.Parse(parts1[2]))
            {
                if (int.Parse(parts2[1]) == int.Parse(parts1[1])) {
                    result += (int.Parse(parts2[0]) - int.Parse(parts1[0])) * int.Parse(kq);
                }
            }

            return result;
        }
    }
}
