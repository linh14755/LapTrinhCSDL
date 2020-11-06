namespace QuanLyThuVien
{
    partial class frmQuanLySach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTenTG = new System.Windows.Forms.RadioButton();
            this.rdTenSach = new System.Windows.Forms.RadioButton();
            this.rdMaSach = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbLinhVuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbNamXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tcbNhaXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.txbTim);
            this.groupBox3.Location = new System.Drawing.Point(541, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Thông Tin Tìm Kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(332, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 37);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(31, 30);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(251, 22);
            this.txbTim.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTenTG);
            this.groupBox2.Controls.Add(this.rdTenSach);
            this.groupBox2.Controls.Add(this.rdMaSach);
            this.groupBox2.Location = new System.Drawing.Point(16, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // rdTenTG
            // 
            this.rdTenTG.AutoSize = true;
            this.rdTenTG.Location = new System.Drawing.Point(325, 31);
            this.rdTenTG.Name = "rdTenTG";
            this.rdTenTG.Size = new System.Drawing.Size(108, 21);
            this.rdTenTG.TabIndex = 2;
            this.rdTenTG.TabStop = true;
            this.rdTenTG.Text = "Tên Tác Giả";
            this.rdTenTG.UseVisualStyleBackColor = true;
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.Location = new System.Drawing.Point(181, 31);
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Size = new System.Drawing.Size(90, 21);
            this.rdTenSach.TabIndex = 1;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên Sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            // 
            // rdMaSach
            // 
            this.rdMaSach.AutoSize = true;
            this.rdMaSach.Location = new System.Drawing.Point(45, 31);
            this.rdMaSach.Name = "rdMaSach";
            this.rdMaSach.Size = new System.Drawing.Size(84, 21);
            this.rdMaSach.TabIndex = 0;
            this.rdMaSach.TabStop = true;
            this.rdMaSach.Text = "Mã Sách";
            this.rdMaSach.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(305, 132);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(206, 49);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(550, 132);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(206, 49);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Danh Sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(9, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1057, 143);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Sách";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbLinhVuc);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(541, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(453, 31);
            this.panel6.TabIndex = 5;
            // 
            // txbLinhVuc
            // 
            this.txbLinhVuc.Location = new System.Drawing.Point(156, 4);
            this.txbLinhVuc.Name = "txbLinhVuc";
            this.txbLinhVuc.Size = new System.Drawing.Size(294, 22);
            this.txbLinhVuc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lĩnh Vực:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbNamXB);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(541, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 31);
            this.panel5.TabIndex = 4;
            // 
            // txbNamXB
            // 
            this.txbNamXB.Location = new System.Drawing.Point(156, 4);
            this.txbNamXB.Name = "txbNamXB";
            this.txbNamXB.Size = new System.Drawing.Size(294, 22);
            this.txbNamXB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm XB:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tcbNhaXB);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(541, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 31);
            this.panel4.TabIndex = 3;
            // 
            // tcbNhaXB
            // 
            this.tcbNhaXB.Location = new System.Drawing.Point(156, 4);
            this.tcbNhaXB.Name = "tcbNhaXB";
            this.tcbNhaXB.Size = new System.Drawing.Size(294, 22);
            this.tcbNhaXB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà XB:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTacGia);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(49, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 31);
            this.panel3.TabIndex = 2;
            // 
            // txbTacGia
            // 
            this.txbTacGia.Location = new System.Drawing.Point(156, 4);
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(294, 22);
            this.txbTacGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác Giả:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTenSach);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(49, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 31);
            this.panel2.TabIndex = 1;
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(156, 4);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(294, 22);
            this.txbTenSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 31);
            this.panel1.TabIndex = 0;
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(156, 4);
            this.txbMa.Name = "txbMa";
            this.txbMa.ReadOnly = true;
            this.txbMa.Size = new System.Drawing.Size(294, 22);
            this.txbMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(319, 336);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 51);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(468, 336);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(112, 51);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(617, 336);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 51);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSach);
            this.groupBox5.Location = new System.Drawing.Point(9, 393);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1057, 291);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(4, 22);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1047, 263);
            this.dgvSach.TabIndex = 0;
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 687);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyDocGia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTenTG;
        private System.Windows.Forms.RadioButton rdTenSach;
        private System.Windows.Forms.RadioButton rdMaSach;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbNamXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tcbNhaXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbLinhVuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}