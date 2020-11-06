using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTableList();
            LoadCategory();
        }
        #region Method
        public void LoadTableList()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Tag = item;
                btn.Width = 90;
                btn.Height = 90;
                btn.Text = item.Name + "\n" + item.Status;
                if (item.Status == "Trống")
                    btn.BackColor = Color.Aqua;
                else
                    btn.BackColor = Color.LightYellow;
                flpTable.Controls.Add(btn);
            }
        }

        public void LoadMenuBill(int idtable)
        {
            float totalprice = 0;
            lsvBill.Items.Clear();
            List<MenuBill> listmenubill = MenuBillDAO.Instance.LoadMenuBill(idtable);
            foreach (MenuBill item in listmenubill)
            {
                ListViewItem lvitem = new ListViewItem(item.Foodname);
                lvitem.SubItems.Add(item.Count.ToString());
                lvitem.SubItems.Add(item.Price.ToString());
                lvitem.SubItems.Add(item.Totalprice.ToString());
                lsvBill.Items.Add(lvitem);
                totalprice += item.Totalprice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lsvBill.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tbxtotalprice.Text = totalprice.ToString("c",culture);
        }
        public void LoadCategory()
        {
            List<Category> listcategory = CategoryDAO.Instance.GetListcategory();
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "Name";
        }
        public void LoadListFoodByCategoryID(int id)
        {
            List<Food> listfood = FoodDAO.Instance.GetFoodListByCateGoryID(id);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "name";
        }

        public void InsertBill(int idtable)
        {
            BillDAO.Instance.InsertBill(idtable);
        }

        public void InsertBillInfo(int idbill, int idfood, int count)
        {
            BillInfoDAO.Instance.InsertBillInfo(idbill, idfood, count);
        }

        #endregion

        #region Events


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (MessageBox.Show("Bạn có thực sự muốn thanh toán cho " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.UncheckBill(table.ID);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetIDBillByIDTable(table.ID);
            int idfood = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
                {
                    InsertBill(table.ID);
                    InsertBillInfo(BillInfoDAO.Instance.GetIDMax(), idfood, count);
                }
            else
                {
                    InsertBillInfo(idBill, idfood, count);
                }
            LoadMenuBill(table.ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadListFoodByCategoryID(id);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int idtable = ((sender as Button).Tag as Table).ID;
            LoadMenuBill(idtable);
            lsvBill.Tag = ((sender as Button).Tag as Table);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        #endregion

        
    }
}
