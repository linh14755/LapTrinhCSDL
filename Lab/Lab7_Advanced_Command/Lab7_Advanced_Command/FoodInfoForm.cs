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
    public partial class FoodInfoForm : Form
    {
        string connectSTR = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            InitValues();
        }
        private void ResetText()
        {
            txbFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbcatName.ResetText();
            nmPrice.ResetText();
        }

        private void InitValues()
        {
            using(SqlConnection connect = new SqlConnection(connectSTR))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandText = "select ID , Name from Category";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dtset = new DataSet();

                adapter.Fill(dtset,"Category");

                //hien thi len combobox
                cbbcatName.DataSource = dtset.Tables["Category"];
                cbbcatName.DisplayMember = "Name";
                cbbcatName.ValueMember = "ID";

                connect.Close();
            }
        }

        public void DisplayFoodInfo(DataRowView rowview)
        {
            try
            {
                txbFoodID.Text = rowview["ID"].ToString();
                txtName.Text = rowview["Name"].ToString();
                txtUnit.Text = rowview["Unit"].ToString();
                txtNotes.Text = rowview["Notes"].ToString();
                nmPrice.Text = rowview["Price"].ToString();

                cbbcatName.SelectedIndex = -1;

                for (int index = 0; index < cbbcatName.Items.Count; index++)
                {
                    DataRowView cat = cbbcatName.Items[index] as DataRowView;

                    if (cat["ID"].ToString() == rowview["FoodCategoryID"].ToString())
                    {
                        cbbcatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectSTR))
                {
                    connect.Open();

                    SqlCommand command = connect.CreateCommand();
                    command.CommandText = "execute USP_InsertFood  @ID output , @Name  , @Unit, @FoodCategoryId , @Price , @Notes";

                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar,100);
                    command.Parameters.Add("@Unit", SqlDbType.NVarChar,100);
                    command.Parameters.Add("@FoodCategoryId", SqlDbType.Int);
                    command.Parameters.Add("@Price", SqlDbType.NVarChar,100);
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar,100);

                    command.Parameters["@id"].Direction = ParameterDirection.Output;

                    command.Parameters["@Name"].Value = txtName.Text;
                    command.Parameters["@Unit"].Value = txtUnit.Text;
                    command.Parameters["@FoodCategoryId"].Value = cbbcatName.SelectedValue;
                    command.Parameters["@Price"].Value = nmPrice.Text;
                    command.Parameters["@Notes"].Value = txtNotes.Text;

                    int numRowAffected = command.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {
                        string foodid = command.Parameters["@id"].Value.ToString();

                        MessageBox.Show("Thêm thành công tại FoodID = " + foodid,"Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Food bị lỗi");
                    }


                    connect.Close();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
            }
            
        }

        private void cbbcatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FoodInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectSTR))
                {
                    connect.Open();

                    SqlCommand command = connect.CreateCommand();
                    command.CommandText = "exec UpdateFood @ID , @Name , @Unit , @FoodCategoryId , @Price , @Notes";

                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@FoodCategoryId", SqlDbType.Int);
                    command.Parameters.Add("@Price", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 100);

                    command.Parameters["@id"].Value = txbFoodID.Text;

                    command.Parameters["@Name"].Value = txtName.Text;
                    command.Parameters["@Unit"].Value = txtUnit.Text;
                    command.Parameters["@FoodCategoryId"].Value = cbbcatName.SelectedValue;
                    command.Parameters["@Price"].Value = nmPrice.Text;
                    command.Parameters["@Notes"].Value = txtNotes.Text;

                    int numRowAffected = command.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {

                        MessageBox.Show("Update thành công ", "Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Update Food bị lỗi");
                    }


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dtset = new DataSet();

                    adapter.Fill(dtset, "Category");

                    //hien thi len combobox
                    cbbcatName.DataSource = dtset.Tables["Category"];
                    cbbcatName.DisplayMember = "Name";
                    cbbcatName.ValueMember = "ID";

                    connect.Close();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
            }
        }
    }
}
