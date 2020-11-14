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

namespace Lab7_Advanced_Command
{
    public partial class Form1 : Form
    {
        private DataTable foodTable;
        string connectSTR = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                string query = "SELECT ID, Name FROM Category";
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable data = new DataTable();

                adapter.Fill(data);

                connect.Close();
                connect.Dispose();

                //lay gia tri hien thi len combobox
                cbbCategory.DataSource = data;

                cbbCategory.DisplayMember = "Name";

                cbbCategory.ValueMember = "ID";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                string query = "SELECT * FROM Food where FoodCategoryID = @idcategory";
                connect.Open();
                SqlCommand command = connect.CreateCommand();
                command.CommandText = query;

                //truyen paramaters
                command.Parameters.Add("@idcategory", SqlDbType.Int);

                if(cbbCategory.SelectedValue is DataRowView)
                {
                    DataRowView rowview = cbbCategory.SelectedValue as DataRowView;

                    command.Parameters["@idcategory"].Value = rowview["ID"];
                }
                else
                {
                    command.Parameters["@idcategory"].Value = cbbCategory.SelectedValue;
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                 foodTable = new DataTable();

                adapter.Fill(foodTable);

                connect.Close();
                connect.Dispose();

                //lay gia tri hien thi len combobox
                dgvFoodList.DataSource = foodTable;

                lblquantity.Text = "Có tất cả:   "+ foodTable.Rows.Count.ToString();
                lblbcatname.Text = "Món ăn thuộc nhóm:   " +cbbCategory.Text;
            }
        }

        private void tsmCalculateQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                string query = "SELECT @numsalefood = sum(Quantity) from BillDetails where FoodID = @foodid";
                
                SqlCommand command = connect.CreateCommand();
                command.CommandText = query;

                if (dgvFoodList.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectrow = dgvFoodList.SelectedRows[0];

                    DataRowView rowview = selectrow.DataBoundItem as DataRowView;

                    //truyen tham so
                    command.Parameters.Add("@foodid", SqlDbType.Int);
                    command.Parameters["@foodid"].Value = rowview["ID"];

                    command.Parameters.Add("@numsalefood", SqlDbType.Int);
                    command.Parameters["@numsalefood"].Direction = ParameterDirection.Output;

                    connect.Open();

                    //thuc thi va lay du lieu tu tham so
                    command.ExecuteNonQuery();

                    string result = command.Parameters["@numsalefood"].Value.ToString();
                    if (result == "")
                        result = "0";
                    MessageBox.Show("Tổng số lượng món " + rowview["Name"] + " đã bán là: " + result + " "+rowview["Unit"]);
                    connect.Close();
                    connect.Dispose();
                }
            }
        }

        private void tsmAddFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodInfoForm frm = new FoodInfoForm();
            frm.FormClosed += Frm_FormClosed;
            frm.Show(this);
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dgvFoodList.SelectedRows[0];
                DataRowView rowview = selectrow.DataBoundItem as DataRowView;

                FoodInfoForm frm = new FoodInfoForm();
                frm.FormClosed += new FormClosedEventHandler(Frm_FormClosed);
                frm.Show(this);

                frm.DisplayFoodInfo(rowview);
            }
        }

        private void Frm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowsatefilter);

            dgvFoodList.DataSource = foodView;
        }
    }
}
