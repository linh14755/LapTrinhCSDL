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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            rdNgayMuon.Checked = true;
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            Loads();
        }
        private void Loads()
        {
            dataGridView1.DataSource = MuonTraDAO.instance.GetDSDaTra();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            List<MuonSach> l = new List<MuonSach>();
            if (rdNgayMuon.Checked) l = MuonTraDAO.instance.GetDSMuonTraByNgayMuon(dtpFromDate.Value, dtpToDate.Value);
            if (rdNgayTra.Checked) l = MuonTraDAO.instance.GetDSMuonTraByNgayTra(dtpFromDate.Value, dtpToDate.Value);
            dataGridView1.DataSource = l;
        }

    }
}
