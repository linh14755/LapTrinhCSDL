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
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
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

        public void GetTK(string tk)
        {
            tentk = tk;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            frm.GetTK(this.tentk);
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
            frm.GetTK(this.tentk);
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
            openChildForm(new frmQuanLySach());
            hideSubMenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyDocGia());
            hideSubMenu();
        }


        #endregion

        private void btnqunlymuontra_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyMuonTra());
            hideSubMenu();
        }
    }
}
