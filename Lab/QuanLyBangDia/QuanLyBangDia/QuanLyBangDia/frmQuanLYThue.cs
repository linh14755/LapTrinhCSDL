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
    public partial class frmQuanLyThue : Form
    {
        public frmQuanLyThue()
        {
            InitializeComponent();
            Loads();
            LoadComBoBox();
            rdMaLuot.Checked = true;
            dtpNgayThue.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
        }

        #region Methods

        private void Loads()
        {
            LoadListView(ThueDAO.instance.GetList());
        }
        private void LoadComBoBox()
        {

            cbbMaBD.DisplayMember = "mabd";
            cbbMaBD.ValueMember = "tenbd";
            cbbMaBD.DataSource = BangDiaDAO.instance.GetList();

            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "TenKH";
            cbbMaKH.DataSource = KhachHangDAO.instance.GetList();
        }
        public void LoadListView(List<Thue> l)
        {
            lvThue.Items.Clear();
            foreach (var k in l)
            {
                ListViewItem lvitem = new ListViewItem(k.luot);
                lvitem.SubItems.Add(k.mabd);
                lvitem.SubItems.Add(k.makh.ToString());
                lvitem.SubItems.Add(k.ngaythue.ToString());
                lvitem.SubItems.Add(k.ngaytra.ToString());
                lvitem.SubItems.Add(k.tiencoc.ToString());
                lvitem.SubItems.Add(k.tongtien.ToString());

                lvThue.Items.Add(lvitem);
            }
        }
        public void LoadControls(Thue k)
        {
            txbLuot.Text = k.luot;
            cbbMaBD.Text = k.mabd;
            cbbMaKH.Text = k.makh.ToString();
            dtpNgayThue.Value = k.ngaythue;
            dtpNgayTra.Value = k.ngaytra;
            nmTienCoc.Value = k.tiencoc;
            nmTongTien.Value = k.tongtien;
        }
        public Thue GetControls()
        {
            Thue k = new Thue();
            k.luot = txbLuot.Text;
            k.mabd = cbbMaBD.Text;
            k.makh = cbbMaKH.Text;
            k.tiencoc = int.Parse(nmTienCoc.Value.ToString());
            k.tongtien = int.Parse(nmTongTien.Value.ToString());
            k.ngaythue = dtpNgayThue.Value;
            k.ngaytra = dtpNgayTra.Value;

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
            if (int.TryParse(kt, out n))
                return true;
            return false;
        }

        #endregion

        #region Events

        private void cbbMaBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaBD.SelectedIndex == -1) return;

            if (cbbMaBD.SelectedValue is string)
            {
                txbTenBD.Text = cbbMaBD.SelectedValue.ToString();
            }
        }
        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaKH.SelectedIndex == -1) return;

            if (cbbMaKH.SelectedValue is string)
            {
                txbTenKH.Text = cbbMaKH.SelectedValue.ToString();
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            var thue = GetControls();
            
            if (ThueDAO.instance.Insert(thue))
                MessageBox.Show("Cho Thuê thành công");
            else MessageBox.Show("Thuê thất bại");

            Loads();
        }

        private void txbTim_TextChanged(object sender, EventArgs e)
        {
            var lst = DataProvider.instance.ExcuteQuery("select * from Thue where status = 0");
            if (lst == null) return;

            if (txbTim.Text != "" && KTKytuDacBiet(txbTim.Text))
            {
                string filterExpression = "";
                if (KTMA(txbTim.Text))
                {
                    if (rdMaLuot.Checked) filterExpression = "Luot = " + txbTim.Text + "";
                    if (rdMaBD.Checked) filterExpression = "MaBD = " + txbTim.Text + "";
                    if (rdMaKH.Checked) filterExpression = "MaKH = " + txbTim.Text + "";
                }
                string sortExpression = "Luot DESC";
                DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

                DataView dataview = new DataView(lst, filterExpression, sortExpression, rowsatefilter);

                List<Thue> l = new List<Thue>();
                foreach (DataRowView row in dataview)
                {
                    Thue k = new Thue(row);
                    l.Add(k);
                }
                LoadListView(l);
            }
            else Loads();
        }

        private void lvThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThue.SelectedItems.Count == 0) return;
            string luot = lvThue.SelectedItems[0].Text;
            Thue thue = ThueDAO.instance.GetBDByID(luot);

            BangDia b = BangDiaDAO.instance.GetBDByID(thue.mabd);
            txbTenBD.Text = b.tenbd;

            KhachHang k = KhachHangDAO.instance.GetKHByID(thue.makh);
            txbTenKH.Text = k.tenkh;

            LoadControls(thue);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


    }
}
