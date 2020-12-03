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

        public bool KiemTraTaiKhoan(string tk)
        {
            List<DocGia> lst = DocGiaDAO.instance.GetList();
            foreach (DocGia d in lst)
            {
                if (tk == d.taikhoan)
                {
                    return false;
                }
            }
            return true;
        }

        public bool DoiMK(string tk, string mkmoi, string mkcu)
        {
            string query = "update DocGia set	MATKHAU = N'" + mkmoi + "' where TaiKhoan = N'" + tk + "' and MatKhau = N'" + mkcu + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<DocGia> GetListByTK(string tk)
        {
            List<DocGia> l = new List<DocGia>();
            var data = DataProvider.instance.ExcuteQuery("select * from DocGia where taikhoan = N'" + tk + "'");
            foreach (DataRow row in data.Rows)
            {
                DocGia d = new DocGia(row);
                l.Add(d);
            }
            return l;
        }
        public bool Delete(string id)
        {
            int result = 0;
            var kt = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = " + id + "");
            if (kt.Rows.Count <= 0)
                result = DataProvider.instance.ExcuteNonQuery("delete docgia where MaDG = " + id + "");
            return result > 0;
        }
        public bool UpdateDocGia(DocGia d)
        {
            int gt = 1;
            if (d.gioitinh == false)
                gt = 0;

            string query = "update DocGia set MATkHAU = N'" + d.matkhau + "' , HOTEN = N'" + d.hoten + "' , NGAYSINH = '" + d.ngaysinh + "' ,GIOITINH = " + gt + " , SODT = N'" + d.sodt + "' , DIACHI = N'" + d.diachi + "' ,EMAIL = N'" + d.email + "' where TaiKhoan = N'" + d.taikhoan + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool Update(DocGia d)
        {
            int gt = 1;
            if (d.gioitinh == false)
                gt = 0;
            string query = "update DocGia set MATkHAU = N'" + d.matkhau + "' , HOTEN = N'" + d.hoten + "' , NGAYSINH = '" + d.ngaysinh + "' ,GIOITINH = " + gt + " , SODT = N'" + d.sodt + "' , DIACHI = N'" + d.diachi + "' ,EMAIL = N'" + d.email + "', GhiChu = N'" + d.ghichu + "' where MADG = " + d.madg + "";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;

        }
        public List<DocGia> FindByID(string id)
        {
            List<DocGia> ldg = new List<DocGia>();
            var data = DataProvider.instance.ExcuteQuery("select * from DocGia where MaDG = N'" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                DocGia d = new DocGia(row);
                ldg.Add(d);
            }
            return ldg;
        }
        public bool Insert(DocGia d)
        {
            var data = DataProvider.instance.ExcuteQuery("select * from DocGia");
            int gt = 1;
            if (d.gioitinh == false)
                gt = 0;

            foreach (DataRow row in data.Rows)
            {
                if (d.taikhoan == row["TaiKhoan"].ToString())
                    return false;
            }

            int result = DataProvider.instance.ExcuteNonQuery("INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, SODT, DIACHI, EMAIL) VALUES (N'" + d.taikhoan + "',N'" + d.matkhau + "',N'" + d.hoten + "', '" + d.ngaysinh + "', " + gt + ", N'" + d.sodt + "', N'" + d.diachi + "',N'" + d.email + "')");
            return result > 0;
        }
        public List<DocGia> GetList()
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
            string query = "INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, SODT, DIACHI, EMAIL, GHICHU) VALUES (N'" + dg.taikhoan + "',N'" + dg.matkhau + "',N'" + dg.hoten + "', N'" + dg.ngaysinh + "', N'" + dg.gioitinh + "', N'" + dg.sodt + "', N'" + dg.diachi + "',N'" + dg.email + "' , N'" + dg.ghichu + "')";
            var data = DataProvider.instance.ExcuteNonQuery(query);
            return data > 0;
        }

        public bool LoginDocgia(string acc, string pass)
        {
            DataTable data = DataProvider.instance.ExcuteQuery("select* from  DocGia where TaiKhoan = @tk and matkhau = @mk", new object[] { acc, pass });
            return data.Rows.Count > 0;
        }
    }
}
