using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class DocGia
    {
        public string madg { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string sodt { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string ghichu { get; set; }
        //public DateTime thoihan { get; set; }
        //public bool tinhtrang { get; set; }
        //public int phi { get; set; }
        public DocGia() { }

        public DocGia(string madg, string tk, string mk, string hoten, DateTime ngaysinh, bool gt, string sodt, string diachi, string email, string ghichu/*, DateTime thoihan, bool tinhtrang, int phi*/)
        {
            this.madg = madg;
            this.taikhoan = tk;
            this.matkhau = mk;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gt;
            this.sodt = sodt;
            this.diachi = diachi;
            this.email = email;
            this.ghichu = ghichu;
            //this.thoihan = thoihan;
            //this.tinhtrang = tinhtrang;
            //this.phi = phi;
        }
        public DocGia(DataRow row)
        {
            this.madg = row["madg"].ToString();
            this.taikhoan = row["taikhoan"].ToString();
            this.matkhau = row["matkhau"].ToString();
            this.hoten = row["hoten"].ToString();
            this.ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.gioitinh = (bool)row["gioitinh"];
            this.sodt = row["sodt"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.ghichu = row["ghichu"].ToString();
            //this.thoihan = DateTime.Parse(row["thoihan"].ToString());
            //this.tinhtrang = (bool)row["tinhtrang"];
            //this.phi = int.Parse(row["phi"].ToString());
        }
        public DocGia(DataRowView row)
        {
            this.madg = row["madg"].ToString();
            this.taikhoan = row["taikhoan"].ToString();
            this.matkhau = row["matkhau"].ToString();
            this.hoten = row["hoten"].ToString();
            this.ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.gioitinh = (bool)row["gioitinh"];
            this.sodt = row["sodt"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.ghichu = row["ghichu"].ToString();
            //this.thoihan = DateTime.Parse(row["thoihan"].ToString());
            //this.tinhtrang = (bool)row["tinhtrang"];
            //this.phi = int.Parse(row["phi"].ToString());
        }
    }
}
