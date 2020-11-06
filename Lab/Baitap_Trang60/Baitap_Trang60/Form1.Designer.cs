namespace Baitap_Trang60
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbPhongban = new System.Windows.Forms.ComboBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.mtbSodt = new System.Windows.Forms.MaskedTextBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.mtbNV = new System.Windows.Forms.MaskedTextBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.lbHinh = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhongban = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbSodt = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGoitinh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.DialogChon = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnAddImg);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.cbPhongban);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.mtbSodt);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.mtbNV);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.lbHinh);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbPhongban);
            this.groupBox1.Controls.Add(this.lbDiachi);
            this.groupBox1.Controls.Add(this.lbSodt);
            this.groupBox1.Controls.Add(this.lbNgaysinh);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbGoitinh);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(752, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(555, 167);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(135, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // cbPhongban
            // 
            this.cbPhongban.FormattingEnabled = true;
            this.cbPhongban.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cbPhongban.Location = new System.Drawing.Point(344, 167);
            this.cbPhongban.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhongban.Name = "cbPhongban";
            this.cbPhongban.Size = new System.Drawing.Size(92, 21);
            this.cbPhongban.TabIndex = 11;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(344, 128);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(208, 20);
            this.tbDiaChi.TabIndex = 10;
            // 
            // mtbSodt
            // 
            this.mtbSodt.Location = new System.Drawing.Point(555, 93);
            this.mtbSodt.Margin = new System.Windows.Forms.Padding(2);
            this.mtbSodt.Mask = "\\0633. 000 . 000";
            this.mtbSodt.Name = "mtbSodt";
            this.mtbSodt.Size = new System.Drawing.Size(135, 20);
            this.mtbSodt.TabIndex = 9;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(344, 91);
            this.dtpkNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(151, 20);
            this.dtpkNgaySinh.TabIndex = 8;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(344, 56);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(208, 20);
            this.tbTen.TabIndex = 7;
            // 
            // mtbNV
            // 
            this.mtbNV.Location = new System.Drawing.Point(344, 26);
            this.mtbNV.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNV.Mask = "NV. 000";
            this.mtbNV.Name = "mtbNV";
            this.mtbNV.Size = new System.Drawing.Size(99, 20);
            this.mtbNV.TabIndex = 1;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(654, 27);
            this.rbNu.Margin = new System.Windows.Forms.Padding(2);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(584, 27);
            this.rbNam.Margin = new System.Windows.Forms.Padding(2);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // lbHinh
            // 
            this.lbHinh.AutoSize = true;
            this.lbHinh.Location = new System.Drawing.Point(252, 197);
            this.lbHinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHinh.Name = "lbHinh";
            this.lbHinh.Size = new System.Drawing.Size(29, 13);
            this.lbHinh.TabIndex = 6;
            this.lbHinh.Text = "Hình";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(514, 167);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbPhongban
            // 
            this.lbPhongban.AutoSize = true;
            this.lbPhongban.Location = new System.Drawing.Point(252, 167);
            this.lbPhongban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhongban.Name = "lbPhongban";
            this.lbPhongban.Size = new System.Drawing.Size(59, 13);
            this.lbPhongban.TabIndex = 4;
            this.lbPhongban.Text = "Phòng ban";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(252, 128);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(40, 13);
            this.lbDiachi.TabIndex = 2;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Location = new System.Drawing.Point(514, 95);
            this.lbSodt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(38, 13);
            this.lbSodt.TabIndex = 2;
            this.lbSodt.Text = "Số ĐT";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(252, 91);
            this.lbNgaysinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaysinh.TabIndex = 3;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(252, 58);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ và tên";
            // 
            // lbGoitinh
            // 
            this.lbGoitinh.AutoSize = true;
            this.lbGoitinh.Location = new System.Drawing.Point(514, 27);
            this.lbGoitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGoitinh.Name = "lbGoitinh";
            this.lbGoitinh.Size = new System.Drawing.Size(51, 13);
            this.lbGoitinh.TabIndex = 1;
            this.lbGoitinh.Text = "Giới Tính";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(252, 28);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvInfo);
            this.groupBox2.Location = new System.Drawing.Point(9, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(752, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // lvInfo
            // 
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(4, 17);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(744, 171);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 446);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(182, 446);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(394, 446);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(85, 27);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Mặc Định";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 446);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(344, 193);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(92, 23);
            this.btnAddImg.TabIndex = 14;
            this.btnAddImg.Text = "Browse";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // DialogChon
            // 
            this.DialogChon.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 191);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 483);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label lbHinh;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhongban;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbSodt;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGoitinh;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ComboBox cbPhongban;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.MaskedTextBox mtbSodt;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.MaskedTextBox mtbNV;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.OpenFileDialog DialogChon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

