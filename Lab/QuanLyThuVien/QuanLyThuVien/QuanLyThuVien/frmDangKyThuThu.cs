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
        bool loaitk;
        public frmDangKy()
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

        public void ThietLapControlsDG(DocGia d)
        {
            txbHoTen.Text = d.hoten;
            dtpkNgaySinh.Value = d.ngaysinh;
            rdNam.Checked = true;
            if (d.gioitinh == false) //nu
                rdNu.Checked = true;
            txbSoDT.Text = d.sodt;
            txbDiaChi.Text = d.diachi;
            txbEmail.Text = d.email;
            txbTaiKhoan.Text = d.taikhoan;
            txbMatKhau.Text = d.matkhau;
        }
        public DocGia GetConTrolsDG()
        {
            DocGia ac = new DocGia();
            ac.hoten = txbHoTen.Text;
            ac.ngaysinh = dtpkNgaySinh.Value;
            ac.gioitinh = true;
            if (rdNu.Checked)
                ac.gioitinh = false;
            ac.sodt = txbSoDT.Text;
            ac.diachi = txbDiaChi.Text;
            ac.email = txbEmail.Text;
            ac.taikhoan = txbTaiKhoan.Text;
            ac.matkhau = txbMatKhau.Text;
            return ac;
        }

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
        public void GetTK(string tk, bool loaitk)
        {
            this.tk = tk;
            this.loaitk = loaitk;
            //loaitk = true ->> thu thu = false docgia
            if (!loaitk)
            {
                List<DocGia> lst = DocGiaDAO.Instance.GetListByTK(this.tk);

                ThietLapControlsDG(lst[0]);
                this.Text = "Cập nhật thông tin";
            }
            else
            {
                List<Account> lst = AccountDAO.Instance.GetListByTK(this.tk);

                ThietLapControls(lst[0]);
                this.Text = "Cập nhật thông tin";
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

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (!loaitk)
            {
                var dg = GetConTrolsDG();
                if (DocGiaDAO.Instance.UpdateDocGia(dg))
                {
                    MessageBoxCT("Sửa thành công");
                    ThietLapControlsDG(dg);
                }
            }
            else
            {
                var ac = GetConTrols();
                if (AccountDAO.Instance.Update(ac))
                {
                    MessageBoxCT("Sửa thành công");
                    ThietLapControls(ac);
                }
            }
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
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

                        AccountDAO.Instance.Insert(ac);
                        MessageBoxCT("Đăng Ký Thành Công");
                        this.Close();
                    }
                    else MessageBoxCT("Tài khoản dã tồn tại");
                }
                else MessageBoxCT("Nhập lại mật khẩu không đúng");

            }
            else MessageBoxCT("Bạn phải điền đầy đủ thông tin");
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


    }
}
