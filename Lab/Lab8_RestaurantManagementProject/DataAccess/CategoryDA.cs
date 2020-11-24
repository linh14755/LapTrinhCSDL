using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        //Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Category> GettAll()
        {
            using (SqlConnection connect = new SqlConnection(Ultilities.ConnectionString))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Ultilities.Category_GetAll;

                SqlDataReader read = command.ExecuteReader();
                List<Category> list = new List<Category>();
                while (read.Read())
                {
                    Category category = new Category();
                    category.ID = Convert.ToInt32(read["ID"]);
                    category.Name = read["Name"].ToString();
                    category.Type = Convert.ToInt32(read["Type"]);
                    list.Add(category);
                }
                connect.Close();
                return list;
            }

        }
        //Phương thức thêm, xoá, sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            using (SqlConnection connect = new SqlConnection(Ultilities.ConnectionString))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Ultilities.Category_InsertUpdateDelete;

                // Thêm các tham số cho thủ tục; Các tham số này chính là các tham số trong thủ tục;
                //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xoá, sửa
                SqlParameter Idpara = new SqlParameter("@ID", SqlDbType.Int);
                Idpara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra
                command.Parameters.Add(Idpara).Value = category.ID;
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;
                command.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
                command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                // Thực thi lệnh
                int result = command.ExecuteNonQuery();
                if (result > 0) //tra ve ID da them
                    return (int)command.Parameters["@ID"].Value;
                return 0;
            }
        }
    }
}
