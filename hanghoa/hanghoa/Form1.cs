using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hanghoa
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
            Class.Functions.Connect();
            Load_DT();
            txt_mahh.Enabled = false;
            btn_save.Enabled = false;
            Class.Functions.FillCombo("SELECT * FROM tblMausac",cbmamau,"Mamau","Tenmau");
            cbmamau.SelectedIndex = -1;
            ResetValues();

        }
        // load header Text
        private void Load_DT()
        {
            string sql = "select * from tblHanghoa";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã hàng hóa";
            ListDT.Columns[1].HeaderText = "Tên hàng hóa";
            ListDT.Columns[2].HeaderText = "Mã màu";
            ListDT.Columns[3].HeaderText = "Ảnh";
            ListDT.Columns[4].HeaderText = "Số lượng";
            ListDT.Columns[5].HeaderText = "Thời gian bảo hành";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListDT.Columns[0].Width = 100;
        }
        //reset values
        private void ResetValues() {

            txt_mahh.Text = "";
            txt_ten.Text = "";
            txt_sl.Text = "0";
            txt_time.Text = "0";
            txt_picture.Text = "";
            picBox.Image = null;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahh.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mahh.Text = ListDT.CurrentRow.Cells["Mahang"].Value.ToString();
            txt_ten.Text = ListDT.CurrentRow.Cells["Tenhang"].Value.ToString();
            string ma = ListDT.CurrentRow.Cells["Mamau"].Value.ToString();
            cbmamau.Text = Class.Functions.GetFieldValues("SELECT Tenmau FROM tblMausac WHERE  (Mamau = '"+ma+"')");
            txt_sl.Text = ListDT.CurrentRow.Cells["Soluong"].Value.ToString();
            txt_time.Text = ListDT.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            txt_picture.Text = Class.Functions.GetFieldValues("SELECT Anh FROM tblHanghoa WHERE Mahang = '"+txt_mahh.Text+"' ");
            picBox.Image = Image.FromFile(txt_picture.Text);
            btn_del.Enabled = true;
            btn_bq.Enabled = true;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_mahh.Enabled = true;
            txt_mahh.Focus();
        }
        // them anh
        private void btn_op_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|JPG(*.jpg)|*.jpg|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "chon anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK) {

                picBox.Image = Image.FromFile(dlgOpen.FileName);
                txt_picture.Text = dlgOpen.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_mahh.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập mã hng hoa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mahh.Focus();
                return;

            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (txt_picture.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_picture.Focus();
                return;
            }
            if (cbmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmamau.Focus();
                return;
            }
            sql = "SELECT Mahang FROM tblHanghoa WHERE  (Mahang = '" + txt_mahh.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập sinh viên khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mahh.Focus();
                txt_mahh.Text = "";
                return;
            }

            sql = "INSERT INTO tblHanghoa VALUES('"+txt_mahh.Text+"','"+txt_ten.Text+"','"+cbmamau.SelectedValue.ToString()+"','"+txt_picture.Text+"',"+float.Parse(txt_sl.Text)+","+float.Parse(txt_time.Text)+")";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_mahh.Enabled = false;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahh.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (txt_picture.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_picture.Focus();
                return;
            }
            if (cbmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmamau.Focus();
                return;
            }
            sql = "";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahh.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (txt_picture.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_picture.Focus();
                return;
            }
            if (cbmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmamau.Focus();
                return;
            }
            sql = "";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_mahh.Enabled = false;
        }

        private void cbmamau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
    }
}
