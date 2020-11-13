using QuanLyThuVien.DAO;
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
        }

        public void LoadDanhSach()
        {
            string query = @"select * from  DocGia";
            dataGridView1.DataSource = DataProvider.instance.ExcuteQuery(query);
        }


        #region Events

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text != "" && txbMatKhau.Text != "" && txbHoTen.Text != "" && txbLop.Text != "" && txbDiaChi.Text != "" && txbEmail.Text != "")
            {
                string gt = "Nam";
                if (rdNu.Checked)
                    gt = "Nữ";
                DocGiaDAO.Instance.DangKyDocGia(txbTaiKhoan.Text, txbMatKhau.Text, txbHoTen.Text, dtpkNgaySinh.Value.ToString(), gt, txbLop.Text, txbDiaChi.Text, txbEmail.Text, txbGhiChu.Text);
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
