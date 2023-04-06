using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlybanhang
{
    class KH
    {
        string Tenkh, Makh, Diachi;
        public KH() { }

        public KH(string Makh, string Tenkh, string Diachi)
        {
            this.Makh = Makh;
            this.Tenkh = Tenkh;
            this.Diachi = Diachi;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C95D7VA;Initial Catalog=QLBH;Integrated Security=True");
        public void Hienthi(ListView item, String sql)
        {
            item.Items.Clear();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {

                string makh = row["Makh"].ToString();
                string tenkh = row["Tenkh"].ToString();
                string diachi = row["Diachi"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(makh);
                item.Items[i].SubItems.Add(tenkh);
                item.Items[i].SubItems.Add(diachi);
                i = i + 1;
            }
        }

        public void insert(KH kh)
        {

            string sql = "insert into Khachhang values('"+kh.Makh+"','"+kh.Tenkh+"','"+kh.Diachi+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();


        }

        public bool KT_check(string key)
        {

            bool kt = false;
            string sql = "select Makh from Khachhang";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {

                string masp = row["Makh"].ToString();
                if (String.Compare(masp.Trim(), key.Trim(), true) == 0)
                {
                    kt = true; break;
                }
            }
            return kt;
        }

        public void update(KH kh)
        {

            string sql = "update Khachhang set Tenkh = '"+kh.Tenkh+"', Diachi = '"+kh.Diachi+"' where Makh = '"+kh.Makh+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void delete(KH kh)
        {

            string sql = "delete from Khachhang where Makh = '"+kh.Makh+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
