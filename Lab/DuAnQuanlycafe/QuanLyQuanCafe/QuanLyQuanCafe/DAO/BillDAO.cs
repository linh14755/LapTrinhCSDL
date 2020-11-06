using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance = new BillDAO();

        public BillDAO() { }

        public void UncheckBill(int idtable)
        {
            string query = "update Bill set status = 1 where idTable = " + idtable;
            DataProvider.Instance.ExcuteQuery(query);
        }

        public void InsertBill(int idtable)
        {
            DataProvider.Instance.ExcuteQuery("exec USP_InsertBill @idtable", new object[] { idtable });
        }

        public int GetIDBillByIDTable(int idtable)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetIDBillByIdTable @idtable", new object[] { idtable });

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public static BillDAO Instance { get => instance; set => instance = value; }
    }
}
