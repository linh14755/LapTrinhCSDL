using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class Sach
    {
        public string masach { get; set; }
        public string tensach { get; set; }
        public string tentg { get; set; }
        public string tenlv { get; set; }
        public string tennxb { get; set; }
        public DateTime namxb { get; set; }
        public string sl { get; set; }
        public DateTime ngaynhap { get; set; }
        public string ghichu { get; set; }
        public Sach() { }
        public Sach(string ms, string tensach, string tentg, string tenlv, string tennxb, DateTime namxb, string sl, DateTime ngaynhap, string ghichu)
        {
            this.masach = ms;
            this.tensach = tensach;
            this.tentg = tentg;
            this.tenlv = tenlv;
            this.tennxb = tennxb;
            this.namxb = namxb;
            this.sl = sl;
            this.ngaynhap = ngaynhap;
            this.ghichu = ghichu;
        }
        public Sach(DataRow row)
        {
            this.masach = row["masach"].ToString();
            this.tensach = row["tensach"].ToString();
            this.tentg = row["tentg"].ToString();
            this.tenlv = row["tenlv"].ToString();
            this.tennxb = row["tennxb"].ToString();
            this.namxb = DateTime.Parse(row["namxb"].ToString());
            this.sl = row["soluong"].ToString();
            this.ngaynhap = DateTime.Parse(row["ngaynhap"].ToString());
            this.ghichu = row["ghichu"].ToString();
        }
        public Sach(DataRowView row)
        {
            this.masach = row["masach"].ToString();
            this.tensach = row["tensach"].ToString();
            this.tentg = row["tentg"].ToString();
            this.tenlv = row["tenlv"].ToString();
            this.tennxb = row["tennxb"].ToString();
            this.namxb = DateTime.Parse(row["namxb"].ToString());
            this.sl = row["soluong"].ToString();
            this.ngaynhap = DateTime.Parse(row["ngaynhap"].ToString());
            this.ghichu = row["ghichu"].ToString();
        }
    }
}
