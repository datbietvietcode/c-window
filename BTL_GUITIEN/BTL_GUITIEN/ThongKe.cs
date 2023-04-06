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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select distinct MONTH(Ngayms) as NgayMS from SoTK", cbngayms, "NgayMS", "NgayMS");
            cbngayms.Text = "Chọn tháng mở sổ";
            functions.FillComBo("select distinct MONTH(Ngaytrs) as NgayHH from SoTK",cbthanghh,"NgayHH","NgayHH");
            cbthanghh.Text = "Chọn tháng hết hạn";
            this.reportTK.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbngayms.Text.CompareTo("Chọn tháng mở sổ") == 0)
            {
                MessageBox.Show("Bạn phải chọn tháng mở sổ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbthanghh.Text.CompareTo("Chọn tháng hết hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn tháng hết hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select SoTK.Maso,KhachHang.Tenkh,SoTK.TienGoc,KyHan.Loaikh,LoaiTien.Tentien,";
            sql += " NhanVien.Tennv,ChiNhanh.TenCN,CONVERT(nvarchar,SoTK.Ngayms,101) as Ngayms,CONVERT(nvarchar,SoTK.Ngaytrs,101) as Ngaytrs, SoTK.tattoan,LaiSuat.lai";
            sql += " from SoTK,KhachHang,KyHan,LaiSuat,NhanVien,ChiNhanh,LoaiTien";
            sql += " where SoTK.Macn = ChiNhanh.MaCN and SoTK.Makh = KhachHang.Makh";
            sql += " and SoTK.Makhan = KyHan.Makh and SoTK.Mals = LaiSuat.Mals";
            sql += " and SoTK.Matien = LoaiTien.Matien and SoTK.Manv = NhanVien.Manv";
            sql += " and MONTH(SoTK.Ngayms) = "+cbngayms.SelectedValue.ToString()+"  and MONTH(SoTK.Ngaytrs) = "+cbthanghh.SelectedValue.ToString()+" ";

            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportTK.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportTK.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\TKSOTK.rdlc";
           
            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "TK_So"; rds.Value = dt;
                reportTK.LocalReport.DataSources.Clear();
                reportTK.LocalReport.DataSources.Add(rds);
                reportTK.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }

        }


    }
}
