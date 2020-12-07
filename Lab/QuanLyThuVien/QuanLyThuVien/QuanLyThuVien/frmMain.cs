using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        string tentk = "";
        bool loaitk;
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }
        #region Methods
        
        public void XuLyConTrolsChoDocGia()
        {
            button7.Enabled = false;
            //btnqunlymuontra.Enabled = false;
            btnEqualizer.Enabled = false;
            button2.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }
        private void hideSubMenu()
        {
            panelTaikhoanSubMenu.Visible = false;
            panelQuanlydanhmucSubMenu.Visible = false;
            panelQuanlymuontraSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void GetTK(string tk, bool loaitk)
        {
            this.tentk = tk;
            this.loaitk = loaitk;
        }
        #endregion
        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxOKCancel box = new MessageBoxOKCancel();
            box.SetMessage("Bạn có muốn đăng xuất không ?");
            if (box.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
        #region Menu
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTaikhoanSubMenu);
        }

        #region Taikhoansubmenu
        private void button2_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.UnEnableUpdate();
            openChildForm(frm);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.GetTK(this.tentk,loaitk);
            frm.UnEnableTK();
            openChildForm(frm);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.GetTK(this.tentk,loaitk);
            openChildForm(frm);
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnQuanlydanhmuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanlydanhmucSubMenu);
        }
        #region Quanlydanhmucsubmenu
        private void button8_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            frm.GetTK(tentk);
            openChildForm(frm);
            hideSubMenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyDocGia());
            hideSubMenu();
        }
        private void btndsquahan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDanhSachQuaHan());
            hideSubMenu();
        }


        #endregion

        private void btnqunlymuontra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanlymuontraSubMenu);
        }
        #region quanlymuontrasubmenu
        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyMuonSach());
            hideSubMenu();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyTraSach());
            hideSubMenu();
        }
        private void btndsquahan_Click_1(object sender, EventArgs e)
        {
            frmDanhSachQuaHan frm = new frmDanhSachQuaHan();
            frm.GetTK(this.tentk,loaitk);
            openChildForm(frm);
            hideSubMenu();
        }

        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());

            hideSubMenu();
        }


        #endregion
    }
}
