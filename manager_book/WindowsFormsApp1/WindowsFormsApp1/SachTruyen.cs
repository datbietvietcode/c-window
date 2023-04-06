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
    public partial class SachTruyen : Form
    {
        public SachTruyen()
        {
            InitializeComponent();
        }
        DataTable dtbl;
        private void SachTruyen_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Load_DT();
            txt_mas.Enabled = false;
            btn_save.Enabled = false;
            Class.Functions.FillCombo("SELECT * FROM tbllinhvuc", cblinhvuc, "malv", "tenlv");
            cblinhvuc.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblloaisach", cbloaisach, "mals", "tenls");
            cbloaisach.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tbltacgia", cbtacgia, "matg", "tentg");
            cbtacgia.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblngongu", cbngonngu, "mann", "tenn");
            cbngonngu.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT * FROM tblnxb", cbnhaxuatban, "manxb", "tennxb");
            cbnhaxuatban.SelectedIndex = -1;
            ResetValues();
        }

        private void Load_DT()
        {
            string sql = "select * from tblsachtruyen";
            dtbl = Class.Functions.GetDataToTable(sql);
            ListDT.DataSource = dtbl;
            ListDT.Columns[0].HeaderText = "Mã sách";
            ListDT.Columns[1].HeaderText = "Tên sách";
            ListDT.Columns[2].HeaderText = "Mã loại sách";
            ListDT.Columns[3].HeaderText = "Mã lĩnh vực";
            ListDT.Columns[4].HeaderText = "Mã tác giả";
            ListDT.Columns[5].HeaderText = "Mã nhà xuất bản";
            ListDT.Columns[6].HeaderText = "Mã ngôn ngữ";
            ListDT.Columns[7].HeaderText = "Số trang";
            ListDT.Columns[8].HeaderText = "Đơn giá";
            ListDT.Columns[9].HeaderText = "Số lượng";
            ListDT.Columns[10].HeaderText = "Ảnh";
            ListDT.Columns[11].HeaderText = "Ghi chú";
            ListDT.AllowUserToAddRows = false;
            ListDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //reset values
        private void ResetValues()
        {
            cbnhaxuatban.SelectedIndex = -1;
            cbngonngu.SelectedIndex = -1;
            cbtacgia.SelectedIndex = -1;
            cbloaisach.SelectedIndex = -1;
            cblinhvuc.SelectedIndex = -1;
            txt_mas.Text = "";
            txt_tens.Text = "";
            txt_anh.Text = "";
            txt_sotrang.Text = "0";
            txt_dongia.Text = "0";
            txt_ghichu.Text = "";
            txt_soluong.Text = "0";
            picBox.Image = null;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListDT_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {

                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mas.Focus();
                return;
            }
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không có dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mas.Text = ListDT.CurrentRow.Cells["masach"].Value.ToString();
            txt_tens.Text = ListDT.CurrentRow.Cells["tensach"].Value.ToString();
            string ma1 = ListDT.CurrentRow.Cells["mals"].Value.ToString();
            cbloaisach.Text = Class.Functions.GetFieldValues("SELECT tenls FROM tblloaisach WHERE  (mals = '" + ma1 + "')");
            string ma2 = ListDT.CurrentRow.Cells["malv"].Value.ToString();
            cblinhvuc.Text = Class.Functions.GetFieldValues("SELECT tenlv FROM tbllinhvuc WHERE  (malv = '" + ma2 + "')");
            string ma3 = ListDT.CurrentRow.Cells["matg"].Value.ToString();
            cbtacgia.Text = Class.Functions.GetFieldValues("SELECT tentg FROM tbltacgia WHERE  (matg = '" + ma3 + "')");
            string ma4 = ListDT.CurrentRow.Cells["manxb"].Value.ToString();
            cbnhaxuatban.Text = Class.Functions.GetFieldValues("SELECT tennxb FROM tblnxb WHERE  (manxb = '" + ma4 + "')");
            string ma5 = ListDT.CurrentRow.Cells["mann"].Value.ToString();
            cbngonngu.Text = Class.Functions.GetFieldValues("SELECT tenn FROM tblngongu WHERE  (mann = '" + ma5 + "')");
            txt_sotrang.Text = ListDT.CurrentRow.Cells["sotranng"].Value.ToString();
            txt_dongia.Text = ListDT.CurrentRow.Cells["dongia"].Value.ToString();
            txt_anh.Text = Class.Functions.GetFieldValues("SELECT anh FROM tblsachtruyen WHERE masach = '" + txt_mas.Text + "' ");
            picBox.Image = Image.FromFile(txt_anh.Text);
            txt_soluong.Text = ListDT.CurrentRow.Cells["soluong"].Value.ToString();
            txt_ghichu.Text = ListDT.CurrentRow.Cells["ghichu"].Value.ToString();
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
            txt_mas.Enabled = true;
            txt_mas.Focus();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mas.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tens.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tens.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_anh.Focus();
                return;
            }
            if (cblinhvuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cblinhvuc.Focus();
                return;
            }
            if (cbloaisach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbloaisach.Focus();
                return;
            }
            if (cbngonngu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbngonngu.Focus();
                return;
            }
            if (cbnhaxuatban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbnhaxuatban.Focus();
                return;
            }
            if (cbtacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtacgia.Focus();
                return;
            }
            sql = "delete from tblsachtruyen where masach = '"+txt_mas.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_op_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|JPG(*.jpg)|*.jpg|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "chon anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {

                picBox.Image = Image.FromFile(dlgOpen.FileName);
                txt_anh.Text = dlgOpen.FileName;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtbl.Rows.Count == 0)
            {

                MessageBox.Show("Không còn dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mas.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tens.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tens.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_anh.Focus();
                return;
            }
            if (cblinhvuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cblinhvuc.Focus();
                return;
            }
            if (cbloaisach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbloaisach.Focus();
                return;
            }
            if (cbngonngu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbngonngu.Focus();
                return;
            }
            if (cbnhaxuatban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbnhaxuatban.Focus();
                return;
            }
            if (cbtacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtacgia.Focus();
                return;
            }
            sql = "update tblsachtruyen set tensach = '"+txt_tens.Text+"', mals = '"+cbloaisach.SelectedValue.ToString()+"', malv = '"+cblinhvuc.SelectedValue.ToString()+"',matg = '"+cbtacgia.SelectedValue.ToString()+"',manxb = '"+cbnhaxuatban.SelectedValue.ToString()+"',mann = '"+cbngonngu.SelectedValue.ToString()+"',sotranng ="+float.Parse(txt_sotrang.Text)+" ,dongia ="+float.Parse(txt_dongia.Text)+",soluong ="+float.Parse(txt_soluong.Text)+", anh = '"+txt_anh.Text+"', ghichu = '"+txt_ghichu.Text+"' where masach = '"+txt_mas.Text+"'";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_bq.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txt_mas.Text == "")
            {

                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tens.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tens.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_anh.Focus();
                return;
            }
            if (cblinhvuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cblinhvuc.Focus();
                return;
            }
            if (cbloaisach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbloaisach.Focus();
                return;
            }
            if (cbngonngu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbngonngu.Focus();
                return;
            }
            if (cbnhaxuatban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbnhaxuatban.Focus();
                return;
            }
            if (cbtacgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtacgia.Focus();
                return;
            }
            sql = "SELECT masach FROM tblsachtruyen WHERE  (masach = '" + txt_mas.Text.Trim() + "')";
            if (Class.Functions.checkKey(sql))
            {

                MessageBox.Show("Nhap truong du liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mas.Focus();
                txt_mas.Text = "";
                return;
            }
            sql = "insert into tblsachtruyen values('"+txt_mas.Text+"','"+txt_tens.Text+"','"+cbloaisach.SelectedValue.ToString()+"','"+cblinhvuc.SelectedValue.ToString()+"','"+cbtacgia.SelectedValue.ToString()+"','"+cbnhaxuatban.SelectedValue.ToString()+"','"+cbngonngu.SelectedValue.ToString()+"',"+float.Parse(txt_sotrang.Text)+" ,"+float.Parse(txt_dongia.Text)+","+float.Parse(txt_soluong.Text)+",'"+txt_anh.Text+"','"+txt_ghichu.Text+"')";
            Class.Functions.runSql(sql);
            Load_DT();
            ResetValues();
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            btn_bq.Enabled = false;
            txt_mas.Enabled = false;
        }

        private void btn_bq_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_bq.Enabled = false;
            btn_add.Enabled = true;
            btn_del.Enabled = true;
            btn_up.Enabled = true;
            btn_save.Enabled = false;
            txt_mas.Enabled = false;
        }
    }
}
