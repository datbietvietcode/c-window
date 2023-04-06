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
    public partial class Timkiemsachtruyencs : Form
    {
        public Timkiemsachtruyencs()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void Timkiemsachtruyencs_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Class.Functions.FillCombo("SELECT * FROM tbllinhvuc", cblv, "malv", "tenlv");
            cblv.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tbltacgia", cbtg, "matg", "tentg");
            cbtg.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblnxb", cbnxb, "manxb", "tennxb");
            cbnxb.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tblsachtruyen where tensach = '%"+txt_tens.Text+"%' or malv = '"+cblv.SelectedValue.ToString()+"' and matg = '"+cbtg.SelectedValue.ToString()+"' and manxb = '"+cbnxb.SelectedValue.ToString()+"'";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã sách";
            ListDT.Columns[1].HeaderText = "Tên sách";
            ListDT.Columns[2].HeaderText = "Mã loại sách";
            ListDT.Columns[3].HeaderText = "Mã lĩnh vực";
            ListDT.Columns[4].HeaderText = "Mã tác giả";
            ListDT.Columns[5].HeaderText = "Mã nhà xuất bản";
            ListDT.Columns[6].HeaderText = "Mã ngôn ngữ";
            ListDT.Columns[7].HeaderText = "Số trang";
            ListDT.Columns[8].HeaderText = "Đơn giá";
            ListDT.Columns[9].HeaderText = "Số lượng";
            ListDT.Columns[10].HeaderText = "Ảnh";
            ListDT.Columns[11].HeaderText = "Ghi chú";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {
            cblv.SelectedIndex = -1;
            cbtg.SelectedIndex = -1;
            cbnxb.SelectedIndex = -1;
            txt_tens.Text = "";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Load_DT();
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}
