using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class SachDAO
    {
        public static SachDAO instance = new SachDAO();
        public SachDAO() { }
        public bool Delete(string id)
        {
            int result = 0;
            var kt = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaSach = " + id + "");
            if (kt.Rows.Count <= 0)
                result = DataProvider.instance.ExcuteNonQuery("delete Sach where MaSach = @id", new object[] { id });
            return result > 0;
        }
        public bool Update(Sach b)
        {
            int result = DataProvider.instance.ExcuteNonQuery("update Sach set TENSACH = @tensach , TENTG = @tentg , TENNXB = @tennxb , TENLV = @tenlv , NAMXB = '" + b.namxb + "' ,GhiChu = N'" + b.ghichu + "', SOLUONG = @soluong , NGAYNHAP = '" + b.ngaynhap + "' where MASACH = @id", new object[] { b.tensach, b.tentg, b.tennxb, b.tenlv, b.sl, b.masach });
            return result > 0;
        }
        public bool Insert(Sach b)
        {
            string query = "INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'" + b.tensach + "', N'" + b.tentg + "', N'" + b.tennxb + "', N'" + b.tenlv + "', '" + b.namxb + "', " + b.sl + ", '" + b.ngaynhap + "')";
            int restult = DataProvider.instance.ExcuteNonQuery(query);
            return restult > 0;
        }
        public List<Sach> FindByID(string id)
        {
            List<Sach> lstbook = new List<Sach>();
            string query = "SELECT * FROM SACH where masach = " + id + "";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Sach book = new Sach(row);
                lstbook.Add(book);
            }
            return lstbook;
        }

        public List<Sach> GetList()
        {
            List<Sach> lstbook = new List<Sach>();
            string query = "SELECT * FROM SACH";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Sach book = new Sach(row);
                lstbook.Add(book);
            }
            return lstbook;
        }
    }
}
