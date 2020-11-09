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
    public partial class Form1 : Form
    {
        string connectSRT = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        #region Methods
        public bool KiemTra()
        {
            bool kt = true;
            if (txbID.Text != "" && txbName.Text != "" && txbType.Text != "")
            {
                if (txbType.Text == "Đồ ăn" || txbType.Text == "1" || txbType.Text == "Thức uống" || txbType.Text == "0")
                {
                    if (txbType.Text == "Đồ ăn")
                        txbType.Text = "1";
                    if (txbType.Text == "Thức uống")
                        txbType.Text = "0";
                }
                else
                {
                    MessageBox.Show("Type bị sai !");
                    kt = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ thông tin trước khi hoặc thêm hoặc cập nhật !");
                kt = false;
            }
            return kt;
        }

        private void DisPlayCateGory(SqlDataReader reader)
        {
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvitem = new ListViewItem(reader["ID"].ToString());
                lvitem.SubItems.Add(reader["Name"].ToString());
                lvitem.SubItems.Add(reader["Type"].ToString());

                listView1.Items.Add(lvitem);
            }
        }

        #endregion
        #region Events

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txbID.Text != "")
            {
                frmFood frmfood = new frmFood();
                frmfood.LoadFood(Convert.ToInt32(txbID.Text));
                frmfood.ShowDialog();
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btnXoa.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from Category where ID = " + txbID.Text + "";

            SqlConnection connect = new SqlConnection(connectSRT);
            connect.Open();

            SqlCommand command = new SqlCommand(query, connect);
            int numOfRowEffected = 0;

            if (txbName.Text != "" || txbType.Text != "")
            {
                numOfRowEffected = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }

            connect.Close();
            if (numOfRowEffected == 1)
            {
                btnGetDS.PerformClick();
                MessageBox.Show("Xóa món ăn thành công");

                txbID.Text = "";
                txbName.Text = "";
                txbType.Text = "";
            }

            //SqlDataReader sqlDataReader = command.ExecuteReader();
            //this.DisPlayCateGory(sqlDataReader);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            if(KiemTra())
            {
                string query = "update Category set Name = N'" + txbName.Text + "', Type = " + txbType.Text + " where id = " + txbID.Text + "";

                SqlConnection connect = new SqlConnection(connectSRT);
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);
                int numOfRowEffected = 0;

                if (txbName.Text != "" || txbType.Text != "")
                {
                    numOfRowEffected = command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }

                connect.Close();
                if (numOfRowEffected == 1)
                {
                    MessageBox.Show("Cập nhật món ăn thành công");
                    btnGetDS.PerformClick();

                    txbID.Text = "";
                    txbName.Text = "";
                    txbType.Text = "";
                }


                //SqlDataReader sqlDataReader = command.ExecuteReader();
                //this.DisPlayCateGory(sqlDataReader);
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            txbID.Text = item.Text;
            txbName.Text = item.SubItems[1].Text;
            txbType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (KiemTra())
            {
                string query = "insert into Category(Name,Type) values(N'" + txbName.Text + "' , " + txbType.Text + ")";

                SqlConnection connect = new SqlConnection(connectSRT);
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);
                int numOfRowEffected = 0;

                if (txbName.Text != "" || txbType.Text != "")
                {
                    numOfRowEffected = command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }

                connect.Close();
                if (numOfRowEffected == 1)
                {
                    MessageBox.Show("Thêm món ăn thành công");
                    btnGetDS.PerformClick();

                    txbID.Text = "";
                    txbName.Text = "";
                    txbType.Text = "";
                }

                //SqlDataReader sqlDataReader = command.ExecuteReader();
                //this.DisPlayCateGory(sqlDataReader);
            }

        }

        private void btnGetDS_Click(object sender, EventArgs e)
        {
            string query = "select * from Category";

            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                this.DisPlayCateGory(sqlDataReader);
                connect.Close();
            }
        }

        #endregion

        private void btnDanhSachBill_Click(object sender, EventArgs e)
        {
            frmBill frmbill = new frmBill();
            frmbill.ShowDialog();
        }
    }
}
