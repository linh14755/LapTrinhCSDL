namespace QuanLyThuVien
{
    partial class frmQuanLyDocGia
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
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvdocgia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rdTenDocGia = new System.Windows.Forms.RadioButton();
            this.rdMaDocGia = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbdocgia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ghi Chú";
            this.columnHeader10.Width = 350;
            // 
            // lvdocgia
            // 
            this.lvdocgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvdocgia.FullRowSelect = true;
            this.lvdocgia.GridLines = true;
            this.lvdocgia.HideSelection = false;
            this.lvdocgia.Location = new System.Drawing.Point(39, 405);
            this.lvdocgia.MultiSelect = false;
            this.lvdocgia.Name = "lvdocgia";
            this.lvdocgia.Size = new System.Drawing.Size(823, 174);
            this.lvdocgia.TabIndex = 27;
            this.lvdocgia.UseCompatibleStateImageBehavior = false;
            this.lvdocgia.View = System.Windows.Forms.View.Details;
            this.lvdocgia.SelectedIndexChanged += new System.EventHandler(this.lvdocgia_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Đọc Giả";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Đọc Giả";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới Tính";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tài Khoản";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mật Khẩu";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số ĐT";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa Chỉ";
            this.columnHeader8.Width = 170;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Email";
            this.columnHeader9.Width = 160;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTim);
            this.groupBox2.Controls.Add(this.rdTenDocGia);
            this.groupBox2.Controls.Add(this.rdMaDocGia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 57);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(449, 21);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(235, 27);
            this.txbTim.TabIndex = 2;
            this.txbTim.TextChanged += new System.EventHandler(this.txbTim_TextChanged_1);
            // 
            // rdTenDocGia
            // 
            this.rdTenDocGia.AutoSize = true;
            this.rdTenDocGia.Location = new System.Drawing.Point(284, 22);
            this.rdTenDocGia.Name = "rdTenDocGia";
            this.rdTenDocGia.Size = new System.Drawing.Size(124, 24);
            this.rdTenDocGia.TabIndex = 1;
            this.rdTenDocGia.TabStop = true;
            this.rdTenDocGia.Text = "Tên Đọc Giả";
            this.rdTenDocGia.UseVisualStyleBackColor = true;
            // 
            // rdMaDocGia
            // 
            this.rdMaDocGia.AutoSize = true;
            this.rdMaDocGia.Location = new System.Drawing.Point(139, 21);
            this.rdMaDocGia.Name = "rdMaDocGia";
            this.rdMaDocGia.Size = new System.Drawing.Size(119, 24);
            this.rdMaDocGia.TabIndex = 0;
            this.rdMaDocGia.TabStop = true;
            this.rdMaDocGia.Text = "Mã Đọc Giả";
            this.rdMaDocGia.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbGhiChu);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txbEmail);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txbDiaChi);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txbLop);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(462, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 226);
            this.panel5.TabIndex = 29;
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(161, 116);
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(230, 98);
            this.txbGhiChu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ghi Chú:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(161, 80);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(230, 27);
            this.txbEmail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email:";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(161, 42);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(230, 27);
            this.txbDiaChi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa Chỉ:";
            // 
            // txbLop
            // 
            this.txbLop.Location = new System.Drawing.Point(161, 6);
            this.txbLop.Name = "txbLop";
            this.txbLop.Size = new System.Drawing.Size(230, 27);
            this.txbLop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số ĐT:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMatKhau);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbTaiKhoan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbHoTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbdocgia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 226);
            this.panel1.TabIndex = 28;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(160, 187);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(230, 27);
            this.txbMatKhau.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mật khẩu:";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(160, 150);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(230, 27);
            this.txbTaiKhoan.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tài Khoản:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(284, 117);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(51, 24);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(171, 117);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(65, 24);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới Tính:";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(161, 78);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(229, 27);
            this.dtpkNgaySinh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Sinh:";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(160, 42);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(230, 27);
            this.txbHoTen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Đọc Giả:";
            // 
            // txbdocgia
            // 
            this.txbdocgia.Location = new System.Drawing.Point(160, 9);
            this.txbdocgia.Name = "txbdocgia";
            this.txbdocgia.ReadOnly = true;
            this.txbdocgia.Size = new System.Drawing.Size(230, 27);
            this.txbdocgia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Đọc Giả:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(39, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 80);
            this.panel2.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(424, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(114, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.CheckedState.Parent = this.btnCapNhat;
            this.btnCapNhat.CustomImages.Parent = this.btnCapNhat;
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.HoverState.Parent = this.btnCapNhat;
            this.btnCapNhat.Location = new System.Drawing.Point(282, 15);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(114, 50);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 20;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(142, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(114, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.btnHome.Location = new System.Drawing.Point(567, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(114, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Quay lại";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvdocgia);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyDocGia";
            this.ShowIcon = false;
            this.Text = "Quản Lý Đọc Giả";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lvdocgia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbdocgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rdTenDocGia;
        private System.Windows.Forms.RadioButton rdMaDocGia;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}