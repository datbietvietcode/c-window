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
    public partial class SoTK : Form
    {
        public SoTK()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void SoTK_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from KhachHang",cbkhachhang,"Tenkh","Makh");
            functions.FillComBo("select * from KyHan",cbloaikh,"Loaikh","Makh");
            functions.FillComBo("select * from LoaiTien",cbtien,"Tentien","Matien");
            functions.FillComBo("select * from NhanVien",cbnhanvien,"Tennv","Manv");
            functions.FillComBo("select * from ChiNhanh",cbchinhanh,"TenCN","MaCN");
            txt_nhh.Enabled = false;
            txt_ms.Enabled = false;
            txt_laisuat.Enabled = false;
            txt_chucvu.Enabled = false;
            Reset();
            LoadDT();
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
        }
        private void LoadDT()
        {
            string sql = "select * from SoTK";
            dtbl = functions.GetTableToTable(sql);
            dataSOTK.DataSource = dtbl;
            dataSOTK.Columns[0].HeaderText = "Mã sổ";
            dataSOTK.Columns[1].HeaderText = "Mã khách hàng";
            dataSOTK.Columns[2].HeaderText = "Tiền gốc";
            dataSOTK.Columns[3].HeaderText = "Mã kỳ hạn";
            dataSOTK.Columns[4].HeaderText = "Mã lãi suất";
            dataSOTK.Columns[5].HeaderText = "Mã loại tiền";
            dataSOTK.Columns[6].HeaderText = "Mã nhân viên";
            dataSOTK.Columns[7].HeaderText = "Mã chi nhánh";
            dataSOTK.Columns[8].HeaderText = "Ngày mở sổ";
            dataSOTK.Columns[9].HeaderText = "Ngày trả sổ";
            dataSOTK.Columns[10].HeaderText = "Hình thức tất toán";
            dataSOTK.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataSOTK.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            //dataNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSOTK.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void Reset() {
            txt_ms.Text = "";
            rdtt1.Checked = true;
            rdtt2.Checked = false;
            rdtt3.Checked = false;
            txt_laisuat.Text = "";
            txt_chucvu.Text = "";
            cbkhachhang.Text = "Chọn khách hàng";
            txt_tiengui.Text = "";
            cbloaikh.Text = "Chọn loại kỳ hạn";
            cbthoihan.Text = "Chọn thời hạn";
            cbtien.Text = "Chọn loại tiền";
            cbnhanvien.Text = "Chọn nhân viên";
            cbchinhanh.Text = "Chọn chi nhánh";
            txt_nms.Text = "dd/mm/yyyy";
            txt_nhh.Text = "dd/mm/yyyy";


        }

        private void laisuat(object sender, EventArgs e)
        {
            if (cbthoihan.SelectedValue == null) {
                txt_laisuat.Focus();
                txt_laisuat.Text = "";
                cbthoihan.Text = "Chọn thời hạn";
                return; 
            } else {
                txt_laisuat.Text = functions.GetFieldValues("select lai from LaiSuat where Mals = '" + cbthoihan.SelectedValue.ToString() + "'", "lai");
            }
           
        }

        private void thoihan(object sender, EventArgs e)
        {
            if (cbloaikh.SelectedValue == null)
            {
                 
                return;
            }
            else {
                functions.FillComBo("select * from LaiSuat where Makh = '"+cbloaikh.SelectedValue.ToString()+"' order by Ngaycn desc", cbthoihan, "Thoihan", "Mals");
            }
           
        }

        private void chucvu(object sender, EventArgs e)
        {
            if (cbnhanvien.SelectedValue == null)
            {
                return;
            }
            else
            {
                txt_chucvu.Text = functions.GetFieldValues("select Tencv from ChucVu, NhanVien where ChucVu.Macv = NhanVien.Macv and NhanVien.Manv = '" + cbnhanvien.SelectedValue.ToString() + "'", "Tencv");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_ms.Enabled = true;
            txt_ms.Focus();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_ms.Enabled = false;
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
            if (txt_ms.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ms.Focus();
                return;
            }
            if (txt_tiengui.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tiền gửi tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tiengui.Focus();
                return;
            }
            if (cbkhachhang.Text.CompareTo("Chọn khách hàng") == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbloaikh.Text.CompareTo("Chọn loại kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại gửi kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbthoihan.Text.CompareTo("Chọn thời hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tt = "";
            if (rdtt1.Checked == true)
            {
                tt = rdtt1.Text;
            }
            else if (rdtt2.Checked == true)
            {
                tt = rdtt2.Text;
            }
            else {
                tt = rdtt3.Text;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbchinhanh.Text.CompareTo("Chọn chi nhánh") == 0)
            {
                MessageBox.Show("Bạn phải chọn chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_nms.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nms.Focus();
                return;
            }
            if (txt_nhh.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nhh.Focus();
                return;
            }
            if (!functions.IsDate(txt_nms.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_nhh.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_tiengui.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string sql = "select Maso from SoTK where Maso = '"+txt_ms.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ms.Focus();
                txt_ms.Text = "";
                return;
            }
            string sql1 = "insert into SoTK values('"+txt_ms.Text+"','"+cbkhachhang.SelectedValue.ToString()+"',"+Convert.ToInt64(txt_tiengui.Text)+",'"+cbloaikh.SelectedValue.ToString()+"','"+cbthoihan.SelectedValue.ToString()+"','"+cbtien.SelectedValue.ToString()+"','"+cbnhanvien.SelectedValue.ToString()+"','"+cbchinhanh.SelectedValue.ToString()+"','"+functions.ConvertDateTime(txt_nms.Text)+"','"+functions.ConvertDateTime(txt_nhh.Text)+"',N'"+tt+"')";
            functions.RunSql(sql1);
            LoadDT();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_ms.Enabled = false;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_ms.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ms.Focus();
                return;
            }
            if (txt_tiengui.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tiền gửi tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tiengui.Focus();
                return;
            }
            if (cbkhachhang.Text.CompareTo("Chọn khách hàng") == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbloaikh.Text.CompareTo("Chọn loại kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại gửi kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbthoihan.Text.CompareTo("Chọn thời hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tt = "";
            if (rdtt1.Checked == true)
            {
                tt = rdtt1.Text;
            }
            else if (rdtt2.Checked == true)
            {
                tt = rdtt2.Text;
            }
            else
            {
                tt = rdtt3.Text;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbchinhanh.Text.CompareTo("Chọn chi nhánh") == 0)
            {
                MessageBox.Show("Bạn phải chọn chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_nms.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nms.Focus();
                return;
            }
            if (txt_nhh.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nhh.Focus();
                return;
            }
            if (!functions.IsDate(txt_nms.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_nhh.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_tiengui.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from SoTK where Maso = '"+txt_ms.Text+"'";
                functions.RunSqlDel(sql);
                LoadDT();
                Reset();
            }
        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ms.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_ms.Text = dataSOTK.CurrentRow.Cells["Maso"].Value.ToString();
            string kh = dataSOTK.CurrentRow.Cells["Makh"].Value.ToString();
            cbkhachhang.Text = functions.GetFieldValues("select * from KhachHang where Makh = '"+kh+"'","Tenkh");
            txt_tiengui.Text = dataSOTK.CurrentRow.Cells["TienGoc"].Value.ToString();
            string kyhan = dataSOTK.CurrentRow.Cells["Makhan"].Value.ToString();
            cbloaikh.Text = functions.GetFieldValues("select * from KyHan where Makh = '"+kyhan+"'","Loaikh");
            string ls = dataSOTK.CurrentRow.Cells["Mals"].Value.ToString();
            cbthoihan.Text = functions.GetFieldValues("select * from LaiSuat where Mals = '"+ls+"'","Thoihan");
            txt_laisuat.Text = functions.GetFieldValues("select * from LaiSuat where Mals = '"+ls+"'","lai");
            string tien = dataSOTK.CurrentRow.Cells["Matien"].Value.ToString();
            cbtien.Text = functions.GetFieldValues("select * from LoaiTien where Matien = '"+tien+"'","Tentien");
            string nv = dataSOTK.CurrentRow.Cells["Manv"].Value.ToString();
            cbnhanvien.Text = functions.GetFieldValues("select * from NhanVien where Manv = '"+nv+"'", "Tennv");
            txt_chucvu.Text = functions.GetFieldValues("select * from ChucVu,NhanVien where ChucVu.Macv = NhanVien.Macv and NhanVien.Manv = '"+nv+"'","Tencv");
            string cn = dataSOTK.CurrentRow.Cells["Macn"].Value.ToString();
            cbchinhanh.Text = functions.GetFieldValues("select * from ChiNhanh where MaCN = '"+cn+"'","TenCN");
            string nms = dataSOTK.CurrentRow.Cells["Ngayms"].Value.ToString();
            txt_nms.Text = functions.date(nms);
            string nts = dataSOTK.CurrentRow.Cells["Ngaytrs"].Value.ToString();
            txt_nhh.Text = functions.date(nts);
            string tt = dataSOTK.CurrentRow.Cells["tattoan"].Value.ToString();
            if (tt.CompareTo("Cuối kỳ") == 0) {
                rdtt1.Checked = true;
            }
            else if (tt.CompareTo("Định kỳ") == 0)
            {
                rdtt2.Checked = true;
            }
            else {
                rdtt3.Checked = true;
            }


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
            if (txt_ms.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ms.Focus();
                return;
            }
            if (txt_tiengui.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tiền gửi tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tiengui.Focus();
                return;
            }
            if (cbkhachhang.Text.CompareTo("Chọn khách hàng") == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbloaikh.Text.CompareTo("Chọn loại kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại gửi kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbthoihan.Text.CompareTo("Chọn thời hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tt = "";
            if (rdtt1.Checked == true)
            {
                tt = rdtt1.Text;
            }
            else if (rdtt2.Checked == true)
            {
                tt = rdtt2.Text;
            }
            else
            {
                tt = rdtt3.Text;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbchinhanh.Text.CompareTo("Chọn chi nhánh") == 0)
            {
                MessageBox.Show("Bạn phải chọn chi nhánh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_nms.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nms.Focus();
                return;
            }
            if (txt_nhh.Text.CompareTo("dd/mm/yyyy") == 0 || txt_nms.Text.Trim().Length == 0 || txt_nms.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nhh.Focus();
                return;
            }
            if (!functions.IsDate(txt_nms.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_nhh.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_tiengui.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update SoTK set Makh = '"+cbkhachhang.SelectedValue.ToString()+"', TienGoc = "+Convert.ToInt64(txt_tiengui.Text)+", Makhan = '"+cbloaikh.SelectedValue.ToString()+"', Mals = '"+cbthoihan.SelectedValue.ToString()+"', Matien = '"+cbtien.SelectedValue.ToString()+"', Manv = '"+cbnhanvien.SelectedValue.ToString()+"', Macn = '"+cbchinhanh.SelectedValue.ToString()+"', Ngayms = '"+functions.ConvertDateTime(txt_nms.Text)+"', Ngaytrs = '"+functions.ConvertDateTime(txt_nhh.Text)+"', tattoan = N'"+tt+"' where Maso = '"+txt_ms.Text+"'";
                functions.RunSql(sql);
                LoadDT();
                Reset();
                btn_bq.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e){
        
            try{
            string time = functions.theFirt(cbthoihan.Text);
            if (cbthoihan.Text.Trim().CompareTo(time + " tháng") == 0)
            {
                int m = Convert.ToInt32(time) * 30;
                string s = functions.anonymousSql("select DATEADD(DAY," + m + ",'" + functions.ConvertDateTime(txt_nms.Text) + "')");
                txt_nhh.Text = functions.date(s);
            }
            else if (cbthoihan.Text.Trim().CompareTo(time + " tuần") == 0)
            {
                int x = Convert.ToInt32(time) * 7;
                string a = functions.anonymousSql("select DATEADD(DAY," + x + ",'" + functions.ConvertDateTime(txt_nms.Text) + "')");
                txt_nhh.Text = functions.date(a);
            }
            else {
                string y = functions.anonymousSql("select DATEADD(YEAR," + Convert.ToInt32(time) + ",'" + functions.ConvertDateTime(txt_nms.Text) + "')");
                txt_nhh.Text = functions.date(y);
            }
            }catch(System.Exception){
                MessageBox.Show("Hãy điền đầy đủ thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            In_STK stk = new In_STK();
            stk.Show();
        }
    }
}
