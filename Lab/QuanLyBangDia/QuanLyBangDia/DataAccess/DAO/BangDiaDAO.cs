using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class BangDiaDAO
    {
        public static BangDiaDAO instance = new BangDiaDAO();
        public BangDiaDAO() { }
        public BangDia GetBDByID(string id)
        {
            var data = DataProvider.instance.ExcuteQuery("select * from BangDia where MaBD = " + id + "");
            foreach (DataRow row in data.Rows)
            {
                BangDia k = new BangDia(row);
                if (k.mabd == id)
                    return k;
            }
            return null;
        }
        public bool Insert(BangDia k)
        {
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("exec USP_InsertBangDia N'{0}' , {1} , {2} , N'{3}'", k.tenbd, k.soluong, k.dongia, k.theloai));
            return result > 0;
        }
        public bool Update(BangDia k)
        {
            if (k.mabd == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("exec USP_UpdateBangDia {0} , N'{1}' , {2} , {3} , N'{4}'", k.mabd, k.tenbd, k.soluong, k.dongia, k.theloai));
            return result > 0;
        }
        public bool Delete(string makh)
        {
            if (makh == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery("delete BangDia where MaBD = " + makh + "");
            return result > 0;
        }

        public List<BangDia> GetList()
        {
            List<BangDia> l = new List<BangDia>();
            var data = DataProvider.instance.ExcuteQuery("select * from BangDia");
            foreach (DataRow row in data.Rows)
            {
                BangDia k = new BangDia(row);
                l.Add(k);
            }
            return l;
        }
    }
}
