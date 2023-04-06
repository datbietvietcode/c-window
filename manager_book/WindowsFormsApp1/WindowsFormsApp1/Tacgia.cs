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
    public partial class Tacgia : Form
    {
        public Tacgia()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dtbl;
        private void Tacgia_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_matg.Enabled = false;
            btn_save.Enabled = false;
            ResetValues();
        }
        private void Load_DT()
        {
            string sql = "select * from tbltacgia";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã tác giả";
            ListDT.Columns[1].HeaderText = "Tên tác giả";
            ListDT.Columns[2].HeaderText = "Ngày sinh";
            ListDT.Columns[3].HeaderText = "Giới tính";
            ListDT.Columns[4].HeaderText = "địa chỉ";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {

            txt_matg.Text = "";
            txt_tentg.Text = "";
            txt_date.Text = "(__//__/___)";
            txt_address.Text = "";
            checksex.Checked = false;
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matg.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_matg.Text = ListDT.CurrentRow.Cells["matg"].Value.ToString();
            txt_tentg.Text = ListDT.CurrentRow.Cells["tentg"].Value.ToString();
            txt_date.Text = ListDT.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txt_address.Text = ListDT.CurrentRow.Cells["diachi"].Value.ToString();
            if (ListDT.CurrentRow.Cells["gioitinh"].Value.ToString() == "nam")
            {
                checksex.Checked = true;
            }
            else {
                checksex.Checked = false;
            }
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
            txt_matg.Enabled = true;
            txt_matg.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_matg.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tentg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentg.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }
            if (txt_date.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_date.Focus();
                return;
            }
            sql = "delete from tbltacgia where matg = '"+txt_matg.Text+"'";
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
            if (txt_matg.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tentg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentg.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }

            sql = "update tbltacgia set tentg = '"+txt_tentg.Text+"', gioitinh = '"+Class.Functions.gioitinh(checksex.Checked)+"', ngaysinh = '"+Class.Functions.ConvertDateTime(txt_date.Text)+"', diachi = '"+txt_address.Text+"' where matg = '"+txt_matg.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_matg.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập mã hng hoa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matg.Focus();
                return;

            }
            if (txt_tentg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentg.Focus();
                return;
            }
            if (txt_address.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }

            sql = "SELECT matg FROM tbltacgia WHERE  (matg = '" +txt_matg.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Sinh viên này đã có, bạn phải nhập sinh viên khác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matg.Focus();
                txt_matg.Text = "";
                return;
            }

            sql = "insert into tbltacgia values('"+txt_matg.Text+"','"+txt_tentg.Text+"','"+Class.Functions.ConvertDateTime(txt_date.Text)+"','"+Class.Functions.gioitinh(checksex.Checked)+"','"+txt_address.Text+"')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_matg.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_matg.Enabled = false;
        }
    }
}
