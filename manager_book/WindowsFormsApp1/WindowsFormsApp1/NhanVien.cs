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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl;

        private void NhanVien_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_manv.Enabled = false;
            btn_save.Enabled = false;
            Class.Functions.FillCombo("SELECT * FROM tblcalam", cbcalam, "maca", "tenca");
            cbcalam.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tblnhanvien";
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
            ListDT.Columns[0].Width = 100;
        }
        //reset values
        private void ResetValues()
        {
            txt_dienthoai.Text = "";
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_date.Text = "__//__//____";
            txt_address.Text = "";
            txt_luong.Text = "0";
            checksex.Checked = false;
            cbcalam.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_manv.Enabled = true;
            txt_manv.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manv.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (cbcalam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcalam.Focus();
                return;
            }
            sql = "delete from tblnhanvien where manv = '"+txt_manv.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_manv.Text = ListDT.CurrentRow.Cells["manv"].Value.ToString();
            txt_tennv.Text = ListDT.CurrentRow.Cells["tennv"].Value.ToString();
            string ma = ListDT.CurrentRow.Cells["maca"].Value.ToString();
            cbcalam.Text = Class.Functions.GetFieldValues("SELECT tenca FROM tblcalam WHERE  (maca = '" + ma + "')");
            txt_luong.Text = ListDT.CurrentRow.Cells["luong"].Value.ToString();
            txt_address.Text = ListDT.CurrentRow.Cells["diachi"].Value.ToString();
            txt_date.Text = ListDT.CurrentRow.Cells["namsinh"].Value.ToString();
            txt_dienthoai.Text = ListDT.CurrentRow.Cells["dienthoai"].Value.ToString();
            if (ListDT.CurrentRow.Cells["gioitinh"].Value.ToString() == "nam")
            {
                checksex.Checked = true;
            }
            else
            {
                checksex.Checked = false;
            }
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manv.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (cbcalam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcalam.Focus();
                return;
            }
            sql = "update tblnhanvien set tennv = '"+txt_tennv.Text+"', maca = '"+cbcalam.SelectedValue.ToString()+"', namsinh = '"+Class.Functions.ConvertDateTime(txt_date.Text)+"', gioitinh = '"+Class.Functions.gioitinh(checksex.Checked)+"', diachi = '"+txt_address.Text+"', dienthoai = '"+txt_dienthoai.Text+"', luong = '"+float.Parse(txt_luong.Text)+"' where manv = '"+txt_manv.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manv.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (cbcalam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcalam.Focus();
                return;
            }

            sql = "SELECT manv FROM tbltacgia WHERE  (matg = '" + txt_manv.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập sinh viên khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                txt_manv.Text = "";
                return;
            }

            sql = "insert into tblnhanvien values('"+txt_manv.Text+"','"+txt_tennv.Text+"','"+cbcalam.SelectedValue.ToString()+"','"+Class.Functions.ConvertDateTime(txt_date.Text)+"','"+Class.Functions.gioitinh(checksex.Checked)+"','"+txt_address.Text+"','"+txt_dienthoai.Text+"',"+float.Parse(txt_luong.Text)+")";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_manv.Enabled = false;

        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_manv.Enabled = false;
        }
    }
}
