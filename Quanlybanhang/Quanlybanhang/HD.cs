using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlybanhang
{
    class HD
    {
        string Mahd, Makh, Masp;
        float SL, Dongia;
        DateTime ngaymua;
        public HD() { }
        public HD(string Mahd,string Makh,string Masp ,float SL, float Dongia, DateTime ngaymua) {

            this.Mahd = Mahd;
            this.Makh = Makh;
            this.Masp = Masp;
            this.SL = SL;
            this.Dongia = Dongia;
            this.ngaymua = ngaymua;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C95D7VA;Initial Catalog=QLBH;Integrated Security=True");

        public DataTable Load_Table(string sql) {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }

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

                string mahd = row["Mahd"].ToString();
                string makh = row["Makh"].ToString();
                string masp = row["Masp"].ToString();
                string soluong = row["Soluong"].ToString();
                string dongia = row["Dongia"].ToString();
                string ngaymua = row["Ngaymua"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(mahd);
                item.Items[i].SubItems.Add(makh);
                item.Items[i].SubItems.Add(masp);
                item.Items[i].SubItems.Add(soluong);
                item.Items[i].SubItems.Add(dongia);
                item.Items[i].SubItems.Add(ngaymua);
                i = i + 1;
            }
        }

        public void insert(HD hd)
        {

            string sql = "insert into Hoadon values('"+hd.Mahd+"','"+hd.Makh+"','"+hd.Masp+"',"+hd.SL+","+hd.Dongia+",'"+hd.ngaymua+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();


        }

        public bool KT_check(string key)
        {

            bool kt = false;
            string sql = "select Mahd from Sanpham";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {

                string masp = row["Mahd"].ToString();
                if (String.Compare(masp.Trim(), key.Trim(), true) == 0)
                {
                    kt = true; break;
                }
            }
            return kt;
        }

        public void update(HD hd)
        {

            string sql = "update hoadon set Makh = '"+hd.Makh+"', Masp = '"+hd.Masp+"', Soluong ="+hd.SL+", Dongia ="+hd.Dongia+",Ngaymua = '"+hd.ngaymua+"' where Mahd = '"+hd.Mahd+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void delete(HD hd)
        {

            string sql = "delete from hoadon where Mahd = '"+hd.Mahd+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void Excecute(string sql){

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
