using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance = new FoodDAO();

        public List<Food> GetFoodListByCateGoryID(int id)
        {
            List<Food> listfood = new List<Food>();

            DataTable data = DataProvider.Instance.ExcuteQuery("select *from Food where idCategory = " + id);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listfood.Add(food);
            }
            return listfood;
        }

        public static FoodDAO Instance { get => instance; set => instance = value; }
    }
}
