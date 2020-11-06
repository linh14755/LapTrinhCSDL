using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_Trang60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listview_load();
   
        }
        

        private void Listview_load()
        {
            //lvInfo.Columns.Add("");
            lvInfo.Columns.Add("Mã NV");
            lvInfo.Columns.Add("Họ và Tên");
            lvInfo.Columns.Add("Ngày sinh");
            lvInfo.Columns.Add("Phái");
            lvInfo.Columns.Add("Địa chỉ");
            lvInfo.Columns.Add("Email");
            lvInfo.Columns.Add("Số ĐT");
            lvInfo.Columns.Add("Phòng ban");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var manv = this.mtbNV.Text;
            var hoten = this.tbTen.Text;
            var ngaysinh = this.dtpkNgaySinh.Text;
            string gt = "Nam";
            if (rbNu.Checked) gt = "Nữ";
            var diachi = this.tbDiaChi.Text;
            var email = this.tbEmail.Text;
            var sodt = this.mtbSodt.Text;
            var phong = this.cbPhongban.Text;

            ListViewItem item = lvInfo.Items.Add(manv);
            item.SubItems.Add(hoten);
            item.SubItems.Add(ngaysinh );
            item.SubItems.Add(gt);
            item.SubItems.Add(diachi);
            item.SubItems.Add(email);
            item.SubItems.Add(sodt);
            item.SubItems.Add(phong);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvInfo.SelectedItems.Count; i++)
            {
                lvInfo.Items.Remove(lvInfo.SelectedItems[i]);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.mtbNV.Text = "";
            this.tbTen.Text = "";
            this.dtpkNgaySinh.Text = "";
            this.tbDiaChi.Text = "";
            this.tbEmail.Text = "";
            this.mtbSodt.Text = "";
            this.cbPhongban.Text = "";
        }

      

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            if (DialogChon.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = DialogChon.FileName;
                Bitmap bm = new Bitmap(filename);
                pictureBox1.Image = bm;
            }
        }

       
    }
}
