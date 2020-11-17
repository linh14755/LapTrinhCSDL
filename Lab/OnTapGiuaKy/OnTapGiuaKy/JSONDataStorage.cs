using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    public class JSONDataStorage : IDataSource
    {
        string filename { get; set; }
        public JSONDataStorage(string filename)
        {
            this.filename = filename;
        }
        public List<SinhVien> GetSinhVien()
        {
            if (!File.Exists(filename))
            {
                FileStream fs = File.Create(filename);
                fs.Close();
            }
            using (var r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(json))
                {
                    return new List<SinhVien>();
                }
                List<SinhVien> listsv = new List<SinhVien>();
                listsv = JsonConvert.DeserializeObject<List<SinhVien>>(json);

                r.Close();
                
                return listsv;
            }
        }

        public void Save(List<SinhVien> listsv)
        {
            using (var w = new StreamWriter(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(w, listsv);
                w.Close();
            }
        }
    }
}
