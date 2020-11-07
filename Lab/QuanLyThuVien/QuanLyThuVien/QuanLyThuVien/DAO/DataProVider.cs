using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class DataProVider
    {
        public static DataProVider instance = new DataProVider();

        public static DataProVider Instance { get => instance; set => instance = value; }

        string connectSRT = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        public DataTable ExcuteQuery (string query)
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
                
            return data;
        }
    }
}
