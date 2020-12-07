namespace QuanLyThuVien
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdThuThu = new System.Windows.Forms.RadioButton();
            this.rdDocGia = new System.Windows.Forms.RadioButton();
            this.txbTaiKhoan = new JMaterialTextbox.JMaterialTextbox();
            this.txbMatKhau = new JMaterialTextbox.JMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndaangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(293, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(45, 45);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdThuThu
            // 
            this.rdThuThu.AutoSize = true;
            this.rdThuThu.Checked = true;
            this.rdThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThuThu.ForeColor = System.Drawing.Color.White;
            this.rdThuThu.Location = new System.Drawing.Point(57, 294);
            this.rdThuThu.Margin = new System.Windows.Forms.Padding(4);
            this.rdThuThu.Name = "rdThuThu";
            this.rdThuThu.Size = new System.Drawing.Size(108, 29);
            this.rdThuThu.TabIndex = 2;
            this.rdThuThu.TabStop = true;
            this.rdThuThu.Text = "Thủ Thư";
            this.rdThuThu.UseVisualStyleBackColor = true;
            // 
            // rdDocGia
            // 
            this.rdDocGia.AutoSize = true;
            this.rdDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDocGia.ForeColor = System.Drawing.Color.White;
            this.rdDocGia.Location = new System.Drawing.Point(174, 294);
            this.rdDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.rdDocGia.Name = "rdDocGia";
            this.rdDocGia.Size = new System.Drawing.Size(103, 29);
            this.rdDocGia.TabIndex = 3;
            this.rdDocGia.Text = "Đọc Giả";
            this.rdDocGia.UseVisualStyleBackColor = true;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.ForeColors = System.Drawing.Color.White;
            this.txbTaiKhoan.HintText = "Tài khoản";
            this.txbTaiKhoan.IsPassword = false;
            this.txbTaiKhoan.LineBackColor = System.Drawing.Color.White;
            this.txbTaiKhoan.LineThickness = 2;
            this.txbTaiKhoan.Location = new System.Drawing.Point(57, 185);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txbTaiKhoan.MaxLength = 32767;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.OnFocusedColor = System.Drawing.Color.White;
            this.txbTaiKhoan.OnFocusedTextColor = System.Drawing.Color.White;
            this.txbTaiKhoan.ReadOnly = false;
            this.txbTaiKhoan.Size = new System.Drawing.Size(220, 28);
            this.txbTaiKhoan.TabIndex = 0;
            this.txbTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbTaiKhoan.TextName = "Tài khoản";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.ForeColors = System.Drawing.Color.White;
            this.txbMatKhau.HintText = "Mật khẩu";
            this.txbMatKhau.IsPassword = true;
            this.txbMatKhau.LineBackColor = System.Drawing.Color.White;
            this.txbMatKhau.LineThickness = 2;
            this.txbMatKhau.Location = new System.Drawing.Point(57, 242);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txbMatKhau.MaxLength = 32767;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.OnFocusedColor = System.Drawing.Color.White;
            this.txbMatKhau.OnFocusedTextColor = System.Drawing.Color.White;
            this.txbMatKhau.ReadOnly = false;
            this.txbMatKhau.Size = new System.Drawing.Size(220, 27);
            this.txbMatKhau.TabIndex = 1;
            this.txbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbMatKhau.TextName = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 45);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btndaangnhap
            // 
            this.btndaangnhap.BorderRadius = 20;
            this.btndaangnhap.CheckedState.Parent = this.btndaangnhap;
            this.btndaangnhap.CustomImages.Parent = this.btndaangnhap;
            this.btndaangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btndaangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndaangnhap.ForeColor = System.Drawing.Color.White;
            this.btndaangnhap.HoverState.Parent = this.btndaangnhap;
            this.btndaangnhap.Location = new System.Drawing.Point(59, 341);
            this.btndaangnhap.Name = "btndaangnhap";
            this.btndaangnhap.ShadowDecoration.Parent = this.btndaangnhap;
            this.btndaangnhap.Size = new System.Drawing.Size(220, 45);
            this.btndaangnhap.TabIndex = 4;
            this.btndaangnhap.Text = "Đăng nhập";
            this.btndaangnhap.Click += new System.EventHandler(this.btndaangnhap_Click_1);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 412);
            this.Controls.Add(this.btndaangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.rdDocGia);
            this.Controls.Add(this.rdThuThu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdThuThu;
        private System.Windows.Forms.RadioButton rdDocGia;
        private JMaterialTextbox.JMaterialTextbox txbTaiKhoan;
        private JMaterialTextbox.JMaterialTextbox txbMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btndaangnhap;
    }
}