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
    public partial class LoaiTien : Form
    {
        public LoaiTien()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataTien.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }
       
        private void KyHan_Load(object sender, EventArgs e)
        {
            txt_matien.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            Loadtb();
        }

        private void Loadtb()
        {
            string sql = "select * from LoaiTien";
            dtbl = functions.GetTableToTable(sql);
            dataTien.DataSource = dtbl;
            dataTien.Columns[0].HeaderText = "Mã loại tiền";
            dataTien.Columns[1].HeaderText = "Loại tiền";
            dataTien.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataTien.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            dataTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void Reset()
        {
            txt_matien.Text = "";
            txt_ltien.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_matien.Enabled = true;
            txt_matien.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_matien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matien.Focus();
                return;
            }
            if (txt_ltien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ltien.Focus();
                return;
            }

            string sql = "select Matien from LoaiTien where Matien = '"+txt_matien.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matien.Focus();
                txt_matien.Text = "";
                return;
            }

            string sql1 = "insert into LoaiTien values('"+txt_matien.Text+"',N'"+txt_ltien.Text+"')";
            functions.RunSql(sql1);
            Loadtb();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_matien.Enabled = false;
        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matien.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_matien.Text = dataTien.CurrentRow.Cells["Matien"].Value.ToString();
            txt_ltien.Text = dataTien.CurrentRow.Cells["Tentien"].Value.ToString();
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
            if (txt_matien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ltien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ltien.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update LoaiTien set Tentien = N'"+txt_ltien.Text+"' where Matien = '"+txt_matien.Text+"'";
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
            if (txt_matien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ltien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ltien.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from LoaiTien where Matien = '"+txt_matien.Text+"'";
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
            txt_matien.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
