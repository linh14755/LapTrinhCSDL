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
            Loads();
            rdMaSach.Checked = true;
            dtpnamxb.Value = DateTime.Now;
            dtpngaynhap.Value = DateTime.Now;
        }
        #region MEthods
        
        public void Loads()
        {
            LoadDanhSachLV(SachDAO.instance.GetList());
        }

        public bool KTText()
        {
            if (txbMaSach.Text != "" &&
                txbTenSach.Text != "" &&
                txbTenTG.Text != "" &&
                txbLinhVuc.Text != "" &&
                txbsoluong.Text != "")
                return true;
            return false;
        }

        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }

        public Sach GetControls()
        {
            Sach b = new Sach();
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

        public void LoadConTrols(Sach b)
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

        public void LoadDanhSachLV(List<Sach> lb)
        {
            lvsach.Items.Clear();
            foreach (var bk in lb)
            {
                ListViewItem lvitem = new ListViewItem(bk.masach);
                lvitem.SubItems.Add(bk.tensach);
                lvitem.SubItems.Add(bk.tentg);
                lvitem.SubItems.Add(bk.tenlv);
                lvitem.SubItems.Add(bk.tennxb);
                lvitem.SubItems.Add(bk.namxb.ToShortDateString().ToString());
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
            if (tentk.Contains("docgia"))
            {
                btnThem.Enabled = false;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        #endregion

        #region Events

        private void txbTim_TextChanged_1(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from Sach");
            if (lst == null) return;
            string text = txbTim.Text;

            if (text != "" && KTKytuDacBiet(text))
            {
                string filterExpression = "";
                if (KTMA(text))
                {
                    filterExpression = "MaSach = " + text + "";
                }
                if (rdTenSach.Checked) filterExpression = "TenSach like '%" + text + "%'";
                if (rdTenTG.Checked) filterExpression = "TenTG like '%" + text + "%'";

                string sortExpression = "MaSach DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<Sach> lbook = new List<Sach>();
                foreach (DataRowView row in dataview)
                {
                    Sach b = new Sach(row);
                    lbook.Add(b);
                }
                LoadDanhSachLV(lbook);
            }
            else
            {
                Loads();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var book = GetControls();
            if (KTText())
            {
                if (SachDAO.instance.Insert(book))
                    MessageBoxCT("Thêm Thành Công");
                else
                    MessageBoxCT("Thêm Thất Bại");
                Loads();
            }
            else
                MessageBoxCT("Hãy điền đủ thông tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txbMaSach.Text;
            if (id != "")
            {
                if (SachDAO.instance.Delete(id))
                    MessageBoxCT("Xóa Thành Công");
                else
                    MessageBoxCT("Phiếu mượn có loại sách này, không thể xóa");
                Loads();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var b = GetControls();
            if (b.tensach != "" && b.tennxb != "" && b.tentg != "")
            {
                if (SachDAO.instance.Update(b))
                    MessageBoxCT("Sửa Thành Công");
                else
                    MessageBoxCT("Sửa Thất Bại");
                Loads();
            }
        }
        private void lvsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsach.SelectedItems.Count == 0) return;
            string id = lvsach.SelectedItems[0].Text;
            var lst = SachDAO.instance.FindByID(id);
            Sach d = lst[0];
            LoadConTrols(d);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
