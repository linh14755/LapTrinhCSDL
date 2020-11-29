using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class BookDAO
    {
        public static BookDAO instance = new BookDAO();
        public BookDAO() { }
        public string ConvertDateTime(DateTime datetime)
        {
            return Convert.ToDateTime(datetime).ToString("yyyy-MM-dd");
        }
        public bool Delete(string id)
        {
            int result = 0;
            var kt = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaSach = " + id + "");
            if (kt.Rows.Count <= 0)
                result = DataProvider.instance.ExcuteNonQuery("delete Sach where MaSach = @id", new object[] { id });
            return result > 0;
        }
        public bool Update(Book b)
        {
            string namxb = ConvertDateTime(b.namxb);
            string ngaynhap = ConvertDateTime(b.ngaynhap);

            int result = DataProvider.instance.ExcuteNonQuery("update Sach set TENSACH = @tensach , TENTG = @tentg , TENNXB = @tennxb , TENLV = @tenlv , NAMXB = '" + namxb + "' ,GhiChu = N'" + b.ghichu + "', SOLUONG = @soluong , NGAYNHAP = '" + ngaynhap + "' where MASACH = @id", new object[] { b.tensach, b.tentg, b.tennxb, b.tenlv, b.sl, b.masach });
            return result > 0;
        }
        public bool Insert(Book b)
        {
            string namxb = ConvertDateTime(b.namxb);
            string ngaynhap = ConvertDateTime(b.ngaynhap);

            string query = "INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'" + b.tensach + "', N'" + b.tentg + "', N'" + b.tennxb + "', N'" + b.tenlv + "', '" + namxb + "', " + b.sl + ", '" + ngaynhap + "')";
            int restult = DataProvider.instance.ExcuteNonQuery(query);
            return restult > 0;
        }
        public List<Book> FindByID(string id)
        {
            List<Book> lstbook = new List<Book>();
            string query = "SELECT * FROM SACH where masach = " + id + "";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Book book = new Book(row);
                lstbook.Add(book);
            }
            return lstbook;
        }

        public List<Book> GetList()
        {
            List<Book> lstbook = new List<Book>();
            string query = "SELECT * FROM SACH";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Book book = new Book(row);
                lstbook.Add(book);
            }
            return lstbook;
        }
    }
}
