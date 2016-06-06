using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmThongKeLanThi : Form
    {
        QuanLySinhVien.QLSinhVien.Service1SoapClient bien;
        public frmThongKeLanThi()
        {
            bien = new QLSinhVien.Service1SoapClient();
            InitializeComponent();
        }

        private void frmThongKeLanThi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int i = 1;
            dataGridViewLT.DataSource = bien.TaoBangTKLanThi(i.ToString());
            txtTong.Text = (dataGridViewLT.Rows.Count).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            int i = 1;
            dataGridViewLT.DataSource = bien.TaoBangTKLanThi(i.ToString());
            txtTong.Text = (dataGridViewLT.Rows.Count).ToString();
        }
        
    }
}
