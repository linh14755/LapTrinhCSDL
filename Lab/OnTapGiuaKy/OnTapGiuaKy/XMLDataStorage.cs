using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OnTapGiuaKy
{
    public class XMLDataStorage : IDataSource
    {
        string filename { get; set; }
        public XMLDataStorage(string filename)
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
            using (StreamReader r = new StreamReader(filename))
            {
                string xml = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(xml))
                {
                    return new List<SinhVien>();
                }
                List<SinhVien> listsv = new List<SinhVien>();
                XmlSerializer x = new XmlSerializer(typeof(List<SinhVien>));
                listsv = (List<SinhVien>)x.Deserialize(new StringReader(xml));

                return listsv;
            }
        }

        public void Save(List<SinhVien> listsv)
        {
            using (var w = new StreamWriter(filename))
            {
                XmlSerializer x = new XmlSerializer(typeof(List<SinhVien>));
                x.Serialize(w, listsv);
                w.Close();
            }
        }
    }
}
