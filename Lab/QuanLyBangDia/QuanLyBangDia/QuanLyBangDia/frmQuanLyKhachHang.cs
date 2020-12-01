using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DAO;
using DataAccess.DTO;

namespace QuanLyBangDia
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            Loads();
            rdMaKH.Checked = true;
        }
        #region Methods
        private void Loads()
        {
            LoadListView(KhachHangDAO.instance.GetList());
        }
        public void LoadListView(List<KhachHang> l)
        {
            lvKhachHang.Items.Clear();
            foreach (var k in l)
            {
                ListViewItem lvitem = new ListViewItem(k.makh);
                lvitem.SubItems.Add(k.tenkh);
                lvitem.SubItems.Add(k.sodt);
                lvitem.SubItems.Add(k.diachi);

                lvKhachHang.Items.Add(lvitem);
            }
        }
        public void LoadControls(KhachHang k)
        {
            txbMaKH.Text = k.makh;
            txbTenKH.Text = k.tenkh;
            txbSDT.Text = k.sodt;
            txbDiaChi.Text = k.diachi;
        }
        public KhachHang GetControls()
        {
            KhachHang k = new KhachHang();
            
            if (string.IsNullOrEmpty(txbMaKH.Text)) k.makh = "0";
            else k.makh = txbMaKH.Text;

            if (string.IsNullOrEmpty(txbTenKH.Text)) k.tenkh = "trống";
            else k.tenkh = txbTenKH.Text;

            if (string.IsNullOrEmpty(txbSDT.Text)) k.sodt = "trống";
            else k.sodt = txbSDT.Text;

            if (string.IsNullOrEmpty(txbDiaChi.Text)) k.diachi = "trống";
            else k.diachi = txbDiaChi.Text;

            return k;
        }
        public bool KTKytuDacBiet(string kt)
        {
            if (kt.Contains("~") ||
                kt.Contains("!") ||
                kt.Contains("@") ||
                kt.Contains("#") ||
                kt.Contains("$") ||
                kt.Contains("%") ||
                kt.Contains("^") ||
                kt.Contains("&") ||
                kt.Contains("*") ||
                kt.Contains("(") ||
                kt.Contains(")") ||
                kt.Contains("-") ||
                kt.Contains("=") ||
                kt.Contains("`") ||
                kt.Contains("?") ||
                kt.Contains("/") ||
                kt.Contains(".") ||
                kt.Contains(",") ||
                kt.Contains("<") ||
                kt.Contains(">")
                )
                return false;
            return true;
        }
        public bool KTMA(string kt)
        {
            int n;
            if (rdMaKH.Checked && int.TryParse(kt, out n))
                return true;
            return false;
        }

        #endregion

        #region Events
        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from KhachHang");
            if (lst == null) return;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text))
            {
                string filterExpression = "";
                if (KTMA(txbTim.Text))
                {
                    filterExpression = "MaKH = " + txbTim.Text + "";
                    }
                if (rdTenKH.Checked) filterExpression = "TENKH like '%" + txbTim.Text + "%'";

                string sortExpression = "MaKH DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<KhachHang> l = new List<KhachHang>();
                foreach (DataRowView row in dataview)
                {
                    KhachHang k = new KhachHang(row);
                    l.Add(k);
                }
                LoadListView(l);
            }
            else
            {
                Loads();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var k = GetControls();
            if (KhachHangDAO.instance.Delete(k.makh))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            Loads();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var k = GetControls();
            if (KhachHangDAO.instance.Update(k))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            Loads();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var k = GetControls();
            if (k.tenkh == "trống")
            {
                MessageBox.Show("Hãy điền tên"); 
                return;
            }
            if (KhachHangDAO.instance.Insert(k))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            Loads();
        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0) return;
            string makh = lvKhachHang.SelectedItems[0].Text;
            var k = KhachHangDAO.instance.GetKHByID(makh);
            LoadControls(k);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        
    }
}
