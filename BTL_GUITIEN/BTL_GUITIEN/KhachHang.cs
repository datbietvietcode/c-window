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
    public partial class KH : Form
    {
        public KH()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void KH_Load(object sender, EventArgs e)
        {
            set();
            txt_makh.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            LoadDT();
        }
        private void Reset()
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_cmnd.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            set();

        }

        private void set()
        {
            txt_ns.Text = "dd/mm/yyyy";
            gtNam.Checked = true;
            gtNu.Checked = false;

        }

        private void LoadDT()
        {
            string sql = "select * from KhachHang";
            dtbl = functions.GetTableToTable(sql);
            dataKH.DataSource = dtbl;
            dataKH.Columns[0].HeaderText = "Mã khách hàng";
            dataKH.Columns[1].HeaderText = "Tên khách hàng";
            dataKH.Columns[2].HeaderText = "Giới tính";
            dataKH.Columns[3].HeaderText = "Số điện thoại";
            dataKH.Columns[4].HeaderText = "CMND";
            dataKH.Columns[5].HeaderText = "Địa chỉ";
            dataKH.Columns[6].HeaderText = "Ngày sinh";
            dataKH.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataKH.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            //dataNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataKH.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            string gt = "";
            if (gtNu.Checked == true)
            {
                gt = gtNu.Text;
            }
            else
            {
                gt = gtNam.Text;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (txt_cmnd.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập chứng minh nhân dân", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cmnd.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select Makh from KhachHang where Makh = '"+txt_makh.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                txt_makh.Text = "";
                return;

            }
            string sql1 = "insert into KhachHang values('"+txt_makh.Text+"',N'"+txt_tenkh.Text+"',N'"+gt+"','"+txt_sdt.Text+"','"+txt_cmnd.Text+"','"+txt_diachi.Text+"','"+functions.ConvertDateTime(txt_ns.Text)+"')";
            functions.RunSql(sql1);
            LoadDT();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_makh.Enabled = false;
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
            txt_tenkh.Text = dataKH.CurrentRow.Cells["Tenkh"].Value.ToString();
            string gt = dataKH.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (gt.CompareTo("Nam") == 0) { gtNam.Checked = true; } else { gtNu.Checked = true; }
            txt_sdt.Text = dataKH.CurrentRow.Cells["SDT"].Value.ToString();
            txt_cmnd.Text = dataKH.CurrentRow.Cells["CMND"].Value.ToString();
            txt_diachi.Text = dataKH.CurrentRow.Cells["Diachi"].Value.ToString();
            string d = dataKH.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            txt_ns.Text = functions.date(d);
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Chỉ nhập số", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            string gt = "";
            if (gtNu.Checked == true)
            {
                gt = gtNu.Text;
            }
            else
            {
                gt = gtNam.Text;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (txt_cmnd.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập chứng minh nhân dân", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cmnd.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update KhachHang set Tenkh = N'"+txt_tenkh.Text+"',GioiTinh = N'"+gt+"',SDT = '"+txt_sdt.Text+"',CMND = '"+txt_cmnd.Text+"', Diachi = N'"+txt_diachi.Text+"',NgaySinh = '"+functions.ConvertDateTime(txt_ns.Text)+"' where Makh = '"+txt_makh.Text+"'";
                functions.RunSql(sql);
                LoadDT();
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
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return;
            }
            if (txt_tenkh.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return;
            }
            string gt = "";
            if (gtNu.Checked == true)
            {
                gt = gtNu.Text;
            }
            else
            {
                gt = gtNam.Text;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (txt_cmnd.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập chứng minh nhân dân", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cmnd.Focus();
                return;
            }
            if (txt_diachi.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from KhachHang where Makh = '" + txt_makh.Text + "'";
                functions.RunSqlDel(sql);
                LoadDT();
                Reset();
            }
        }


 


    }
}
