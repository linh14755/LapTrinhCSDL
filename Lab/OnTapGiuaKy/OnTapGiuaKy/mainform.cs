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
        public SinhVien GetSVControls()
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

            foreach (var cn in sv.Monhoc)
            {
                for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                {
                    if (cn.CompareTo(clbChuyenNganh.Items[i]) == 0)
                    {
                        clbChuyenNganh.SetItemChecked(i, true);
                    }
            }
            }
        }

        public void LoadListView(List<SinhVien> lsv)
        {
            lvSinhVien.Items.Clear();
            foreach (var item in lsv)
            {
                ListViewItem lvitem = new ListViewItem(item.Mssv);
                lvitem.SubItems.Add(item.Holot);
                lvitem.SubItems.Add(item.Ten);
                lvitem.SubItems.Add(item.Gioitinh);
                lvitem.SubItems.Add(item.Ngaysinh.ToString());
                lvitem.SubItems.Add(item.Lop);
                lvitem.SubItems.Add(item.Socmnd);
                lvitem.SubItems.Add(item.Sodt);
                lvitem.SubItems.Add(item.Diachi);
                lvitem.SubItems.Add(string.Join(",",item.Monhoc));
                lvSinhVien.Items.Add(lvitem);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //qlsv = new QuanLySinhVien(new DocFileTXT("DanhSach.txt"));
            qlsv = new QuanLySinhVien(new DocFileJSON("DanhSach.json"));
            List<SinhVien> lsv = qlsv.GetStudentList();
            LoadListView(lsv);
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            string id = lvSinhVien.SelectedItems[0].Text;
            SinhVien sv = qlsv.FindID(id);
            LoadControls(sv);
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSVControls();
            qlsv.AddOrUpdate(sv);
            LoadListView(qlsv.GetStudentList());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSVControls();
            qlsv.AddOrUpdate(sv);
            LoadListView(qlsv.GetStudentList());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSVControls();
            qlsv.Xoa(sv);
            LoadListView(qlsv.GetStudentList());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var kt = frm.GetKieuTim();
                var keyword = frm.GetKeyWord();
                List<SinhVien> result = qlsv.CompareStudent(CompareSV, kt, keyword);

                LoadListView(result);
            }
        }
        public bool CompareSV(SinhVien sv,KieuTim kt,string kw)
        {
            switch (kt)
            {
                case KieuTim.TheoTen:
                    return sv.Ten.ToLower().Contains(kw.ToLower());
                case KieuTim.TheoLop:
                    return sv.Lop == kw;
                default:
                    return sv.Mssv == kw;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListView(qlsv.GetStudentList());
        }
    }
}
