using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance = new DataProvider();
        string conncetSRT = @"Data Source=LAPTOP-AB3AI976;Initial Catalog=QuanlyQuanCafe;Integrated Security=True";

        public static DataProvider Instance { get => instance; set => instance = value; }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(conncetSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (var item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }

        //tra ve so dong thanh cong khi truy van
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(conncetSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (var item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
        }
        //tra ve so luong khi thuc hien count(*)
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(conncetSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (var item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connect.Close();
                return data;
            }
        }

    }
}
