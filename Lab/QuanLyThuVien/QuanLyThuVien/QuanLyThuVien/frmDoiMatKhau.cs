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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
         
          
        }
        
        public void GetTK(string tk)
        {
            txbtaikhoan.Text = tk;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txbtaikhoan.Text.Contains("docgia"))
            {
                if (txbMatKhauMoi.Text == txbNhapLaiMatKhau.Text)
                {
                    if (DocGiaDAO.Instance.DoiMK(txbtaikhoan.Text, txbNhapLaiMatKhau.Text, txbMatKhauCu.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else MessageBox.Show("Mật khẩu cũ không đúng!");
                }
                else MessageBox.Show("Nhập lại mật khẩu không đúng!");
            }
            else
            {
                if (txbMatKhauMoi.Text == txbNhapLaiMatKhau.Text)
                {
                    if (AccountDAO.Instance.DoiMK(txbtaikhoan.Text, txbNhapLaiMatKhau.Text, txbMatKhauCu.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else MessageBox.Show("Mật khẩu cũ không đúng!");
                }
                else MessageBox.Show("Nhập lại mật khẩu không đúng!");
            }
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
