using System.Collections.Generic;
using System.IO;

namespace OnTapGiuaKy
{
    public interface IDataSource
    {
        List<SinhVien> GetStudent();
        void Save(List<SinhVien> studentlist);
    }
}

