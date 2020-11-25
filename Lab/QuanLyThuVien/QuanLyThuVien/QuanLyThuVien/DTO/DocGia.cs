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
        public string matkau { get; set; }
        public string hoten { get; set; }
        public DateTime? ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string lop { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string ghichu { get; set; }
        public DocGia() { }

        public DocGia(string madg, string tk, string mk, string hoten, DateTime? ngaysinh, bool gt, string lop, string diachi, string email, string ghichu)
        {
            this.madg = madg;
            this.taikhoan = tk;
            this.matkau = mk;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gt;
            this.lop = lop;
            this.diachi = diachi;
            this.email = email;
            this.ghichu = ghichu;
        }
        public DocGia(DataRow row)
        {
            this.madg = row["madg"].ToString();
            this.taikhoan = row["taikhoan"].ToString();
            this.matkau = row["matkhau"].ToString();
            this.hoten = row["hoten"].ToString();
            this.ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.gioitinh = true;
            if ((bool)row["gioitinh"] == false)
                this.gioitinh = false;
            this.lop = row["lop"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.ghichu = row["ghichu"].ToString();
        }
    }
}
