using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baiktra.Class
{
    class Sach
    {
        public static SqlConnection conn;
        public static string connString;

        public static void Connect()
        {
            connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\c#_visual\\baiktra\\baiktra\\Sach.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
        }

        public static void Disconnect()
        {

            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Dispose();
            conn = null;
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter myData = new SqlDataAdapter(sql, Sach.conn);
            DataTable table = new DataTable();
            myData.Fill(table);
            return table;
        }

        public static bool checkKey(string sql)
        {

            SqlDataAdapter myData = new SqlDataAdapter(sql, Sach.conn);
            DataTable table = new DataTable();
            myData.Fill(table);
            if (table.Rows.Count > 0)
            {

                return true;
            }
            return false;
        }

        public static void runSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Sach.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SyntaxErrorException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void runSqlDel(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch (SyntaxErrorException ex)
            {

                MessageBox.Show("Dữ liệu đang được dùng không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        // dung cho combobox
        public static void FillCombo(string sql, ComboBox cbo, string ma, string name)
        {
            SqlDataAdapter myData = new SqlDataAdapter(sql,Sach.conn);
            DataTable table = new DataTable();
            myData.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = name;

        }

        public static string GetFieldValues(string sql)
        {

            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Sach.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
