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
    public partial class TKTG : Form
    {
        public TKTG()
        {
            InitializeComponent();
        }

        private void TKTG_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select distinct month(NgayGui) as NgayGui from GuiTien",cbthang,"NgayGui","NgayGui");
            cbthang.Text = "Chọn tháng";
            this.reportTKGT.RefreshReport();     
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (cbthang.Text.CompareTo("Chọn tháng") == 0)
            {
                MessageBox.Show("Bạn phải chọn tháng gửi", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string sql = "select GuiTien.Magt,GuiTien.Maso,KhachHang.Tenkh,GuiTien.Tien,SoTK.TienGoc,CONVERT(nvarchar,GuiTien.NgayGui,101) as NgayGui,";
            sql += " NhanVien.Tennv,LoaiTien.Tentien from GuiTien,SoTK,NhanVien,KhachHang,LoaiTien";
            sql += " where GuiTien.Manv = NhanVien.Manv and GuiTien.Maso = SoTK.Maso and SoTK.Matien = LoaiTien.Matien";
            sql += " and SoTK.Makh = KhachHang.Makh and MONTH(NgayGui) = "+cbthang.SelectedValue.ToString()+"";
            DataTable dt = new DataTable();
            dt = functions.GetTableToTable(sql);
            reportTKGT.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportTKGT.LocalReport.ReportPath = @"D:\c#_visual\BTL_GUITIEN\BTL_GUITIEN\TKTG.rdlc";

            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "TK_GT"; rds.Value = dt;
                reportTKGT.LocalReport.DataSources.Clear();
                reportTKGT.LocalReport.DataSources.Add(rds);
                reportTKGT.RefreshReport();
            }
            else
            {

                MessageBox.Show("Không có dữ liệu!");
            }
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
