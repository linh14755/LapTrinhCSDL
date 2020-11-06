using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmPicture : Form
    {
        Point p = new Point();

        //Phương thức tạo lập frmPicture
        public frmPicture()
        {
            InitializeComponent();
        }

        //Phương thức tạo lập frmPicture có tham số
        public frmPicture(string name)
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
        }

        //Sự kiện Load của frmPicture
        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
        }

        //ReLoad file cho hình
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            string title = "";
            if (dlg == DialogResult.OK)
            {
                title = this.Text.Substring(0, this.Text.LastIndexOf('-'))
                    + openFileDialog1.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openFileDialog1.FileName;
            }
        }

        //Phóng lớn hình
        private void zoomOut_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        //Thu nhỏ hình
        private void zoomIn_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }

        //Sự kiện scroll trên thanh vScrollBar
        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

        //Mở trình paint để chỉnh sửa hình
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint", this.pbHinh.ImageLocation);
        }
    }
}
