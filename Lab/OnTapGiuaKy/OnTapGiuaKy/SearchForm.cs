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
        QuanLySinhVien quanlysv;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            rdMa.Checked = true;
        }
        public string GetKeyWord()
        {
            return txbTim.Text;
        }
        public KieuTim GetKieuTim()
        {
            if (rdMa.Checked) return KieuTim.TheoLop;
            if (rdLop.Checked) return KieuTim.TheoTen;
            return KieuTim.TheoMa;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string keyword = GetKeyWord();
            var kieutim = GetKieuTim();

            List<SinhVien> result = quanlysv.FindStudents(CompareStudent, kieutim, keyword);

            (result);
        }
        public bool CompareStudent(SinhVien sv, KieuTim kieutim, string keyword)
        {
            switch (kieutim)
            {
                case KieuTim.TheoTen:
                    return sv.ten.ToLower().Contains(keyword.ToLower());
                case KieuTim.TheoLop:
                    return sv.lop == keyword;
                default:
                    return sv.mssv == keyword;
            }
        }
    }
}
