using DevExpress.ClipboardSource.SpreadsheetML;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQuanLySach : Form
    {
        public string tentk = "";
        public frmQuanLySach()
        {
            InitializeComponent();
            Load();
            rdMaSach.Checked = true;
        }
        #region MEthods
        public void Load()
        {
            LoadDanhSachLV(BookDAO.instance.GetListBook());
        }
        public Book GetControls()
        {
            Book b = new Book();
            b.masach = txbMaSach.Text;
            b.tensach = txbTenSach.Text;
            b.tentg = txbTenTG.Text;
            b.tenlv = txbLinhVuc.Text;
            b.tennxb = txbNhaXB.Text;
            b.namxb = dtpnamxb.Value;
            b.sl = txbsoluong.Text;
            b.ngaynhap = dtpngaynhap.Value;
            b.ghichu = txbGhiChu.Text;

            return b;
        }
        public void LoadConTrols(Book b)
        {
            txbMaSach.Text = b.masach;
            txbTenSach.Text = b.tensach;
            txbTenTG.Text = b.tentg;
            txbLinhVuc.Text = b.tenlv;
            txbNhaXB.Text = b.tennxb;
            dtpnamxb.Value = b.namxb;
            txbsoluong.Text = b.sl;
            dtpngaynhap.Value = b.ngaynhap;
            txbGhiChu.Text = b.ghichu;
        }

        public void LoadDanhSachLV(List<Book> lb)
        {
            lvsach.Items.Clear();
            //lvsach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            foreach (var bk in lb)
            {
                ListViewItem lvitem = new ListViewItem(bk.masach);
                lvitem.SubItems.Add(bk.tensach);
                lvitem.SubItems.Add(bk.tentg);
                lvitem.SubItems.Add(bk.tenlv);
                lvitem.SubItems.Add(bk.tennxb);
                lvitem.SubItems.Add(bk.namxb.ToString());
                lvitem.SubItems.Add(bk.sl);
                lvitem.SubItems.Add(bk.ngaynhap.ToString());
                lvitem.SubItems.Add(bk.ghichu);

                lvsach.Items.Add(lvitem);
            }
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
            if (rdMaSach.Checked && int.TryParse(kt, out n))
                return true;
            return false;
        }

        public void GetTK(string tk)
        {
            LoginDocGia(tk);
        }
        public void LoginDocGia(string tentk)
        {
            if(tentk.Contains("docgia"))
            {
                btnThem.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }

        }
        #endregion

        #region Events

        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from Sach");
            if (lst == null) return;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text))
            {
                string filterExpression = "";
                if (KTMA(txbTim.Text))
                {
                   filterExpression  = "MaSach = " + txbTim.Text + "";
                }
                if (rdTenSach.Checked) filterExpression = "TenSach like '%" + txbTim.Text + "%'";
                if (rdTenTG.Checked) filterExpression = "TenTG like '%" + txbTim.Text + "%'";

                string sortExpression = "MaSach DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<Book> lbook = new List<Book>();
                foreach (DataRowView row in dataview)
                {
                    Book b = new Book(row);
                    lbook.Add(b);
                }
                LoadDanhSachLV(lbook);
            }
            else
            {
                Load();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txbMaSach.Text;
            if (BookDAO.instance.Delete(id))
                MessageBox.Show("Xóa Thành Công");
            else
                MessageBox.Show("Xóa Thất Bại");

            Load();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var book = GetControls();
            if (BookDAO.instance.Update(book))
                MessageBox.Show("Sửa Thành Công");
            else
                MessageBox.Show("Sửa Thất Bại");
            Load();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var book = GetControls();
            if (BookDAO.instance.Insert(book))
                MessageBox.Show("Thêm Thành Công");
            else
                MessageBox.Show("Thêm Thất Bại");
            Load();
        }

        private void lvsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsach.SelectedItems.Count == 0) return;
            int id = Convert.ToInt32(lvsach.SelectedItems[0].Text);
            var lst = BookDAO.instance.FindByID(id);
            var book = lst[0];
            LoadConTrols(book);
        }
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
