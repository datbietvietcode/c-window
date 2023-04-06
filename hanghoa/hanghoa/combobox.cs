using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hanghoa
{
    public partial class combobox : Form
    {
        public combobox()
        {
            InitializeComponent();
        }

        private void combobox_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Class.Functions.FillCombo("SELECT mannv, tennv FROM tbnv", cbnv, "mannv", "mannv");
            Class.Functions.FillCombo("SELECT masp, manv, tensp FROM tblsp WHERE manv = '"+cbnv.Text+"'",cbsp,"masp","masp");
            
                   
        }
        private void cbSanpham(object sender, EventArgs e)
        {
            string s = "";
            if(cbsp.Text == ""){
                txt_tenb.Text = "";
                s = "SELECT tensp FROM  tblsp where masp = '"+cbsp.SelectedValue.ToString()+"'";
                txt_tenb.Text = Class.Functions.GetFieldValues(s);
            }
        }
    }
}
