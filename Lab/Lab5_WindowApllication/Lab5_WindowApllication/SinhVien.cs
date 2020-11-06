using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_WindowApllication
{
    public class SinhVien
    {
        public string mssv;
        public bool gioitinh;
        public string holot;
        public string ten;
        public DateTime ngaysinh;
        public string lop;
        public string socmnd;
        public string sodt;
        public string diachi;
        public List<String> chuyennganh;


        public SinhVien()
        {
            chuyennganh = new List<string>();
        }
        public SinhVien(string ms, string ho,string ten, bool gt, DateTime ngaysinh, string lop, string socmnd, string sodt, string diachi, List<String> cn)
        {
            this.mssv = ms;
            this.gioitinh = gt;
            this.holot = ho;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.lop = lop;
            this.socmnd = socmnd;
            this.sodt = sodt;
            this.diachi = diachi;
            this.chuyennganh = cn;
        }


        public string Mssv { get => mssv; set => mssv = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Holot { get => holot; set => holot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Socmnd { get => socmnd; set => socmnd = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public List<string> Chuyennganh { get => chuyennganh; set => chuyennganh = value; }
    }
}
