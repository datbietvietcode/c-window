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
    public partial class CaLam : Form
    {
        public CaLam()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl;
        private void CaLam_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_maca.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {

            txt_maca.Text = "";
            txt_tenca.Text = "";
        }

        private void Load_DT()
        {
            string sql = "select * from tblcalam";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã ca làm";
            ListDT.Columns[1].HeaderText = "Tên ca làm";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            txt_maca.Text = ListDT.CurrentRow.Cells["maca"].Value.ToString();
            txt_tenca.Text = ListDT.CurrentRow.Cells["tenca"].Value.ToString();
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
            txt_maca.Enabled = true;
            txt_maca.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maca.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenca.Focus();
                return;
            }
            sql = "delete from tblcalam where maca = '" + txt_maca.Text + "'";
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
            if (txt_maca.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenca.Focus();
                return;
            }

            sql = "update tblcalam set tenca = '" + txt_tenca.Text + "' where maca = '" + txt_maca.Text + "'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_maca.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập trường này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maca.Focus();
                return;

            }
            if (txt_tenca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenca.Focus();
                return;
            }

            sql = "SELECT maca FROM tblcalam WHERE  (maca = '" + txt_maca.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Trường này không có", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maca.Focus();
                txt_maca.Text = "";
                return;
            }

            sql = "INSERT INTO tblcalam VALUES('" + txt_maca.Text + "','" + txt_tenca.Text + "')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_maca.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_maca.Enabled = false;
        }
    }
}
