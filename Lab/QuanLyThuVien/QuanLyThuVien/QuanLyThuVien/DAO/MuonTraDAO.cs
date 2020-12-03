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
        public List<MuonSach> GetDSMuonTraByNgayTra(DateTime datefrom, DateTime dateto)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery(string.Format("EXEC USP_GetDSMuonTraByNgayTra '{0}' , '{1}'", datefrom, dateto));
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public List<MuonSach> GetDSMuonTraByNgayMuon(DateTime datefrom, DateTime dateto)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery(String.Format("EXEC USP_GetDSMuonTraByNgayMuon '{0}' , '{1}'", datefrom, dateto));
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public List<MuonSach> GetDSDaTra()
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where XACNHANTRA = 1");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                l.Add(m);
            }
            return l;
        }
        public bool TraSach(string sophieumuon)
        {
            int result = DataProvider.instance.ExcuteNonQuery("exec USP_TraSach @sophieumuon ", new object[] { sophieumuon });
            return result > 0;
        }
        public bool GianHan(DateTime ngaytra, string id)
        {
            int result = DataProvider.instance.ExcuteNonQuery(string.Format("update MuonSach set NgayTra = '{0}' where sophieumuon = {1}", ngaytra, id));
            return result > 0;
        }
        public List<MuonSach> GetListByMaDG(string madg)
        {
            List<MuonSach> l = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery(string.Format("select * from MuonSach where MaDG = N'{0}' and XacNhanTra = 0",madg));
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
            var data = DataProvider.instance.ExcuteQuery(string.Format("select * from MuonSach where SoPhieuMuon = N'{0}'",sophieumuon));
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
                var dsquahan = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = 0 and MaDG = " + madg + "");
                //cập nhật tiền phạt
                foreach (DataRow row1 in dsquahan.Rows)
                {
                    MuonSach m = new MuonSach(row1);
                    TimeSpan Time = DateTime.Now - m.ngaytra;
                    songayquahan = Time.Days;

                    var tienphat = songayquahan * giatienphat;
                    DataProvider.instance.ExcuteNonQuery("update MuonSach set TIENPHAT = @tienphat where SoPhieuMuon = @sopm", new object[] { tienphat, m.sophieumuon });
                }

                var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where NgayTra < '" + datecurrent + "' and xacnhantra = 0 and MaDG = " + madg + "");
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
                var dsquahan = DataProvider.instance.ExcuteQuery("select * from MuonSach where ngaytra < '" + datecurrent + "' and xacnhantra = 0");
                //cập nhật tiền phạt
                foreach (DataRow row1 in dsquahan.Rows)
                {
                    MuonSach m = new MuonSach(row1);
                    TimeSpan Time = DateTime.Now - m.ngaytra;
                    songayquahan = Time.Days;

                    var tienphat = songayquahan * giatienphat;
                    DataProvider.instance.ExcuteNonQuery("update MuonSach set TIENPHAT = @tienphat where SoPhieuMuon = @sopm", new object[] { tienphat, m.sophieumuon });
                }

                var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where NgayTra < '" + datecurrent + "' and xacnhantra = 0");
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
            var result = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "' and MaSach = N'" + masach + "' and XacNhanTra = 0");
            var result2 = DataProvider.instance.ExcuteQuery("select * from MuonSach where MaDG = N'" + madg + "'and XacNhanTra = 0");
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
            string query = "exec USP_MuonSach " + m.madg + ", " + m.masach + ", '" + m.ngaymuon + "', '" + m.ngaytra + "', " + m.xacnhantra + " , N'" + m.ghichu + "'";
            int result = DataProvider.instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<MuonSach> GetList()
        {
            List<MuonSach> lst = new List<MuonSach>();
            var data = DataProvider.instance.ExcuteQuery("select * from MuonSach where xacnhantra = 0");
            foreach (DataRow row in data.Rows)
            {
                MuonSach m = new MuonSach(row);
                lst.Add(m);
            }
            return lst;
        }
    }
}
