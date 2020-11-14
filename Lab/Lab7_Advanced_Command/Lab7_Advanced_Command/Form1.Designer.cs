namespace Lab7_Advanced_Command
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblbcatname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn món ăn";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(201, 7);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(217, 24);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoodList.Location = new System.Drawing.Point(17, 43);
            this.dgvFoodList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.Size = new System.Drawing.Size(868, 395);
            this.dgvFoodList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantityToolStripMenuItem,
            this.tsmSeperatorToolStripMenuItem,
            this.tsmAddFoodToolStripMenuItem,
            this.tsmUpdateFoodToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 100);
            // 
            // tsmCalculateQuantityToolStripMenuItem
            // 
            this.tsmCalculateQuantityToolStripMenuItem.Name = "tsmCalculateQuantityToolStripMenuItem";
            this.tsmCalculateQuantityToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.tsmCalculateQuantityToolStripMenuItem.Text = "tsmCalculateQuantity";
            this.tsmCalculateQuantityToolStripMenuItem.Click += new System.EventHandler(this.tsmCalculateQuantityToolStripMenuItem_Click);
            // 
            // tsmSeperatorToolStripMenuItem
            // 
            this.tsmSeperatorToolStripMenuItem.Name = "tsmSeperatorToolStripMenuItem";
            this.tsmSeperatorToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.tsmSeperatorToolStripMenuItem.Text = "tsmSeperator";
            // 
            // tsmAddFoodToolStripMenuItem
            // 
            this.tsmAddFoodToolStripMenuItem.Name = "tsmAddFoodToolStripMenuItem";
            this.tsmAddFoodToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.tsmAddFoodToolStripMenuItem.Text = "tsmAddFood";
            this.tsmAddFoodToolStripMenuItem.Click += new System.EventHandler(this.tsmAddFoodToolStripMenuItem_Click);
            // 
            // tsmUpdateFoodToolStripMenuItem
            // 
            this.tsmUpdateFoodToolStripMenuItem.Name = "tsmUpdateFoodToolStripMenuItem";
            this.tsmUpdateFoodToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.tsmUpdateFoodToolStripMenuItem.Text = "tsmUpdateFood";
            this.tsmUpdateFoodToolStripMenuItem.Click += new System.EventHandler(this.tsmUpdateFoodToolStripMenuItem_Click);
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(44, 459);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(96, 17);
            this.lblquantity.TabIndex = 3;
            this.lblquantity.Text = "Có tất cả:    ...";
            // 
            // lblbcatname
            // 
            this.lblbcatname.AutoSize = true;
            this.lblbcatname.Location = new System.Drawing.Point(197, 459);
            this.lblbcatname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbcatname.Name = "lblbcatname";
            this.lblbcatname.Size = new System.Drawing.Size(161, 17);
            this.lblbcatname.TabIndex = 4;
            this.lblbcatname.Text = "Món ăn thuộc nhóm:   ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm Kiếm Theo Tên";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(719, 7);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(166, 22);
            this.txtSearchByName.TabIndex = 6;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 486);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblbcatname);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblbcatname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSeperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFoodToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchByName;
    }
}

