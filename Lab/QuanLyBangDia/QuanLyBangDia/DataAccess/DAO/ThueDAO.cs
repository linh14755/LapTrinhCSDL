using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ThueDAO
    {
        public static ThueDAO instance = new ThueDAO();
        public ThueDAO() { }

        public List<Thue> GetListByNgayTra(DateTime datefrom, DateTime dateto)
        {
            List<Thue> l = new List<Thue>();
            var data = DataProvider.instance.ExcuteQuery("select * from Thue where status = 1 and NgayTra between '" + datefrom + "' and '" + dateto + "'");
            foreach (DataRow row in data.Rows)
            {
                Thue t = new Thue(row);
                l.Add(t);
            }
            return l;
        }
        public List<Thue> GetListThueDaTra()
        {
            List<Thue> l = new List<Thue>();
            var data = DataProvider.instance.ExcuteQuery("select * from Thue where status = 1");
            foreach (DataRow row in data.Rows)
            {
                Thue t = new Thue(row);
                l.Add(t);
            }
            return l;
        }
        public bool TraHet(string makh)
        {
            var result = DataProvider.instance.ExcuteNonQuery("update Thue set status = 1 where MaKH = " + makh + " and status = 0");
            return result > 0;
        }
        public List<Thue> GetListByMAKH(string makh)
        {
            List<Thue> l = new List<Thue>();
            var data = DataProvider.instance.ExcuteQuery("select * from Thue where status = 0 and MaKH = " + makh + "");
            foreach (DataRow row in data.Rows)
            {
                Thue k = new Thue(row);
                l.Add(k);
            }
            return l;
        }
        public bool Tra(string maluot)
        {
            var result = DataProvider.instance.ExcuteNonQuery("update Thue set status = 1 where Luot = " + maluot + "");
            return result > 0;
        }
        public Thue GetBDByID(string id)
        {
            var data = DataProvider.instance.ExcuteQuery("select * from Thue where Luot = " + id + "");
            foreach (DataRow row in data.Rows)
            {
                Thue k = new Thue(row);
                if (k.luot == id)
                    return k;
            }
            return null;
        }
        public bool Insert(Thue k)
        {
            string query = string.Format("exec USP_InsertThue {0} , {1} , {2} , '{3}' , '{4}' , {5}", k.mabd, k.makh, k.tiencoc, k.ngaythue, k.ngaytra, k.tongtien);
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool Update(Thue k)
        {
            if (k.mabd == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("exec USP_UpdateThue {0} , {1} , {2} , {3}, '{4}' , '{5}' , {6}", k.luot, k.mabd, k.makh, k.tiencoc, k.ngaythue, k.ngaytra, k.tongtien));
            return result > 0;
        }
        public bool Delete(string luot)
        {
            if (luot == "0") return false;
            int result = DataProvider.instance.ExcuteNonQuery("delete Thue where Luot = " + luot + "");
            return result > 0;
        }

        public List<Thue> GetList()
        {
            List<Thue> l = new List<Thue>();
            var data = DataProvider.instance.ExcuteQuery("select * from Thue where status = 0");
            foreach (DataRow row in data.Rows)
            {
                Thue k = new Thue(row);
                l.Add(k);
            }
            return l;
        }
    }
}
