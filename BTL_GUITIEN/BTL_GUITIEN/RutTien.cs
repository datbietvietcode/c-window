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
    public partial class txt_map : Form
    {
        public txt_map()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void search_Click(object sender, EventArgs e)
        {
            //string s = functions.anonymousSql("select Datediff(DAY,Ngayms,Ngaytrs) as day from SoTK where Maso = '"+txt_maso.Text+"'");
            string s = "";
            s = functions.GetFieldValues("select Maso from SoTK where Maso Like '%"+txt_search.Text+"%'","Maso");
            if (s != "")
            {
                MessageBox.Show("Đã tìm thấy sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmaso.Text = functions.GetFieldValues("select * from SoTK where Maso = '" + s + "'", "Maso");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void RutTien_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from SoTK", cbmaso, "Maso", "Maso");
            functions.FillComBo("select * from NhanVien", cbnhanvien, "Tennv", "Manv");
            txt_mrt.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_khachhang.Enabled = false;
            txt_laisuat.Enabled = false;
            txt_chucvu.Enabled = false;
            txt_tien.Enabled = false;
            txt_tien1.Enabled = false;
            txt_tien2.Enabled = false;
            txt_tienlai.Enabled = false;
            txt_tongtien.Enabled = false;
            txt_tienrut.Enabled = false;
            txt_tien3.Enabled = false;
            txt_tg.Enabled = false;
            Reset();
            LoadDT();

        }
        private void Reset() {
            txt_search.Text = "";
            txt_chucvu.Text = "";
            txt_khachhang.Text = "";
            txt_laisuat.Text = "";
            txt_mrt.Text = "";
            txt_ngayrut.Text = "dd/mm/yyyy";
            txt_tien.Text = "";
            txt_tien1.Text = "";
            txt_tien2.Text = "";
            txt_tien3.Text = "";
            txt_tienrut.Text = "";
            txt_tongtien.Text = "";
            cbmaso.Text = "Chọn mã sổ";
            cbnhanvien.Text = "Chọn nhân viên";
            txt_tienlai.Text = "";
            docchu.Text = "";
            txt_tg.Text = "";
        
        }
        private void LoadDT()
        {

            string sql = "select * from RutTien";
            dtbl = functions.GetTableToTable(sql);
            dataRT.DataSource = dtbl;
            dataRT.Columns[0].HeaderText = "Mã rút tiền";
            dataRT.Columns[1].HeaderText = "Mã sổ";
            dataRT.Columns[2].HeaderText = "Mã nhân viên";
            dataRT.Columns[3].HeaderText = "Tiền lãi";
            dataRT.Columns[4].HeaderText = "Tổng tiền";
            dataRT.Columns[5].HeaderText = "Ngày rút";
            dataRT.Columns[6].HeaderText = "Tiền rút";
            dataRT.Columns[7].HeaderText = "Tiền gốc";
            dataRT.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataRT.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
            dataRT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_mrt.Enabled = true;
            txt_mrt.Focus();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_mrt.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void sott(object sender, EventArgs e)
        {

            if (cbmaso.SelectedValue == null && txt_ngayrut.Text == "")
            {
                return;
            }
            else {
                txt_laisuat.Text = functions.GetFieldValues("select LaiSuat.lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '"+cbmaso.SelectedValue.ToString()+"'", "lai");
                txt_khachhang.Text = functions.GetFieldValues("select * from KhachHang, SoTK where KhachHang.Makh = SoTK.Makh and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'", "Tenkh");
                txt_tien.Text = functions.GetFieldValues("select * from LoaiTien, SoTK where LoaiTien.Matien = SoTK.Matien and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'", "Tentien");
                txt_tien1.Text = txt_tien.Text;
                txt_tien2.Text = txt_tien.Text;
                txt_tien3.Text = txt_tien.Text;
                
            }
        }

        private void cv(object sender, EventArgs e)
        {
            if (cbnhanvien.SelectedValue == null)
            {
                return;
            }
            else
            {
                
                txt_chucvu.Text = functions.GetFieldValues("select * from NhanVien, ChucVu where NhanVien.Macv = ChucVu.Macv and NhanVien.Manv = '" + cbnhanvien.SelectedValue.ToString() + "'", "Tencv");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_mrt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phiếu rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mrt.Focus();
                return;
            }
            if (cbmaso.Text.CompareTo("Chọn mã sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            { 
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ngayrut.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngayrut.Text.Trim().Length == 0 || txt_ngayrut.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn phải nhập ngày rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ngayrut.Focus();
                return;
            }
            if (!functions.IsDate(txt_ngayrut.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tienlai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Có lẽ bạn chưa nhấn refresh, hãy nhấn refresh để thêm thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tienlai.Focus();
                return;
            }
            string sql = "select Mart from RutTien where Mart = '"+txt_mrt.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mrt.Focus();
                txt_mrt.Text = "";
                return;
            }
            if (Convert.ToInt64(txt_tienrut.Text) > (Convert.ToInt64(txt_tongtien.Text) - Convert.ToInt64(txt_tienlai.Text) / 2)) {
                string sql2 = "update SoTK set TienGoc = 0 where Maso = '"+cbmaso.SelectedValue.ToString()+"'";
                functions.RunSql(sql2);
            }

            string sql1 = "insert into RutTien values('"+txt_mrt.Text+"','"+cbmaso.SelectedValue.ToString()+"','"+cbnhanvien.SelectedValue.ToString()+"',"+Convert.ToInt64(txt_tienlai.Text)+","+Convert.ToInt64(txt_tongtien.Text)+",'"+functions.ConvertDateTime(txt_ngayrut.Text)+"',"+Convert.ToInt64(txt_tienrut.Text)+","+Convert.ToInt64(txt_tg.Text)+")";
            functions.RunSql(sql1);
            LoadDT();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_mrt.Enabled = false;
    }
        private void refesh_Click(object sender, EventArgs e)
        {
            if (cbmaso.Text.CompareTo("Chọn mã sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn sổ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string ngms = functions.GetFieldValues("select Ngayms from SoTK where SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'", "Ngayms");
                if (txt_ngayrut.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngayrut.Text.Trim().Length == 0 || txt_ngayrut.Text == "  /  /    " || !functions.IsDate(txt_ngayrut.Text) || functions.dateCompareTo(functions.ConvertDate(txt_ngayrut.Text),functions.date(ngms)) < 0)
                {
                    MessageBox.Show("Mời nhập lại ngày đúng định dạng hoặc ngày rút phải lớn hơn ngày mở sổ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    float tong = float.Parse(functions.anonymousSql("select TienGoc from SoTK where Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                    float sn = float.Parse(functions.anonymousSql("select DATEDIFF(DAY,Ngayms,Ngaytrs) from SoTK where Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                    float nt = float.Parse(functions.anonymousSql("select DATEDIFF(DAY,Ngayms,'" + functions.ConvertDateTime(txt_ngayrut.Text) + "') from SoTK where Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                    int values = 0;
                    txt_tg.Text = ""+Convert.ToInt64(tong)+"";
                    string key = functions.anonymousSql("select tattoan from SoTK where Maso = '" + cbmaso.SelectedValue.ToString() + "'");
                    if (key.CompareTo("Cuối kỳ") == 0) { values = 1;}
                    else if (key.CompareTo("Định kỳ") == 0) { values = 2; }
                    else { values = 3; }
                    string yesOrNo = functions.GetFieldValues("select KyHan.kyhan from  SoTK,KyHan where SoTK.Makhan = KyHan.Makh and SoTK.Maso = '"+cbmaso.SelectedValue.ToString()+"'","kyhan");
                    if (yesOrNo.CompareTo("Có") == 0)
                    {
                        switch (values) {
                        
                            case 1:
                                if (nt < sn)
                                {
                                    txt_laisuat.Text = functions.anonymousSql("select top 1 LaiSuat.lai from LaiSuat,KyHan where LaiSuat.Makh = KyHan.Makh and KyHan.kyhan = N'Không' order by LaiSuat.Ngaycn desc");
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlai = (tong * (lai / 100) * nt) / 365;
                                    string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                    txt_tienlai.Text = "" + functions.round(ls) + "";
                                    txt_tongtien.Text = "" +Convert.ToInt64((tong + float.Parse(ls))) +"";
                                    txt_tienrut.Text = txt_tongtien.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else {
                                    txt_laisuat.Text = functions.anonymousSql("select LaiSuat.lai from LaiSuat,SoTK where LaiSuat.Mals = SoTK.Mals and SoTK.Maso = '"+cbmaso.SelectedValue.ToString()+"'");
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlais = (tong * (lai / 100) * sn) / 365;
                                    string lss = functions.anonymousSql("select ROUND(" + tienlais + ",0)");
                                    txt_tienlai.Text = "" + functions.round(lss) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(lss))) + "";
                                    txt_tienrut.Text = txt_tongtien.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                break;
                            case 2:
                                if (nt < sn)
                                {
                                    if (nt % 30 == 0)
                                    {
                                        txt_laisuat.Text = functions.anonymousSql("select LaiSuat.lai from LaiSuat,SoTK where LaiSuat.Mals = SoTK.Mals and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'");
                                        float lai = float.Parse(txt_laisuat.Text);
                                        float tienlai = (tong * (lai / 100) * 30) / 365;
                                        string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                        txt_tienlai.Text = "" + functions.round(ls) + "";
                                        txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(ls))) + "";
                                        txt_tienrut.Text = txt_tienlai.Text;
                                        docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                    }
                                    else
                                    {
                                        txt_laisuat.Text = functions.anonymousSql("select top 1 LaiSuat.lai from LaiSuat,KyHan where LaiSuat.Makh = KyHan.Makh and KyHan.kyhan = N'Không' order by LaiSuat.Ngaycn desc");
                                        float lai = float.Parse(txt_laisuat.Text);
                                        float nk = nt % 30;
                                        int sl = (int)nt / 30;
                                        float laicn = (tong * (lai / 100) * nk) / 365;
                                        string lcn = functions.anonymousSql("select ROUND(" + laicn + ",0)");
                                        if (nt > 30)
                                        {
                                            float laigoc = float.Parse(functions.anonymousSql("select lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                                            float tienlg = ((tong * (laigoc / 100) * 30 * sl) / 365) - ((tong *(lai/100)*30*sl)/365);
                                            string roundlg = functions.anonymousSql("select ROUND(" + tienlg + ",0)");

                                            txt_tienlai.Text = "" + functions.round(lcn) + "";
                                            txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(lcn))) + "";
                                            txt_tienrut.Text = "" + Convert.ToInt64(((tong + float.Parse(lcn)) - float.Parse(roundlg))) + "";
                                            docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);

                                        }
                                        else
                                        {
                                            txt_tienlai.Text = "" + functions.round(lcn) + "";
                                            txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(lcn))) + "";
                                            txt_tienrut.Text = txt_tongtien.Text;
                                            docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                        }
                                    }
                                }
                                else {
                                    txt_laisuat.Text = functions.anonymousSql("select LaiSuat.lai from LaiSuat,SoTK where LaiSuat.Mals = SoTK.Mals and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'");
                                        float lai = float.Parse(txt_laisuat.Text);
                                        float tienlai = (tong * (lai / 100) * 30) / 365;
                                        string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                        txt_tienlai.Text = "" + functions.round(ls) + "";
                                        txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(ls))) + "";
                                        txt_tienrut.Text = txt_tongtien.Text;
                                        docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                   
                                }
                                break;
                            case 3:
                                string date = functions.date(functions.anonymousSql("select Ngayms from SoTK where Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                                if (functions.dateCompareTo(date, functions.ConvertDate(txt_ngayrut.Text)) == 0) {
                                    txt_laisuat.Text = functions.anonymousSql("select LaiSuat.lai from LaiSuat,SoTK where LaiSuat.Mals = SoTK.Mals and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'");
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlais = (tong * (lai / 100) * sn) / 365;
                                    string lss = functions.anonymousSql("select ROUND(" + tienlais + ",0)");
                                    txt_tienlai.Text = "" + functions.round(lss) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64((tong + float.Parse(lss))) + "";
                                    txt_tienrut.Text = txt_tienlai.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else if (nt >= sn)
                                {
                                    txt_tienlai.Text = "0";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong) + "";
                                    txt_tienrut.Text = "" + Convert.ToInt64(tong) + "";
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else {
                                    txt_laisuat.Text = functions.anonymousSql("select top 1 LaiSuat.lai from LaiSuat,KyHan where LaiSuat.Makh = KyHan.Makh and KyHan.kyhan = N'Không' order by LaiSuat.Ngaycn desc");
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlai = (tong * (lai / 100) * nt) / 365;
                                    string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                    txt_tienlai.Text = "" + functions.round(ls) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(ls)) + "";
                                    float laibn = float.Parse(functions.anonymousSql("select LaiSuat.lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '"+cbmaso.SelectedValue.ToString()+"'"));
                                    float tienlaibn = (tong * (laibn / 100) * sn)/365;
                                    txt_tienrut.Text = "" + functions.round("" + Convert.ToInt64((tong + tienlai) - tienlaibn) + "") + "";
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                break;
                        }
                       
                    }
                    else {
                        switch(values){
                            case 1:
                                if (nt < sn)
                                {
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlai = (tong * (lai / 100) * nt) / 365;
                                    string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                    txt_tienlai.Text = "" + functions.round(ls) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(ls)) + "";
                                    txt_tienrut.Text = txt_tongtien.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else
                                {
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlais = (tong * (lai / 100) * sn) / 365;
                                    string lss = functions.anonymousSql("select ROUND(" + tienlais + ",0)");
                                    txt_tienlai.Text = "" + functions.round(lss) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(lss)) + "";
                                    txt_tienrut.Text = txt_tongtien.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                break;
                            case 2:
                                if (nt < sn)
                                {
                                    if (nt % 30 == 0)
                                    {
           
                                        float lai = float.Parse(txt_laisuat.Text);
                                        float tienlai = (tong * (lai / 100) * 30) / 365;
                                        string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                        txt_tienlai.Text = "" + functions.round(ls) + "";
                                        txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(ls)) + "";
                                        txt_tienrut.Text = txt_tienlai.Text;
                                        docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                    }
                                    else
                                    {
                                     
                                        float lai = float.Parse(txt_laisuat.Text);
                                        float nk = nt % 30;
                                        int sl = (int)nt / 30;
                                        float laicn = (tong * (lai / 100) * nk) / 365;
                                        string lcn = functions.anonymousSql("select ROUND(" + laicn + ",0)");
                                        if (nt > 30)
                                        {
                                            float laigoc = float.Parse(functions.anonymousSql("select lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '" + cbmaso.SelectedValue.ToString() + "'"));
                                            float tienlg = ((tong * (laigoc / 100) * 30 * sl) / 365) - ((tong * (lai / 100) * 30 * sl) / 365);
                                            string roundlg = functions.anonymousSql("select ROUND(" + tienlg + ",0)");

                                            txt_tienlai.Text = "" + functions.round(lcn) + "";
                                            txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(lcn)) + "";
                                            txt_tienrut.Text = "" + Convert.ToInt64((tong + float.Parse(lcn))) + "";
                                            docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);

                                        }
                                        else
                                        {
                                            txt_tienlai.Text = "" + functions.round(lcn) + "";
                                            txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(lcn)) + "";
                                            txt_tienrut.Text = txt_tongtien.Text;
                                            docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                        }
                                    }
                                }
                                else
                                {
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlai = (tong * (lai / 100) * 30) / 365;
                                    string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                    txt_tienlai.Text = "" + functions.round(ls) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(ls)) + "";
                                    txt_tienrut.Text = txt_tongtien.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);

                                } 
                                break;
                            case 3:
                                string date = functions.date(functions.anonymousSql("select Ngayms from SoTK where Maso = '"+cbmaso.SelectedValue.ToString()+"'"));
                                if (functions.dateCompareTo(date, functions.ConvertDate(txt_ngayrut.Text)) == 0) {
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlais = (tong * (lai / 100) * sn) / 365;
                                    string lss = functions.anonymousSql("select ROUND(" + tienlais + ",0)");
                                    txt_tienlai.Text = "" + functions.round(lss) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(lss)) + "";
                                    txt_tienrut.Text = txt_tienlai.Text;
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else if (nt >= sn)
                                {
                                    txt_tienlai.Text = "0";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong) + "";
                                    txt_tienrut.Text = "" + Convert.ToInt64(tong) + "";
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                else {
                                    float lai = float.Parse(txt_laisuat.Text);
                                    float tienlai = (tong * (lai / 100) * nt) / 365;
                                    string ls = functions.anonymousSql("select ROUND(" + tienlai + ",0)");
                                    txt_tienlai.Text = "" + functions.round(ls) + "";
                                    txt_tongtien.Text = "" + Convert.ToInt64(tong + float.Parse(ls)) + "";
                                    float laibn = float.Parse(functions.anonymousSql("select LaiSuat.lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '"+cbmaso.SelectedValue.ToString()+"'"));
                                    float tienlaibn = (tong * (laibn / 100) * sn)/365;
                                    txt_tienrut.Text = "" + functions.round("" + Convert.ToInt64((tong + tienlai) - tienlaibn) + "") + "";
                                    docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
                                }
                                break;                      
                        }
                    }
                }
            }
        }

        private void getTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mrt.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mrt.Text = dataRT.CurrentRow.Cells["Mart"].Value.ToString();
            string so = dataRT.CurrentRow.Cells["Maso"].Value.ToString();
            cbmaso.Text = functions.anonymousSql("select Maso from SoTK where Maso = '"+so+"'");
            txt_khachhang.Text = functions.anonymousSql("select KhachHang.Tenkh from SoTK,KhachHang where SoTK.Makh = KhachHang.Makh and SoTK.Maso = '"+so+"'");
            txt_laisuat.Text = functions.anonymousSql("select LaiSuat.lai from SoTK,LaiSuat where SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '"+so+"'");
            txt_tien.Text = functions.anonymousSql("select LoaiTien.Tentien from SoTK,LoaiTien where SoTK.Matien = LoaiTien.Matien and SoTK.Maso = '"+so+"'");
            txt_tien1.Text = txt_tien.Text;
            txt_tien2.Text = txt_tien.Text;
            string nv = dataRT.CurrentRow.Cells["Manv"].Value.ToString();
            cbnhanvien.Text = functions.GetFieldValues("select * from NhanVien where Manv = '" + nv + "'", "Tennv");
            txt_chucvu.Text = functions.GetFieldValues("select * from ChucVu,NhanVien where ChucVu.Macv = NhanVien.Macv and NhanVien.Manv = '" + nv + "'", "Tencv");
            string d = dataRT.CurrentRow.Cells["ngayrut"].Value.ToString();
            txt_ngayrut.Text = functions.date(d);
            txt_tienlai.Text = dataRT.CurrentRow.Cells["tienlai"].Value.ToString();
            txt_tongtien.Text = dataRT.CurrentRow.Cells["tongtien"].Value.ToString();
            txt_tienrut.Text = dataRT.CurrentRow.Cells["tienrut"].Value.ToString();
            docchu.Text = functions.ConvertNumberToString(txt_tienrut.Text);
            txt_tg.Text = dataRT.CurrentRow.Cells["TG"].Value.ToString();
            if (Convert.ToInt64(txt_tienrut.Text) > (Convert.ToInt64(txt_tongtien.Text) - Convert.ToInt64(txt_tienlai.Text) / 2))
            {

                string sql2 = "update SoTK set TienGoc = " + Convert.ToInt64(txt_tg.Text)+ " where Maso = '" + cbmaso.SelectedValue.ToString() + "'";
                functions.RunSql(sql2);
            }
            
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mrt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phiếu rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mrt.Focus();
                return;
            }
            if (cbmaso.Text.CompareTo("Chọn mã sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            { 
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ngayrut.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngayrut.Text.Trim().Length == 0 || txt_ngayrut.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn phải nhập ngày rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ngayrut.Focus();
                return;
            }
            if (!functions.IsDate(txt_ngayrut.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tienlai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Có lẽ bạn chưa nhấn refresh, hãy nhấn refresh để thêm thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tienlai.Focus();
                return;
            }
            if (Convert.ToInt64(txt_tienrut.Text) > (Convert.ToInt64(txt_tongtien.Text) - Convert.ToInt64(txt_tienlai.Text) / 2))
            {
                string sql2 = "update SoTK set TienGoc = 0 where Maso = '" + cbmaso.SelectedValue.ToString() + "'";
                functions.RunSql(sql2);
            }
            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update RutTien set Maso = '"+cbmaso.SelectedValue.ToString()+"', Manv = '"+cbnhanvien.SelectedValue.ToString()+"', tienlai = "+Convert.ToInt64(txt_tienlai.Text)+", tongtien = "+Convert.ToInt64(txt_tongtien.Text)+", ngayrut = '"+functions.ConvertDateTime(txt_ngayrut.Text)+"', tienrut = "+Convert.ToInt64(txt_tienrut.Text)+" where Mart = '"+txt_mrt.Text+"'";
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
            if (txt_mrt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phiếu rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mrt.Focus();
                return;
            }
            if (cbmaso.Text.CompareTo("Chọn mã sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnhanvien.Text.CompareTo("Chọn nhân viên") == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ngayrut.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ngayrut.Text.Trim().Length == 0 || txt_ngayrut.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn phải nhập ngày rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ngayrut.Focus();
                return;
            }
            if (!functions.IsDate(txt_ngayrut.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tienlai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Có lẽ bạn chưa nhấn refresh, hãy nhấn refresh để thêm thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tienlai.Focus();
                return;
            }
            if (Convert.ToInt64(txt_tienrut.Text) > (Convert.ToInt64(txt_tongtien.Text) - Convert.ToInt64(txt_tienlai.Text) / 2))
            {

                string sql2 = "update SoTK set TienGoc = "+Convert.ToInt64(txt_tg.Text)+" where Maso = '" + cbmaso.SelectedValue.ToString() + "'";
                functions.RunSql(sql2);
            }

            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from RutTien where Mart = '"+txt_mrt.Text+"'";
                functions.RunSqlDel(sql);
                LoadDT();
                Reset();
            }
        }

        private void InHoadon_Click(object sender, EventArgs e)
        {
            HoaDonRT rt = new HoaDonRT();
            rt.Show();
        }

 






   
    }
}
