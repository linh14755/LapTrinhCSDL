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
            Setbackground();
        }
        public void Setbackground()
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
        }
        public void SetTK(string tk)
        {
            txbTaiKhoan.Text = tk;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txbMatKhauMoi.Text == txbNhapLaiMatKhau.Text)
            {
                if (AccountDAO.Instance.DoiMK(txbTaiKhoan.Text, txbNhapLaiMatKhau.Text,txbMatKhauCu.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else MessageBox.Show("Mật khẩu cũ không đúng!");
            }
            else MessageBox.Show("Nhập lại mật khẩu không đúng!");
        }
    }
}
