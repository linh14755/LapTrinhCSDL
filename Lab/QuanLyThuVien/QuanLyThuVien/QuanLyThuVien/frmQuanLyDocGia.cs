using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
            LoadDanhSach();
            Setbackground();
        }
        public void Setbackground()
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            groupBox5.BackColor = Color.Transparent;
        }
        public void LoadDanhSach()
        {
            dataGridView1.DataSource = DocGiaDAO.Instance.GettAll();
        }


        #region Events

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text != "" && txbMatKhau.Text != "" && txbHoTen.Text != "" && txbLop.Text != "" && txbDiaChi.Text != "" && txbEmail.Text != "")
            {
                DocGia dg = new DocGia();
                dg.taikhoan = txbTaiKhoan.Text;
                dg.matkau = txbMatKhau.Text;
                dg.hoten = txbHoTen.Text;
                dg.ngaysinh = dtpkNgaySinh.Value;
                dg.gioitinh = true;
                if (rdNu.Checked)
                    dg.gioitinh = false;
                dg.lop = txbLop.Text;
                dg.diachi = txbDiaChi.Text;
                dg.email = txbEmail.Text;
                dg.ghichu = txbGhiChu.Text;

                DocGiaDAO.Instance.DangKyDocGia(dg);
                MessageBox.Show("Thêm Đọc Giả thành Công !");
                LoadDanhSach();
            }
            else
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !");

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
