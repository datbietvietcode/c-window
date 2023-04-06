using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BTL_GUITIEN
{
    public partial class In_STK : Form
    {
        public In_STK()
        {
            InitializeComponent();
        }

        private void In_STK_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from SoTK",cbso,"Maso","Maso");
            cbso.Text = "Chọn STK";
            this.reportSTK.RefreshReport();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {   
            string s = "";
            s = functions.GetFieldValues("select Maso from SoTK where Maso like '%"+txt_search.Text+"%'", "Maso");
            if (s != "")
            {
                MessageBox.Show("Đã tìm thấy mã sổ TK", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbso.Text = functions.GetFieldValues("select * from SoTK where Maso = '"+s+"'", "Maso");
            }
            else
            {
                MessageBox.Show("Không tìm thấy STK", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printSTK_Click(object sender, EventArgs e)
        {
            if (cbso.Text.CompareTo("Chọn STK") == 0)
            {
                MessageBox.Show("Bạn phải chọn STK", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select ChiNhanh.TenCN,LoaiTien.Tentien,KhachHang.Tenkh,KhachHang.Diachi,";
            sql += " KhachHang.CMND,KyHan.Loaikh,LaiSuat.Thoihan,SoTK.Maso,KyHan.kyhan,KyHan.tragop,LaiSuat.lai,";
            sql += " NhanVien.Tennv,ChucVu.Tencv,SoTK.TienGoc,SoTK.tattoan,CONVERT(nvarchar,SoTK.Ngayms,101) as Ngayms,CONVERT(nvarchar,SoTK.Ngaytrs,101) as Ngaytrs";
            sql += " from SoTK,KhachHang,KyHan,LaiSuat,LoaiTien,NhanVien,ChucVu,ChiNhanh";
            sql += " where SoTK.Makh = KhachHang.Makh and SoTK.Macn = ChiNhanh.MaCN";
            sql += " and SoTK.Makhan = KyHan.Makh and SoTK.Matien = LoaiTien.Matien";
            sql += " and SoTK.Manv = NhanVien.Manv and NhanVien.Macv = ChucVu.Macv";
            sql += " and SoTK.Mals = LaiSuat.Mals and SoTK.Maso = '"+cbso.SelectedValue.ToString()+"'";
            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportSTK.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportSTK.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\So_TK.rdlc";
            //truyen bien
            ReportParameter ht = new ReportParameter("Maso");
            ht.Values.Add(cbso.Text);
            reportSTK.LocalReport.SetParameters(ht);
            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "STK"; rds.Value = dt;
                reportSTK.LocalReport.DataSources.Clear();
                reportSTK.LocalReport.DataSources.Add(rds);
                reportSTK.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }
        }
    }
}
