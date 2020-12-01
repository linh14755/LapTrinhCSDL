using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class DataProvider
    {
        string connectSRT = ConfigurationManager.ConnectionStrings["QLBD"].ConnectionString;
        public static DataProvider instance = new DataProvider();
        public DataProvider() { }

        public DataTable ExcuteQuery(string query)
        {
            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                connect.Close();
                return data;
            }
        }

        public int ExcuteNonQuery(string query)
        {
            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);

                int data = command.ExecuteNonQuery();
                connect.Close();

                return data;
            }
        }
    }
}
