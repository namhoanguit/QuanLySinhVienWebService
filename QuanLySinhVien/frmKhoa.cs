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
    public partial class frmKhoa : Form
    {
        QuanLySinhVien.QLSinhVien.Service1SoapClient bien;
        public frmKhoa()
        {
            bien = new QLSinhVien.Service1SoapClient();
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            bien.myconnect();
            dataGridViewKhoa.DataSource = bien.TaoBangKhoa("KHOA");
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            bien.myconnect();
            LoadDuLieu();
            LoadDuLieu();
            txtTong.Text = (dataGridViewKhoa.RowCount).ToString();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            txtTong.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            bien.myClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dataGridViewKhoa.DataSource;
            chiso = dataGridViewKhoa.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];

            txtMaKhoa.Text = hang["makhoa"].ToString();
            txtTenKhoa.Text = hang["tenkhoa"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            txtMaKhoa.Focus();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = true;
            txtTong.Enabled = true;
        }

        int flag;

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
        

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bien.Khoa_Xoa(txtMaKhoa.Text);
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            if(flag == 0)
            {
                bien.Khoa_Them(txtMaKhoa.Text, txtTenKhoa.Text);
                txtMaKhoa.ResetText();
                txtTenKhoa.ResetText();
                txtMaKhoa.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnSua.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadDuLieu();

            }
            else if (flag ==1 )
            {
                bien.Khoa_Sua(txtMaKhoa.Text,txtTenKhoa.Text);
                txtMaKhoa.ResetText();
                txtTenKhoa.ResetText();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                LoadDuLieu();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThongKeSVTheoKhoa frmKhoa = new frmThongKeSVTheoKhoa();
            frmKhoa.Show();
        }


        
    }
}
