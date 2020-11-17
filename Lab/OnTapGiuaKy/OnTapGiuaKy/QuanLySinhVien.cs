using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public delegate bool CompareFunc(SinhVien sv, KieuTim kt, string keyword);
    public class QuanLySinhVien
    {
        List<SinhVien> lsv;
        IDataSource idatasource;
        public QuanLySinhVien(IDataSource idatasource)
        {
            this.idatasource = idatasource;
            lsv = idatasource.GetSinhVien();
        }
        
        public List<SinhVien> GetListSinhVien()
        {
            return lsv;
        }

        public void Xoa(SinhVien sv)
        {
            int index = FindIndex(sv);
            lsv.RemoveAt(index);
            idatasource.Save(lsv);
        }

        public void Add(SinhVien sv)
        {
            lsv.Add(sv);
            idatasource.Save(lsv);
        }
        public int FindIndex(SinhVien sv)
        {
            for (int i = 0; i < lsv.Count; i++)
            {
                if(lsv[i].Mssv == sv.Mssv)
                {
                    return i;
                }
            }
            return -1;
        }
        public SinhVien FindStudentByID(string id)
        {
            foreach (var item in lsv)
            {
                if (item.Mssv == id)
                    return item;
            }
            return null;
        }
        public void AddOrUpdate(SinhVien sv)
        {
            int index = FindIndex(sv);
            if(index < 0) //ko ton tai
            {
                lsv.Add(sv);
                idatasource.Save(lsv);
            }
            else //da ton tai
            {
                lsv[index] = sv;
                idatasource.Save(lsv);
            }
        }
        public List<SinhVien> FindStudents(CompareFunc compare,KieuTim kt, string keyword)
        {
            List<SinhVien> listsv = new List<SinhVien>();

            foreach (var item in lsv)
            {
                if (compare(item, kt, keyword))
                {
                    listsv.Add(item);
                }
            }

            return listsv;
        } 
    }
}
