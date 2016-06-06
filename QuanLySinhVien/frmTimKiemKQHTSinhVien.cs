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
    public partial class frmTimKiemKQHTSinhVien : Form
    {
        QuanLySinhVien.QLSinhVien.Service1SoapClient bien;
        public frmTimKiemKQHTSinhVien()
        {
            bien = new QLSinhVien.Service1SoapClient();
            InitializeComponent();
        }

        private void frmTimKiemKQHTSinhVien_Load(object sender, EventArgs e)
        {
            bien.myconnect();

            cmbMaSV.DataSource = bien.taobang("SINHVIEN");
            cmbMaSV.DisplayMember = "MASV";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable d = bien.TimKiem_ThongTinSV(cmbMaSV.Text);
            foreach (DataRow hang in d.Rows)
                txtNgaySinh.Text = hang["ngaysinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtHoTenSv.Text = hang["hoten"].ToString();
            foreach (DataRow hang in d.Rows)
                txtGioiTinh.Text = hang["gioitinh"].ToString();
            foreach (DataRow hang in d.Rows)
                txtMaKhoa.Text = hang["makhoa"].ToString();

            DataTable c = bien.TimKiem_DiemTrungBinh(cmbMaSV.Text);
            foreach (DataRow hang in c.Rows)
               txtDiemTB.Text = hang["diem"].ToString().Substring(0, 3);
            dataGridViewTim.DataSource = bien.TimKiem_ThongTinSVGridView(cmbMaSV.Text);
        }
    }
}
