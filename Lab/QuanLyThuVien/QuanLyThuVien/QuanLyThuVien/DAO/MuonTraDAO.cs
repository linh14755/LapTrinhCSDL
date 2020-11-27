using DevExpress.ClipboardSource.SpreadsheetML;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class MuonTraDAO
    {
        public static MuonTraDAO instance = new MuonTraDAO();
        public MuonTraDAO() { }
        public bool KiemTraDocGia(string madg, string masach) //mot doc gia khong duoc muon qua 3 sach
        {
            var result = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "' and MaSach = N'" + masach + "'");
            return result.Rows.Count < 3;
        }
        public bool MuonSach(MuonSach m)
        {
            var data = DataProvider.instance.ExcuteQuery("select soluong from Sach where masach = " + m.masach + "");
            foreach (DataRow row in data.Rows)
            {
                if (row[0].ToString() == "0")
                    return false;
            }

            string ngaymuon = Convert.ToDateTime(m.ngaymuon).ToString("yyyy-MM-dd");
            string ngaytra = Convert.ToDateTime(m.ngaytra).ToString("yyyy-MM-dd");

            string query = "exec USP_MuonSach N'" + m.madg + "', N'" + m.masach + "', '" + ngaymuon + "', '" + ngaytra + "', '" + m.xacnhantra + "', N'" + m.ghichu + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<MuonSach> GetListMuonTra()
        {
            List<MuonSach> lst = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where xacnhantra = '0'");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                lst.Add(m);
            }
            return lst;
        }
    }
}
