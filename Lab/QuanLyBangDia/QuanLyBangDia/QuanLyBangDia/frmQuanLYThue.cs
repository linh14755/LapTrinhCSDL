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
            
        }

        #region Methods

        private void Loads()
        {
            LoadListView(ThueDAO.instance.GetList());
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
            txbMaBD.Text = k.mabd;
            txbMaKH.Text = k.makh.ToString();
            dtpNgayThue.Value = k.ngaythue;
            dtpNgayTra.Value = k.ngaytra;
            nmTienCoc.Value = k.tiencoc;
            nmTongTien.Value = k.tongtien;
        }
        public Thue GetControls()
        {
            Thue k = new Thue();
            if (string.IsNullOrEmpty(txbLuot.Text)) k.luot = "0";
            else k.luot = txbLuot.Text;

            if (string.IsNullOrEmpty(txbMaBD.Text)) k.mabd = "0";
            else k.mabd = txbMaBD.Text;

            if (string.IsNullOrEmpty(txbMaKH.Text)) k.makh = "0";
            else k.makh = txbMaKH.Text;

            k.tiencoc = int.Parse(nmTienCoc.Value.ToString());
            k.tongtien = int.Parse(nmTongTien.Value.ToString());

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
        //public bool KTMA(string kt)
        //{
        //    int n;
        //    if (rdMaBD.Checked && int.TryParse(kt, out n))
        //        return true;
        //    return false;
        //}
        //public bool KTDonGia(string kt)
        //{
        //    int n;
        //    if (rdDonGia.Checked && int.TryParse(kt, out n))
        //        return true;
        //    return false;
        //}

        #endregion

        #region Events
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
