namespace QuanLyThuVien
{
    partial class frmQuanLyMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvmuonsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rdmasach = new System.Windows.Forms.RadioButton();
            this.rdMaDocGia = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtptra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpmuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbmadg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnmuon = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbtendocgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvmuonsach
            // 
            this.lvmuonsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvmuonsach.FullRowSelect = true;
            this.lvmuonsach.GridLines = true;
            this.lvmuonsach.HideSelection = false;
            this.lvmuonsach.Location = new System.Drawing.Point(25, 362);
            this.lvmuonsach.MultiSelect = false;
            this.lvmuonsach.Name = "lvmuonsach";
            this.lvmuonsach.Size = new System.Drawing.Size(869, 232);
            this.lvmuonsach.TabIndex = 33;
            this.lvmuonsach.UseCompatibleStateImageBehavior = false;
            this.lvmuonsach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đọc giả";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã sách";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mượn";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ghi chú";
            this.columnHeader7.Width = 350;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbTenSach);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txbtendocgia);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(25, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 191);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTim);
            this.groupBox2.Controls.Add(this.rdmasach);
            this.groupBox2.Controls.Add(this.rdMaDocGia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 104);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(27, 56);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(184, 27);
            this.txbTim.TabIndex = 3;
            this.txbTim.TextChanged += new System.EventHandler(this.txbTim_TextChanged);
            // 
            // rdmasach
            // 
            this.rdmasach.AutoSize = true;
            this.rdmasach.Location = new System.Drawing.Point(115, 26);
            this.rdmasach.Name = "rdmasach";
            this.rdmasach.Size = new System.Drawing.Size(96, 24);
            this.rdmasach.TabIndex = 1;
            this.rdmasach.TabStop = true;
            this.rdmasach.Text = "Mã Sách";
            this.rdmasach.UseVisualStyleBackColor = true;
            // 
            // rdMaDocGia
            // 
            this.rdMaDocGia.AutoSize = true;
            this.rdMaDocGia.Location = new System.Drawing.Point(25, 26);
            this.rdMaDocGia.Name = "rdMaDocGia";
            this.rdMaDocGia.Size = new System.Drawing.Size(83, 24);
            this.rdMaDocGia.TabIndex = 0;
            this.rdMaDocGia.TabStop = true;
            this.rdMaDocGia.Text = "Mã ĐG";
            this.rdMaDocGia.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtptra);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.dtpmuon);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cbbmasach);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cbbmadg);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txbghichu);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(269, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(625, 249);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cho Mượn Sách";
            // 
            // dtptra
            // 
            this.dtptra.CustomFormat = "dd/MM/yyyy";
            this.dtptra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptra.Location = new System.Drawing.Point(433, 62);
            this.dtptra.Name = "dtptra";
            this.dtptra.Size = new System.Drawing.Size(186, 27);
            this.dtptra.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày Trả";
            // 
            // dtpmuon
            // 
            this.dtpmuon.CustomFormat = "dd/MM/yyyy";
            this.dtpmuon.Enabled = false;
            this.dtpmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmuon.Location = new System.Drawing.Point(433, 24);
            this.dtpmuon.Name = "dtpmuon";
            this.dtpmuon.Size = new System.Drawing.Size(186, 27);
            this.dtpmuon.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày Mượn";
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(123, 64);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(186, 28);
            this.cbbmasach.TabIndex = 14;
            this.cbbmasach.SelectedIndexChanged += new System.EventHandler(this.cbbmasach_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Sách";
            // 
            // cbbmadg
            // 
            this.cbbmadg.FormattingEnabled = true;
            this.cbbmadg.Location = new System.Drawing.Point(123, 26);
            this.cbbmadg.Name = "cbbmadg";
            this.cbbmadg.Size = new System.Drawing.Size(186, 28);
            this.cbbmadg.TabIndex = 2;
            this.cbbmadg.SelectedIndexChanged += new System.EventHandler(this.cbbmadg_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Đọc Giả";
            // 
            // txbghichu
            // 
            this.txbghichu.Location = new System.Drawing.Point(137, 110);
            this.txbghichu.Multiline = true;
            this.txbghichu.Name = "txbghichu";
            this.txbghichu.Size = new System.Drawing.Size(482, 114);
            this.txbghichu.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ghi chú";
            // 
            // btnmuon
            // 
            this.btnmuon.BorderRadius = 20;
            this.btnmuon.CheckedState.Parent = this.btnmuon;
            this.btnmuon.CustomImages.Parent = this.btnmuon;
            this.btnmuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnmuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmuon.ForeColor = System.Drawing.Color.White;
            this.btnmuon.HoverState.Parent = this.btnmuon;
            this.btnmuon.Location = new System.Drawing.Point(342, 291);
            this.btnmuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnmuon.Name = "btnmuon";
            this.btnmuon.ShadowDecoration.Parent = this.btnmuon;
            this.btnmuon.Size = new System.Drawing.Size(114, 50);
            this.btnmuon.TabIndex = 47;
            this.btnmuon.Text = "Cho Mượn";
            this.btnmuon.Click += new System.EventHandler(this.btnmuon_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 20;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(485, 291);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(114, 50);
            this.btnHome.TabIndex = 48;
            this.btnHome.Text = "Quay lại";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(27, 45);
            this.txbTenSach.Multiline = true;
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.ReadOnly = true;
            this.txbTenSach.Size = new System.Drawing.Size(185, 49);
            this.txbTenSach.TabIndex = 13;
            this.txbTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Sách";
            // 
            // txbtendocgia
            // 
            this.txbtendocgia.Location = new System.Drawing.Point(26, 125);
            this.txbtendocgia.Multiline = true;
            this.txbtendocgia.Name = "txbtendocgia";
            this.txbtendocgia.ReadOnly = true;
            this.txbtendocgia.Size = new System.Drawing.Size(185, 49);
            this.txbtendocgia.TabIndex = 14;
            this.txbtendocgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên ĐG";
            // 
            // frmQuanLyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.btnmuon);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lvmuonsach);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyMuonSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvmuonsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rdmasach;
        private System.Windows.Forms.RadioButton rdMaDocGia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtptra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpmuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmadg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbghichu;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnmuon;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbtendocgia;
        private System.Windows.Forms.Label label3;
    }
}