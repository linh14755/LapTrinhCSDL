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
    public partial class frmQuanLyTraSach : Form
    {
        public frmQuanLyTraSach()
        {
            InitializeComponent();
            Loads();
            rdmadocgia.Checked = true;
        }

        private void Loads()
        {
            LoadDanhSachLV(MuonTraDAO.instance.GetList());
        }
        #region Methods
        public void MessageBoxCT(string text)
        {
            MessageBoxOK box = new MessageBoxOK();
            box.SetMessage(text);
            box.ShowDialog();
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

        public void LoadControls(MuonSach m)
        {
            txbmaphieu.Text = m.sophieumuon;
            txbmadocgia.Text = m.madg;
            txbmasach.Text = m.masach;
            dtpngaymuon.Value = m.ngaymuon;
            dtpngaytra.Value = m.ngaytra;
            txbghichu.Text = m.ghichu;
        }
        public void LoadDanhSachLV(List<MuonSach> m)
        {
            lvsach.Items.Clear();
            foreach (var ms in m)
            {
                ListViewItem lvitem = new ListViewItem(ms.sophieumuon);
                lvitem.SubItems.Add(ms.madg);
                lvitem.SubItems.Add(ms.masach);
                lvitem.SubItems.Add(ms.ngaymuon.ToShortDateString().ToString());
                lvitem.SubItems.Add(ms.ngaytra.ToShortDateString().ToString());
                lvitem.SubItems.Add(ms.soluong);
                lvitem.SubItems.Add(ms.ghichu);
                lvsach.Items.Add(lvitem);
            }
        }

        #endregion

        #region Events
        private void txbtim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from MuonSach where XacNhanTra = 0");
            if (lst == null) return;
            int n;
            if (txbtim.Text != "" && KTKytuDacBiet(txbtim.Text) && int.TryParse(txbtim.Text, out n))
            {
                string filterExpression = "MaDG = " + txbtim.Text + "";
                if (rdmasach.Checked) filterExpression = "MASACH = " + txbtim.Text + "";

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
                LoadDanhSachLV(MuonTraDAO.instance.GetList());
            }
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
            if (lvsach.SelectedItems.Count == 0) return;
            frmTraSach frm = new frmTraSach(MuonTraDAO.instance.GetListByMaDG(txbmadocgia.Text));
            if(frm.ShowDialog() == DialogResult.Cancel)
            {
                Loads();
            }
        }
        private void lvsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsach.SelectedItems.Count == 0) return;
            string maphieu = lvsach.SelectedItems[0].Text;
            var ls = MuonTraDAO.instance.FindByID(maphieu);
            LoadControls(ls[0]);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
