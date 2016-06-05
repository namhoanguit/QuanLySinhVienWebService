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
    public partial class frmKetQua : Form
    {
        QuanLySinhVien.WebServiceDemo.Service1 bien;
        public frmKetQua()
        {
            bien = new WebServiceDemo.Service1();
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            dataGridViewKetQua.DataSource = bien.TaoBangKQ("KETQUATHI");
        }
        private void frmKetQua_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            LoadDuLieu();
            txtMaSV.Enabled = false;
            txtMaMH.Enabled = false;
            txtLanThi.Enabled = false;
            txtDiem.Enabled = false;

            btnLuu.Enabled = false;
            btnHUy.Enabled = false;

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bien.KetQua_Xoa(txtMaSV.Text);
            txtMaSV.Enabled = false;
            txtMaMH.Enabled = false;
            txtLanThi.Enabled = false;
            txtDiem.Enabled = false;

            txtDiem.ResetText();
            txtLanThi.ResetText();
            txtMaMH.ResetText();
            txtMaSV.ResetText();
            txtMaSV.Focus();
            LoadDuLieu();
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            btnLuu.Enabled = false;
            btnHUy.Enabled = false;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            txtMaSV.Enabled = false;
            txtMaMH.Enabled = false;
            txtLanThi.Enabled = false;
            txtDiem.Enabled = false;

            LoadDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnLuu.Enabled = true;
            btnHUy.Enabled = true;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            txtMaSV.Enabled = true;
            txtMaMH.Enabled = true;
            txtLanThi.Enabled = true;
            txtDiem.Enabled = true;

            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag ==0)
            {
                int lanthi = Convert.ToInt32(txtLanThi.Text);
                int diem = Convert.ToInt32(txtDiem.Text);

                bien.KetQua_Them(txtMaSV.Text, txtMaMH.Text, lanthi, diem);
                txtDiem.ResetText();
                txtLanThi.ResetText();
                txtMaMH.ResetText();
                txtMaSV.ResetText();
                txtMaSV.Focus();
                btnLuu.Enabled = false;
                btnHUy.Enabled = false;

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadDuLieu();
            }
            else if(flag==1)
            {
                int lanthi = Convert.ToInt32(txtLanThi.Text);
                int diem = Convert.ToInt32(txtDiem.Text);

                bien.KetQua_Sua(txtMaSV.Text, txtMaMH.Text, lanthi, diem);
                txtDiem.ResetText();
                txtLanThi.ResetText();
                txtMaMH.ResetText();
                txtMaSV.ResetText();
                txtMaSV.Focus();
                btnLuu.Enabled = false;
                btnHUy.Enabled = false;

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadDuLieu();
            }
        }

        private void btnTKLanThi_Click(object sender, EventArgs e)
        {
            frmThongKeLanThi lanthi = new frmThongKeLanThi();
            lanthi.Show();
        }
    }
}
