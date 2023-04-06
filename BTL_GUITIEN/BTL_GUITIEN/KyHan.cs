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
    public partial class KyHan : Form
    {
        public KyHan()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           // dataKH.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void KyHan_Load(object sender, EventArgs e)
        {
            txt_makh.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            set();
            Loadtb();   
        }
        private void Loadtb()
        {
            string sql = "select * from KyHan";
            dtbl = functions.GetTableToTable(sql);
            dataKH.DataSource = dtbl;
            dataKH.Columns[0].HeaderText = "Mã kỳ hạn";
            dataKH.Columns[1].HeaderText = "Tên kỳ hạn";
            dataKH.Columns[2].HeaderText = "Trả góp";
            dataKH.Columns[3].HeaderText = "Kỳ hạn";
            dataKH.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataKH.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            dataKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void Reset()
        {
            txt_makh.Text = "";
            txt_loaikh.Text = "";
            set();
        }

        private void set() {
            rdco.Checked = true;
            rdkhong.Checked = false;
            checkCo.Checked = true;
        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_makh.Enabled = true;
            txt_makh.Focus();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_makh.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            string trl = "";
            if (rdco.Checked == true)
            {
                trl = rdco.Text;
            }
            else
            {
                trl = rdkhong.Text;
            }

            string check = "";
            if (checkCo.Checked == true)
            {
                check = "Có";
            }
            else {
                check = "Không";
            }
            if (txt_loaikh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_loaikh.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update KyHan set Loaikh = N'" + txt_loaikh.Text + "', tragop = N'"+trl+"', kyhan = N'"+check+"' where Makh = '" + txt_makh.Text + "'";
                functions.RunSql(sql);
                Loadtb();
                Reset();
                btn_bq.Enabled = false;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            if (txt_loaikh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_loaikh.Focus();
                return;
            }
            string trl = "";
            if (rdco.Checked == true)
            {
                trl = rdco.Text;
            }
            else {
                trl = rdkhong.Text;
            }
            string check = "";
            if (checkCo.Checked == true)
            {
                check = "Có";
            }
            else
            {
                check = "Không";
            }

            string sql = "select Makh from KyHan where Makh = '"+txt_makh+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                txt_makh.Text = "";
                return;
            }

            string sql1 = "insert into KyHan values('"+txt_makh.Text+"',N'"+txt_loaikh.Text+"',N'"+trl+"',N'"+check+"')";
            functions.RunSql(sql1);
            Loadtb();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_makh.Enabled = false;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            if (txt_loaikh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_loaikh.Focus();
                return;
            }
       /*     string check = "";
            if (checkCo.Checked == true)
            {
                check = "Có";
            }
            else
            {
                check = "Không";
            }*/
            string trl = "";
            if (rdco.Checked == true)
            {
                trl = rdco.Text;
            }
            else
            {
                trl = rdkhong.Text;
            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from KyHan where Makh = '"+txt_makh.Text+"'";
                functions.RunSqlDel(sql);
                Loadtb();
                Reset();
            }
        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makh.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_makh.Text = dataKH.CurrentRow.Cells["Makh"].Value.ToString();
            txt_loaikh.Text = dataKH.CurrentRow.Cells["Loaikh"].Value.ToString();
            string trl = dataKH.CurrentRow.Cells["tragop"].Value.ToString();
            if (trl.CompareTo(rdco.Text) == 0)
            {
                rdco.Checked = true;
            }
            else {
                rdkhong.Checked = true;
            }
            string check = dataKH.CurrentRow.Cells["kyhan"].Value.ToString();
            if (check.CompareTo("Có") == 0)
            {
                checkCo.Checked = true;
            }
            else {
                checkCo.Checked = false;
            }
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }
    }
}
