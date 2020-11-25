﻿using QuanLyThuVien.DAO;
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
    public partial class frmQuanLyMuonTra : Form
    {
        public frmQuanLyMuonTra()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        public void Setbackground(Image img)
        {
            tabPage1.BackgroundImage = img;
            tabPage2.BackgroundImage = img;
        }

        public void LoadDanhSach()
        {
            string query = @"select * from  Sach";
            dataGridView1.DataSource = DataProvider.instance.ExcuteQuery(query);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
