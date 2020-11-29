﻿using DevExpress.Data.Mask;
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
    public partial class frmDanhSachQuaHan : Form
    {
        public frmDanhSachQuaHan()
        {
            InitializeComponent();
            Loads();
            rdMaDocGia.Checked = true;
        }
        #region Methods
        private void Loads()
        {
            LoadDanhSachLV(MuonTraDAO.instance.GetDSQuaHan());
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
                lvitem.SubItems.Add(ms.ngaymuon.ToString());
                lvitem.SubItems.Add(ms.ngaytra.ToString());
                lvitem.SubItems.Add(ms.soluong);
                lvitem.SubItems.Add(ms.xacnhantra);
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

        private void txbTim_TextChanged_1(object sender, EventArgs e)
        {
            string datecurrent = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var lst = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = N'0'");

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
                LoadDanhSachLV(MuonTraDAO.instance.GetDSQuaHan());
            }
        }

        private void btngiahan_Click(object sender, EventArgs e)
        {
            //giahan
            if (txbmaphieu.Text == "") return;
            frmGiaHan frm = new frmGiaHan();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DateTime dategiahan = frm.Getdatetime();
                if (KTngayquahan(dategiahan))
                {
                    MuonTraDAO.instance.GianHan(dategiahan, txbmaphieu.Text);
                    MessageBoxCT("Gian Hạn Thành Công");
                }
                else
                {
                    MessageBoxCT("Gia hạn thất bại, ngày nhập không hợp lệ");
                }
            }
            LoadDanhSachLV(MuonTraDAO.instance.GetDSQuaHan());
        }

        private void lvmuonsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvmuonsach.SelectedItems.Count == 0) return;
            string id = lvmuonsach.SelectedItems[0].Text;
            var list = MuonTraDAO.instance.FindByID(id);
            MuonSach m = list[0];

            LoadConTrols(m);
        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}