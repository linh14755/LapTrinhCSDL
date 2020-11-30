namespace QuanLyThuVien
{
    partial class frmQuanLyTraSach
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txbghichu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpngaymuon = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txbmasach = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbmadocgia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbmaphieu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbtim = new System.Windows.Forms.TextBox();
            this.rdmasach = new System.Windows.Forms.RadioButton();
            this.rdmadocgia = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvsach = new System.Windows.Forms.ListView();
            this.btntrasach = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txbghichu);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.dtpngaytra);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.dtpngaymuon);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.txbmasach);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.txbmadocgia);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.txbmaphieu);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Location = new System.Drawing.Point(265, 27);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(625, 291);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Trả sách";
            // 
            // txbghichu
            // 
            this.txbghichu.Location = new System.Drawing.Point(126, 176);
            this.txbghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txbghichu.Multiline = true;
            this.txbghichu.Name = "txbghichu";
            this.txbghichu.Size = new System.Drawing.Size(446, 95);
            this.txbghichu.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ghi chú";
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.CustomFormat = "dd/MM/yyyy";
            this.dtpngaytra.Enabled = false;
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaytra.Location = new System.Drawing.Point(433, 67);
            this.dtpngaytra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(184, 27);
            this.dtpngaytra.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Ngày trả";
            // 
            // dtpngaymuon
            // 
            this.dtpngaymuon.CustomFormat = "dd/MM/yyyy";
            this.dtpngaymuon.Enabled = false;
            this.dtpngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaymuon.Location = new System.Drawing.Point(433, 25);
            this.dtpngaymuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaymuon.Name = "dtpngaymuon";
            this.dtpngaymuon.Size = new System.Drawing.Size(184, 27);
            this.dtpngaymuon.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(323, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ngày mượn";
            // 
            // txbmasach
            // 
            this.txbmasach.Location = new System.Drawing.Point(126, 118);
            this.txbmasach.Margin = new System.Windows.Forms.Padding(4);
            this.txbmasach.Name = "txbmasach";
            this.txbmasach.ReadOnly = true;
            this.txbmasach.Size = new System.Drawing.Size(187, 27);
            this.txbmasach.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mã sách";
            // 
            // txbmadocgia
            // 
            this.txbmadocgia.Location = new System.Drawing.Point(126, 69);
            this.txbmadocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txbmadocgia.Name = "txbmadocgia";
            this.txbmadocgia.ReadOnly = true;
            this.txbmadocgia.Size = new System.Drawing.Size(187, 27);
            this.txbmadocgia.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Mã đọc giả";
            // 
            // txbmaphieu
            // 
            this.txbmaphieu.Location = new System.Drawing.Point(126, 26);
            this.txbmaphieu.Margin = new System.Windows.Forms.Padding(4);
            this.txbmaphieu.Name = "txbmaphieu";
            this.txbmaphieu.ReadOnly = true;
            this.txbmaphieu.Size = new System.Drawing.Size(187, 27);
            this.txbmaphieu.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 30);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Mã phiếu";
            // 
            // txbtim
            // 
            this.txbtim.Location = new System.Drawing.Point(21, 85);
            this.txbtim.Name = "txbtim";
            this.txbtim.Size = new System.Drawing.Size(187, 27);
            this.txbtim.TabIndex = 2;
            this.txbtim.TextChanged += new System.EventHandler(this.txbtim_TextChanged);
            // 
            // rdmasach
            // 
            this.rdmasach.AutoSize = true;
            this.rdmasach.Location = new System.Drawing.Point(130, 41);
            this.rdmasach.Margin = new System.Windows.Forms.Padding(4);
            this.rdmasach.Name = "rdmasach";
            this.rdmasach.Size = new System.Drawing.Size(94, 24);
            this.rdmasach.TabIndex = 1;
            this.rdmasach.TabStop = true;
            this.rdmasach.Text = "Mã sách";
            this.rdmasach.UseVisualStyleBackColor = true;
            // 
            // rdmadocgia
            // 
            this.rdmadocgia.AutoSize = true;
            this.rdmadocgia.Location = new System.Drawing.Point(8, 41);
            this.rdmadocgia.Margin = new System.Windows.Forms.Padding(4);
            this.rdmadocgia.Name = "rdmadocgia";
            this.rdmadocgia.Size = new System.Drawing.Size(112, 24);
            this.rdmadocgia.TabIndex = 0;
            this.rdmadocgia.TabStop = true;
            this.rdmadocgia.Text = "Mã đọc giả";
            this.rdmadocgia.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txbtim);
            this.groupBox9.Controls.Add(this.rdmasach);
            this.groupBox9.Controls.Add(this.rdmadocgia);
            this.groupBox9.Location = new System.Drawing.Point(27, 27);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(230, 145);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tìm Theo";
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
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mượn";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ghi chú";
            this.columnHeader7.Width = 350;
            // 
            // lvsach
            // 
            this.lvsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvsach.FullRowSelect = true;
            this.lvsach.GridLines = true;
            this.lvsach.HideSelection = false;
            this.lvsach.Location = new System.Drawing.Point(27, 325);
            this.lvsach.Name = "lvsach";
            this.lvsach.Size = new System.Drawing.Size(863, 269);
            this.lvsach.TabIndex = 30;
            this.lvsach.UseCompatibleStateImageBehavior = false;
            this.lvsach.View = System.Windows.Forms.View.Details;
            this.lvsach.SelectedIndexChanged += new System.EventHandler(this.lvsach_SelectedIndexChanged);
            // 
            // btntrasach
            // 
            this.btntrasach.BorderRadius = 20;
            this.btntrasach.CheckedState.Parent = this.btntrasach;
            this.btntrasach.CustomImages.Parent = this.btntrasach;
            this.btntrasach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btntrasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrasach.ForeColor = System.Drawing.Color.White;
            this.btntrasach.HoverState.Parent = this.btntrasach;
            this.btntrasach.Location = new System.Drawing.Point(25, 216);
            this.btntrasach.Margin = new System.Windows.Forms.Padding(2);
            this.btntrasach.Name = "btntrasach";
            this.btntrasach.ShadowDecoration.Parent = this.btntrasach;
            this.btntrasach.Size = new System.Drawing.Size(114, 50);
            this.btntrasach.TabIndex = 45;
            this.btntrasach.Text = "Trả sách";
            this.btntrasach.Click += new System.EventHandler(this.btntrasach_Click);
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
            this.btnHome.Location = new System.Drawing.Point(143, 216);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(114, 50);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Quay lại";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmQuanLyTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.btntrasach);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lvsach);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyTraSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trả Sách";
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txbtim;
        private System.Windows.Forms.RadioButton rdmasach;
        private System.Windows.Forms.RadioButton rdmadocgia;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txbghichu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpngaymuon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbmasach;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbmadocgia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbmaphieu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvsach;
        private Guna.UI2.WinForms.Guna2Button btntrasach;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}