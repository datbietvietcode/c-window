using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Quanlybanhang
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            HD hd = new HD();
            cbkhachhang.DataSource = hd.Load_Table("select * from Khachhang");
            cbkhachhang.DisplayMember = "Tenkh";
            cbkhachhang.ValueMember = "Makh";
            cbkhachhang.SelectedIndex = -1;
            this.report_hd.RefreshReport();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string sql = "select Tensp,hoadon.Soluong,hoadon.Dongia,Diachi from Sanpham,Khachhang,hoadon";
            sql += " where Khachhang.Makh = hoadon.Makh and hoadon.Masp = Sanpham.Masp and Khachhang.Makh = '"+cbkhachhang.SelectedValue.ToString()+"'";
            HD ob = new HD();
            DataTable dt = new DataTable();
            dt = ob.Load_Table(sql);
            report_hd.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            report_hd.LocalReport.ReportPath = @"D:\c#_visual\Quanlybanhang\Quanlybanhang\GiayHD.rdlc";
            //truyen bien
            ReportParameter ht = new ReportParameter("Tenkh");
            ht.Values.Add(cbkhachhang.Text);
            report_hd.LocalReport.SetParameters(ht);
            if (dt.Rows.Count > 0)
            {

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Inhoadon"; rds.Value = dt;
                report_hd.LocalReport.DataSources.Clear();
                report_hd.LocalReport.DataSources.Add(rds);
                report_hd.RefreshReport();  
            }else {

                MessageBox.Show("Không có dữ liệu!");
            }


        }
    }
}
