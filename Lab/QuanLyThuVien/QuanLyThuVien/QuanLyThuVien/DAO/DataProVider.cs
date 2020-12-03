using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyThuVien.DAO
{
    public class DataProvider
    {
        public static DataProvider instance = new DataProvider();

        public static DataProvider Instance { get => instance; set => instance = value; }

        public static string connectSRT = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;

        public DataTable ExcuteQuery(string query, object[] paramaters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (paramaters != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
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


        //tra ve so dong thanh cong
        public int ExcuteNonQuery(string query, object[] paramaters = null)
        {
            int data = 0;

            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (paramaters != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connect.Close();
            }

            return data;
        }


        //tra ve thong tin dong dau tien cua cot dau tien
        public object ExcuteScalar(string query, object[] paramaters = null)
        {
            object data;

            using (SqlConnection connect = new SqlConnection(connectSRT))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (paramaters != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramaters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connect.Close();
            }

            return data;
        }
    }
}
