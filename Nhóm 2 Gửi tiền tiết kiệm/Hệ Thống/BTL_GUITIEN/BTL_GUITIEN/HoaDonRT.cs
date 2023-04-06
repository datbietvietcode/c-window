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
    public partial class HoaDonRT : Form
    {
        public HoaDonRT()
        {
            InitializeComponent();
        }

        private void HoaDonRT_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from RutTien",cbchonhd,"Mart","Mart");
            cbchonhd.Text = "Chọn mã rút tiền";
            this.reportHDRT.RefreshReport();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string s = "";
            s = functions.GetFieldValues("select Mart from RutTien where Mart like '%"+txt_mhd.Text+"%'","Mart");
            if (s != "")
            {
                MessageBox.Show("Đã tìm thấy mã phiếu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbchonhd.Text = functions.GetFieldValues("select Mart from RutTien where Mart = '"+s+"'", "Mart");
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbchonhd.Text.CompareTo("Chọn mã rút tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn mã rút tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select RutTien.Maso,NhanVien.Tennv,ChucVu.Tencv,KhachHang.Tenkh,KhachHang.Diachi,KhachHang.CMND,RutTien.tienlai,RutTien.tienrut, convert(nvarchar,RutTien.ngayrut,101) as ngayrut,";
            sql += " RutTien.tongtien,LaiSuat.lai,LaiSuat.Thoihan,LoaiTien.Tentien,KyHan.Loaikh,KyHan.kyhan,KyHan.tragop,";
            sql += " convert(nvarchar,SoTK.Ngayms,101) as Ngayms,convert(nvarchar,SoTK.Ngaytrs,101) as Ngaytrs,SoTK.tattoan,ChiNhanh.TenCN,SoTK.TienGoc,RutTien.TG";
            sql += " from RutTien,SoTK,LaiSuat,KyHan,LoaiTien,KhachHang,NhanVien,ChiNhanh,ChucVu";
            sql += " where RutTien.Maso = SoTK.Maso and SoTK.Mals = LaiSuat.Mals";
            sql += " and KyHan.Makh = SoTK.Makhan and SoTK.Matien = LoaiTien.Matien";
            sql += " and KhachHang.Makh = SoTK.Makh and RutTien.Manv = NhanVien.Manv";
            sql += " and SoTK.Macn = ChiNhanh.MaCN and NhanVien.Macv = ChucVu.Macv";
            sql += " and RutTien.Mart = '"+cbchonhd.SelectedValue.ToString()+"'";
            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportHDRT.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportHDRT.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\HoaDonRT.rdlc";
            //truyen bien
            ReportParameter ht = new ReportParameter("Mart");
            ht.Values.Add(cbchonhd.Text);
            reportHDRT.LocalReport.SetParameters(ht);
            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HD_RT"; rds.Value = dt;
                reportHDRT.LocalReport.DataSources.Clear();
                reportHDRT.LocalReport.DataSources.Add(rds);
                reportHDRT.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }
        }
    }
}
