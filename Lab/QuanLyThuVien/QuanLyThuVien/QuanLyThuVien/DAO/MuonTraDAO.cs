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
        public bool TraSach(string sophieumuon)
        {
            int result = DataProvider.instance.ExcuteNonQuery("exec USP_TraSach " + sophieumuon + "");
            return result > 0;
        }
        public bool GianHan(DateTime ngaytra, string id)
        {
            string ngaytranew = Convert.ToDateTime(ngaytra).ToString("yyyy-MM-dd");
            int result = DataProvider.instance.ExcuteNonQuery("update MuonSach set NgayTra = '" + ngaytranew + "' where sophieumuon = N'" + id + "'");
            return result > 0;
        }
        public List<MuonSach> GetListByMaDG(string madg)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "'");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public List<MuonSach> FindByID(string sophieumuon)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where SoPhieuMuon = N'" + sophieumuon + "'");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public List<MuonSach> GetDSQuaHan(string madg = null, int giatienphat = 5000)
        {
            //quá hạn 1 ngày sẽ phạt 5k trên mỗi đầu sách mượn
            List<MuonSach> l = new List<MuonSach>();
            var songayquahan = 0;
            string datecurrent = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");

            if (madg != null)
            {
                var dsquahan = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = N'0' and MaDG = " + madg + "");
                //cập nhật tiền phạt
                foreach (DataRow row1 in dsquahan.Rows)
                {
                    MuonSach m = new MuonSach(row1);
                    TimeSpan Time = DateTime.Now - m.ngaytra;
                    songayquahan = Time.Days;

                    var tienphat = songayquahan * giatienphat;
                    DataProvider.instance.ExcuteNonQuery("update MuonSach set TIENPHAT = @tienphat where SoPhieuMuon = @sopm", new object[] { tienphat, m.sophieumuon });
                }

                var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where NgayTra < '" + datecurrent + "' and xacnhantra = N'0' and MaDG = " + madg + "");
                foreach (DataRow row in data.Rows)
                {
                    //tiền phạt
                    MuonSach m = new MuonSach(row);
                    l.Add(m);
                }
                return l;
            }
            else
            {
                var dsquahan = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = N'0'");
                //cập nhật tiền phạt
                foreach (DataRow row1 in dsquahan.Rows)
                {
                    MuonSach m = new MuonSach(row1);
                    TimeSpan Time = DateTime.Now - m.ngaytra;
                    songayquahan = Time.Days;

                    var tienphat = songayquahan * giatienphat;
                    DataProvider.instance.ExcuteNonQuery("update MuonSach set TIENPHAT = @tienphat where SoPhieuMuon = @sopm", new object[] { tienphat, m.sophieumuon });
                }

                var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where NgayTra < '" + datecurrent + "' and xacnhantra = N'0'");
                foreach (DataRow row in data.Rows)
                {
                    //tiền phạt
                    MuonSach m = new MuonSach(row);
                    l.Add(m);
                }
                return l;
            }
        }
        public bool KiemTraDocGia(string madg, string masach) //mot doc gia khong duoc muon qua 3 sach
        {
            var result = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "' and MaSach = N'" + masach + "' and XacNhanTra = N'0'");
            var result2 = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "'and XacNhanTra = N'0'");
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

            string query = "exec USP_MuonSach " + m.madg + ", " + m.masach + ", '" + ngaymuon + "', '" + ngaytra + "', " + m.xacnhantra + " , N'" + m.ghichu + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<MuonSach> GetList()
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
