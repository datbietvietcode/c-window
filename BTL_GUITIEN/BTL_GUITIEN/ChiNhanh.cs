using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_GUITIEN
{
    public partial class ChiNhanh : Form
    {
        public ChiNhanh()
        {
            InitializeComponent();
        }
        
        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select Manv,Tennv from NhanVien where Macv = 'CV02'",cbquanly,"Tennv","Manv");
            txt_macn.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            Loadtb();
            cbquanly.Text = "Chọn người quản lý";
        }
        DataTable dtbl;
        private void Loadtb()
        {
            string sql = "select * from ChiNhanh";
            dtbl = functions.GetTableToTable(sql);
            dataCN.DataSource = dtbl;
            dataCN.Columns[0].HeaderText = "Mã chi nhánh";
            dataCN.Columns[1].HeaderText = "Tên chi nhánh";
            dataCN.Columns[2].HeaderText = "Địa chỉ";
            dataCN.Columns[3].HeaderText = "Mã nhân viên quản lý";
            dataCN.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataCN.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            dataCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void Reset()
        {
            txt_macn.Text = "";
            txt_tencn.Text = "";
            txt_diachi.Text = "";
            cbquanly.Text = "Chọn người quản lý";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_macn.Enabled = true;
            txt_macn.Focus();
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_macn.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_macn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_macn.Focus();
                return;
            }
            if (txt_tencn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencn.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (cbquanly.Text.CompareTo("Chọn người quản lý") == 0)
            {
                MessageBox.Show("Bạn phải chọn người quản lý", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "select MaCN from ChiNhanh where MaCN = '"+txt_macn.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_macn.Focus();
                txt_macn.Text = "";
                return;
            }

            string sql1 = "insert into ChiNhanh values('"+txt_macn.Text+"',N'"+txt_tencn.Text+"',N'"+txt_diachi.Text+"','"+cbquanly.SelectedValue.ToString()+"')";
            functions.RunSql(sql1);
            Loadtb();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_macn.Enabled = false;
        }

        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataCN.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void getTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_macn.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_macn.Text = dataCN.CurrentRow.Cells["MaCN"].Value.ToString();
            txt_tencn.Text = dataCN.CurrentRow.Cells["TenCN"].Value.ToString();
            txt_diachi.Text = dataCN.CurrentRow.Cells["Diachi"].Value.ToString();
            string d = dataCN.CurrentRow.Cells["Manv"].Value.ToString();
            cbquanly.Text = functions.GetFieldValues("select * from NhanVien where Manv = '"+d+"'", "Tennv");
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_macn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_macn.Focus();
                return;
            }
            if (txt_tencn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencn.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (cbquanly.Text.CompareTo("Chọn người quản lý") == 0)
            {
                MessageBox.Show("Bạn phải chọn người quản lý", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update ChiNhanh set TenCN = N'"+txt_tencn.Text+"', Diachi = N'"+txt_diachi.Text+"', Manv = '"+cbquanly.SelectedValue.ToString()+"' where MaCN = '"+txt_macn.Text+"'";
                functions.RunSql(sql);
                Loadtb();
                Reset();
                btn_bq.Enabled = false;
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_macn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_macn.Focus();
                return;
            }
            if (txt_tencn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencn.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (cbquanly.Text.CompareTo("Chọn người quản lý") == 0)
            {
                MessageBox.Show("Bạn phải chọn người quản lý", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from ChiNhanh where MaCN = '"+txt_macn.Text+"'";
                functions.RunSqlDel(sql);
                Loadtb();
                Reset();
            }

        }
    }
}
