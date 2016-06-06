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
    public partial class frmThongKeSVTheoKhoa : Form
    {
        QuanLySinhVien.QLSinhVien.Service1SoapClient bien;
        public frmThongKeSVTheoKhoa()
        {
            bien = new QLSinhVien.Service1SoapClient();
            InitializeComponent();
        }

        private void frmThongKeSVTheoKhoa_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            cbMakhoa.DataSource = bien.TaoBangKhoa("KHOA");
            cbMakhoa.DisplayMember = "MAKHOA";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void cbMakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load dữ liệu từ combobox xuống textbox
            DataTable d = bien.Khoa_TimTheoMaKhoa(cbMakhoa.Text);
            foreach (DataRow hang in d.Rows)
                txtTenKhoa.Text = hang["TENKHOA"].ToString();

            //load dữ liệu lên DataGrid
            dataGridViewTKSV.DataSource = bien.TaoBangTKKhoa(cbMakhoa.Text);
            txtTongSV.Text = (dataGridViewTKSV.Rows.Count).ToString();

        }
    }
}
