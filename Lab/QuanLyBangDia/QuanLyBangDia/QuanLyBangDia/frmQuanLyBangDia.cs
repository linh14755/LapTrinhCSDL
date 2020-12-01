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
    public partial class frmQuanLyBangDia : Form
    {
        public frmQuanLyBangDia()
        {
            InitializeComponent();
            Loads();
            rdMaBD.Checked = true;
        }
        #region Methods
        private void Loads()
        {
            LoadListView(BangDiaDAO.instance.GetList());
        }
        public void LoadListView(List<BangDia> l)
        {
            lvBangDia.Items.Clear();
            foreach (var k in l)
            {
                ListViewItem lvitem = new ListViewItem(k.mabd);
                lvitem.SubItems.Add(k.tenbd);
                lvitem.SubItems.Add(k.soluong.ToString());
                lvitem.SubItems.Add(k.dongia.ToString());
                lvitem.SubItems.Add(k.theloai);

                lvBangDia.Items.Add(lvitem);
            }
        }
        public void LoadControls(BangDia k)
        {
            txbMaBD.Text = k.mabd;
            txbTenBD.Text = k.tenbd;
            txbSL.Text = k.soluong.ToString();
            txbDonGia.Text = k.dongia.ToString();
            txbTL.Text = k.theloai.ToString();
        }
        public BangDia GetControls()
        {
            BangDia k = new BangDia();
            if (string.IsNullOrEmpty(txbMaBD.Text)) k.mabd = "0";
            else k.mabd = txbMaBD.Text;

            if (string.IsNullOrEmpty(txbTenBD.Text)) k.tenbd = "trống";
            else k.tenbd = txbTenBD.Text;

            if (string.IsNullOrEmpty(txbSL.Text)) k.soluong = 0;
            else k.soluong = int.Parse(txbSL.Text);

            if (string.IsNullOrEmpty(txbDonGia.Text)) k.dongia = 0;
            else k.dongia = int.Parse(txbDonGia.Text);

            if (string.IsNullOrEmpty(txbTL.Text)) k.theloai = "trống";
            else k.theloai = txbTL.Text;

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
            if (rdMaBD.Checked && int.TryParse(kt, out n))
                return true;
            return false;
        }
        public bool KTDonGia(string kt)
        {
            int n;
            if (rdDonGia.Checked && int.TryParse(kt, out n))
                return true;
            return false;
        }
        #endregion

        #region Events

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var bd = GetControls();
            if (BangDiaDAO.instance.Delete(bd.mabd))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            Loads();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var bd = GetControls();
            if (BangDiaDAO.instance.Update(bd))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            Loads();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var bd = GetControls();
            if(bd.tenbd == "trống")
            {
                MessageBox.Show("hãy điền tên đĩa"); return;
            }
            if (BangDiaDAO.instance.Insert(bd))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            Loads();
        }

        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from BangDia");
            if (lst == null) return;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text))
            {
                string filterExpression = "";
                if (KTMA(txbTim.Text))
                {
                    filterExpression = "MaBD = " + txbTim.Text + "";
                }
                if (KTDonGia(txbTim.Text))
                {
                    filterExpression = "DonGia = " + txbTim.Text + "";
                }
                if (rdTenBD.Checked) filterExpression = "TENBD like '%" + txbTim.Text + "%'";

                string sortExpression = "MaBD DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<BangDia> l = new List<BangDia>();
                foreach (DataRowView row in dataview)
                {
                    BangDia k = new BangDia(row);
                    l.Add(k);
                }
                LoadListView(l);
            }
            else
            {
                Loads();
            }
        }

        private void lvBangDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBangDia.SelectedItems.Count == 0) return;
            string mabd = lvBangDia.SelectedItems[0].Text;
            var bd = BangDiaDAO.instance.GetBDByID(mabd);

            LoadControls(bd);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
