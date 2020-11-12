using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapGiuaKy
{
    public delegate bool CompareFunc(SinhVien sv, KieuTim kieutim, string keyword);
    public class QuanLySinhVien
    {
        private IDataSource _dataSource;
        private List<SinhVien> _listsv;

        
        //co cai nay moi ke thua du lieu duoc
        public QuanLySinhVien(IDataSource datasource)
        {
            _dataSource = datasource;
            _listsv = _dataSource.GetStudent();
        }

        public List<SinhVien> GetStudents()
        {
            return _listsv;
        }

        //them sv vao danh sach
        public void Add(SinhVien sv)
        {
            _listsv.Add(sv);
            _dataSource.Save(_listsv);
        }

        //Them hoac cap nhat sv trong danh sach
        public void AddorUpdate(SinhVien sv)
        {
            var index = Find(sv);
            if (index < 0)
            {
                Add(sv);
            }
            else
            {
                _listsv[index] = sv;
                _dataSource.Save(_listsv);
            }
        }

        public int Find(SinhVien sv)
        {
            for (int i = 0; i < _listsv.Count; i++)
            {
                if (_listsv[i].mssv == sv.mssv)
                    return i;
            }
            return -1;
        }
        public void Delete(SinhVien sv)
        {
            for (int i = 0; i < _listsv.Count; i++)
            {
                if (sv.mssv == _listsv[i].mssv)
                    _listsv.RemoveAt(i);
            }
        }

        public SinhVien FindByID(string id)
        {
            foreach (var item in _listsv)
            {
                if (item.mssv == id)
                    return item;
            }
            return null;
        }
        public List<SinhVien> FindStudents(CompareFunc sreachFunc,KieuTim kieutim,string keyword)
        {
            var listsv = new List<SinhVien>();

            foreach (SinhVien sv in _listsv)
            {
                if (sreachFunc(sv, kieutim, keyword))
                    listsv.Add(sv);
            }
            return listsv;
        }
    }
}
