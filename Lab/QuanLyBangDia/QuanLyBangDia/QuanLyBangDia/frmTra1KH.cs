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
    public partial class frmTra1KH : Form
    {
        string makh;
        List<Thue> listthue = new List<Thue>();
        public frmTra1KH(List<Thue> l)
        {
            InitializeComponent();
            this.listthue = l;
            this.makh = listthue[0].makh;
            LoadListView(listthue);
        }
        public frmTra1KH()
        {
            InitializeComponent();
        }
        private void Loads()
        {
            LoadListView(ThueDAO.instance.GetListByMAKH(makh));
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

        private void btnTraHet_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn trả hết đĩa cho khách hàng này?") == DialogResult.OK)
            {
                ThueDAO.instance.TraHet(makh);
                Loads();
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (lvThue.SelectedItems.Count == 0) return;
            ThueDAO.instance.Tra(lvThue.SelectedItems[0].Text);
            Loads();
        }
    }
}
