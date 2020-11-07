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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach frmsach = new frmQuanLySach();
            frmsach.ShowDialog();
        }

        private void quảnLýĐọcGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia frmdocgia = new frmQuanLyDocGia();
            frmdocgia.ShowDialog();
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMuonTra frmmuontra = new frmQuanLyMuonTra();
            frmmuontra.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmdangky = new frmDangKy();
            frmdangky.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmdoimk = new frmDoiMatKhau();
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
            frmthongke.ShowDialog();
        }
    }
}
