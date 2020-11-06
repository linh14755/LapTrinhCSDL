using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance = new MenuDAO();
        public MenuDAO() { }

        public static MenuDAO Instance { get => instance; private set => instance = value; }

        public List<MenuBill> GetMenuByIDTable(int idtable)
        {
            List<MenuBill> listmenu = new List<MenuBill>();
            string query = "select f.name, bi.count ,f.price, f.price*bi.count as totalprice from bill as b, BillInfo as bi, Food as f where b.id = bi.idBill and b.status = 0 and bi.idFood = f.id and b.idTable = " + idtable;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuBill menu = new MenuBill(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }

        
    }
}
