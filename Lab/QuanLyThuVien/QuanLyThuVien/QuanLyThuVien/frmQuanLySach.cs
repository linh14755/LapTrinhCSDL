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
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        #region MEthods
        public void LoadDanhSach()
        {
            string query = @"select* from  TaiKhoan";
            dgvSach.DataSource = DataProVider.instance.ExcuteQuery(query);
        }
        #endregion

        #region Events
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
