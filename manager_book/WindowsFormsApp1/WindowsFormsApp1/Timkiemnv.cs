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
    public partial class Timkiemnv : Form
    {
        public Timkiemnv()
        {
            InitializeComponent();
        }
        DataTable dtbl;

        private void Timkiemnv_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Class.Functions.FillCombo("SELECT * FROM tblcalam", cbcalam, "maca", "tenca");
            cbcalam.SelectedIndex = -1;
            ResetValues();
        }
        
        private void Load_DT()
        {
            string sql = "select * from tblnhanvien where tennv = '%" + txt_manv.Text + "%' or maca = '" + cbcalam.SelectedValue.ToString() + "' and gioitinh='" + Class.Functions.gioitinh(checksex.Checked) + "'";

            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã nhân viên";
            ListDT.Columns[1].HeaderText = "Tên nhân viên";
            ListDT.Columns[2].HeaderText = "Mã ca làm";
            ListDT.Columns[3].HeaderText = "Năm sinh";
            ListDT.Columns[4].HeaderText = "Giới tính";
            ListDT.Columns[5].HeaderText = "Địa chỉ";
            ListDT.Columns[5].HeaderText = "Điện thoại";
            ListDT.Columns[5].HeaderText = "Lương";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {

            txt_manv.Text = "";
            checksex.Checked = false;
            cbcalam.SelectedIndex = -1;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Load_DT();
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            txt_manv.Text = "";
            txt_manv.Focus();
            cbcalam.SelectedIndex = -1;
            checksex.Checked = false;
        }
    }
}
