﻿using System;
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
    public partial class MessageBoxOKCancel : Form
    {
        public MessageBoxOKCancel()
        {
            InitializeComponent();
        }
        public void SetMessage(string text)
        {
            guna2TextBox1.Text = text;
            //guna2Button1.DialogResult = DialogResult.OK;
            //guna2Button2.DialogResult = DialogResult.Cancel;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
