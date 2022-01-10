
namespace ThiNetFramework
{
    partial class frmSanPham
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.btnsua = new System.Windows.Forms.ToolStripButton();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn mã loại:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 36);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanPhamBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnxoa,
            this.btnsua,
            this.btnthem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1215, 41);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(177, 36);
            this.toolStripLabel1.Text = "Danh sách sản phẩm";
            // 
            // btnxoa
            // 
            this.btnxoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnxoa.Image = global::ThiNetFramework.Properties.Resources.xoa;
            this.btnxoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 36);
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
            this.btnsua.Size = new System.Drawing.Size(78, 36);
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
            this.btnthem.Size = new System.Drawing.Size(92, 36);
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(27, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 402);
            this.panel1.TabIndex = 5;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 150;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 150;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.Width = 551;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(ThiNetFramework.DAL.SanPham);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(468, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1278, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton btnsua;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}