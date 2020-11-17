using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapGiuaKy
{
    public partial class MainForm : Form
    {
        QuanLySinhVien qlsv;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kt = frm.GetKieuTim();
                var keyword = frm.GetKeyWord();
                var result = qlsv.FindStudents(CompareFunc, kt, keyword);
                LoadListViewItem(result);
            }
        }
        public bool CompareFunc(SinhVien sv, KieuTim kt, string kw)
        {
            switch (kt)
            {
                case KieuTim.TheoLop: return sv.Lop == kw;
                case KieuTim.TheoTen: return sv.Ten.ToLower() == kw.ToLower();
                default: return sv.Mssv == kw;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListViewItem(qlsv.GetListSinhVien());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var sv = GetSvControls();
            qlsv.AddOrUpdate(sv);
            LoadListViewItem(qlsv.GetListSinhVien());
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var sv = GetSvControls();
            qlsv.AddOrUpdate(sv);
            LoadListViewItem(qlsv.GetListSinhVien());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //qlsv = new QuanLySinhVien(new TXTDataStorage("DanhSach.txt"));
            //qlsv = new QuanLySinhVien(new JSONDataStorage("DanhSach.json"));
            qlsv = new QuanLySinhVien(new XMLDataStorage("DanhSach.xml"));
            LoadListViewItem(qlsv.GetListSinhVien());
        }
        public SinhVien GetSvControls()
        {
            var sv = new SinhVien();

            sv.Mssv = txbMSSV.Text;
            sv.Holot = txbHoLot.Text;
            sv.Ten = txbTen.Text;
            sv.Gioitinh = "Nam";
            if (rdNu.Checked)
                sv.Gioitinh = "Nữ";
            sv.Ngaysinh = dtpNgaySinh.Value;
            sv.Lop = txbLop.Text;
            sv.Socmnd = txbCMND.Text;
            sv.Sodt = txbSoDT.Text;
            sv.Diachi = txbDiaChi.Text;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                {
                    sv.Monhoc.Add(clbChuyenNganh.Items[i].ToString());
                }
            }

            return sv;
        }
        public void LoadControls(SinhVien sv)
        {
            txbMSSV.Text = sv.Mssv;
            txbHoLot.Text = sv.Holot;
            txbTen.Text = sv.Ten;
            rdNam.Checked = true;
            if (sv.Gioitinh == "Nữ")
                rdNu.Checked = true;
            dtpNgaySinh.Value = sv.Ngaysinh;
            txbLop.Text = sv.Lop;
            txbCMND.Text = sv.Socmnd;
            txbSoDT.Text = sv.Sodt;
            txbDiaChi.Text = sv.Diachi;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
            {
                clbChuyenNganh.SetItemChecked(i, false);
            }

            foreach (var item in sv.Monhoc)
            {
                for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                {
                    if (clbChuyenNganh.Items[i].ToString() == item)
                    {
                        clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }

        public void LoadListViewItem(List<SinhVien> lsv)
        {
            lvSinhVien.Items.Clear();

            foreach (var sv in lsv)
            {
                ListViewItem lvitem = new ListViewItem(sv.Mssv);
                lvitem.SubItems.Add(sv.Holot);
                lvitem.SubItems.Add(sv.Ten);
                lvitem.SubItems.Add(sv.Gioitinh);
                lvitem.SubItems.Add(sv.Ngaysinh.ToString());
                lvitem.SubItems.Add(sv.Lop);
                lvitem.SubItems.Add(sv.Socmnd);
                lvitem.SubItems.Add(sv.Sodt);
                lvitem.SubItems.Add(sv.Diachi);
                lvitem.SubItems.Add(string.Join(",", sv.Monhoc));

                lvSinhVien.Items.Add(lvitem);
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            string id = lvSinhVien.SelectedItems[0].Text;
            SinhVien sv = qlsv.FindStudentByID(id);
            LoadControls(sv);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sv = GetSvControls();
            qlsv.Xoa(sv);
            LoadListViewItem(qlsv.GetListSinhVien());
        }
    }
}