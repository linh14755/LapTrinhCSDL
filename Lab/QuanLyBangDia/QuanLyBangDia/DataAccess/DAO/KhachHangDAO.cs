using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class KhachHangDAO
    {
        public static KhachHangDAO instance = new KhachHangDAO();
        public KhachHangDAO() { }
        public KhachHang GetKHByID(string id)
        {
            var data = DataProvider.instance.ExcuteQuery("select * from KhachHang where MaKH = " + id + "");
            foreach (DataRow row in data.Rows)
            {
                KhachHang k = new KhachHang(row);
                if (k.makh == id)
                    return k;
            }
            return null;
        }
        public bool Insert(KhachHang k)
        {
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("exec USP_InsertKhachHang N'{0}' , N'{1}' , N'{2}'", k.tenkh, k.sodt, k.diachi));
            return result > 0;
        }
        public bool Update(KhachHang k)
        {
            if (k.makh == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("exec USP_UpdateKhachHang {0} , N'{1}' , N'{2}' , N'{3}'", k.makh, k.tenkh, k.sodt, k.diachi));
            return result > 0;
        }
        public bool Delete(string makh)
        {
            if (makh == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery("delete KhachHang where MaKH = " + makh + "");
            return result > 0;
        }

        public List<KhachHang> GetList()
        {
            List<KhachHang> l = new List<KhachHang>();
            var data = DataProvider.instance.ExcuteQuery("select * from KhachHang");
            foreach (DataRow row in data.Rows)
            {
                KhachHang k = new KhachHang(row);
                l.Add(k);
            }
            return l;
        }
    }
}
