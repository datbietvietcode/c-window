using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baiktra
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Sach.Connect();
            Load_DT();
            txt_masach.Enabled = false;
            btn_save.Enabled = false;
            Class.Sach.FillCombo("SELECT * FROM tblNXB", cbNXB, "MaNXB", "TenNXB");
            cbNXB.SelectedIndex = -1;
        }
        private void Load_DT()
        {
            string sql = "select * from tblSachTruyen";
            dtbl = Class.Sach.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã sách";
            ListDT.Columns[1].HeaderText = "Tên sách";
            ListDT.Columns[2].HeaderText = "Mã NXB";
            ListDT.Columns[3].HeaderText = "Số lượng";
            ListDT.Columns[4].HeaderText = "Giá tiền";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListDT.Columns[0].Width = 100;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_masach.Enabled = true;
            txt_masach.Focus();
        }
        private void ResetValues()
        {

            txt_masach.Text = "";
            txt_tensach.Text = "";
            txt_sl.Text = "0";
            txt_gia.Text = "0";
            cbNXB.SelectedIndex = -1;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_masach.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_masach.Text = ListDT.CurrentRow.Cells["Masach"].Value.ToString();
            txt_tensach.Text = ListDT.CurrentRow.Cells["Tensach"].Value.ToString();
            string ma = ListDT.CurrentRow.Cells["MaNXB"].Value.ToString();
            cbNXB.Text = Class.Sach.GetFieldValues("SELECT TenNXB FROM tblNXB WHERE  (MaNXB = '" + ma + "')");
            txt_sl.Text = ListDT.CurrentRow.Cells["Soluong"].Value.ToString();
            txt_gia.Text = ListDT.CurrentRow.Cells["Gia"].Value.ToString();
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_masach.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập mã hng hoa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_masach.Focus();
                return;

            }
            if (txt_tensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensach.Focus();
                return;
            }
            if (cbNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNXB.Focus();
                return;
            }
            sql = "SELECT Masach FROM tblSachTruyen WHERE  (Masach = '" + txt_masach.Text.Trim() + "')";
            if (Class.Sach.checkKey(sql))
            {

                MessageBox.Show("Bản ghi này đã có, nhập bản ghi khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_masach.Focus();
                txt_masach.Text = "";
                return;
            }

            sql = "insert into tblSachTruyen values('"+txt_masach.Text+"','"+txt_tensach.Text+"','"+cbNXB.SelectedValue.ToString()+"',"+float.Parse(txt_sl.Text)+","+float.Parse(txt_gia.Text)+")";
            Class.Sach.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_masach.Enabled = false;
        }


        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_masach.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensach.Focus();
                return;
            }
            if (cbNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNXB.Focus();
                return;
            }
            sql = "delete from tblSachTruyen where Masach = '"+txt_masach.Text+"'";
            Class.Sach.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_masach.Enabled = false;
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_up_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_masach.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensach.Focus();
                return;
            }
            if (cbNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNXB.Focus();
                return;
            }
            sql = "update tblSachTruyen set Tensach = '"+txt_tensach.Text+"', MaNXB = '"+cbNXB.SelectedValue.ToString()+"', Soluong = "+float.Parse(txt_sl.Text)+", Gia = "+float.Parse(txt_gia.Text)+" where Masach = '"+txt_masach.Text+"'";
            Class.Sach.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void cbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
