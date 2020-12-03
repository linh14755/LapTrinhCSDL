using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmDanhSachQuaHan : Form
    {
        string tk;
        bool loaitk;
        int tongtien = 0;
        public frmDanhSachQuaHan()
        {
            InitializeComponent();
            rdMaDocGia.Checked = true;
        }
        #region Methods
        public void GetTK(string tk, bool loaitk)
        {
            this.tk = tk;
            this.loaitk = loaitk;
            if (!loaitk)
            {
                rdMaDocGia.Enabled = false;
                rdmasach.Checked = true;
            }
            Loads();
        }
        public void Loads()
        {
            var lst = DocGiaDAO.Instance.GetListByTK(tk);
            List<MuonSach> dsqh = new List<MuonSach>();
            if (lst.Count == 0)
            {
                dsqh = MuonTraDAO.instance.GetDSQuaHan();
            }
            else
            {
                DocGia dg = new DocGia();
                dg = lst[0];
                dsqh = MuonTraDAO.instance.GetDSQuaHan(dg.madg);
            }
            LoadDanhSachLV(dsqh);
        }
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
        }
        public void LoadConTrols(MuonSach m)
        {
            txbmaphieu.Text = m.sophieumuon;
            cbbmadg.Text = m.madg;
            cbbmasach.Text = m.masach;
            dtpmuon.Value = m.ngaymuon;
            dtptra.Value = m.ngaytra;
            txbghichu.Text = m.ghichu;

            CultureInfo culture = new CultureInfo("vi-VN");
            txbtienphat.Text = m.tienphat.ToString("c", culture);
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
        public void LoadDanhSachLV(List<MuonSach> m)
        {
            lvmuonsach.Items.Clear();
            foreach (var ms in m)
            {
                ListViewItem lvitem = new ListViewItem(ms.sophieumuon);
                lvitem.SubItems.Add(ms.madg);
                lvitem.SubItems.Add(ms.masach);
                lvitem.SubItems.Add(ms.ngaymuon.ToShortDateString().ToString());
                lvitem.SubItems.Add(ms.ngaytra.ToShortDateString().ToString());
                lvitem.SubItems.Add(ms.soluong);
                lvitem.SubItems.Add(ms.tienphat.ToString());
                lvitem.SubItems.Add(ms.ghichu);
                lvmuonsach.Items.Add(lvitem);
            }
        }
        public bool KTngayquahan(DateTime ngaygiahan)
        {
            if (ngaygiahan > dtptra.Value && ngaygiahan >= DateTime.Now)
                return true;
            return false;
        }
        #endregion


        #region Events
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var ls = MuonTraDAO.instance.GetDSQuaHan(cbbmadg.Text);
            if (ls.Count > 0)
            {
                tongtien = 0;
                foreach (var item in ls)
                {
                    tongtien += item.tienphat;
                }
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txbtongtien.Text = tongtien.ToString("c", culture);
            lbtongiten.Text = "Đọc giả:" + cbbmadg.Text;
        }

        private void txbTim_TextChanged_1(object sender, EventArgs e)
        {
            string datecurrent = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var lst = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = 0");

            if (lst == null) return;
            int n;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text) && int.TryParse(txbTim.Text, out n))
            {
                string filterExpression = "MaDG = " + txbTim.Text + "";
                if (rdmasach.Checked) filterExpression = "MASACH = " + txbTim.Text + "";

                string sortExpression = "MaDG DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<MuonSach> lm = new List<MuonSach>();
                foreach (DataRowView row in dataview)
                {
                    MuonSach d = new MuonSach(row);
                    lm.Add(d);
                }
                LoadDanhSachLV(lm);
            }
            else
            {
                Loads();
            }
        }

        private void lvmuonsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvmuonsach.SelectedItems.Count == 0) return;
            string id = lvmuonsach.SelectedItems[0].Text;
            var list = MuonTraDAO.instance.FindByID(id);
            MuonSach m = list[0];

            LoadConTrols(m);


            //tổng tiền phạt
            var ls = MuonTraDAO.instance.GetDSQuaHan(cbbmadg.Text);
            if (ls.Count > 0)
            {
                tongtien = 0;
                foreach (var item in ls)
                {
                    tongtien += item.tienphat;
                }
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txbtongtien.Text = tongtien.ToString("c", culture);
            lbtongiten.Text = "Tổng tiền phạt ĐG:" + cbbmadg.Text;
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
    }
}
