namespace QuanLyBangDia
{
    partial class frmTra1KH
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
            this.lvThue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTraHet = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lvThue.Location = new System.Drawing.Point(0, 106);
            this.lvThue.MultiSelect = false;
            this.lvThue.Name = "lvThue";
            this.lvThue.Size = new System.Drawing.Size(690, 322);
            this.lvThue.TabIndex = 115;
            this.lvThue.UseCompatibleStateImageBehavior = false;
            this.lvThue.View = System.Windows.Forms.View.Details;
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày thuê";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 110;
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
            // btnTraHet
            // 
            this.btnTraHet.BackColor = System.Drawing.Color.White;
            this.btnTraHet.Location = new System.Drawing.Point(232, 22);
            this.btnTraHet.Name = "btnTraHet";
            this.btnTraHet.Size = new System.Drawing.Size(85, 45);
            this.btnTraHet.TabIndex = 117;
            this.btnTraHet.Text = "Trả hết";
            this.btnTraHet.UseVisualStyleBackColor = false;
            this.btnTraHet.Click += new System.EventHandler(this.btnTraHet_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.White;
            this.btnTra.Location = new System.Drawing.Point(350, 22);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(85, 45);
            this.btnTra.TabIndex = 118;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // frmTra1KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(690, 428);
            this.Controls.Add(this.btnTraHet);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.lvThue);
            this.Name = "frmTra1KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTra1KH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnTraHet;
        private System.Windows.Forms.Button btnTra;
    }
}