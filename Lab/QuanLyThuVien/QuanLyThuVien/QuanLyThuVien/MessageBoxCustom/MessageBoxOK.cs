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
    public partial class MessageBoxOK : Form
    {
        public MessageBoxOK()
        {
            InitializeComponent();
        }

        public void SetMessage(string text)
        {
            guna2TextBox1.Text = text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
