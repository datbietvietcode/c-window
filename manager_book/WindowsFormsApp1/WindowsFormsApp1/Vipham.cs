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
    public partial class Vipham : Form
    {
        public Vipham()
        {
            InitializeComponent();
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl; 
        private void Vipham_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_mavp.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tblvipham";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã vi phạm";
            ListDT.Columns[1].HeaderText = "Tên vi phạm";
            ListDT.Columns[2].HeaderText = "Tiền phạt";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {

            txt_mavp.Text = "";
            txt_tenvp.Text = "";
            txt_tien.Text = "0";
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mavp.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mavp.Text = ListDT.CurrentRow.Cells["mavipham"].Value.ToString();
            txt_tenvp.Text = ListDT.CurrentRow.Cells["tenvipham"].Value.ToString();
            txt_tien.Text = ListDT.CurrentRow.Cells["tienphat"].Value.ToString();
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
            txt_mavp.Enabled = true;
            txt_mavp.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mavp.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenvp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenvp.Focus();
                return;
            }
            sql = "delete from tblvipham where mavipham = '"+txt_mavp.Text+"'";
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
            if (txt_mavp.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenvp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenvp.Focus();
                return;
            }
            sql = "update tblvipham set tenvipham='"+txt_tenvp.Text+"', tienphat = '"+float.Parse(txt_tien.Text)+"' where mavipham = '"+txt_mavp.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_mavp.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập mã hng hoa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mavp.Focus();
                return;

            }
            if (txt_tenvp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenvp.Focus();
                return;
            }
            sql = "SELECT mavipham FROM tblvipham WHERE  (mavipham = '" + txt_mavp.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập sinh viên khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mavp.Focus();
                txt_mavp.Text = "";
                return;
            }

            sql = "INSERT INTO tblvipham VALUES('" + txt_mavp.Text + "','" + txt_tenvp.Text + "',"+float.Parse(txt_tien.Text)+")";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_mavp.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_mavp.Enabled = false;
        }
    }
}
