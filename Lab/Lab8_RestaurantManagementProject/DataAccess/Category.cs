using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        // Kiểu: 0 là đố uống; 1 là thức ăn...
        public int Type { get; set; }
         
    }
}
