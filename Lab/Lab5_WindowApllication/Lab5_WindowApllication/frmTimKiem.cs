using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WindowApllication
{
    public partial class frmTimKiem : Form
    {
        QuanLySinhVien qlsv;
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            KieuTim kieutim = KieuTim.TheoMa;
            if (rdTen.Checked)
                kieutim = KieuTim.TheoTen;
            else if (rdLop.Checked)
                kieutim = KieuTim.TheoLop;


            SinhVien sv = qlsv.TimKiem(txbTim.Text, kieutim);

            if (sv.mssv == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                frmThongBao frm = new frmThongBao();
                string gt = "Nữ";
                if (sv.gioitinh)
                    gt = "Nam";
                string cn = "";
                foreach (string item in sv.chuyennganh)
                {
                    cn += item + ",";
                }
                cn = cn.Substring(0, cn.Length - 1);
                string ketqua = sv.mssv + '\n' + sv.holot + " " + sv.ten + '\n' + gt + '\n' + sv.ngaysinh + '\n' + sv.lop + '\n' + sv.socmnd + '\n' + sv.sodt + '\n' + sv.diachi + '\n' + cn;
                frm.SetText(ketqua);
                frm.ShowDialog();
            }
        }
    }
}
