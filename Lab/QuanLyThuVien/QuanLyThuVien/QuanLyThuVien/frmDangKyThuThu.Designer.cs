namespace QuanLyThuVien
{
    partial class frmDangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSoDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(288, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 163);
            this.panel1.TabIndex = 50;
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 20;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(10, 96);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(257, 50);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Thay đổi thông tin";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.CheckedState.Parent = this.btnDangKy;
            this.btnDangKy.CustomImages.Parent = this.btnDangKy;
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.HoverState.Parent = this.btnDangKy;
            this.btnDangKy.Location = new System.Drawing.Point(10, 25);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ShadowDecoration.Parent = this.btnDangKy;
            this.btnDangKy.Size = new System.Drawing.Size(114, 50);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click_1);
            // 
            // btnhome
            // 
            this.btnhome.BorderRadius = 20;
            this.btnhome.CheckedState.Parent = this.btnhome;
            this.btnhome.CustomImages.Parent = this.btnhome;
            this.btnhome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.Parent = this.btnhome;
            this.btnhome.Location = new System.Drawing.Point(153, 25);
            this.btnhome.Margin = new System.Windows.Forms.Padding(2);
            this.btnhome.Name = "btnhome";
            this.btnhome.ShadowDecoration.Parent = this.btnhome;
            this.btnhome.Size = new System.Drawing.Size(114, 50);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Quay lại";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click_1);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(266, 208);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 21);
            this.rdNu.TabIndex = 3;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(166, 208);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Giới tính:";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(166, 160);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(239, 22);
            this.dtpkNgaySinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(166, 122);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(239, 22);
            this.txbHoTen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Họ Tên:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(552, 119);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(239, 22);
            this.txbEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Email:";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(550, 158);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(241, 22);
            this.txbTaiKhoan.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tên tài khoản:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(550, 204);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(241, 22);
            this.txbMatKhau.TabIndex = 8;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Mật khẩu";
            // 
            // txbNhapLaiMK
            // 
            this.txbNhapLaiMK.Location = new System.Drawing.Point(550, 246);
            this.txbNhapLaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.txbNhapLaiMK.Name = "txbNhapLaiMK";
            this.txbNhapLaiMK.Size = new System.Drawing.Size(239, 22);
            this.txbNhapLaiMK.TabIndex = 9;
            this.txbNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Nhập lại MK";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(167, 280);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(624, 22);
            this.txbDiaChi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txbSoDT
            // 
            this.txbSoDT.Location = new System.Drawing.Point(166, 245);
            this.txbSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoDT.Name = "txbSoDT";
            this.txbSoDT.Size = new System.Drawing.Size(239, 22);
            this.txbSoDT.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Số ĐT:";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 606);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpkNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNhapLaiMK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSoDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNhapLaiMK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSoDT;
        private System.Windows.Forms.Label label7;
    }
}