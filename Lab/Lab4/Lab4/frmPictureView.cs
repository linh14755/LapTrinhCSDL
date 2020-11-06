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
    public partial class frmPictureView : Form
    {
        int count = 0;
        public frmPictureView()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Sự kiện
        //Sự kiện click cho menu item File --> New
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK) 
            {
                frmPicture frm = new frmPicture(openFileDialog1.FileName);
                frm.MdiParent = this;
                count++;
                frm.Text = "Picture - " + count + "-" + openFileDialog1.FileName;
                frm.Show();
            }
        }
        #endregion

    }
}
