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
    public partial class frmQuanLyMuonSach : Form
    {
        public frmQuanLyMuonSach()
        {
            InitializeComponent();
            rdMaDocGia.Checked = true;
            Loads();
            dtpmuon.Value = DateTime.Now;
            dtptra.Value = DateTime.Now;
        }
        #region Methods
        private void Loads()
        {
            LoadDanhSachLV(MuonTraDAO.instance.GetList());
            LoadMaDG();
            LoadMaSach();
        }
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
        public MuonSach GetConTrols()
        {
            MuonSach m = new MuonSach();
            //m.sophieumuon = txbmaphieu.Text;
            m.masach = cbbmasach.Text;
            m.madg = cbbmadg.Text;
            m.ngaymuon = dtpmuon.Value;
            m.ngaytra = dtptra.Value;
            m.xacnhantra = "0"; //khi muon auto chua tra 0
            m.ghichu = txbghichu.Text;

            return m;
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
                lvitem.SubItems.Add(ms.ghichu);
                lvmuonsach.Items.Add(lvitem);
            }
        }
        public void LoadMaSach()
        {
            List<Sach> lst = SachDAO.instance.GetList();
            cbbmasach.DataSource = lst;
            cbbmasach.DisplayMember = "masach";
            cbbmasach.ValueMember = "tensach";
        }
        public void LoadMaDG()
        {
            List<DocGia> lst = DocGiaDAO.Instance.GetList();

            cbbmadg.DataSource = lst;
            cbbmadg.DisplayMember = "madg";
            cbbmadg.ValueMember = "hoten";

        }
        #endregion

        #region Events

        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from MuonSach where XacNhanTra = 0");
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
                LoadDanhSachLV(MuonTraDAO.instance.GetList());
            }
        }
        public bool KTCBBMaDG()
        {
            var data = DataProvider.instance.ExcuteQuery("select * from DocGia");
            foreach (DataRow row in data.Rows)
            {
                DocGia d = new DocGia(row);
                if (cbbmadg.Text.Contains(d.madg))
                    return true;
            }
            return false;
        }
        public bool KTCBBMaSach()
        {
            var data = DataProvider.instance.ExcuteQuery("select * from Sach");
            foreach (DataRow row in data.Rows)
            {
                Sach d = new Sach(row);
                if (cbbmasach.Text.Contains(d.masach))
                    return true;
            }
            return false;
        }

        private void btnmuon_Click(object sender, EventArgs e)
        {
            //cho muon
            //danh sach muon
            if (dtptra.Value >= DateTime.Now)
            {
                if (KTCBBMaDG())
                {
                    if (KTCBBMaSach())
                    {
                        var muon = GetConTrols();
                        if (MuonTraDAO.instance.KiemTraDocGia(muon.madg, muon.masach))
                        {
                            if (MuonTraDAO.instance.MuonSach(muon))
                                MessageBox.Show(string.Format("Cho Mượn Thành Công \n Tên người mượn: " + txbtendocgia.Text + " \n Tên Sách: " + txbTenSach.Text + "", "Thông Báo"));
                            else
                                MessageBoxCT("Ngày Trả không hợp lệ , hoặc không còn sách để mượn");
                            LoadDanhSachLV(MuonTraDAO.instance.GetList());
                        }
                        else
                            MessageBox.Show("Một đọc giả không được mượn quá 2 quyển sách cùng loại\n Và không quá 4 cuốn sách");
                    }
                    else MessageBoxCT("Mã sách không hợp lệ");
                }
                else MessageBoxCT("Mã đọc giả không hợp lệ");
            }
            else MessageBoxCT("Ngày trả không hợp lệ");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbmasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmasach.SelectedIndex == -1) return;

            if (cbbmasach.SelectedValue is string)
            {
                txbTenSach.Text = cbbmasach.SelectedValue.ToString();
            }
        }
        
        private void cbbmadg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmadg.SelectedIndex == -1) return;

            if (cbbmadg.SelectedValue is string)
            {
                txbtendocgia.Text = cbbmadg.SelectedValue.ToString();
            }
        }


        #endregion

        
    }
}
