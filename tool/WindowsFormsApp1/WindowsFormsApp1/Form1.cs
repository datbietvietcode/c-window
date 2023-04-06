using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textCMD;
            textCMD = "/C " + txt_cmd.Text;
            Process.Start("CMD.exe",textCMD);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";
            String textCMD;
            textCMD = "/C " + txt_cmd.Text;
            p.StartInfo.Arguments = textCMD;
            p.Start();
        }
    }
}
