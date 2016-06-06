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
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien.QLSinhVien.Service1SoapClient bien;
        public frmSinhVien()
        {
            bien = new QLSinhVien.Service1SoapClient();
            InitializeComponent();
       }
        public void LoadDuLieu()
        {
            dataGridView1.DataSource = bien.taobang("SINHVIEN");
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            LoadDuLieu();
            txtMaSV.Enabled = false;
            txtHoSv.Enabled = false;
            txtTenSv.Enabled = false;
            txtGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            txtMaKhoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dataGridView1.DataSource;
            chiso = dataGridView1.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtGioiTinh.Text = hang["gioitinh"].ToString();
            txtHoSv.Text = hang["hosv"].ToString();
            txtMaSV.Text = hang["masv"].ToString();
            txtMaKhoa.Text = hang["makhoa"].ToString();
            txtHoSv.Text = hang["hosv"].ToString();
            dateNgaySinh.Value = Convert.ToDateTime(hang["ngaysinh"].ToString());
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            txtMaSV.Enabled = true;
            txtHoSv.Enabled = true;
            txtTenSv.Enabled = true;
            txtGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtMaKhoa.Enabled = true;

            txtMaSV.ResetText();
            txtMaKhoa.ResetText();
            txtGioiTinh.ResetText();
            txtHoSv.ResetText();
            txtTenSv.ResetText();
            dateNgaySinh.ResetText();
            txtMaSV.Focus();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaSV.Enabled = false;
            txtHoSv.Enabled = true;
            txtTenSv.Enabled = true;
            txtGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtMaKhoa.Enabled = true;

            txtMaSV.ResetText();
            txtMaKhoa.ResetText();
            txtGioiTinh.ResetText();
            txtHoSv.ResetText();
            txtTenSv.ResetText();
            dateNgaySinh.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bien.SinhVien_Xoa(txtMaSV.Text);
                LoadDuLieu();


                txtMaSV.ResetText();
                txtMaKhoa.ResetText();
                txtGioiTinh.ResetText();
                txtHoSv.ResetText();
                txtTenSv.ResetText();
                dateNgaySinh.ResetText();
                txtMaSV.Focus();

            }
            catch(Exception)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu xóa");
            }
            bien.myClose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = false;
            txtHoSv.Enabled = false;
            txtTenSv.Enabled = false;
            txtGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;

            if(flag==0)
            {
                try
                {
                    DateTime NgaySinh = dateNgaySinh.Value;
                    bien.SinhVien_Them(txtMaSV.Text, txtHoSv.Text, txtTenSv.Text, txtGioiTinh.Text, NgaySinh, txtMaKhoa.Text);
                    LoadDuLieu();
                    txtMaSV.ResetText();
                    txtMaKhoa.ResetText();
                    txtGioiTinh.ResetText();
                    txtHoSv.ResetText();
                    txtTenSv.ResetText();
                    dateNgaySinh.ResetText();
                    txtMaSV.Focus();

                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã sinh viên đã có , vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bien.myClose();
            }
            else if(flag==1)
            {

                DataTable dt = new DataTable();       
                DateTime NgaySinh = dateNgaySinh.Value;
                bien.SinhVien_Sua(txtMaSV.Text, txtHoSv.Text, txtTenSv.Text, NgaySinh,txtGioiTinh.Text, txtMaKhoa.Text);
                LoadDuLieu();
                txtMaSV.ResetText();
                txtMaKhoa.ResetText();
                txtGioiTinh.ResetText();
                txtHoSv.ResetText();
                txtTenSv.ResetText();
                dateNgaySinh.ResetText();
                txtMaSV.Focus();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                LoadDuLieu();
                bien.myClose();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.ResetText();
            txtMaKhoa.ResetText();
            txtGioiTinh.ResetText();
            txtHoSv.ResetText();
            txtTenSv.ResetText();
            dateNgaySinh.ResetText();
            txtMaSV.Focus();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnSua.Enabled = true ;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
