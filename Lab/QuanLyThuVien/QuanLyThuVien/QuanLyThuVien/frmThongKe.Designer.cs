namespace QuanLyThuVien
{
    partial class frmThongKe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNgayTra = new System.Windows.Forms.RadioButton();
            this.rdNgayMuon = new System.Windows.Forms.RadioButton();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 44);
            this.label3.TabIndex = 22;
            this.label3.Text = "Danh sách phiếu mượn ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNgayTra);
            this.groupBox1.Controls.Add(this.rdNgayMuon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 51);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdNgayTra
            // 
            this.rdNgayTra.AutoSize = true;
            this.rdNgayTra.Location = new System.Drawing.Point(133, 18);
            this.rdNgayTra.Name = "rdNgayTra";
            this.rdNgayTra.Size = new System.Drawing.Size(93, 24);
            this.rdNgayTra.TabIndex = 3;
            this.rdNgayTra.TabStop = true;
            this.rdNgayTra.Text = "Ngày trả";
            this.rdNgayTra.UseVisualStyleBackColor = true;
            // 
            // rdNgayMuon
            // 
            this.rdNgayMuon.AutoSize = true;
            this.rdNgayMuon.Location = new System.Drawing.Point(13, 18);
            this.rdNgayMuon.Name = "rdNgayMuon";
            this.rdNgayMuon.Size = new System.Drawing.Size(114, 24);
            this.rdNgayMuon.TabIndex = 2;
            this.rdNgayMuon.TabStop = true;
            this.rdNgayMuon.Text = "Ngày mượn";
            this.rdNgayMuon.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(563, 113);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(224, 27);
            this.dtpToDate.TabIndex = 55;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(128, 113);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(224, 27);
            this.dtpFromDate.TabIndex = 54;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 20;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Location = new System.Drawing.Point(400, 100);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(114, 50);
            this.btnThongKe.TabIndex = 57;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 606);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNgayTra;
        private System.Windows.Forms.RadioButton rdNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
    }
}