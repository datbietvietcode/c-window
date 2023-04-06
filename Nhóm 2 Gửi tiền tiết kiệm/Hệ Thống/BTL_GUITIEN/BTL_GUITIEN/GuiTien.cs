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
    public partial class GuiTien : Form
    {
        public GuiTien()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void btn_search_Click(object sender, EventArgs e)

        {
            string s = "";
            s = functions.GetFieldValues("select SoTK.Maso from SoTK,KyHan where SoTK.Makhan = KyHan.Makh and KyHan.tragop = N'Có' and SoTK.Maso like '%" + txt_search.Text + "%'", "Maso");
            if (s != "")
            {
                MessageBox.Show("Đã tìm thấy sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmso.Text = functions.GetFieldValues("select * from SoTK where Maso = '" + s + "'", "Maso"); 
            }
            else
            {
                MessageBox.Show("Không tìm thấy sổ hoặc sổ không phải sổ gửi trả góp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void GuiTien_Load(object sender, EventArgs e)
        {
        
            functions.FillComBo("select * from SoTK, KyHan where SoTK.Makhan = KyHan.Makh and KyHan.tragop = N'Có'",cbmso, "Maso", "Maso");
            functions.FillComBo("select * from NhanVien",cbnhanvien,"Tennv","Manv");
            txt_mp.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_khachhang.Enabled = false;
            txt_tien.Enabled = false;
            txt_cv.Enabled = false;
            LoadDT();
            Reset();
        }

        private void LoadDT(){

            string sql = "select * from GuiTien";
            dtbl = functions.GetTableToTable(sql);
            dataGT.DataSource = dtbl;
            dataGT.Columns[0].HeaderText = "Mã phiếu";
            dataGT.Columns[1].HeaderText = "Mã sổ";
            dataGT.Columns[2].HeaderText = "Mã nhân viên";
            dataGT.Columns[3].HeaderText = "Tiền gửi";
            dataGT.Columns[4].HeaderText = "Ngày gửi";
            dataGT.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataGT.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            dataGT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Reset() {
            txt_mp.Text = "";
            cbmso.Text = "Chọn mã sổ";
            txt_khachhang.Text = "";
            cbnhanvien.Text = "Chọn nhân viên";
            txt_cv.Text = "";
            txt_tien.Text = "";
            txt_tiengui.Text = "";
            txt_ngaygui.Text = "dd/mm/yyyy";
        }

        private void khachhang(object sender, EventArgs e)
        {

            if (cbmso.SelectedValue == null)
            {
                txt_khachhang.Text = "";
                txt_khachhang.Focus();
                return;
            }
            else {
                txt_khachhang.Text = functions.GetFieldValues("select * from KhachHang, SoTK where KhachHang.Makh = SoTK.Makh and SoTK.Maso = '"+cbmso.SelectedValue.ToString()+"'","Tenkh");
                txt_tien.Text = functions.GetFieldValues("select * from LoaiTien, SoTK where LoaiTien.Matien = SoTK.Matien and SoTK.Maso = '"+cbmso.SelectedValue.ToString()+"'","Tentien");
            }
           
        }

        private void chucvu(object sender, EventArgs e)
        {
            if (cbnhanvien.SelectedValue == null)
            {
                return;
            }
            else {
                txt_cv.Text = functions.GetFieldValues("select * from NhanVien, ChucVu where NhanVien.Macv = ChucVu.Macv and NhanVien.Manv = '"+cbnhanvien.SelectedValue.ToString()+"'","Tencv");
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
            txt_mp.Enabled = true;
            txt_mp.Focus();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_mp.Enabled = false;
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
            if (txt_mp.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mp.Focus();
                return;
            }

            if (cbmso.Text.CompareTo("Chọn mã sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tiengui.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập tiền gửi", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tiengui.Focus();
                return;
            }
            if (txt_ngaygui.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngaygui.Text.Trim().Length == 0 || txt_ngaygui.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ngaygui.Focus();
                return;
            }
            if (!functions.IsDate(txt_ngaygui.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_tiengui.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string sql = "select Magt from GuiTien where Magt = '"+txt_mp.Text +"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mp.Focus();
                txt_mp.Text = "";
                return;
            }

            string hh = functions.GetFieldValues("select Ngaytrs from SoTK where Maso = '"+cbmso.SelectedValue.ToString()+"'","Ngaytrs");
            if (!functions.SoSanh(txt_ngaygui.Text, functions.date(hh)))
            {
                MessageBox.Show("Ngày phải nhỏ hơn ngày hết hạn " + functions.date(hh) + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int rs = 0;
                string tg = functions.GetFieldValues("select * from SoTK where Maso = '" + cbmso.SelectedValue.ToString() + "'", "TienGoc");
                rs = Convert.ToInt32(tg) + Convert.ToInt32(txt_tiengui.Text);
                string up = "update SoTK set TienGoc = " + rs + " where Maso = '" + cbmso.SelectedValue.ToString() + "'";
                string sql1 = "insert into GuiTien values('" + txt_mp.Text + "','" + cbmso.SelectedValue.ToString() + "','" + cbnhanvien.SelectedValue.ToString() + "'," + Convert.ToInt32(txt_tiengui.Text) + ",'" + functions.ConvertDateTime(txt_ngaygui.Text) + "')";
                functions.RunSql(sql1);
                functions.RunSql(up);
                LoadDT();
                Reset();
                btn_add.Enabled = true;
                btn_del.Enabled = true;
                btn_up.Enabled = true;
                btn_bq.Enabled = false;
                btn_save.Enabled = false;
                txt_mp.Enabled = false;
            }

        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mp.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_mp.Text = dataGT.CurrentRow.Cells["Magt"].Value.ToString();
            string ms = dataGT.CurrentRow.Cells["Maso"].Value.ToString();
            cbmso.Text = functions.GetFieldValues("select * from SoTK where Maso = '"+ms+"' ", "Maso");
            txt_khachhang.Text = functions.GetFieldValues("select * from KhachHang, SoTK where KhachHang.Makh = SoTK.Makh and SoTK.Maso = '" + ms + "'", "Tenkh");
            txt_tien.Text = functions.GetFieldValues("select * from LoaiTien, SoTK where LoaiTien.Matien = SoTK.Matien and SoTK.Maso = '" + ms + "'", "Tentien");
            string nv = dataGT.CurrentRow.Cells["Manv"].Value.ToString();
            cbnhanvien.Text = functions.GetFieldValues("select * from NhanVien where Manv = '"+nv+"'","Tennv");
            txt_cv.Text = functions.GetFieldValues("select * from NhanVien, ChucVu where NhanVien.Macv = ChucVu.Macv and NhanVien.Manv = '" + nv + "'", "Tencv");
            txt_tiengui.Text = dataGT.CurrentRow.Cells["Tien"].Value.ToString();
            string date = dataGT.CurrentRow.Cells["NgayGui"].Value.ToString();
            txt_ngaygui.Text = functions.date(date);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtbl.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_mp.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mp.Focus();
                    return;
                }

                if (cbmso.Text.CompareTo("Chọn mã sổ") == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_tiengui.Text.Trim().Length == 0)
                {

                    MessageBox.Show("Bạn phải nhập tiền gửi", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tiengui.Focus();
                    return;
                }
                if (txt_ngaygui.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngaygui.Text.Trim().Length == 0 || txt_ngaygui.Text == "  /  /    ")
                {

                    MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ngaygui.Focus();
                    return;
                }
                if (!functions.IsDate(txt_ngaygui.Text))
                {
                    MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!functions.So(txt_tiengui.Text))
                {
                    MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                string hh = functions.GetFieldValues("select Ngaytrs from SoTK where Maso = '" + cbmso.SelectedValue.ToString() + "'", "Ngaytrs");
                if (!functions.SoSanh(txt_ngaygui.Text, functions.date(hh)))
                {
                    MessageBox.Show("Ngày phải nhỏ hơn ngày hết hạn " + functions.date(hh) + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int rs = 0;
                        string tg = functions.GetFieldValues("select * from SoTK where Maso = '" + cbmso.SelectedValue.ToString() + "'", "TienGoc");
                        if (Convert.ToInt32(tg) > 0)
                        {
                            rs = Convert.ToInt32(tg) - Convert.ToInt32(txt_tiengui.Text);
                            string up = "update SoTK set TienGoc = " + rs + " where Maso = '" + cbmso.SelectedValue.ToString() + "'";
                            functions.RunSql(up);
                        }
                        else {
                            string up = "update SoTK set TienGoc = 0 where Maso = '" + cbmso.SelectedValue.ToString() + "'";
                            functions.RunSql(up);
                        }
                        string sql = "delete from GuiTien where Magt = '" + txt_mp.Text + "'";
                        functions.RunSqlDel(sql);
                        
                        LoadDT();
                        Reset();
                    }
                }
            }
            catch (System.Exception) {
                MessageBox.Show("Vui lòng chọn những sổ có trả góp, và chắc chắn đó là 100%", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtbl.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_mp.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã sổ tiết kiệm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mp.Focus();
                    return;
                }

                if (cbmso.Text.CompareTo("Chọn mã sổ") == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_tiengui.Text.Trim().Length == 0)
                {

                    MessageBox.Show("Bạn phải nhập tiền gửi", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tiengui.Focus();
                    return;
                }
                if (txt_ngaygui.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngaygui.Text.Trim().Length == 0 || txt_ngaygui.Text == "  /  /    ")
                {

                    MessageBox.Show("Bạn phải nhập ngày mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ngaygui.Focus();
                    return;
                }
                if (!functions.IsDate(txt_ngaygui.Text))
                {
                    MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!functions.So(txt_tiengui.Text))
                {
                    MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                string hh = functions.GetFieldValues("select Ngaytrs from SoTK where Maso = '" + cbmso.SelectedValue.ToString() + "'", "Ngaytrs");
                if (!functions.SoSanh(txt_ngaygui.Text, functions.date(hh)))
                {
                    MessageBox.Show("Ngày phải nhỏ hơn ngày hết hạn " + functions.date(hh) + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int rs = 0;
                        string tg = functions.GetFieldValues("select * from SoTK where Maso = '" + cbmso.SelectedValue.ToString() + "'", "TienGoc");
                        if (Convert.ToInt32(tg) > 0)
                        {
                            string cu = functions.GetFieldValues("select * from GuiTien", "Tien");
                            rs = (Convert.ToInt32(tg) + Convert.ToInt32(txt_tiengui.Text)) - Convert.ToInt32(cu);
                            string up = "update SoTK set TienGoc = " + rs + " where Maso = '" + cbmso.SelectedValue.ToString() + "'";
                            functions.RunSql(up);
                        }
                        else {
                            string up = "update SoTK set TienGoc = 0  where Maso = '" + cbmso.SelectedValue.ToString() + "'";
                            functions.RunSql(up);                        
                        }
                       
                        
                        string sql = "update GuiTien set Maso = '" + cbmso.SelectedValue.ToString() + "', Manv = '" + cbnhanvien.SelectedValue.ToString() + "', Tien = " + Convert.ToInt32(txt_tiengui.Text) + " , NgayGui = '" + functions.ConvertDateTime(txt_ngaygui.Text) + "' where Magt = '" + txt_mp.Text + "'";
                        functions.RunSql(sql);
                       
                        LoadDT();
                        Reset();
                        btn_bq.Enabled = false;
                    }
                }
            }catch(System.Exception){
                MessageBox.Show("Vui lòng chọn những sổ có trả góp, và chắc chắn đó là 100%","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonGT gt = new HoaDonGT();
            gt.Show();
        }        

    }
}
