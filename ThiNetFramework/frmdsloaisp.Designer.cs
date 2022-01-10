
namespace ThiNetFramework
{
    partial class frmdsloaisp
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnxoa,
            this.btnsua,
            this.btnthem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(225, 36);
            this.toolStripLabel1.Text = "danh sách loại sản phẩm";
            // 
            // btnxoa
            // 
            this.btnxoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoa.Image = global::ThiNetFramework.Properties.Resources.xoa;
            this.btnxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(82, 36);
            this.btnxoa.Text = "Xoá";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnsua.Image = global::ThiNetFramework.Properties.Resources.sua;
            this.btnsua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 36);
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthem.Image = global::ThiNetFramework.Properties.Resources.them;
            this.btnthem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(96, 36);
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(25, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 377);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loaiSanPhamBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(905, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataSource = typeof(ThiNetFramework.DAL.LoaiSanPham);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(236, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH LOẠI SẢN PHẨM";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLoaiDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            this.tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmdsloaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmdsloaisp";
            this.Text = "frmdsloaisp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
    }
}