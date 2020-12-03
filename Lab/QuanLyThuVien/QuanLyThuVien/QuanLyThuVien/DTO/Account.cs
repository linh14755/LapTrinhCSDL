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
        public string taikhoan { get; set; }
        public string matkau { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }

        public Account() { }

        public Account(string taikhoan, string matkhau, string ten, string diachi, string email, string sdt, DateTime ngaysinh, bool gt)
        {
            this.taikhoan = taikhoan;
            this.matkau = matkhau;
            this.ten = ten;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gt;
        }

        public Account(DataRow row) 
        {
            this.taikhoan = row["taikhoan"].ToString();
            this.matkau = row["matkhau"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.sdt = row["sodt"].ToString();
            this.ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.gioitinh = true;
            if ((bool)row["gioitinh"] == false)
                this.gioitinh = false;
        }
    }
}
