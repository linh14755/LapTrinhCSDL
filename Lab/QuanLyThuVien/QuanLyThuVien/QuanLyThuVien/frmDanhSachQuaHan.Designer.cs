namespace QuanLyThuVien
{
    partial class frmDanhSachQuaHan
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
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rdmasach = new System.Windows.Forms.RadioButton();
            this.rdMaDocGia = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbmaphieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbmadg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpmuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtptra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txbghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngiahan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.columnHeader7,
            this.columnHeader8});
            this.lvmuonsach.FullRowSelect = true;
            this.lvmuonsach.GridLines = true;
            this.lvmuonsach.HideSelection = false;
            this.lvmuonsach.Location = new System.Drawing.Point(17, 309);
            this.lvmuonsach.MultiSelect = false;
            this.lvmuonsach.Name = "lvmuonsach";
            this.lvmuonsach.Size = new System.Drawing.Size(862, 273);
            this.lvmuonsach.TabIndex = 37;
            this.lvmuonsach.UseCompatibleStateImageBehavior = false;
            this.lvmuonsach.View = System.Windows.Forms.View.Details;
            this.lvmuonsach.SelectedIndexChanged += new System.EventHandler(this.lvmuonsach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu Mượn";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Đọc Giả";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Sách";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Mượn";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Trả";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Lượng";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Xác Nhận Trả";
            this.columnHeader7.Width = 129;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ghi Chú";
            this.columnHeader8.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTim);
            this.groupBox2.Controls.Add(this.rdmasach);
            this.groupBox2.Controls.Add(this.rdMaDocGia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 104);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(15, 59);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(221, 27);
            this.txbTim.TabIndex = 3;
            this.txbTim.TextChanged += new System.EventHandler(this.txbTim_TextChanged_1);
            // 
            // rdmasach
            // 
            this.rdmasach.AutoSize = true;
            this.rdmasach.Location = new System.Drawing.Point(141, 29);
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
            this.rdMaDocGia.Location = new System.Drawing.Point(16, 28);
            this.rdMaDocGia.Name = "rdMaDocGia";
            this.rdMaDocGia.Size = new System.Drawing.Size(119, 24);
            this.rdMaDocGia.TabIndex = 0;
            this.rdMaDocGia.TabStop = true;
            this.rdMaDocGia.Text = "Mã Đọc Giả";
            this.rdMaDocGia.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtptra);
            this.groupBox5.Controls.Add(this.txbghichu);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.dtpmuon);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txbmaphieu);
            this.groupBox5.Controls.Add(this.cbbmasach);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cbbmadg);
            this.groupBox5.Location = new System.Drawing.Point(323, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(556, 280);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cho Mượn Sách";
            // 
            // txbmaphieu
            // 
            this.txbmaphieu.Location = new System.Drawing.Point(116, 27);
            this.txbmaphieu.Name = "txbmaphieu";
            this.txbmaphieu.ReadOnly = true;
            this.txbmaphieu.Size = new System.Drawing.Size(187, 27);
            this.txbmaphieu.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã Phiếu";
            // 
            // cbbmadg
            // 
            this.cbbmadg.Enabled = false;
            this.cbbmadg.FormattingEnabled = true;
            this.cbbmadg.Location = new System.Drawing.Point(116, 67);
            this.cbbmadg.Name = "cbbmadg";
            this.cbbmadg.Size = new System.Drawing.Size(187, 28);
            this.cbbmadg.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mã Đọc Giả";
            // 
            // cbbmasach
            // 
            this.cbbmasach.Enabled = false;
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(116, 110);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(187, 28);
            this.cbbmasach.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mã Sách";
            // 
            // dtpmuon
            // 
            this.dtpmuon.CustomFormat = "dd/MM/yyyy";
            this.dtpmuon.Enabled = false;
            this.dtpmuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmuon.Location = new System.Drawing.Point(116, 154);
            this.dtpmuon.Name = "dtpmuon";
            this.dtpmuon.Size = new System.Drawing.Size(187, 27);
            this.dtpmuon.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Ngày Mượn";
            // 
            // dtptra
            // 
            this.dtptra.CustomFormat = "dd/MM/yyyy";
            this.dtptra.Enabled = false;
            this.dtptra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptra.Location = new System.Drawing.Point(116, 194);
            this.dtptra.Name = "dtptra";
            this.dtptra.Size = new System.Drawing.Size(187, 27);
            this.dtptra.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ngày Trả";
            // 
            // txbghichu
            // 
            this.txbghichu.Enabled = false;
            this.txbghichu.Location = new System.Drawing.Point(345, 67);
            this.txbghichu.Multiline = true;
            this.txbghichu.Name = "txbghichu";
            this.txbghichu.Size = new System.Drawing.Size(189, 185);
            this.txbghichu.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ghi chú";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btngiahan);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(26, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 38;
            // 
            // btngiahan
            // 
            this.btngiahan.BorderRadius = 20;
            this.btngiahan.CheckedState.Parent = this.btngiahan;
            this.btngiahan.CustomImages.Parent = this.btngiahan;
            this.btngiahan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btngiahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiahan.ForeColor = System.Drawing.Color.White;
            this.btngiahan.HoverState.Parent = this.btngiahan;
            this.btngiahan.Location = new System.Drawing.Point(10, 25);
            this.btngiahan.Margin = new System.Windows.Forms.Padding(2);
            this.btngiahan.Name = "btngiahan";
            this.btngiahan.ShadowDecoration.Parent = this.btngiahan;
            this.btngiahan.Size = new System.Drawing.Size(114, 50);
            this.btngiahan.TabIndex = 45;
            this.btngiahan.Text = "Gia Hạn";
            this.btngiahan.Click += new System.EventHandler(this.btngiahan_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 20;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(153, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(114, 50);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Quay lại";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // frmDanhSachQuaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvmuonsach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDanhSachQuaHan";
            this.ShowIcon = false;
            this.Text = "Danh sách Quá Hạn";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rdmasach;
        private System.Windows.Forms.RadioButton rdMaDocGia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtptra;
        private System.Windows.Forms.TextBox txbghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpmuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbmaphieu;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbmadg;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btngiahan;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}