using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class DocGiaDAO
    {

        private static DocGiaDAO instance = new DocGiaDAO();
        public DocGiaDAO() { }

        public static DocGiaDAO Instance { get => instance; set => instance = value; }

        public void DangKyDocGia(string tk, string mk, string hoten, string ngaysinh, string gt, string lop, string diachi, string email,string ghichu)
        {
            string query = "INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, LOP, DIACHI, EMAIL, GHICHU) VALUES (N'" + tk + "',N'" + mk + "',N'" + hoten + "', N'" + ngaysinh + "', N'" + gt + "', N'" + lop + "', N'" + diachi + "',N'" + email + "' , N'" + ghichu + "')";
            DataProvider.instance.ExcuteQuery(query);
        }

        public bool LoginDocgia(string acc,string pass)
        {

           DataTable data =  DataProvider.instance.ExcuteQuery("select* from  DocGia where TaiKhoan = @tk and matkhau = @mk", new object[] { acc, pass });

            return data.Rows.Count > 0;
        }
    }
}
