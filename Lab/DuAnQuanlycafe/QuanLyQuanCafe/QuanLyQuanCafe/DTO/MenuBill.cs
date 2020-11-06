using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MenuBill
    {
        private string foodname;
        private int count;
        private float price;
        private float totalprice;
        public MenuBill(string foodname, int count, float price, float totalprice = 0)
        {
            this.foodname = foodname;
            this.count = count;
            this.price = price;
            this.totalprice = totalprice;
        }
        public MenuBill() { }

        public MenuBill(DataRow row)
        {
            this.foodname = row["name"].ToString();
            this.count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }

        public string Foodname { get => foodname; set => foodname = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
