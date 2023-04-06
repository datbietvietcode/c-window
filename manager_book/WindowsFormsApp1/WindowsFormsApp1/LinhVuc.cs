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
    public partial class LinhVuc : Form
    {
        public LinhVuc()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void LinhVuc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_malv.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }

        private void ResetValues()
        {

            txt_malv.Text = "";
            txt_tenlv.Text = "";
        }

        private void Load_DT()
        {
            string sql = "select * from tbllinhvuc";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã lĩnh vực";
            ListDT.Columns[1].HeaderText = "Tên lĩnh vực";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_bq.Enabled = true;
            ResetValues();
            txt_malv.Enabled = true;
            txt_malv.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_malv.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenlv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenlv.Focus();
                return;
            }
            sql = "delete from tbllinhvuc where malv = '"+txt_malv.Text+"'";
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
            if (txt_malv.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenlv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenlv.Focus();
                return;
            }
           
            sql = "update tbllinhvuc set tenlv = '"+txt_tenlv.Text+"' where malv = '"+txt_malv.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            txt_malv.Text = ListDT.CurrentRow.Cells["malv"].Value.ToString();
            txt_tenlv.Text = ListDT.CurrentRow.Cells["tenlv"].Value.ToString();
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_malv.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập trường này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_malv.Focus();
                return;

            }
            if (txt_tenlv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenlv.Focus();
                return;
            }
          
            sql = "SELECT malv FROM tbllinhvuc WHERE  (malv = '" + txt_malv.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Trường này không có", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_malv.Focus();
                txt_malv.Text = "";
                return;
            }

            sql = "INSERT INTO tbllinhvuc VALUES('" + txt_malv.Text + "','" + txt_tenlv.Text + "')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_malv.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_malv.Enabled = false;
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
