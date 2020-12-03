using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = new AccountDAO();

        public static AccountDAO Instance { get => instance; set => instance = value; }
        public AccountDAO() { }

        public bool LoginAdmin(string account, string password)
        {
            DataTable data = new DataTable();
            data = DataProvider.instance.ExcuteQuery("EXEC USP_Login @account , @password", new object[] { account, password });

            List<Account> listaccount = new List<Account>();

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                listaccount.Add(acc);
            }

            return listaccount.Count > 0;
        }
        public List<Account> GetList()
        {
            List<Account> listaccount = new List<Account>();

            DataTable data = DataProvider.instance.ExcuteQuery("select * from TaiKhoan");

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                listaccount.Add(acc);
            }

            return listaccount;
        }
        public bool Update(Account acc)
        {
            DateTime date = acc.ngaysinh;
            int gt = 0;
            if (acc.gioitinh == true)
                gt = 1;

            string createddate = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
            string query = "update TaiKhoan set	MATKHAU = N'" + acc.matkau + "' , TEN = N'" + acc.ten + "' , DIACHI = N'" + acc.diachi + "', EMAIL = N'" + acc.email + "', SODT = N'" + acc.sdt + "', NGAYSINH = '" + date + "', GIOITINH = " + gt + " where TaiKhoan = N'" + acc.taikhoan + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool Insert(Account acc)
        {
            DateTime date = acc.ngaysinh;
            string createddate = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
            string query = "insert TaiKhoan values(N'" + acc.taikhoan + "',N'" + acc.matkau + "',N'" + acc.ten + "',N'" + acc.diachi + "',N'" + acc.email + "',N'" + acc.sdt + "','" + createddate + "',N'" + acc.gioitinh + "')";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<Account> GetListByTK(string tk)
        {
            List<Account> listaccount = new List<Account>();

            DataTable data = DataProvider.instance.ExcuteQuery("select * from TaiKhoan where TaiKhoan = N'" + tk + "'");

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                listaccount.Add(acc);
            }

            return listaccount;
        }
        public bool LoginThuThu(string acc, string pass)
        {
            return AccountDAO.Instance.LoginAdmin(acc, pass);
        }
        public bool LoginDocGia(string acc, string pass)
        {
            return DocGiaDAO.Instance.LoginDocgia(acc, pass);
        }

        public bool KiemTraTaiKhoan(string tk)
        {
            List<Account> lst = AccountDAO.Instance.GetList();
            foreach (Account acc in lst)
            {
                if (tk == acc.taikhoan)
                {
                    return false;
                }
            }
            return true;
        }
        public bool DoiMK(string tk, string mkmoi,string mkcu)
        {
            string query = "update TaiKhoan set	MATKHAU = N'" + mkmoi + "' where TaiKhoan = N'" + tk + "' and MatKhau = N'"+mkcu+"'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
