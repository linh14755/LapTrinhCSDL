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
        public string GetKeyWord()
        {
            return txbTim.Text;
        }
        public KieuTim GetKieuTim()
        {
            if (rdTen.Checked) return KieuTim.TheoTen;
            if (rdLop.Checked) return KieuTim.TheoLop;

            return KieuTim.TheoMa;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            rdMa.Checked = true;
        }
    }
}
