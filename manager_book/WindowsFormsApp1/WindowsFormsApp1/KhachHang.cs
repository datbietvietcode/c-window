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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_makh.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tblkhachhang";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã khách hàng";
            ListDT.Columns[1].HeaderText = "Tên khách hàng";
            ListDT.Columns[2].HeaderText = "Ngày sinh";
            ListDT.Columns[3].HeaderText = "Giới tính";
            ListDT.Columns[4].HeaderText = "Địa chỉ";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {

            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_date.Text = "(__//__/___)";
            txt_diachi.Text = "";
            checksex.Checked = false;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makh.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_makh.Text = ListDT.CurrentRow.Cells["makhach"].Value.ToString();
            txt_tenkh.Text = ListDT.CurrentRow.Cells["tenkhach"].Value.ToString();
            txt_date.Text = ListDT.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txt_diachi.Text = ListDT.CurrentRow.Cells["diachi"].Value.ToString();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_makh.Enabled = true;
            txt_makh.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makh.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_date.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_date.Focus();
                return;
            }
            sql = "delete from tblkhachhang where makhach = '"+txt_makh.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makh.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }

            sql = "update tblkhachhang set tenkhach = '"+txt_tenkh.Text+"', diachi = '"+txt_diachi.Text+"', gioitinh = '"+Class.Functions.gioitinh(checksex.Checked)+"', ngaysinh = '"+Class.Functions.ConvertDateTime(txt_date.Text)+"' where makhach = '"+txt_makh.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_makh.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập mã hng hoa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;

            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }

            sql = "SELECT makhach FROM tblkhachhang WHERE  (makhach = '" + txt_makh.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập sinh viên khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                txt_makh.Text = "";
                return;
            }

            sql = "insert into tblkhachhang values('"+txt_makh.Text+"','"+txt_tenkh.Text+"','"+txt_date.Text+"','"+Class.Functions.gioitinh(checksex.Checked)+"','"+txt_diachi.Text+"')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_makh.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_makh.Enabled = false;
        }
    }
}
