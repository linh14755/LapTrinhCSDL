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

        private void btndaangnhap_Click(object sender, EventArgs e)
        {
            string tk = txbTaiKhoan.TextName;
            string mk = txbMatKhau.TextName;
            if (rdThuThu.Checked)
            {
                if (AccountDAO.Instance.LoginThuThu(tk, mk))
                {
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.GetTK(tk);
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            if (rdDocGia.Checked)
            {
                if (AccountDAO.Instance.LoginDocGia(tk, mk))
                {
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.GetTK(tk);
                    frmmain.XuLyConTrolsChoDocGia();
                    frmmain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
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

