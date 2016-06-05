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
    public partial class MonHoc : Form
    {
        QuanLySinhVien.WebServiceDemo.Service1 bien;
        public MonHoc()
        {
            bien = new WebServiceDemo.Service1();
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            LoadDuLieu();
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtSoTiet.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            bien.myClose();
            this.Close();

        }
        public void LoadDuLieu()

        {
            dataGridViewMonHoc.DataSource = bien.TaoBangMonHoc("MONHOC");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dataGridViewMonHoc.DataSource;
            chiso = dataGridViewMonHoc.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtMaMH.Text = hang["mamh"].ToString();
            txtTenMH.Text = hang["tenmh"].ToString();
            txtSoTiet.Text = hang["sotiet"].ToString();

        }
        int flag, sotiet;

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtSoTiet.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            LoadDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
              flag = 1;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = true;
            txtSoTiet.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            LoadDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bien.MonHoc_Xoa(txtMaMH.Text);
            txtMaMH.ResetText();
            txtSoTiet.ResetText();
            txtTenMH.ResetText();
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled =false;
            txtSoTiet.Enabled = false;

            if (flag == 0)
            {
                sotiet = Convert.ToInt32(txtSoTiet.Text);
                bien.MonHoc_Them(txtMaMH.Text, txtTenMH.Text,sotiet);
                txtMaMH.ResetText();
                txtSoTiet.ResetText();
                txtTenMH.ResetText();
                txtMaMH.Focus();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                LoadDuLieu();
            }

            else if(flag ==1)
            {
                sotiet = Convert.ToInt32(txtSoTiet.Text);
                bien.MonHoc_Sua(txtMaMH.Text, txtTenMH.Text, sotiet);
                txtMaMH.ResetText();
                txtSoTiet.ResetText();
                txtTenMH.ResetText();
                txtMaMH.Focus();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                LoadDuLieu();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtSoTiet.Enabled = false;
            txtMaMH.ResetText();
            txtSoTiet.ResetText();
            txtTenMH.ResetText();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            LoadDuLieu();
        }

        private void btnTKMonhoc_Click(object sender, EventArgs e)
        {
            frmThongKeMonHoc monhoc = new frmThongKeMonHoc();
            monhoc.Show();
        }
        
    }
}
