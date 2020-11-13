using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class Account
    {
        private string taikhoan;
        private string matkau;
        private string ten;
        private string diachi;
        private string email;
        private string sdt;
        
        public Account(string taikhoan, string matkhau, string ten, string diachi, string email, string sdt)
        {
            this.taikhoan = taikhoan;
            this.matkau = matkhau;
            this.ten = ten;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
        }

        public Account(DataRow row) 
        {
            this.taikhoan = row["taikhoan"].ToString();
            this.matkau = row["matkhau"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.sdt = row["sodt"].ToString();
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkau { get => matkau; set => matkau = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
