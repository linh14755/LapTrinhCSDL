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
        string tentk ="";
        Image backgroundblue = new Bitmap(@"D:\LapTrinhCSDL\Lab\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Resources\background3.jpg");
        Image backgroundblack = new Bitmap(@"D:\LapTrinhCSDL\Lab\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Resources\backgroundblack.jpg");
        Image backgroundwhite = new Bitmap(@"D:\LapTrinhCSDL\Lab\QuanLyThuVien\QuanLyThuVien\QuanLyThuVien\Resources\backgroundwhite.jpg");
        public frmMain()
        {
            InitializeComponent();
            Setbackground();
        }

        private void Setbackground()
        {
            this.BackgroundImage = backgroundwhite;
            label1.BackColor = Color.Transparent;
            menuStrip1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }

        public void GetTK(string tk)
        {
            tentk = tk;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach frmsach = new frmQuanLySach();
            frmsach.BackgroundImage = this.BackgroundImage;
            frmsach.ShowDialog();
        }

        private void quảnLýĐọcGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia frmdocgia = new frmQuanLyDocGia();
            frmdocgia.BackgroundImage = this.BackgroundImage;
            frmdocgia.ShowDialog();
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMuonTra frmmuontra = new frmQuanLyMuonTra();
            frmmuontra.BackgroundImage = this.BackgroundImage;
            frmmuontra.Setbackground(this.BackgroundImage);
            frmmuontra.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmdangky = new frmDangKy();
            frmdangky.UnEnableTK();
            frmdangky.GetTK(tentk);
            frmdangky.BackgroundImage = this.BackgroundImage;
            frmdangky.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmdangky = new frmDangKy();
            frmdangky.UnEnableUpdate();
            frmdangky.BackgroundImage = this.BackgroundImage;
            frmdangky.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmdoimk = new frmDoiMatKhau();
            frmdoimk.BackgroundImage = this.BackgroundImage;
            frmdoimk.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn đăng xuất ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frmthongke = new frmThongKe();
            frmthongke.BackgroundImage = this.BackgroundImage;
            frmthongke.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachTaiKhoan frmdstk = new frmDanhSachTaiKhoan();
            frmdstk.BackgroundImage = this.BackgroundImage;
            frmdstk.ShowDialog();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = backgroundwhite;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = backgroundblack;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = backgroundblue;
        }

        private void đổiMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.SetTK(tentk);
            frm.BackgroundImage = this.BackgroundImage;
            frm.ShowDialog();
        }

        
    }
}
