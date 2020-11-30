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
        #region Events
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }
        private void btndaangnhap_Click_1(object sender, EventArgs e)
        {
            string tk = txbTaiKhoan.TextName;
            string mk = txbMatKhau.TextName;
            bool loaitk = true;
            if (rdDocGia.Checked)
                loaitk = false;
            if (rdThuThu.Checked)
            {
                if (AccountDAO.Instance.LoginThuThu(tk, mk))
                {
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.GetTK(tk,loaitk);
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBoxCT("Sai tên tài khoản hoặc mật khẩu");
            }
            if (rdDocGia.Checked)
            {
                if (AccountDAO.Instance.LoginDocGia(tk, mk))
                {
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.GetTK(tk,loaitk);
                    frmmain.XuLyConTrolsChoDocGia();
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBoxCT("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBoxOKCancel box = new MessageBoxOKCancel();
            box.SetMessage("Bạn có muốn thoát không ?");
            this.Hide();
            if (box.ShowDialog() == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
    #endregion
}

