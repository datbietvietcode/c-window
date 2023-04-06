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
    public partial class TKRT : Form
    {
        public TKRT()
        {
            InitializeComponent();
        }

        private void TKRT_Load(object sender, EventArgs e)
        {
             functions.FillComBo("select distinct MONTH(ngayrut) as ngayrut from RutTien", cbthang,"ngayrut", "ngayrut");
             cbthang.Text = "Chọn tháng";
            this.reportTKRT.RefreshReport();
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (cbthang.Text.CompareTo("Chọn tháng") == 0)
            {
                MessageBox.Show("Bạn phải chọn tháng rút", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string sql = "select RutTien.Mart,RutTien.Maso,RutTien.tienlai,RutTien.tongtien,RutTien.tienrut,";
            sql += " CONVERT(nvarchar,RutTien.ngayrut,101) as ngayrut,NhanVien.Tennv, LoaiTien.Tentien,KhachHang.Tenkh";
            sql += " from RutTien,SoTK,KhachHang,NhanVien,LoaiTien";
            sql += " where RutTien.Maso = SoTK.Maso and RutTien.Manv = NhanVien.Manv";
            sql += " and SoTK.Makh = KhachHang.Makh and LoaiTien.Matien = SoTK.Matien";
            sql += " and MONTH(RutTien.ngayrut) = "+cbthang.SelectedValue.ToString()+" ";
            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportTKRT.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportTKRT.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\TKHTRT.rdlc";

            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "TK_RT"; rds.Value = dt;
                reportTKRT.LocalReport.DataSources.Clear();
                reportTKRT.LocalReport.DataSources.Add(rds);
                reportTKRT.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }
        }
    }
}
