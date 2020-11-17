using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapGiuaKy
{
    
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public KieuTim GetKieuTim()
        {
            if (rdLop.Checked) return KieuTim.TheoLop;
            if (rdTen.Checked) return KieuTim.TheoTen;
            return KieuTim.TheoMa;
        }
        public string GetKeyWord()
        {
            return txbTim.Text;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            rdMa.Checked = true;
        }
    }
}
