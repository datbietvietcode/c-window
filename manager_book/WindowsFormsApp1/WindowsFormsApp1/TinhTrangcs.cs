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
    public partial class TinhTrangcs : Form
    {
        public TinhTrangcs()
        {
            InitializeComponent();
        }
        DataTable dtbl;

        private void ListDT_Click(object sender, EventArgs e)
        {
            txt_matt.Text = ListDT.CurrentRow.Cells["matinhtrang"].Value.ToString();
            txt_tentt.Text = ListDT.CurrentRow.Cells["tentinhtrang"].Value.ToString();
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void TinhTrangcs_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_matt.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {

            txt_matt.Text = "";
            txt_tentt.Text = "";
        }

        private void Load_DT()
        {
            string sql = "select * from tbltinhtrang";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã tình trạng";
            ListDT.Columns[1].HeaderText = "Tên tình trạng";
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
            txt_matt.Enabled = true;
            txt_matt.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_matt.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tentt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentt.Focus();
                return;
            }
            sql = "delete from tbltinhtrang where matinhtrang = '" + txt_matt.Text + "'";
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
            if (txt_matt.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tentt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentt.Focus();
                return;
            }

            sql = "update tbltinhtrang set tentinhtrang = '" + txt_tentt.Text + "' where matinhtrang = '" + txt_matt.Text + "'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_matt.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập trường này", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matt.Focus();
                return;

            }
            if (txt_tentt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentt.Focus();
                return;
            }

            sql = "SELECT matinhtrang FROM tbltinhtrang WHERE  (matinhtrang = '" + txt_matt.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Trường này không có", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matt.Focus();
                txt_matt.Text = "";
                return;
            }

            sql = "INSERT INTO tbltinhtrang VALUES('" + txt_matt.Text + "','" + txt_tentt.Text + "')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_matt.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_matt.Enabled = false;
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
