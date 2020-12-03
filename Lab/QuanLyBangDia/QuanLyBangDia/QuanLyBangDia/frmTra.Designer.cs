namespace DataAccess
{
    partial class frmTra
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMaKH = new System.Windows.Forms.RadioButton();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rdMaBD = new System.Windows.Forms.RadioButton();
            this.rdMaLuot = new System.Windows.Forms.RadioButton();
            this.btnTra = new System.Windows.Forms.Button();
            this.lvThue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbTenBD = new System.Windows.Forms.TextBox();
            this.nmTongTien = new System.Windows.Forms.NumericUpDown();
            this.cbbMaBD = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLuot = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nmTienCoc = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTienCoc)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày thuê";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tiền cọc";
            this.columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tổng tiền";
            this.columnHeader14.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 110;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(139, 76);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(135, 24);
            this.cbbMaKH.TabIndex = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMaKH);
            this.groupBox1.Controls.Add(this.txbTim);
            this.groupBox1.Controls.Add(this.rdMaBD);
            this.groupBox1.Controls.Add(this.rdMaLuot);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(105, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 44);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdMaKH
            // 
            this.rdMaKH.AutoSize = true;
            this.rdMaKH.Location = new System.Drawing.Point(217, 16);
            this.rdMaKH.Name = "rdMaKH";
            this.rdMaKH.Size = new System.Drawing.Size(71, 21);
            this.rdMaKH.TabIndex = 53;
            this.rdMaKH.TabStop = true;
            this.rdMaKH.Text = "Mã KH";
            this.rdMaKH.UseVisualStyleBackColor = true;
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(336, 15);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(135, 22);
            this.txbTim.TabIndex = 52;
            this.txbTim.TextChanged += new System.EventHandler(this.txbTim_TextChanged_1);
            // 
            // rdMaBD
            // 
            this.rdMaBD.AutoSize = true;
            this.rdMaBD.Location = new System.Drawing.Point(124, 16);
            this.rdMaBD.Name = "rdMaBD";
            this.rdMaBD.Size = new System.Drawing.Size(71, 21);
            this.rdMaBD.TabIndex = 51;
            this.rdMaBD.TabStop = true;
            this.rdMaBD.Text = "Mã BD";
            this.rdMaBD.UseVisualStyleBackColor = true;
            // 
            // rdMaLuot
            // 
            this.rdMaLuot.AutoSize = true;
            this.rdMaLuot.Location = new System.Drawing.Point(31, 16);
            this.rdMaLuot.Name = "rdMaLuot";
            this.rdMaLuot.Size = new System.Drawing.Size(75, 21);
            this.rdMaLuot.TabIndex = 50;
            this.rdMaLuot.TabStop = true;
            this.rdMaLuot.Text = "Mã lượt";
            this.rdMaLuot.UseVisualStyleBackColor = true;
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.White;
            this.btnTra.Location = new System.Drawing.Point(306, 144);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(85, 45);
            this.btnTra.TabIndex = 115;
            this.btnTra.Text = "Trả đĩa";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // lvThue
            // 
            this.lvThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader13,
            this.columnHeader14});
            this.lvThue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvThue.FullRowSelect = true;
            this.lvThue.GridLines = true;
            this.lvThue.HideSelection = false;
            this.lvThue.Location = new System.Drawing.Point(0, 256);
            this.lvThue.MultiSelect = false;
            this.lvThue.Name = "lvThue";
            this.lvThue.Size = new System.Drawing.Size(686, 244);
            this.lvThue.TabIndex = 114;
            this.lvThue.UseCompatibleStateImageBehavior = false;
            this.lvThue.View = System.Windows.Forms.View.Details;
            this.lvThue.SelectedIndexChanged += new System.EventHandler(this.lvThue_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lượt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã băng đĩa";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã khách hàng";
            this.columnHeader3.Width = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 113;
            this.label14.Text = "Tền khách hàng";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(139, 139);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(135, 22);
            this.txbTenKH.TabIndex = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 111;
            this.label13.Text = "Tên băng đĩa";
            // 
            // txbTenBD
            // 
            this.txbTenBD.Location = new System.Drawing.Point(139, 107);
            this.txbTenBD.Name = "txbTenBD";
            this.txbTenBD.Size = new System.Drawing.Size(135, 22);
            this.txbTenBD.TabIndex = 110;
            // 
            // nmTongTien
            // 
            this.nmTongTien.Location = new System.Drawing.Point(533, 109);
            this.nmTongTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmTongTien.Name = "nmTongTien";
            this.nmTongTien.Size = new System.Drawing.Size(135, 22);
            this.nmTongTien.TabIndex = 109;
            // 
            // cbbMaBD
            // 
            this.cbbMaBD.FormattingEnabled = true;
            this.cbbMaBD.Location = new System.Drawing.Point(139, 44);
            this.cbbMaBD.Name = "cbbMaBD";
            this.cbbMaBD.Size = new System.Drawing.Size(135, 24);
            this.cbbMaBD.TabIndex = 118;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(424, 144);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 45);
            this.btnHome.TabIndex = 116;
            this.btnHome.Text = "Quay lại";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(408, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 108;
            this.label12.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(408, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 104;
            this.label7.Text = "Ngày thuê";
            // 
            // txbLuot
            // 
            this.txbLuot.Enabled = false;
            this.txbLuot.Location = new System.Drawing.Point(139, 8);
            this.txbLuot.Name = "txbLuot";
            this.txbLuot.Size = new System.Drawing.Size(135, 22);
            this.txbLuot.TabIndex = 102;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(533, 39);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayTra.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(408, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 106;
            this.label11.Text = "Ngày trả";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(533, 8);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayThue.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 103;
            this.label6.Text = "Lượt";
            // 
            // nmTienCoc
            // 
            this.nmTienCoc.Location = new System.Drawing.Point(533, 74);
            this.nmTienCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmTienCoc.Name = "nmTienCoc";
            this.nmTienCoc.Size = new System.Drawing.Size(135, 22);
            this.nmTienCoc.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(408, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Tiền cọc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Mã khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 98;
            this.label8.Text = "Mã băng đĩa";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tổng tiền";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày trả";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày thuê";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã khách hàng";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã băng đĩa";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lượt";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tiền cọc";
            // 
            // frmTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(686, 500);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.lvThue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbTenKH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbTenBD);
            this.Controls.Add(this.nmTongTien);
            this.Controls.Add(this.cbbMaBD);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbLuot);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmTienCoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "frmTra";
            this.Text = "frmTra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTienCoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMaKH;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rdMaBD;
        private System.Windows.Forms.RadioButton rdMaLuot;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.ListView lvThue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbTenBD;
        private System.Windows.Forms.NumericUpDown nmTongTien;
        private System.Windows.Forms.ComboBox cbbMaBD;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbLuot;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmTienCoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}