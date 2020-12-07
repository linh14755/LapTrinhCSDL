namespace QuanLyThuVien
{
    partial class frmTraSach
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
            this.lvsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntrasach = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.txbtendg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.lvsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvsach.FullRowSelect = true;
            this.lvsach.GridLines = true;
            this.lvsach.HideSelection = false;
            this.lvsach.Location = new System.Drawing.Point(0, 121);
            this.lvsach.Name = "lvsach";
            this.lvsach.Size = new System.Drawing.Size(660, 217);
            this.lvsach.TabIndex = 31;
            this.lvsach.UseCompatibleStateImageBehavior = false;
            this.lvsach.View = System.Windows.Forms.View.Details;
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
            // btntrasach
            // 
            this.btntrasach.BorderRadius = 20;
            this.btntrasach.CheckedState.Parent = this.btntrasach;
            this.btntrasach.CustomImages.Parent = this.btntrasach;
            this.btntrasach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btntrasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrasach.ForeColor = System.Drawing.Color.White;
            this.btntrasach.HoverState.Parent = this.btntrasach;
            this.btntrasach.Location = new System.Drawing.Point(180, 49);
            this.btntrasach.Margin = new System.Windows.Forms.Padding(2);
            this.btntrasach.Name = "btntrasach";
            this.btntrasach.ShadowDecoration.Parent = this.btntrasach;
            this.btntrasach.Size = new System.Drawing.Size(114, 50);
            this.btntrasach.TabIndex = 49;
            this.btntrasach.Text = "Trả hết";
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
            this.btnHome.Location = new System.Drawing.Point(366, 49);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(114, 50);
            this.btnHome.TabIndex = 50;
            this.btnHome.Text = "Trả";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txbtendg
            // 
            this.txbtendg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbtendg.Location = new System.Drawing.Point(180, 13);
            this.txbtendg.Name = "txbtendg";
            this.txbtendg.Size = new System.Drawing.Size(300, 15);
            this.txbtendg.TabIndex = 51;
            this.txbtendg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 338);
            this.Controls.Add(this.txbtendg);
            this.Controls.Add(this.btntrasach);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lvsach);
            this.MaximizeBox = false;
            this.Name = "frmTraSach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private Guna.UI2.WinForms.Guna2Button btntrasach;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.TextBox txbtendg;
    }
}