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
        bool loaitk;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        #region Methods
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }

        public void GetTK(string tk,bool loaitk)
        {
            txbtaikhoan.Text = tk;
            this.loaitk = loaitk;
        }
        #endregion
        #region Events
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            if (!loaitk)
            {
                if (txbMatKhauMoi.Text == txbNhapLaiMatKhau.Text)
                {
                    if (DocGiaDAO.Instance.DoiMK(txbtaikhoan.Text, txbNhapLaiMatKhau.Text, txbMatKhauCu.Text))
                    {
                        MessageBoxCT("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else MessageBoxCT("Mật khẩu cũ không đúng!");
                }
                else MessageBoxCT("Nhập lại mật khẩu không đúng!");
            }
            else
            {
                if (txbMatKhauMoi.Text == txbNhapLaiMatKhau.Text)
                {
                    if (AccountDAO.Instance.DoiMK(txbtaikhoan.Text, txbNhapLaiMatKhau.Text, txbMatKhauCu.Text))
                    {
                        MessageBoxCT("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                    else MessageBoxCT("Mật khẩu cũ không đúng!");
                }
                else MessageBoxCT("Nhập lại mật khẩu không đúng!");
            }
        }
        #endregion

        
    }
}
