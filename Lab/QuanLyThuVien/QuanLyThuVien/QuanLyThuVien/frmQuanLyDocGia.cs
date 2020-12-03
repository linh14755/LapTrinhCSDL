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
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
            Loads();
            rdMaDocGia.Checked = true;
        }
        #region Methods
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }
        public void Loads()
        {
            LoadDanhSachLV(DocGiaDAO.Instance.GetList());
        }
        public DocGia GetConTrols()
        {
            DocGia d = new DocGia();
            d.madg = txbdocgia.Text;
            d.hoten = txbHoTen.Text;
            d.ngaysinh = dtpkNgaySinh.Value;
            d.gioitinh = true;
            if (rdNu.Checked)
                d.gioitinh = false;
            d.taikhoan = txbTaiKhoan.Text;
            d.matkhau = txbMatKhau.Text;
            d.sodt = txbLop.Text;
            d.diachi = txbDiaChi.Text;
            d.email = txbEmail.Text;
            d.ghichu = txbGhiChu.Text;

            return d;
        }
        public void LoadConTrols(DocGia dg)
        {
            txbdocgia.Text = dg.madg;
            txbHoTen.Text = dg.hoten;
            dtpkNgaySinh.Value = dg.ngaysinh;
            rdNam.Checked = true;
            if (dg.gioitinh == false)
                rdNu.Checked = true;
            txbTaiKhoan.Text = dg.taikhoan;
            txbMatKhau.Text = dg.matkhau;
            txbLop.Text = dg.sodt;
            txbDiaChi.Text = dg.diachi;
            txbEmail.Text = dg.email;
            txbGhiChu.Text = dg.ghichu;
        }
        public void LoadDanhSachLV(List<DocGia> ldg)
        {
            lvdocgia.Items.Clear();
            foreach (var dg in ldg)
            {
                ListViewItem lvitem = new ListViewItem(dg.madg);
                lvitem.SubItems.Add(dg.hoten);
                lvitem.SubItems.Add(dg.ngaysinh.ToShortDateString().ToString());
                string gt = "Nam";
                if (dg.gioitinh == false)
                    gt = "Nữ";
                lvitem.SubItems.Add(gt);
                lvitem.SubItems.Add(dg.taikhoan);
                lvitem.SubItems.Add(dg.matkhau);
                lvitem.SubItems.Add(dg.sodt);
                lvitem.SubItems.Add(dg.diachi);
                lvitem.SubItems.Add(dg.email);
                lvitem.SubItems.Add(dg.ghichu);

                lvdocgia.Items.Add(lvitem);
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
            if (rdMaDocGia.Checked && int.TryParse(kt, out n))
                return true;
            return false;
        }
        #endregion

        #region Events
        private void txbTim_TextChanged_1(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from DocGia");
            if (lst == null) return;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text))
            {
                string filterExpression = "";
                if (KTMA(txbTim.Text))
                {
                    filterExpression = "MaDG = " + txbTim.Text + "";
                }
                if (rdTenDocGia.Checked) filterExpression = "HOTEN like '%" + txbTim.Text + "%'";

                string sortExpression = "MaDG DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<DocGia> lbook = new List<DocGia>();
                foreach (DataRowView row in dataview)
                {
                    DocGia d = new DocGia(row);
                    lbook.Add(d);
                }
                LoadDanhSachLV(lbook);
            }
            else
            {
                Loads();
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (txbdocgia.Text == "") return;
            var dg = GetConTrols();
            if (dg.hoten != "" && dg.matkhau != "" && dg.sodt != "")
            {
                if (DocGiaDAO.Instance.Update(dg))
                    MessageBoxCT("Cập nhật thành công");
                else
                    MessageBoxCT("Cập nhật thất bại");
                Loads();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string id = txbdocgia.Text;
            if (id != "")
            {
                if (DocGiaDAO.Instance.Delete(id))
                    MessageBoxCT("Xóa thành công");
                else
                    MessageBoxCT("Đọc giả có trong danh sách mượn, không thể xóa");
                Loads();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var dg = GetConTrols();
            if (dg.hoten != "" && dg.matkhau != "" && dg.sodt != "")
            {
                if (DocGiaDAO.Instance.Insert(dg))
                    MessageBoxCT("Thêm Thành Công");
                else
                    MessageBoxCT("Tài khoản đã có trong danh sách");
                Loads();
            }
        }

        private void lvdocgia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvdocgia.SelectedItems.Count == 0) return;
            string id = lvdocgia.SelectedItems[0].Text;
            var lst = DocGiaDAO.Instance.FindByID(id);
            DocGia d = lst[0];
            LoadConTrols(d);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
