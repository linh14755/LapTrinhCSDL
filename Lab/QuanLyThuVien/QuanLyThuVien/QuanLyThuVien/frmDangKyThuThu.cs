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
    public partial class frmDangKy : Form
    {
        string tk;
        public frmDangKy()
        {
            InitializeComponent();
            Setbackground();
        }

        private void Setbackground()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            rdNam.BackColor = Color.Transparent;
            rdNu.BackColor = Color.Transparent;
        }


        #region Methods

        public void ThietLapControls(Account acc)
        {
            txbHoTen.Text = acc.ten;
            dtpkNgaySinh.Value = acc.ngaysinh;
            rdNam.Checked = true;
            if (acc.gioitinh == false) //nu
                rdNu.Checked = true;
            txbSoDT.Text = acc.sdt;
            txbDiaChi.Text = acc.diachi;
            txbEmail.Text = acc.email;
            txbTaiKhoan.Text = acc.taikhoan;
            txbMatKhau.Text = acc.matkau;
        }
        public Account GetConTrols()
        {
            Account ac = new Account();
            ac.ten = txbHoTen.Text;
            ac.ngaysinh = dtpkNgaySinh.Value;
            ac.gioitinh = true;
            if (rdNu.Checked)
                ac.gioitinh = false;
            ac.sdt = txbSoDT.Text;
            ac.diachi = txbDiaChi.Text;
            ac.email = txbEmail.Text;
            ac.taikhoan = txbTaiKhoan.Text;
            ac.matkau = txbMatKhau.Text;
            return ac;
        }
        public void GetTK(string tk)
        {
            this.tk = tk;
            List<Account> lst = AccountDAO.Instance.GetListAccountByTK(this.tk);
            foreach (var item in lst)
            {
                ThietLapControls(item);
                this.Text = "Cập nhật thông tin thủ thư";
            }
        }
        public void UnEnableUpdate()
        {
            btnupdate.Enabled = false;
        }
        public void UnEnableTK()
        {
            btnDangKy.Enabled = false;
            txbTaiKhoan.ReadOnly = true;
            txbMatKhau.ReadOnly = true;
            txbNhapLaiMK.ReadOnly = true;
        }
        public bool KiemTraThongTin()
        {
            if (txbHoTen.Text != "" &&
                txbSoDT.Text != "" &&
                txbDiaChi.Text != "" &&
                txbEmail.Text != "" &&
                txbTaiKhoan.Text != "" &&
                txbMatKhau.Text != "" &&
                txbNhapLaiMK.Text != "")
                return true;
            return false;
        }


        #endregion

        #region Events
        private void btnupdate_Click(object sender, EventArgs e)
        {
            var ac = GetConTrols();
            if (AccountDAO.Instance.UpdateAccount(ac))
            {
                MessageBox.Show("Sửa thành công");
                ThietLapControls(ac);
            }
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                if (txbMatKhau.Text == txbNhapLaiMK.Text)
                {
                    if (AccountDAO.Instance.KiemTraTaiKhoan(txbTaiKhoan.Text))
                    {
                        Account ac = new Account();
                        ac.ten = txbHoTen.Text;
                        ac.ngaysinh = dtpkNgaySinh.Value;
                        ac.gioitinh = true;
                        if (rdNu.Checked)
                            ac.gioitinh = false;
                        ac.sdt = txbSoDT.Text;
                        ac.diachi = txbDiaChi.Text;
                        ac.email = txbEmail.Text;
                        ac.taikhoan = txbTaiKhoan.Text;
                        ac.matkau = txbMatKhau.Text;

                        AccountDAO.Instance.InsertAccount(ac);
                        MessageBox.Show("Đăng Ký Thành Công");
                        this.Close();
                    }
                    else MessageBox.Show("Tài khoản dã tồn tại");
                }
                else MessageBox.Show("Nhập lại mật khẩu không đúng");

            }
            else MessageBox.Show("Bạn phải điền đầy đủ thông tin");
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
