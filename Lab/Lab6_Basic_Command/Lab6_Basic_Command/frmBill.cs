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
    public partial class frmBill : Form
    {
        string connectSRT = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public frmBill()
        {
            InitializeComponent();
            LoadBill();
            LoadDateTime();
        }

        private  void LoadDateTime()
        {
            DateTime today = DateTime.Now;
            dtpkFrom.Value = new DateTime(today.Year, today.Month, 1);
        }
       
        private void LoadBill()
        {
            DateTime datefrom = dtpkFrom.Value; //dd/mm/yyyy
            DateTime dateto = dtpkTo.Value; //dd/mm/yyyy
            //DateTime newdate = date;//.AddDays(1);
            string createddatefrom = Convert.ToDateTime(datefrom).ToString("yyyy-MM-dd");
            string createdateto = Convert.ToDateTime(dateto).ToString("yyyy-MM-dd");

            string query = "select * from Bills where CheckoutDate between '"+createddatefrom+"' and '"+createdateto+"'"; //  yyyy-mm-dd

            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                //SqlDataReader sqlDataReader = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable data = new DataTable();

                adapter.Fill(data);

                dgvBill.DataSource = data;

                connect.Close();
            }
        }

        private void dtpkFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void dtpkTo_ValueChanged(object sender, EventArgs e)
        {
            LoadBill();
        }
    }
}
