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
    public partial class HoaDonGT : Form
    {
        public HoaDonGT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDonGT_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from GuiTien",cbphieu,"Magt","Magt");
            cbphieu.Text = "Chọn mã gửi tiền";
            this.reportGT.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            s = functions.GetFieldValues("select Magt from GuiTien where Magt like '%"+txt_search.Text+"%'", "Magt");
            if (s != "")
            {
                MessageBox.Show("Đã tìm thấy mã gửi tiềm", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbphieu.Text = functions.GetFieldValues("select * from GuiTien where Magt = '"+s+"'", "Magt");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã gửi tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void hd_Click(object sender, EventArgs e)
        {
            if (cbphieu.Text.CompareTo("Chọn mã gửi tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn mã gửi tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select ChiNhanh.TenCN, LoaiTien.Tentien, KhachHang.Tenkh, KhachHang.Diachi, KhachHang.CMND,KyHan.Loaikh,";
            sql += " LaiSuat.Thoihan,SoTK.Maso,KyHan.kyhan,KyHan.tragop,NhanVien.Tennv,ChucVu.Tencv,GuiTien.Tien,convert(nvarchar,GuiTien.NgayGui,101) as NgayGui,SoTK.TienGoc";
            sql += " from GuiTien,SoTK,ChiNhanh,ChucVu,LoaiTien,KyHan,KhachHang,NhanVien,LaiSuat";
            sql += " where GuiTien.Maso = SoTK.Maso and GuiTien.Manv = NhanVien.Manv";
            sql += " and NhanVien.Macv = ChucVu.Macv and SoTK.Macn = ChiNhanh.MaCN";
            sql += " and SoTK.Makh = KhachHang.Makh and SoTK.Makhan = KyHan.Makh";
            sql += " and SoTK.Matien = LoaiTien.Matien and LaiSuat.Mals = SoTK.Mals";
            sql += " and GuiTien.Magt = '"+cbphieu.SelectedValue.ToString()+"'";
            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportGT.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportGT.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\HDGT.rdlc";
            //truyen bien
            ReportParameter ht = new ReportParameter("Magt");
            ht.Values.Add(cbphieu.Text);
            reportGT.LocalReport.SetParameters(ht);
            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HD_GT"; rds.Value = dt;
                reportGT.LocalReport.DataSources.Clear();
                reportGT.LocalReport.DataSources.Add(rds);
                reportGT.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }
        }
    }
}
