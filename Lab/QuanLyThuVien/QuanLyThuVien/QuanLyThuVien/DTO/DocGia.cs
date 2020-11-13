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
        private string madg;
        private string taikhoan;
        private string matkau;
        private string hoten;
        private DateTime? ngaysinh;
        private string gioitinh;
        private string lop;
        private string diachi;
        private string email;
        private string ghichu;
        public DocGia() { }

        public DocGia(string madg,string tk,string mk,string hoten,DateTime? ngaysinh, string gt,string lop,string diachi, string email, string ghichu)
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
            this.gioitinh = row["gioitinh"].ToString();
            this.lop = row["lop"].ToString();
            this.diachi = row["diachi"].ToString();
            this.email = row["email"].ToString();
            this.ghichu = row["ghichu"].ToString();
        }

        public string Madg { get => madg; set => madg = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkau { get => matkau; set => matkau = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
