using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien qlsv = new QuanLySinhVien();
        public frmTuyChon()
        {
            InitializeComponent();
        }
        #region Methods

        #endregion

        #region Events
        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMa.Checked)
                label1.Text = "Tìm Theo Mã";
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
                label1.Text = "Tìm Theo Họ Tên";
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgaySinh.Checked)
                label1.Text = "Tìm Theo Ngày Sinh";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var kieutim = KieuTim.TheoMa;
            if (rdHoTen.Checked)
                kieutim = KieuTim.TheoTen;
            if (rdNgaySinh.Checked)
                kieutim = KieuTim.TheoNgaySinh;
            SinhVien kq = qlsv.TimKiem(txbTim.Text, kieutim);
            if (kq == null)
                MessageBox.Show("Khong tim thay");
            else
                MessageBox.Show("tim thay");
        }

        #endregion


    }
}
