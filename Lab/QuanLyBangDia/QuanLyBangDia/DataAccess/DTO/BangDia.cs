using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class BangDia
    {
        public string mabd { get; set; }
        public string tenbd { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        public string theloai { get; set; }
        public BangDia() { }

        public BangDia(string mabd,string tenbd, int soluong,int dongia,string theloai)
        {
            this.mabd = mabd;
            this.tenbd = tenbd;
            this.soluong = soluong;
            this.dongia = dongia;
            this.theloai = theloai;
        }
        public BangDia(DataRow row)
        {
            this.mabd = row["mabd"].ToString();
            this.tenbd = row["tenbd"].ToString();
            this.soluong =int.Parse(row["soluong"].ToString());
            this.dongia = int.Parse(row["dongia"].ToString());
            this.theloai = row["theloai"].ToString();
        }
        public BangDia(DataRowView row)
        {
            this.mabd = row["mabd"].ToString();
            this.tenbd = row["tenbd"].ToString();
            this.soluong = int.Parse(row["soluong"].ToString());
            this.dongia = int.Parse(row["dongia"].ToString());
            this.theloai = row["theloai"].ToString();
        }
    }
}
