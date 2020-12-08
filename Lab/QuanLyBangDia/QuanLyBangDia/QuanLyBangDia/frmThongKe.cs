using DataAccess.DAO;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangDia
{
    public partial class frmThongKe : Form
    {
        List<Thue> l = new List<Thue>();
        public frmThongKe()
        {
            InitializeComponent();
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
            l = ThueDAO.instance.GetListThueDaTra();
            LoadListView(l);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            l = ThueDAO.instance.GetListByNgayTra(dtpFrom.Value, dtpTo.Value);
            LoadListView(l);
        }
    }
}
