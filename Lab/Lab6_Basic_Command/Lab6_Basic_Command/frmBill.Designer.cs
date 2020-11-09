namespace Lab6_Basic_Command
{
    partial class frmBill
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
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.CustomFormat = "dd//MM/yyyy";
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFrom.Location = new System.Drawing.Point(196, 15);
            this.dtpkFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(195, 22);
            this.dtpkFrom.TabIndex = 0;
            this.dtpkFrom.ValueChanged += new System.EventHandler(this.dtpkFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DS Bill từ";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(17, 63);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.Size = new System.Drawing.Size(900, 369);
            this.dgvBill.TabIndex = 2;
            // 
            // dtpkTo
            // 
            this.dtpkTo.CustomFormat = "dd//MM/yyyy";
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTo.Location = new System.Drawing.Point(446, 15);
            this.dtpkTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(195, 22);
            this.dtpkTo.TabIndex = 3;
            this.dtpkTo.ValueChanged += new System.EventHandler(this.dtpkTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpkTo);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkFrom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.Label label2;
    }
}