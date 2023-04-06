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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        DataTable dtbl;

        private void NhanVien_Load(object sender, EventArgs e)
        {

            cbChucVu.DataSource = functions.GetTableToTable("select * from ChucVu");
            cbChucVu.DisplayMember = "Tencv";
            cbChucVu.ValueMember = "Macv";
            cbChucVu.SelectedIndex = -1;
            set();
            txt_manv.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            LoadDT();
        }

        private void Reset() {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_cmnd.Text = "";
            txt_sdt.Text = "";
            txt_adress.Text = "";
            set();
        
        }

        private void set() {
            cbChucVu.Text = "Chọn chức vụ";
            txt_ns.Text = "dd/mm/yyyy";
            gtNam.Checked = true;
            gtNu.Checked = false;
        
        }

        private void LoadDT() {
            string sql = "select * from NhanVien";
            dtbl = functions.GetTableToTable(sql);
            dataNV.DataSource = dtbl;
            dataNV.Columns[0].HeaderText = "Mã nhân viên";
            dataNV.Columns[1].HeaderText = "Tên nhân viên";
            dataNV.Columns[2].HeaderText = "Giới tính";
            dataNV.Columns[3].HeaderText = "Số điện thoại";
            dataNV.Columns[4].HeaderText = "CMND";
            dataNV.Columns[5].HeaderText = "Địa chỉ";
            dataNV.Columns[6].HeaderText = "Mã chức vụ";
            dataNV.Columns[7].HeaderText = "Ngày sinh";
            dataNV.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataNV.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            //dataNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataNV.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_manv.Enabled = true;
            txt_manv.Focus();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_manv.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "") {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0) {

                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
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
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length==0 || txt_ns.Text == "  /  /    "){

                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (txt_cmnd.Text.Trim().Length == 0) {

                MessageBox.Show("Bạn phải nhập chứng minh nhân dân", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cmnd.Focus();
                return;
            }
            if (txt_adress.Text.Trim().Length == 0) {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_adress.Focus();
                return;
            }
            if (cbChucVu.Text.CompareTo("Chọn chức vụ") == 0) {
                MessageBox.Show("Bạn phải chọn chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0) {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (!functions.IsDate(txt_ns.Text)) {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select Manv from NhanVien where Manv = '"+txt_manv.Text+"'";
            if (functions.CheckKey(sql)) {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                txt_manv.Text = "";
                return;            
            }
            string sql1 = "insert into NhanVien values('"+txt_manv.Text+"',N'"+txt_tennv.Text+"',N'"+gt+"','"+txt_sdt.Text+"','"+txt_cmnd.Text+"',N'"+txt_adress.Text+"','"+cbChucVu.SelectedValue.ToString()+"','"+functions.ConvertDateTime(txt_ns.Text)+"')";
            functions.RunSql(sql1);
            LoadDT();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_manv.Enabled = false;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Chỉ nhập số","Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            if (txt_manv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
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
            if (txt_adress.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_adress.Focus();
                return;
            }
            if (cbChucVu.Text.CompareTo("Chọn chức vụ") == 0)
            {
                MessageBox.Show("Bạn phải chọn chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string sql = "update NhanVien set Tennv = N'"+txt_tennv.Text+"', GioiTinh = '"+gt+"', SDT = '"+txt_sdt.Text+"', CMND = '"+txt_cmnd.Text+"', Diachi = N'"+txt_adress.Text+"', Macv = '"+cbChucVu.SelectedValue.ToString()+"', NgaySinh = '"+functions.ConvertDateTime(txt_ns.Text)+"' where Manv = '"+txt_manv.Text+"'";
                functions.RunSql(sql);
                LoadDT();
                Reset();
                btn_bq.Enabled = false;
            }

        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_manv.Text = dataNV.CurrentRow.Cells["Manv"].Value.ToString();
            txt_tennv.Text = dataNV.CurrentRow.Cells["Tennv"].Value.ToString();
            string gt = dataNV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (gt.CompareTo("Nam") == 0) { gtNam.Checked = true; } else { gtNu.Checked = true; }
            txt_sdt.Text = dataNV.CurrentRow.Cells["SDT"].Value.ToString();
            txt_cmnd.Text = dataNV.CurrentRow.Cells["CMND"].Value.ToString();
            txt_adress.Text = dataNV.CurrentRow.Cells["Diachi"].Value.ToString();
            string cv = dataNV.CurrentRow.Cells["Macv"].Value.ToString();
            cbChucVu.Text = functions.GetFieldValues("select * from ChucVu where Macv = '"+cv+"'","Tencv");
            string d = dataNV.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            txt_ns.Text = functions.date(d);        
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return;
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
            if (txt_adress.Text == "")
            {

                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_adress.Focus();
                return;
            }
            if (cbChucVu.Text.CompareTo("Chọn chức vụ") == 0)
            {
                MessageBox.Show("Bạn phải chọn chức vụ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string gt = "";
            if (gtNu.Checked == true)
            {
                gt = gtNu.Text;
            }
            else
            {
                gt = gtNam.Text;

            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from NhanVien where Manv = '"+txt_manv.Text+"'";
                functions.RunSqlDel(sql);
                LoadDT();
                Reset();
            }
        }

    }
}
