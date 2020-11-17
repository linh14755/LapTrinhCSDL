using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public class DocFileJSON : IDataSource
    {
        string filepath { get; set; }
        public DocFileJSON(string filepath)
        {
            this.filepath = filepath;
        }
        public List<SinhVien> GetStudentList()
        {
            if (!File.Exists(filepath))
            {
                FileStream f = File.Create(filepath);
                f.Close();
            }
            using (StreamReader r = new StreamReader(filepath))
            {
                string json = r.ReadToEnd();
                if(string.IsNullOrWhiteSpace(filepath))
                {
                    return new List<SinhVien>();
                }
                List<SinhVien> list = JsonConvert.DeserializeObject<List<SinhVien>>(json);

                return list;
            }
        }

        public void Save(List<SinhVien> lsinhvien)
        {
            using (StreamWriter w = new StreamWriter(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(w, lsinhvien);
            }
        }
    }
}
