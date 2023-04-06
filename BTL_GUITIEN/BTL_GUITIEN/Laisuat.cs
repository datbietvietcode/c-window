using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_GUITIEN
{
    public partial class Laisuat : Form
    {
        public Laisuat()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void Laisuat_Load(object sender, EventArgs e)
        {
            functions.FillComBo("select * from KyHan", cbkh,"Loaikh","Makh");
            functions.FillComBo("select * from LoaiTien",cbtien,"Tentien","Matien");
            Set();
            LoadDT();
            txt_mals.Enabled = false;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
        }

        private void LoadDT()
        {
            string sql = "select * from LaiSuat";
            dtbl = functions.GetTableToTable(sql);
            dataLS.DataSource = dtbl;
            dataLS.Columns[0].HeaderText = "Mã lãi suất";
            dataLS.Columns[1].HeaderText = "Thời hạn";
            dataLS.Columns[2].HeaderText = "Lãi suất";
            dataLS.Columns[3].HeaderText = "Ngày cập nhật";
            dataLS.Columns[4].HeaderText = "Mã kỳ hạn";
            dataLS.Columns[5].HeaderText = "Mã tiền";
            dataLS.AllowUserToAddRows = false; // ko cho phep nguoi sd them truc tiep tren table
            dataLS.EditMode = DataGridViewEditMode.EditProgrammatically; // ko cho phep sua truc tiep
           // dataLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            // dataLS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void Set() {
            cbkh.Text = "Chọn kỳ hạn";
            cbtien.Text = "Chọn loại tiền";
            txt_ns.Text = "dd/mm/yyyy";
        }

        private void stt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dataLS.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void Reset() {
            txt_mals.Text = "";
            txt_th.Text = "";
            txt_ls.Text = "";
            Set();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_up.Enabled = false;
            btn_del.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_bq.Enabled = true;
            Reset();
            txt_mals.Enabled = true;
            txt_mals.Focus();
        }

        private void exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            Reset();
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_mals.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_mals.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mals.Focus();
                return;
            }
            if (txt_th.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_th.Focus();
                return;
            }
            if(txt_ls.Text.Trim().Length == 0){
                MessageBox.Show("Bạn phải nhập lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ls.Focus();
                return;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày cập nhật", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (cbkh.Text.CompareTo("Chọn kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_ls.Text)) {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            
            }
            string sql = "select Mals from LaiSuat where Mals = '"+txt_ls.Text+"'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã có xin mời nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mals.Focus();
                txt_mals.Text = "";
                return;

            }
            string sql1 = "insert into LaiSuat values('"+txt_mals.Text+"',N'"+txt_th.Text+"',"+float.Parse(txt_ls.Text)+",'"+functions.ConvertDateTime(txt_ns.Text)+"','"+cbkh.SelectedValue.ToString()+"','"+cbtien.SelectedValue.ToString()+"')";
            functions.RunSql(sql1);
            LoadDT();
            Reset();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_bq.Enabled = false;
            btn_save.Enabled = false;
            txt_mals.Enabled = false;
        }

        private void GetTable(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mals.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mals.Text = dataLS.CurrentRow.Cells["Mals"].Value.ToString();
            txt_th.Text = dataLS.CurrentRow.Cells["Thoihan"].Value.ToString();
            txt_ls.Text = dataLS.CurrentRow.Cells["lai"].Value.ToString();
            string kh = dataLS.CurrentRow.Cells["Makh"].Value.ToString();
            cbkh.Text = functions.GetFieldValues("select * from KyHan where Makh = '"+kh+"'", "Loaikh");
            string t = dataLS.CurrentRow.Cells["Matien"].Value.ToString();
            cbtien.Text = functions.GetFieldValues("select * from LoaiTien", "Tentien");
            string d = dataLS.CurrentRow.Cells["Ngaycn"].Value.ToString();
            txt_ns.Text = functions.date(d);
            btn_up.Enabled = true;
            btn_del.Enabled = true;
            btn_bq.Enabled = true;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mals.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mals.Focus();
                return;
            }
            if (txt_th.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_th.Focus();
                return;
            }
            if (txt_ls.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ls.Focus();
                return;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày cập nhật", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (cbkh.Text.CompareTo("Chọn kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_ls.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("Bạn có muốn sửa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "update LaiSuat set Thoihan = N'"+txt_th.Text+"', lai = "+float.Parse(txt_ls.Text)+" , Ngaycn = '"+functions.ConvertDateTime(txt_ns.Text)+"', Makh = '"+cbkh.SelectedValue.ToString()+"', Matien = '"+cbtien.SelectedValue.ToString()+"' where Mals = '"+txt_mals.Text+"'";
                functions.RunSql(sql);
                LoadDT();
                Reset();
                btn_bq.Enabled = false;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mals.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mals.Focus();
                return;
            }
            if (txt_th.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn phải nhập thời hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_th.Focus();
                return;
            }
            if (txt_ls.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lãi suất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ls.Focus();
                return;
            }
            if (txt_ns.Text.CompareTo("dd/mm/yyyy") == 0 || txt_ns.Text.Trim().Length == 0 || txt_ns.Text == "  /  /    ")
            {

                MessageBox.Show("Bạn phải nhập ngày cập nhật", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ns.Focus();
                return;
            }
            if (cbkh.Text.CompareTo("Chọn kỳ hạn") == 0)
            {
                MessageBox.Show("Bạn phải chọn kỳ hạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbtien.Text.CompareTo("Chọn loại tiền") == 0)
            {
                MessageBox.Show("Bạn phải chọn loại tiền", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.IsDate(txt_ns.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng dd/mm/yyyy", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!functions.So(txt_ls.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng số", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from LaiSuat where Mals = '"+txt_mals.Text+"'";
                functions.RunSqlDel(sql);
                LoadDT();
                Reset();
            }

        }
    }
}
