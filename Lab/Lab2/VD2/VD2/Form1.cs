using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD2
{



    public partial class frmGiaoVien : Form
    {
        private QuanLyGiaoVien quanLyGV;
        public frmGiaoVien()
        {
            InitializeComponent();
            quanLyGV = new QuanLyGiaoVien();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string lienhe = "https://www.google.com.vn/?hl=vi";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            //this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.ngaysinh = this.dtpNgaySinh.Value;
            gv.mail = this.txtMail.Text;
            gv.soDT = this.mtxtSoDT.Text;
            //lay thong tin ngoai ngu
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            }
            gv.ngoaingu = ngoaingu.Split(';');
            //lay thong tin danh sach mon hoc
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
                mh.ThemMH(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            return gv;

        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            };
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            };
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = false;
            this.rdNu.Checked = false;
            //bo chon tren chklbNgoaiNgu
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }
            //chuyen cac danh muc tu lbMonHocDay ve lbDanhSachMH
            foreach (object ob in this.lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            this.lbMonHocDay.Items.Clear();
        }
        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        public class MonHoc
        {
            public int ID { get; set; }
            public string TenMH { get; set; }
            public int SoTC { get; set; }
            public MonHoc() { }
            public MonHoc(string ten)
            {
                this.TenMH = ten;
            }
            public MonHoc(int id, string ten, int tc)
            {
                this.ID = id;
                this.TenMH = ten;
                this.SoTC = tc;
            }
            public override string ToString()
            {
                return TenMH;
            }
        }
        public class DanhMucMonHoc
        {
            public ArrayList ds;
            public DanhMucMonHoc()
            {
                ds = new ArrayList();
            }
            public MonHoc this[int index]
            {
                get { return ds[index] as MonHoc; }
                set { ds[index] = value; }
            }
            public void ThemMH(MonHoc mh)
            {
                ds.Add(mh);
            }
            public override string ToString()
            {
                string s = "Danh sach mon hoc: ";
                foreach (object mh in ds)
                {
                    s += mh as MonHoc + ";";
                }
                return s;
            }
        }
        public class GiaoVien
        {
            public string MaSo { get; set; }
            public string HoTen { get; set; }
            public DateTime ngaysinh;
            public DanhMucMonHoc dsMonHoc;
            public string GioiTinh;
            public string[] ngoaingu;
            public string soDT;
            public string mail;

            public GiaoVien()
            {
                dsMonHoc = new DanhMucMonHoc();
                ngoaingu = new string[10];
            }
            public GiaoVien(string maso, string hoten, DateTime ngaysinh,
                DanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
            {
                this.MaSo = maso;
                this.HoTen = hoten;
                this.ngaysinh = ngaysinh;
                this.dsMonHoc = ds;
                this.GioiTinh = gt;
                this.ngoaingu = nn;
                this.soDT = sdt;
                this.mail = mail;
            }
            public override string ToString()
            {
                string s = "Mã Số: " + MaSo + "\n" + "Họ tên: " + HoTen + "\n"
                    + "Ngày Sinh: " + ngaysinh.ToString() + "\n"
                    + "Giới Tính: " + GioiTinh + "\n"
                    + "Số ĐT: " + soDT + "\n"
                    + "Mail: " + mail + "\n";
                string sngoaingu = "Ngoại Ngữ: ";
                foreach (string t in ngoaingu)
                    sngoaingu += t + "\n";
                string MonDay = "Danh sách môn dạy: ";
                foreach (MonHoc mh in dsMonHoc.ds)
                    MonDay += mh + "\n";
                s += "\n" + sngoaingu + "\n" + MonDay;
                return s;
            }

        }
        public class QuanLyGiaoVien
        {
            public delegate int SoSanh(object a, object b);
            List<GiaoVien> dsGiaoVien;

            public QuanLyGiaoVien()
            {
                dsGiaoVien = new List<GiaoVien>();
            }

            public GiaoVien this[int index]
            {
                get { return dsGiaoVien[index] as GiaoVien; }
                set { dsGiaoVien[index] = value; }
            }
            public bool Them(GiaoVien giaoVien)
            {
                if (!Tim(giaoVien))
                {
                    dsGiaoVien.Add(giaoVien);
                    return true;
                }
                return false;
            }

            private bool Tim(GiaoVien gv)
            {
                foreach (var item in dsGiaoVien)
                {
                    if (item.MaSo == gv.MaSo)
                        return true;
                }
                return false;
            }
            public enum KieuTim
            {
                TheoMa,
                TheoHoTen,
                TheoSDT
            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var giaoVien = GetGiaoVien();
            var success = quanLyGV.Them(giaoVien);
            if (!success)
            {
                MessageBox.Show("Giáo viên có mã số " + giaoVien.MaSo + " đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
        }
    }
}
