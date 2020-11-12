using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public class DocFileTXT:IDataSource
    {
        string filePath;
        public DocFileTXT(string filePath)
        {
            this.filePath = filePath;
        }

        //ham GhiFile
        public void Save(List<SinhVien> listsv)
        {
            if (listsv.Count > 0)
            {
                using (var sw = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)))
                {
                    foreach (var sv in listsv)
                    {
                        sw.WriteLine(FormatSdudent(sv));
                    }
                }
            }
        }

        //ham DocFile
        public List<SinhVien> GetStudent()
        {
            var studentlist = new List<SinhVien>();
            string line;
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open)))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        var sv = ParseLine(line);
                        studentlist.Add(sv);
                    }

                }
            }
            return studentlist;
        }

        //chuyen doi tung dong du lieu thanh SinhVien
        public SinhVien ParseLine(string line)
        {
            

            var parts = line.Split('|');
            var cn = parts[(int)ColumIndex.cn].Split('^').ToList();

            return new SinhVien()
            {
                mssv = parts[(int)ColumIndex.ms],
                holot = parts[(int)ColumIndex.holot],
                ten = parts[(int)ColumIndex.ten],
                Gioitinh = parts[(int)ColumIndex.gt],
                ngaysinh = DateTime.Parse(parts[(int)ColumIndex.ngaysinh]),
                lop = parts[(int)ColumIndex.lop],
                socmnd = parts[(int)ColumIndex.socmnd],
                sodt = parts[(int)ColumIndex.sodt],
                diachi = parts[(int)ColumIndex.diachi],
                chuyennganh = cn
            };
        }

        //chuyen tu Sinh Vien sang line
        public string FormatSdudent(SinhVien sv)
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|",
                sv.mssv,
                sv.holot,
                sv.ten,
                sv.Gioitinh,
                sv.ngaysinh,
                sv.lop,
                sv.socmnd,
                sv.sodt,
                sv.diachi,
                string.Join("^",sv.chuyennganh)
                );
        }

        private enum ColumIndex
        {
            ms,
            holot,
            ten,
            gt,
            ngaysinh,
            lop,
            socmnd,
            sodt,
            diachi,
            cn
        }
    }
}

