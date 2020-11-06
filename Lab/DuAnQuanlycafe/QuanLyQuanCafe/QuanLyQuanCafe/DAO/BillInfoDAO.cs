using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance = new BillInfoDAO();

        public static BillInfoDAO Instance { get => instance; set => instance = value; }

        public void InsertBillInfo(int idbill, int idfood,int count)
        {
            DataProvider.Instance.ExcuteQuery("exec USP_InsertBillInfo @idbill , @idfood , @count", new object[] { idbill, idfood, count });
        }
        public int GetIDMax()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("select max(id) from Bill");
            }
            catch
            {
                return 1;
            }
            
        }
    }
}
