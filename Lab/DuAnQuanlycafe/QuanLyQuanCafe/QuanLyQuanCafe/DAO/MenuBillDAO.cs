using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public class MenuBillDAO
    {
        private static MenuBillDAO instance = new MenuBillDAO();

        public MenuBillDAO() { }

        public List<MenuBill> LoadMenuBill(int idtable)
        {
            List<MenuBill> listmenu = new List<MenuBill>();
            string query = "select f.name, bi.count ,f.price, f.price*bi.count as totalprice from bill as b, BillInfo as bi, Food as f where b.id = bi.idBill and bi.idFood = f.id and b.status = 0 and b.idTable = " + idtable;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuBill menubill = new MenuBill(item);

                listmenu.Add(menubill);
            }

            return listmenu;
        }

        public static MenuBillDAO Instance { get => instance; set => instance = value; }
    }
}
