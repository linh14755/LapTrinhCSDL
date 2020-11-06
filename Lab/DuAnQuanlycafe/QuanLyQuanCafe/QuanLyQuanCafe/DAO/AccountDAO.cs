using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = new AccountDAO();

        public static AccountDAO Instance { get => instance; set => instance = value; }
        public AccountDAO() { }
        public bool Login(string username,string password)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec USP_Login N'" + username + "' , N'" + password + "' ");
            return data.Rows.Count > 0;
        }
    }
}
