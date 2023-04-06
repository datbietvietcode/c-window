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
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void ChucVu_Load(object sender, EventArgs e)
        {
            txt_macv.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            Loadtb();
        }

        private void Loadtb() {
            string sql = "select * from ChucVu";
            dtbl = functions.GetTableToTable(sql);
            data_cv.DataSource = dtbl;
            data_cv.Columns[0].HeaderText = "Mã chức vụ";
            data_cv.Columns[1].HeaderText = "Tên chức vụ";
            data_cv.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            data_cv.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            data_cv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_cv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            }

        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //data_cv.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void GetTbale_click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false) {
                MessageBox.Show("Đang ở chế độ thêm mới!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_macv.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0) {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            txt_macv.Text = data_cv.CurrentRow.Cells["Macv"].Value.ToString();
            txt_tencv.Text = data_cv.CurrentRow.Cells["Tencv"].Value.ToString();
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;

        }

        private void Reset() {
            txt_macv.Text = "";
            txt_tencv.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_macv.Enabled = true;
            txt_macv.Focus();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_macv.Text == "") {
                MessageBox.Show("Bạn phải nhập mã chức vụ","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_macv.Focus();
                return;
            }
            if (txt_tencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencv.Focus();
                return;
            }

            string sql = "select Macv from ChucVu where Macv = '"+txt_macv.Text+"'";
            if (functions.CheckKey(sql)) {
                MessageBox.Show("Mã này đã có xin mời nhập lại!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_macv.Focus();
                txt_macv.Text = "";
                return;
            }

            string sql1 = "insert into ChucVu values('"+txt_macv.Text+"',N'"+txt_tencv.Text+"')";
            functions.RunSql(sql1);
            Loadtb();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_macv.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0) {
                MessageBox.Show("Không có dữ liệu!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txt_macv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencv.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update ChucVu set Tencv = N'" + txt_tencv.Text + "' where Macv = '" + txt_macv.Text + "'";
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
            if (txt_macv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tencv.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                string sql = "delete from ChucVu where Macv = '" + txt_macv.Text + "'";
                functions.RunSqlDel(sql);
                Loadtb();
                Reset();
            }


        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_macv.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }
    }
}
