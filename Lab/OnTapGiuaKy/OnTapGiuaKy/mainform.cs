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
        private QuanLySinhVien quanlysv;
        public MainForm()
        {
            InitializeComponent();
        }



        #region Methods

        //Lay thong tin constrols
        public SinhVien GetStudentConTrols()
        {
            SinhVien sv = new SinhVien();

            sv.mssv = txbMSSV.Text;
            sv.holot = txbHoLot.Text;
            sv.ten = txbTen.Text;
            sv.Gioitinh = "Nữ";
            if (rdNam.Checked)
                sv.Gioitinh = "Nam";
            sv.ngaysinh = dtpNgaySinh.Value;
            sv.lop = txbLop.Text;
            sv.socmnd = txbCMND.Text;
            sv.sodt = txbSoDT.Text;
            sv.diachi = txbDiaChi.Text;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                {
                    sv.chuyennganh.Add(clbChuyenNganh.Items[i].ToString());
                }
            }

            return sv;
        }

        //thietlap thong tin controls
        private void ThietLapSVconTrols(SinhVien sv)
        {
            txbMSSV.Text = sv.mssv;
            txbHoLot.Text = sv.holot;
            txbTen.Text = sv.ten;
            rdNam.Checked = true;
            if (sv.Gioitinh == "Nữ")
                rdNu.Checked = true;
            dtpNgaySinh.Value = sv.ngaysinh;
            txbLop.Text = sv.lop;
            txbCMND.Text = sv.socmnd;
            txbSoDT.Text = sv.sodt;
            txbDiaChi.Text = sv.diachi;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
            {
                clbChuyenNganh.SetItemChecked(i, false);
            }
            foreach (string cn in sv.chuyennganh)
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


        private void ShowStudentList(List<SinhVien> listsv)
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien item in listsv)
            {
                ListViewItem lvitem = new ListViewItem(item.mssv);
                lvitem.SubItems.Add(item.holot);
                lvitem.SubItems.Add(item.ten);
                lvitem.SubItems.Add(item.Gioitinh);
                lvitem.SubItems.Add(item.ngaysinh.ToString());
                lvitem.SubItems.Add(item.lop);
                lvitem.SubItems.Add(item.socmnd);
                lvitem.SubItems.Add(item.sodt);
                lvitem.SubItems.Add(item.diachi);

                string cnganh = "";
                foreach (string cn in item.chuyennganh)
                {
                    cnganh += cn + ",";
                }
                string cnmoi = cnganh.Substring(0, cnganh.Length - 1);
                lvitem.SubItems.Add(cnmoi);


                lvSinhVien.Items.Add(lvitem);
            }
        }

        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            quanlysv = new QuanLySinhVien(new DocFileTXT("DanhSach.txt"));
            ShowStudentList(quanlysv.GetStudents());
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            string studentID = lvSinhVien.SelectedItems[0].Text;
            var sv = quanlysv.FindByID(studentID);

            ThietLapSVconTrols(sv);
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            string studentID = lvSinhVien.SelectedItems[0].Text;
            SinhVien sv = quanlysv.FindByID(studentID);
            quanlysv.AddorUpdate(sv);
            ShowStudentList(quanlysv.GetStudents());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var sv = GetStudentConTrols();
            quanlysv.AddorUpdate(sv);
            ShowStudentList(quanlysv.GetStudents());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sv = GetStudentConTrols();
            quanlysv.Delete(sv);
            ShowStudentList(quanlysv.GetStudents());
        }

        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.ShowDialog();
        }

       
    }
}

