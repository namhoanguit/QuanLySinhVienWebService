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
    public partial class frmThongKeMonHoc : Form
    {
        QuanLySinhVien.WebServiceDemo.Service1 bien;
        public frmThongKeMonHoc()
        {
            bien = new WebServiceDemo.Service1();
            InitializeComponent();
        }

        private void frmThongKeMonHoc_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            cmbMaMH.DataSource = bien.TaoBangMonHoc("MONHOC");
            cmbMaMH.DisplayMember = "MAMH";
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable d = bien.MONHOC_TimTheoMaMH(cmbMaMH.Text);
            foreach (DataRow hang in d.Rows)
                txtTenMH.Text = hang["TENMH"].ToString();
            foreach (DataRow hang in d.Rows)
                txtTenMH.Text = hang["SOTIET"].ToString();
        }
    }
}
