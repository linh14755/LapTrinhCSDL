using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public interface IDataSource
    {
        List<SinhVien> GetStudentList();
        void Save(List<SinhVien> lsinhvien);
    }
}
