using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_GUITIEN
{
    class functions
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C95D7VA;Initial Catalog=SAVEMONEY;Integrated Security=True");

        public static DataTable GetTableToTable(string sql) {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            try
            {
                da.Fill(dt);
            }catch(System.Exception){
                MessageBox.Show("Cần nhập lại dữ liệu");
            }
            dt.AcceptChanges();
            return dt;
        }

        public static string anonymousSql(string sql) {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            try
            {
                da.Fill(dt);
            }catch(System.Exception){
                MessageBox.Show("Nhập lại dữ liệu");
            }
            dt.AcceptChanges();
            string field = "";
            foreach (DataRow rows in dt.Rows) {
                field = rows[0].ToString();
            }
            return field;
        }

        public static void FillComBo(string sql, ComboBox cbo ,string display, string values ) {
            cbo.DataSource = GetTableToTable(sql);
            cbo.DisplayMember = display;
            cbo.ValueMember = values;
            cbo.SelectedIndex = -1;
        }

        public static bool CheckKey(string sql) {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd; // thêm dòng này
            da.Fill(dt);
            dt.AcceptChanges();
            if (dt.Rows.Count > 0) {
                return true;
            }
            return false;
        }

        public static void RunSql(string sql) {
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt); // bắt lỗi câu lệnh
            }
            catch (System.Exception) {
                MessageBox.Show("Mời nhập lại dữ liệu");
            }
            da.Update(dt);
            dt.AcceptChanges();
        }


        public static void RunSqlDel(string sql) {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt); // bắt lỗi câu lệnh
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            da.Update(dt);
            dt.AcceptChanges();
        
        }

        public static bool IsDate(string d) {
            string[] parts = d.Split('/');
            try
            {
                if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                {
                    return true;
                }
            }
            catch (System.Exception) { 
            }
            return false;
        }

        public static string ConvertDateTime(string d) {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}",parts[1],parts[0],parts[2]);
            return dt;
        }

        // getfieldValues

        public static string GetFieldValues(string sql, string field){

            string ma = "";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows) {
                ma = row[field].ToString();
            }
            return ma;
        }

        public static string date(string d) {
            int i = 0;
            string s = "";
            while(d[i] != ' '){
                s += d[i];
                i++;
            }
            string[] parts = s.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static bool So(string s){

            for (int i = 0; i < s.Length; i++) {
                if (Convert.ToByte(s[i]) >= 48 && Convert.ToByte(s[i]) <= 57) {
                    return true;
                }
            }

            return false;
        }

        // so sanh ngay thang

        public static bool SoSanh(string date1, string date2) {
            string[] parts1 = date1.Split('/');
            string[] parts2 = date2.Split('/');
            if (Convert.ToInt32(parts1[2]) < Convert.ToInt32(parts2[2]) || (Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) < Convert.ToInt32(parts2[1])) || (Convert.ToInt32(parts1[0]) < Convert.ToInt32(parts2[0]) && Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) < Convert.ToInt32(parts2[1])))
            {
                return true;
            }
            return false;

        }

        public static string ConvertDate(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[0], parts[1], parts[2]);
            return dt;
        }


        public static string round(string d) {
            string[] parts = d.Split('.');
            string s = String.Format("{0}", parts[0]);
            return s;
        }


        public static string theFirt(string m) {
            int i = 0;
            string s = "";
            while (m[i] != ' ') {
                s += m[i];
                i++;
            }
            return s;
        }

        public static int dateCompareTo(string date1, string date2) {
            string[] parts1 = date1.Split('/');
            string[] parts2 = date2.Split('/');
            int i = 0;
            if (Convert.ToInt32(parts1[2]) < Convert.ToInt32(parts2[2]) || (Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) < Convert.ToInt32(parts2[1])) || (Convert.ToInt32(parts1[0]) < Convert.ToInt32(parts2[0]) && Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) < Convert.ToInt32(parts2[1]))) {
                i = -1;
            }
            else if (Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) || (Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) == Convert.ToInt32(parts2[1])) || (Convert.ToInt32(parts1[0]) == Convert.ToInt32(parts2[0]) && Convert.ToInt32(parts1[2]) == Convert.ToInt32(parts2[2]) && Convert.ToInt32(parts1[1]) == Convert.ToInt32(parts2[1])))
            {
                i = 0;
            }
            else {
                i = 1;
            }

            return i;
        }


        public static string ConvertNumberToString(string sNumber){
           int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",","");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt16(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mươi ", "linh ");
            //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
    }
}
