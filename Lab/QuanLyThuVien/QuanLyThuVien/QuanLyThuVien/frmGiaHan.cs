using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmGiaHan : Form
    {
        public frmGiaHan()
        {
            InitializeComponent();
        }
        public DateTime Getdatetime()
        {
            return dtpgiahan.Value;
        }
    }
}
