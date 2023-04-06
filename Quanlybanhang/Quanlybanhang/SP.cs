using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlybanhang
{
    class SP
    {
        string Masp, Tensp;
        float Sl, Dongia;

        public SP() { }
        public SP(string Masp, string Tensp, float Sl, float Dongia) {

            this.Masp = Masp;
            this.Tensp = Tensp;
            this.Sl = Sl;
            this.Dongia = Dongia;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C95D7VA;Initial Catalog=QLBH;Integrated Security=True");
        public void Hienthi(ListView item, String sql) {
            item.Items.Clear();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            int i = 0;
            foreach (DataRow row in dt.Rows) {

                string masp = row["Masp"].ToString();
                string tensp = row["Tensp"].ToString();
                string soluong = row["Soluong"].ToString();
                string dongia = row["Dongia"].ToString();

                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(masp);
                item.Items[i].SubItems.Add(tensp);
                item.Items[i].SubItems.Add(soluong);
                item.Items[i].SubItems.Add(dongia);
                i = i + 1;
            }
        }

        public void insert(SP sp) {

            string sql = "insert into Sanpham values('"+sp.Masp+"','"+sp.Tensp+"',"+sp.Sl+",'"+sp.Dongia+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();


        }

        public bool KT_check(string key) {

            bool kt = false;
            string sql = "select Masp from Sanpham";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows) {

                string masp = row["Masp"].ToString();
                if (String.Compare(masp.Trim(), key.Trim(), true) == 0) {
                    kt = true; break;
                }
            }
            return kt;
        }

        public void update(SP ob) {

            string sql = "update Sanpham set Tensp = '"+ob.Tensp+"', Soluong = "+ob.Sl+", Dongia = "+ob.Dongia+" where Masp = '"+ob.Masp+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void delete(SP ob) {

            string sql = "delete from Sanpham where Masp = '"+ob.Masp+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
