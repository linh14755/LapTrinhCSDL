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

        public bool LoginAdmin(string account,string password)
        {
            DataTable  data = new DataTable();
            data = DataProvider.instance.ExcuteQuery("EXEC USP_Login @account , @password", new object[] { account, password });

            List<Account> listaccount = new List<Account>();

            foreach (DataRow row in data.Rows)
            {
                Account acc = new Account(row);
                listaccount.Add(acc);
            }

            return listaccount.Count > 0;
        }
        public List<Account> GetListAccount()
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
    }
}
