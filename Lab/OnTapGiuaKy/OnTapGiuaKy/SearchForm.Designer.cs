namespace OnTapGiuaKy
{
    partial class SearchForm
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
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdLop = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(167, 35);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(91, 21);
            this.rdTen.TabIndex = 9;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Theo Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdLop
            // 
            this.rdLop.AutoSize = true;
            this.rdLop.Location = new System.Drawing.Point(306, 35);
            this.rdLop.Name = "rdLop";
            this.rdLop.Size = new System.Drawing.Size(90, 21);
            this.rdLop.TabIndex = 8;
            this.rdLop.TabStop = true;
            this.rdLop.Text = "Theo Lớp";
            this.rdLop.UseVisualStyleBackColor = true;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(38, 35);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(85, 21);
            this.rdMa.TabIndex = 7;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Theo Mã";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(82, 62);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(263, 22);
            this.txbTim.TabIndex = 5;
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(109, 102);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 34);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancel.Location = new System.Drawing.Point(230, 102);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 34);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 148);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.rdTen);
            this.Controls.Add(this.rdLop);
            this.Controls.Add(this.rdMa);
            this.Controls.Add(this.txbTim);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdLop;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}