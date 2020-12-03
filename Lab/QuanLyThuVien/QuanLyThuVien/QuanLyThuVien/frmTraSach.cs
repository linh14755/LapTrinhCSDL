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
    public partial class frmTraSach : Form
    {
        string madg;
        List<MuonSach> list = new List<MuonSach>();
        public frmTraSach()
        {
            InitializeComponent();
        }
        public frmTraSach(List<MuonSach> l)
        {
            InitializeComponent();
            this.list = l;
            LoadDanhSachLV(list);
            GetMaDG(list[0].madg);
        }
        
        public void GetMaDG(string madg)
        {
            this.madg = madg;
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

        private void btntrasach_Click(object sender, EventArgs e)
        {
            MessageBoxOKCancel box = new MessageBoxOKCancel();
            box.SetMessage("Bạn có muốn trả hết sách cho đọc giả này không?");
            if(box.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < lvsach.Items.Count; i++)
                {
                    var sophieumuon = lvsach.Items[i].SubItems[0].Text;
                    MuonTraDAO.instance.TraSach(sophieumuon);
                }
                LoadDanhSachLV(MuonTraDAO.instance.GetListByMaDG(madg));
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (lvsach.SelectedItems.Count == 0) return;

            var sophieumuon = lvsach.SelectedItems[0].Text;

            MuonTraDAO.instance.TraSach(sophieumuon);

            LoadDanhSachLV(MuonTraDAO.instance.GetListByMaDG(madg));
        }
    }
}
