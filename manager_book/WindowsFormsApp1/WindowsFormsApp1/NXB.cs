using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NXB : Form
    {
        public NXB()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NXB_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_manxb.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tblnxb";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã nhà xuất bản";
            ListDT.Columns[1].HeaderText = "Tên nhà xuất bản";
            ListDT.Columns[2].HeaderText = "Địa chỉ ";
            ListDT.Columns[3].HeaderText = "Điện thoại";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {

            txt_manxb.Text = "";
            txt_tennxb.Text = "";
            txt_address.Text = "";
            txt_dt.Text = "";
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manxb.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_manxb.Text = ListDT.CurrentRow.Cells["manxb"].Value.ToString();
            txt_tennxb.Text = ListDT.CurrentRow.Cells["tennxb"].Value.ToString();
            txt_address.Text = ListDT.CurrentRow.Cells["diachi"].Value.ToString();
            txt_dt.Text = ListDT.CurrentRow.Cells["dienthoai"].Value.ToString();
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_manxb.Enabled = true;
            txt_manxb.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manxb.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennxb.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (txt_dt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dt.Focus();
                return;
            }
            sql = "delete from tblnxb where manxb = '"+txt_manxb.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manxb.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennxb.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (txt_dt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dt.Focus();
                return;
            }
            sql = "update tblnxb set tennxb = '"+txt_tennxb.Text+"', diachi = '"+txt_address.Text+"', dienthoai = '"+txt_dt.Text+"' where manxb = '"+txt_manxb.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manxb.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennxb.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (txt_dt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dt.Focus();
                return;
            }
            sql = "SELECT manxb FROM tblnxb WHERE  (manxb = '" + txt_manxb.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập truong khac", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manxb.Focus();
                txt_manxb.Text = "";
                return;
            }

            sql = "insert into tblnxb values('"+txt_manxb.Text+"','"+txt_tennxb.Text+"','"+txt_address.Text+"','"+txt_dt.Text+"')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_manxb.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_manxb.Enabled = false;
        }
    }
}
