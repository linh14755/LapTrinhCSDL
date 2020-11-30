using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class MuonSach
    {
        public string madg { get; set; }
        public string masach { get; set; }
        public string sophieumuon { get; set; }
        public DateTime ngaymuon { get; set; }
        public DateTime ngaytra { get; set; }
        public string xacnhantra { get; set; }
        public string soluong { get; set; }
        public string ghichu { get; set; }
        public int tienphat { get; set; }
        public MuonSach() { }
        public MuonSach(string madg,string masach,string sophieumuon,DateTime ngaymuon,DateTime ngaytra, string xacnhantra, string soluong,string ghichu,int itenphat)
        {
            this.madg = madg;
            this.masach = masach;
            this.sophieumuon = sophieumuon;
            this.ngaymuon = ngaymuon;
            this.ngaytra = ngaytra;
            this.xacnhantra = xacnhantra;
            this.soluong = soluong;
            this.ghichu = ghichu;
            this.tienphat = tienphat;
        }
        public MuonSach(DataRow row)
        {
            this.madg = row["madg"].ToString();
            this.masach = row["masach"].ToString();
            this.sophieumuon = row["sophieumuon"].ToString();
            this.ngaymuon = DateTime.Parse(row["ngaymuon"].ToString());
            this.ngaytra = DateTime.Parse(row["ngaytra"].ToString());
            this.xacnhantra = row["xacnhantra"].ToString();
            this.soluong = row["soluong"].ToString();
            this.ghichu = row["ghichu"].ToString();
            this.tienphat = Int32.Parse(row["tienphat"].ToString());
        }
        public MuonSach(DataRowView row)
        {
            this.madg = row["madg"].ToString();
            this.masach = row["masach"].ToString();
            this.sophieumuon = row["sophieumuon"].ToString();
            this.ngaymuon = DateTime.Parse(row["ngaymuon"].ToString());
            this.ngaytra = DateTime.Parse(row["ngaytra"].ToString());
            this.xacnhantra = row["xacnhantra"].ToString();
            this.soluong = row["soluong"].ToString();
            this.ghichu = row["ghichu"].ToString();
            this.tienphat = Int32.Parse(row["tienphat"].ToString());
        }
    }
}
