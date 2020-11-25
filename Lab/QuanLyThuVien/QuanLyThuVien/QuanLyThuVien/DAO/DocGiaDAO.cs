using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using QuanLyThuVien.DTO;
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
        public List<DocGia> GettAll()
        {
            string query = "select * from  DocGia";
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery(query);
            List<DocGia> lst = new List<DocGia>();

            foreach (DataRow row in data.Rows)
            {
                DocGia dg = new DocGia(row);
                lst.Add(dg);
            }
            return lst;
        }

        public bool DangKyDocGia(DocGia dg)
        {
            string query = "INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, LOP, DIACHI, EMAIL, GHICHU) VALUES (N'" + dg.taikhoan + "',N'" + dg.matkau + "',N'" + dg.hoten + "', N'" + dg.ngaysinh + "', N'" + dg.gioitinh + "', N'" + dg.lop + "', N'" + dg.diachi + "',N'" + dg.email + "' , N'" + dg.ghichu + "')";
            int data = 0;
            data = DataProvider.instance.ExcuteNonQuery(query);

            return data > 0;
        }

        public bool LoginDocgia(string acc,string pass)
        {

           DataTable data =  DataProvider.instance.ExcuteQuery("select* from  DocGia where TaiKhoan = @tk and matkhau = @mk", new object[] { acc, pass });

            return data.Rows.Count > 0;
        }
    }
}
