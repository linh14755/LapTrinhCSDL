using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Thue
    {
        public string luot { get; set; }
        public string mabd { get; set; }
        public string makh { get; set; }
        public  int tiencoc { get; set; }
        public DateTime ngaythue { get; set; }
        public DateTime ngaytra { get; set; }
        public int tongtien { get; set; }
        public Thue() { }
        public Thue(string luot, string mabd,string makh,int tiencoc, DateTime ngaythue, DateTime ngaytra, int tongtien)
        {
            this.luot = luot;
            this.mabd = mabd;
            this.makh = makh;
            this.tiencoc = tiencoc;
            this.ngaythue = ngaythue;
            this.ngaytra = ngaytra;
            this.tongtien = tongtien;
        }
        public Thue(DataRow row)
        {
            this.luot = row["luot"].ToString();
            this.mabd = row["mabd"].ToString();
            this.makh = row["makh"].ToString();
            this.tiencoc =int.Parse(row["tiencoc"].ToString());
            this.ngaythue =DateTime.Parse( row["ngaybd"].ToString());
            this.ngaytra =DateTime.Parse(row["ngaytra"].ToString());
            this.tongtien = int.Parse(row["tongtien"].ToString());
        }
        public Thue(DataRowView row)
        {
            this.luot = row["luot"].ToString();
            this.mabd = row["mabd"].ToString();
            this.makh = row["makh"].ToString();
            this.tiencoc = int.Parse(row["tiencoc"].ToString());
            this.ngaythue = DateTime.Parse(row["ngaybd"].ToString());
            this.ngaytra = DateTime.Parse(row["ngaytra"].ToString());
            this.tongtien = int.Parse(row["tongtien"].ToString());
        }
    }
}
