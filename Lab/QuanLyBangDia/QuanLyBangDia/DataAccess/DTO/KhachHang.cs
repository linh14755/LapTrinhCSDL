using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class KhachHang
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sodt { get; set; }
        public string diachi { get; set; }
        public KhachHang(){ }
        public KhachHang(string makh,string tenkh,string sodt,string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.sodt = sodt;
            this.diachi = diachi;
        }
        public KhachHang(DataRow row)
        {
            this.makh = row["makh"].ToString();
            this.tenkh = row["tenkh"].ToString();
            this.sodt = row["sodt"].ToString();
            this.diachi = row["diachi"].ToString();
        }

        public KhachHang(DataRowView row)
        {
            this.makh = row["makh"].ToString();
            this.tenkh = row["tenkh"].ToString();
            this.sodt = row["sodt"].ToString();
            this.diachi = row["diachi"].ToString();
        }
    }
}
