using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_WindowApllication
{
    public class QuanLySinhVien
    {
        public List<SinhVien> danhsachsv;

        public QuanLySinhVien()
        {
            danhsachsv = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return danhsachsv[index]; }
            set { danhsachsv[index] = value; }
        }


        public bool Sua(SinhVien sv)
        {
            bool kq = false;
            int count = danhsachsv.Count;
            for (int i = 0; i < count; i++)
            {
                if (sv.mssv == danhsachsv[i].mssv)
                {
                    danhsachsv[i] = sv;
                    kq = true;
                }
            }
            return kq;
        }
        public SinhVien TimKiem(string value,KieuTim kieutim)
        {
            SinhVien sv = new SinhVien();
            switch (kieutim)
            {
                case KieuTim.TheoMa:
                    foreach (SinhVien item in danhsachsv)
                    {
                        if (item.mssv == value)
                            sv = item;
                    }
                    break;
                case KieuTim.TheoLop:
                    foreach (SinhVien item in danhsachsv)
                    {
                        if (item.lop == value)
                            sv = item;
                    }
                    break;
                case KieuTim.TheoTen:
                    foreach (SinhVien item in danhsachsv)
                    {
                        if (item.ten == value)
                            sv = item;
                    }
                    break;
                default:
                    break;
            }

            return sv;
        }

        public void ThemSV(SinhVien sv)
        {
            danhsachsv.Add(sv);
        }

        public void GhiFile()
        {
            string filename = "DanhSach.txt";
            // Delete the file if it exists.
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.OpenOrCreate,FileAccess.Write));
            foreach (SinhVien item in danhsachsv)
            { 
                string mssv = item.mssv;
                string gt = "Nữ";
                if (item.gioitinh)
                    gt = "Nam";
                string holot = item.holot;
                string ten = item.ten;
                string ngaysinh = item.ngaysinh.ToString();
                string lop = item.lop;
                string socmnd = item.socmnd;
                string sodt = item.sodt;
                string diachi = item.diachi;
                string cntotal = "";
                foreach (string cn in item.chuyennganh)
                {
                    cntotal += cn + ",";
                }
                cntotal = cntotal.Substring(0, cntotal.Length - 1);
                string sinhvien = mssv + "*" + holot + "*" + ten + "*" + gt + "*" + ngaysinh + "*" + lop + "*" + socmnd + "*" + sodt + "*" + diachi + "*" + cntotal;
                sw.WriteLine(sinhvien);
            }
            sw.Close();
        }

        public void DocTuFile()
        {
            string filename = "DanhSach.txt", t;
            string[] s ;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.mssv = s[0];
                sv.holot = s[1];
                sv.ten = s[2];
                bool gt = false;
                if (s[3] == "Nam")
                    gt = true;
                sv.gioitinh = gt;
                sv.ngaysinh = DateTime.Parse(s[4]);
                sv.lop = s[5];
                sv.socmnd = s[6];
                sv.sodt = s[7];
                sv.diachi = s[8];
                string[] cn = s[9].Split(',');
                foreach (string item in cn)
                {
                    sv.chuyennganh.Add(item);
                }
                ThemSV(sv);
            }
            sr.Close();
        }

    }
}
