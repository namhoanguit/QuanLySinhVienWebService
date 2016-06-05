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
    public partial class frmTimKiemThongTinSV : Form
    {
        QuanLySinhVien.WebServiceDemo.Service1 bien;
        public frmTimKiemThongTinSV()
        {
            bien = new WebServiceDemo.Service1();
            InitializeComponent();
        }

        private void frmTimKiemThongTinSV_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            cmbMaSV.DataSource = bien.taobang("SINHVIEN");
            cmbMaSV.DisplayMember = "MASV";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable d = bien.TimKiem_ThongTinSV(cmbMaSV.Text);
            foreach (DataRow hang in d.Rows)
                txtHoTen.Text = hang["ngaysinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtHoTen.Text = hang["hoten"].ToString();
            foreach (DataRow hang in d.Rows)
                txtHoTen.Text = hang["gioitinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtHoTen.Text = hang["makhoa"].ToString();
            dataGridViewTim.DataSource = bien.TimKiem_ThongTinSVGridView(cmbMaSV.Text);

        }
    }
}
