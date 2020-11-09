using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class frmFood : Form
    {
        string connectSRT = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public frmFood()
        {
            InitializeComponent();
        }

        #region Methods

        public bool KiemTra()
        {
            if (txbName.Text != "" && txbUnits.Text != "" && txbPrice.Text != "")
            {
                double num;
                if (double.TryParse(txbPrice.Text, out num))
                    return true;
                else
                {
                    MessageBox.Show("Price phải là số");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin");
                return false;
            }
        }

        //hien thi len listview
        public void DisplayFood(DataTable data)
        {
            lvFood.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem lvitem = new ListViewItem(row["ID"].ToString());
                lvitem.SubItems.Add(row["Name"].ToString());
                lvitem.SubItems.Add(row["Unit"].ToString());
                lvitem.SubItems.Add(row["FoodCategoryID"].ToString());
                lvitem.SubItems.Add(row["price"].ToString());
                lvitem.SubItems.Add(row["notes"].ToString());

                lvFood.Items.Add(lvitem);
            }
        }

        #endregion

        #region Envents

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbID.Text, idcategory = txbIdCateGory.Text;
            string query = "delete Food where id = " + id + "";
            if (MessageBox.Show("Bạn có muốn xóa food có id = " + id + " ?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(connectSRT))
                {
                    connect.Open();

                    SqlCommand command = new SqlCommand(query, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    connect.Close();
                }
                LoadFood(Convert.ToInt32(idcategory));
            }
        }

        public void LoadFood(int categoryID)
        {
            txbIdCateGory.Text = categoryID.ToString();
            string query = "select Name from Category where ID = " + categoryID + "";

            SqlConnection connect = new SqlConnection(connectSRT);
            connect.Open();

            SqlCommand command = new SqlCommand(query, connect);

            //string catName = null;

            //catName = command.ExecuteScalar().ToString();
            //this.Text = "danh sách thuộc nhóm: " + catName;

            string query2 = "select * from Food where FoodCategoryID = " + categoryID + "";

            SqlCommand command2 = new SqlCommand(query2, connect);

            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable data = new DataTable();
            adapter.Fill(data);

            connect.Close();

            //hien thi len listview
            DisplayFood(data);


        }

        private void tbnCreate_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                //create
                string id = txbID.Text, name = txbName.Text, units = txbUnits.Text, idcategory = txbIdCateGory.Text, price = txbPrice.Text, notes = txbNotes.Text;
                string query = "insert into Food(Name,Unit,FoodCategoryID,price,notes) values(N'" + name + "',N'" + units + "'," + idcategory + "," + price + ", N'" + notes + "')";
                if (MessageBox.Show("Bạn có muốn tạo mới Food ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectSRT))
                    {
                        connect.Open();

                        SqlCommand command = new SqlCommand(query, connect);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        connect.Close();
                    }
                    LoadFood(Convert.ToInt32(idcategory));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                //update
                string id = txbID.Text, name = txbName.Text, units = txbUnits.Text, idcategory = txbIdCateGory.Text, price = txbPrice.Text, notes = txbNotes.Text;
                string query = "update Food set Name = N'" + name + "' ,Unit = N'" + units + "',FoodCategoryID = N'" + idcategory + "',price = N'" + price + "',notes =N'" + notes + "' where ID = " + id + "";
                if (MessageBox.Show("Bạn có muốn chỉnh sửa Food tại FoodId = " + id + " ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataTable data = new DataTable();
                    using (SqlConnection connect = new SqlConnection(connectSRT))
                    {
                        connect.Open();

                        SqlCommand command = new SqlCommand(query, connect);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        adapter.Fill(data);

                        connect.Close();
                    }
                    LoadFood(Convert.ToInt32(idcategory));

                    //DisplayFood(data);
                }
            }
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            ListViewItem lvitem = lvFood.SelectedItems[0];

            txbID.Text = lvitem.SubItems[0].Text;
            txbName.Text = lvitem.SubItems[1].Text;
            txbUnits.Text = lvitem.SubItems[2].Text;
            txbIdCateGory.Text = lvitem.SubItems[3].Text;
            txbPrice.Text = lvitem.SubItems[4].Text;
            txbNotes.Text = lvitem.SubItems[5].Text;
        }

        #endregion
        
    }
}
