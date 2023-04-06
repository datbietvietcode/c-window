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
    public partial class NgonNgu : Form
    {
        public NgonNgu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl;
        private void NgonNgu_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_mann.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {

            txt_mann.Text = "";
            txt_tennn.Text = "";
        }

        private void Load_DT()
        {
            string sql = "select * from tblngongu";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã ngôn ngữ";
            ListDT.Columns[1].HeaderText = "Tên ngôn ngữ";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            txt_mann.Text = ListDT.CurrentRow.Cells["mann"].Value.ToString();
            txt_tennn.Text = ListDT.CurrentRow.Cells["tenn"].Value.ToString();
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
            txt_mann.Enabled = true;
            txt_mann.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mann.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennn.Focus();
                return;
            }
            sql = "delete from tblngongu where mann = '" + txt_mann.Text + "'";
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
            if (txt_mann.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennn.Focus();
                return;
            }

            sql = "update tblngongu set tenn = '" + txt_tennn.Text + "' where mann = '" + txt_mann.Text + "'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            string sql;
            if (txt_mann.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập trường này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mann.Focus();
                return;

            }
            if (txt_tennn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennn.Focus();
                return;
            }

            sql = "SELECT malv FROM tbllinhvuc WHERE  (malv = '" + txt_mann.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Trường này không có", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mann.Focus();
                txt_mann.Text = "";
                return;
            }

            sql = "INSERT INTO tblngongu VALUES('" + txt_mann.Text + "','" + txt_tennn.Text + "')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_mann.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_mann.Enabled = false;
        }
    }
}