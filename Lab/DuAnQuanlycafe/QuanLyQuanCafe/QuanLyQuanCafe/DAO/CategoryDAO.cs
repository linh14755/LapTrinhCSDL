using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = new CategoryDAO();
        public CategoryDAO() { }


        public List<Category> GetListcategory()
        {
            List<Category> list = new List<Category>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select *from FoodCategory");

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public static CategoryDAO Instance { get => instance; set => instance = value; }
    }
}
