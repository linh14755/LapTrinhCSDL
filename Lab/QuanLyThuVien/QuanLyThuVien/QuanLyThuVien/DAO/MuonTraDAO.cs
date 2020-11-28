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
        public bool GianHan(DateTime ngaytra, string id)
        {
            string ngaytranew = Convert.ToDateTime(ngaytra).ToString("yyyy-MM-dd");
            int result = DataProvider.instance.ExcuteNonQuery("update MuonSach set NgayTra = '" + ngaytranew + "' where sophieumuon = N'" + id + "'");
            return result > 0;
        }
        public List<MuonSach> FindByID(string id)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where SoPhieuMuon = N'" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public List<MuonSach> GetDSQuaHan()
        {
            List<MuonSach> l = new List<MuonSach>();
            string datecurrent = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = N'0'");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public bool KiemTraDocGia(string madg, string masach) //mot doc gia khong duoc muon qua 3 sach
        {
            var result = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "' and MaSach = N'" + masach + "'");
            var result2 = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "'");
            return result.Rows.Count < 2 && result2.Rows.Count < 4;
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
