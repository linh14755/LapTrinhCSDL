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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        #region Methods
        public bool LoginThuThu(string acc, string pass)
        {
            return AccountDAO.Instance.LoginAdmin(acc, pass);
        }
        public bool LoginDocGia(string acc, string pass)
        {
            return DocGiaDAO.Instance.LoginDocgia(acc, pass);
        }

        #endregion

        #region Events

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txbTaiKhoan.Text;
            string mk = txbMatKhau.Text;
            if (rdThuThu.Checked)
            {
                if (LoginThuThu(tk, mk))
                {
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            if (rdDocGia.Checked)
            {
                if (LoginDocGia(tk,mk))
                {
                    frmDocGia frmdg = new frmDocGia();
                    this.Hide();
                    frmdg.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

    }
}
