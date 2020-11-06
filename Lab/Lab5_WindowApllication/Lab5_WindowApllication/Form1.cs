using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WindowApllication
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent(); 
        }

        public void LoadListView()
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.danhsachsv)
            {
                ThemSVvaoLV(sv);
            }
        }

        #region Methos

        //lay thong tin sv tu controls them vao danhsachsv
        public SinhVien GetSVConTrols()
        {
            //public SinhVien(string ms, string ho, string ten, bool gt,
            //    DateTime ngaysinh, string lop, string socmnd,
            //    string sodt, string diachi, List<String> cn)
            SinhVien sv = new SinhVien();

            sv.mssv = txbMSSV.Text;
            sv.holot = txbHoLot.Text;
            sv.ten = txbTen.Text;
            sv.gioitinh = false;
            if (rdNam.Checked)
                sv.gioitinh = true;
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
        
        //lay sinh vien tu listview
        public SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = lvitem.SubItems[0].Text;
            sv.holot = lvitem.SubItems[1].Text;
            sv.ten = lvitem.SubItems[2].Text;
            bool gt = false;
            if (lvitem.SubItems[3].Text == "Nam")
                gt = true;
            sv.gioitinh = gt;
            sv.ngaysinh = DateTime.Parse(lvitem.SubItems[4].Text);
            sv.lop = lvitem.SubItems[5].Text;
            sv.socmnd = lvitem.SubItems[6].Text;
            sv.sodt = lvitem.SubItems[7].Text;
            sv.diachi = lvitem.SubItems[8].Text;
            string[] cn = lvitem.SubItems[9].Text.Split(',');
            foreach (string item in cn)
            {
                sv.chuyennganh.Add(item);
            }
            return sv;
        }

        //them sv trong danhsachsv vao controls
        public void ThemSVcontrols(SinhVien sv)
        {
            txbMSSV.Text = sv.mssv;
            txbHoLot.Text = sv.holot;
            txbTen.Text = sv.ten;
            if (sv.gioitinh)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpNgaySinh.Value = sv.ngaysinh;
            txbLop.Text = sv.lop;
            txbCMND.Text = sv.Socmnd;
            txbSoDT.Text = sv.sodt;
            txbDiaChi.Text = sv.diachi;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);

            foreach (string cn in sv.chuyennganh)
            {
                for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                {
                    if (cn.CompareTo(clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
                }
                
            }
        }

        //Them sv trong danhsachsv vao listview
        public void ThemSVvaoLV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.mssv);
            lvitem.SubItems.Add(sv.holot);
            lvitem.SubItems.Add(sv.ten);
            string gt = "Nữ";
            if (sv.gioitinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.ngaysinh.ToShortDateString());
            lvitem.SubItems.Add(sv.lop);
            lvitem.SubItems.Add(sv.socmnd);
            lvitem.SubItems.Add(sv.sodt);
            lvitem.SubItems.Add(sv.diachi);
            string chuyennganh ="";
            foreach (string cn in sv.chuyennganh)
            {
                chuyennganh += cn + ",";
            }
            chuyennganh = chuyennganh.Substring(0, chuyennganh.Length - 1);
            lvitem.SubItems.Add(chuyennganh);

            lvSinhVien.Items.Add(lvitem);
        }
        #endregion

        #region Events

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSVConTrols();
            bool kq = qlsv.Sua(sv);
            if (kq)
            {
                MessageBox.Show("Sửa thành công !", "Thông Báo");
                LoadListView();
                qlsv.GhiFile();
            }
            else
                MessageBox.Show("Mã số SV không hợp lệ !", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = lvSinhVien.SelectedItems.Count;
            if(count > 0)
            {
                ListViewItem lvitem = lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                SinhVien sv2 = null;
                bool kt = false;
                if ((MessageBox.Show("Bạn có thực sự muốn xóa sinh viên ms: " + sv.mssv, "Thông báo", MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (SinhVien item in qlsv.danhsachsv)
                    {
                        if (sv.mssv == item.mssv)
                            kt = true;
                            sv2 = item;
                    }
                    if (kt)
                    {
                        qlsv.danhsachsv.Remove(sv2);
                        LoadListView();
                        qlsv.GhiFile();
                    }   
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn Sinh Viên để xóa !");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTK = new frmTimKiem();
            frmTK.ShowDialog();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (txbMSSV.Text != "")
            {
                SinhVien sv = GetSVConTrols();
                bool kt = true;
                foreach (SinhVien item in qlsv.danhsachsv)
                {
                    if (sv.mssv == item.mssv)
                        kt = false;
                }
                if (kt)
                {
                    qlsv.danhsachsv.Add(sv);
                    qlsv.GhiFile();
                    MessageBox.Show("Thêm SV thành công", "Thông Báo");
                }
                else
                    MessageBox.Show("Mã số SV bị trùng", "Thông Báo");

                LoadListView();
            }
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin, không bị lỗi ấy", "Thông Báo");
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThemSVcontrols(sv);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
