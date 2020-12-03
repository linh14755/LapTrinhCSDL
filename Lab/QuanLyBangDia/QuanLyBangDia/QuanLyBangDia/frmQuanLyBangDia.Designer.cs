namespace QuanLyBangDia
{
    partial class frmQuanLyBangDia
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
            this.lvBangDia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.txbTenBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDonGia = new System.Windows.Forms.RadioButton();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.rdTenBD = new System.Windows.Forms.RadioButton();
            this.rdMaBD = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBangDia
            // 
            this.lvBangDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvBangDia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBangDia.FullRowSelect = true;
            this.lvBangDia.GridLines = true;
            this.lvBangDia.HideSelection = false;
            this.lvBangDia.Location = new System.Drawing.Point(0, 256);
            this.lvBangDia.MultiSelect = false;
            this.lvBangDia.Name = "lvBangDia";
            this.lvBangDia.Size = new System.Drawing.Size(686, 244);
            this.lvBangDia.TabIndex = 29;
            this.lvBangDia.UseCompatibleStateImageBehavior = false;
            this.lvBangDia.View = System.Windows.Forms.View.Details;
            this.lvBangDia.SelectedIndexChanged += new System.EventHandler(this.lvBangDia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã băng đĩa";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên băng đĩa";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thể loại";
            this.columnHeader5.Width = 250;
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(498, 65);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(134, 22);
            this.txbDonGia.TabIndex = 47;
            // 
            // txbTenBD
            // 
            this.txbTenBD.Location = new System.Drawing.Point(176, 65);
            this.txbTenBD.Name = "txbTenBD";
            this.txbTenBD.Size = new System.Drawing.Size(134, 22);
            this.txbTenBD.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên băng đĩa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Số lượng";
            // 
            // txbSL
            // 
            this.txbSL.Location = new System.Drawing.Point(498, 23);
            this.txbSL.Name = "txbSL";
            this.txbSL.Size = new System.Drawing.Size(134, 22);
            this.txbSL.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã băng đĩa";
            // 
            // txbMaBD
            // 
            this.txbMaBD.Enabled = false;
            this.txbMaBD.Location = new System.Drawing.Point(176, 23);
            this.txbMaBD.Name = "txbMaBD";
            this.txbMaBD.Size = new System.Drawing.Size(134, 22);
            this.txbMaBD.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Thể loại";
            // 
            // txbTL
            // 
            this.txbTL.Location = new System.Drawing.Point(498, 108);
            this.txbTL.Name = "txbTL";
            this.txbTL.Size = new System.Drawing.Size(134, 22);
            this.txbTL.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDonGia);
            this.groupBox1.Controls.Add(this.txbTim);
            this.groupBox1.Controls.Add(this.rdTenBD);
            this.groupBox1.Controls.Add(this.rdMaBD);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(109, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 44);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdDonGia
            // 
            this.rdDonGia.AutoSize = true;
            this.rdDonGia.Location = new System.Drawing.Point(194, 15);
            this.rdDonGia.Name = "rdDonGia";
            this.rdDonGia.Size = new System.Drawing.Size(78, 21);
            this.rdDonGia.TabIndex = 57;
            this.rdDonGia.TabStop = true;
            this.rdDonGia.Text = "Đơn giá";
            this.rdDonGia.UseVisualStyleBackColor = true;
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(299, 14);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(135, 22);
            this.txbTim.TabIndex = 56;
            this.txbTim.TextChanged += new System.EventHandler(this.txbTim_TextChanged);
            // 
            // rdTenBD
            // 
            this.rdTenBD.AutoSize = true;
            this.rdTenBD.Location = new System.Drawing.Point(111, 15);
            this.rdTenBD.Name = "rdTenBD";
            this.rdTenBD.Size = new System.Drawing.Size(77, 21);
            this.rdTenBD.TabIndex = 55;
            this.rdTenBD.TabStop = true;
            this.rdTenBD.Text = "Tên BD";
            this.rdTenBD.UseVisualStyleBackColor = true;
            // 
            // rdMaBD
            // 
            this.rdMaBD.AutoSize = true;
            this.rdMaBD.Location = new System.Drawing.Point(34, 15);
            this.rdMaBD.Name = "rdMaBD";
            this.rdMaBD.Size = new System.Drawing.Size(71, 21);
            this.rdMaBD.TabIndex = 54;
            this.rdMaBD.TabStop = true;
            this.rdMaBD.Text = "Mã BD";
            this.rdMaBD.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(477, 149);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 45);
            this.btnHome.TabIndex = 68;
            this.btnHome.Text = "Quay lại";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(359, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 45);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(243, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 45);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(125, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 45);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyBangDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(686, 500);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.txbTenBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTL);
            this.Controls.Add(this.lvBangDia);
            this.Name = "frmQuanLyBangDia";
            this.Text = "frmQuanLyBangDia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvBangDia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.TextBox txbTenBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDonGia;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.RadioButton rdTenBD;
        private System.Windows.Forms.RadioButton rdMaBD;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}