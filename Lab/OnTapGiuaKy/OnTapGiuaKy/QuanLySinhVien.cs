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
        public List<SinhVien> CompareStudent(CompareFunc compare,KieuTim kt,string keyword)
        {
            var lsv = new List<SinhVien>();
            foreach (var item in svlist)
            {
                if(compare(item,kt,keyword))
                {
                    lsv.Add(item);
                }
            }
            return lsv;
        }
        List<SinhVien> svlist;
        IDataSource datasource;

        public QuanLySinhVien(IDataSource datasource)
        {
            this.datasource = datasource;
            svlist = datasource.GetStudentList();
        }
        public List<SinhVien> GetStudentList()
        {
            return svlist;
        }
        public void AddSV(SinhVien sv)
        {
            svlist.Add(sv);
            datasource.Save(svlist);
        }
        public void AddOrUpdate(SinhVien sv)
        {
            int index = Find(sv);
            if (index < 0)
            {
                AddSV(sv);
            }
            else
            {
                svlist[index] = sv;
                datasource.Save(svlist);
            }
        }
        public void Xoa(SinhVien sv)
        {
            for (int i = 0; i < svlist.Count; i++)
            {
                if (svlist[i].Mssv == sv.Mssv)
                {
                    svlist.RemoveAt(i);
                }
                datasource.Save(svlist);
            }
            
        }

        //tra ve index
        public int Find(SinhVien sv)
        {
            for (int i = 0; i < svlist.Count; i++)
            {
                if (sv.Mssv == svlist[i].Mssv)
                {
                    return i;
                }
            }
            return -1;
        }
        public SinhVien FindID(string id)
        {
            foreach (var item in svlist)
            {
                if (item.Mssv == id) return item;
            }
            return null;
        }
    }
}
