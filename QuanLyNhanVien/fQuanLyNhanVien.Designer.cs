namespace QuanLyNhanVien
{
    partial class fQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gBSapXep = new System.Windows.Forms.GroupBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.rBLuongThapDenCao = new System.Windows.Forms.RadioButton();
            this.rBLuongCaoDenThap = new System.Windows.Forms.RadioButton();
            this.rBMa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.rBLuongThapNhat = new System.Windows.Forms.RadioButton();
            this.rBLuongCaoNhat = new System.Windows.Forms.RadioButton();
            this.rBMaNV = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuTừFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.gBSapXep.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBTimKiem.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDSNhanVien);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 631);
            this.panel1.TabIndex = 2;
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.NgaySinh,
            this.QueQuan,
            this.LuongCoBan,
            this.HeSoLuong,
            this.Luong});
            this.dgvDSNhanVien.Location = new System.Drawing.Point(14, 341);
            this.dgvDSNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersWidth = 62;
            this.dgvDSNhanVien.RowTemplate.Height = 28;
            this.dgvDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(879, 280);
            this.dgvDSNhanVien.TabIndex = 4;
            this.dgvDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 8;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Width = 80;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.DataPropertyName = "LuongCoBan";
            this.LuongCoBan.HeaderText = "Lương Cơ Bản";
            this.LuongCoBan.MinimumWidth = 8;
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.Width = 80;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.MinimumWidth = 8;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Width = 50;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương Chính Thức";
            this.Luong.MinimumWidth = 8;
            this.Luong.Name = "Luong";
            this.Luong.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gBSapXep);
            this.panel4.Location = new System.Drawing.Point(517, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 201);
            this.panel4.TabIndex = 3;
            // 
            // gBSapXep
            // 
            this.gBSapXep.Controls.Add(this.btnSapXep);
            this.gBSapXep.Controls.Add(this.rBLuongThapDenCao);
            this.gBSapXep.Controls.Add(this.rBLuongCaoDenThap);
            this.gBSapXep.Controls.Add(this.rBMa);
            this.gBSapXep.Location = new System.Drawing.Point(9, 7);
            this.gBSapXep.Name = "gBSapXep";
            this.gBSapXep.Size = new System.Drawing.Size(361, 191);
            this.gBSapXep.TabIndex = 0;
            this.gBSapXep.TabStop = false;
            this.gBSapXep.Text = "Sắp Xếp";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(225, 134);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(118, 51);
            this.btnSapXep.TabIndex = 7;
            this.btnSapXep.Text = "Xác Nhận";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // rBLuongThapDenCao
            // 
            this.rBLuongThapDenCao.AutoSize = true;
            this.rBLuongThapDenCao.Location = new System.Drawing.Point(20, 122);
            this.rBLuongThapDenCao.Name = "rBLuongThapDenCao";
            this.rBLuongThapDenCao.Size = new System.Drawing.Size(186, 24);
            this.rBLuongThapDenCao.TabIndex = 6;
            this.rBLuongThapDenCao.TabStop = true;
            this.rBLuongThapDenCao.Text = "Lương Thấp Đến Cao";
            this.rBLuongThapDenCao.UseVisualStyleBackColor = true;
            // 
            // rBLuongCaoDenThap
            // 
            this.rBLuongCaoDenThap.AutoSize = true;
            this.rBLuongCaoDenThap.Location = new System.Drawing.Point(20, 79);
            this.rBLuongCaoDenThap.Name = "rBLuongCaoDenThap";
            this.rBLuongCaoDenThap.Size = new System.Drawing.Size(183, 24);
            this.rBLuongCaoDenThap.TabIndex = 5;
            this.rBLuongCaoDenThap.TabStop = true;
            this.rBLuongCaoDenThap.Text = "Lương Cao đến Thấp";
            this.rBLuongCaoDenThap.UseVisualStyleBackColor = true;
            // 
            // rBMa
            // 
            this.rBMa.AutoSize = true;
            this.rBMa.Location = new System.Drawing.Point(20, 37);
            this.rBMa.Name = "rBMa";
            this.rBMa.Size = new System.Drawing.Size(134, 24);
            this.rBMa.TabIndex = 4;
            this.rBMa.TabStop = true;
            this.rBMa.Text = "Mã Nhân Viên";
            this.rBMa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gBTimKiem);
            this.panel2.Location = new System.Drawing.Point(15, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 201);
            this.panel2.TabIndex = 2;
            // 
            // gBTimKiem
            // 
            this.gBTimKiem.Controls.Add(this.btnTim);
            this.gBTimKiem.Controls.Add(this.txtMaCanTim);
            this.gBTimKiem.Controls.Add(this.rBLuongThapNhat);
            this.gBTimKiem.Controls.Add(this.rBLuongCaoNhat);
            this.gBTimKiem.Controls.Add(this.rBMaNV);
            this.gBTimKiem.Location = new System.Drawing.Point(3, 7);
            this.gBTimKiem.Name = "gBTimKiem";
            this.gBTimKiem.Size = new System.Drawing.Size(489, 191);
            this.gBTimKiem.TabIndex = 0;
            this.gBTimKiem.TabStop = false;
            this.gBTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(353, 135);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(130, 50);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm ";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(200, 35);
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(117, 26);
            this.txtMaCanTim.TabIndex = 4;
            // 
            // rBLuongThapNhat
            // 
            this.rBLuongThapNhat.AutoSize = true;
            this.rBLuongThapNhat.Location = new System.Drawing.Point(31, 148);
            this.rBLuongThapNhat.Name = "rBLuongThapNhat";
            this.rBLuongThapNhat.Size = new System.Drawing.Size(157, 24);
            this.rBLuongThapNhat.TabIndex = 3;
            this.rBLuongThapNhat.Text = "Lương Thấp Nhất";
            this.rBLuongThapNhat.UseVisualStyleBackColor = true;
            // 
            // rBLuongCaoNhat
            // 
            this.rBLuongCaoNhat.AutoSize = true;
            this.rBLuongCaoNhat.Location = new System.Drawing.Point(31, 90);
            this.rBLuongCaoNhat.Name = "rBLuongCaoNhat";
            this.rBLuongCaoNhat.Size = new System.Drawing.Size(150, 24);
            this.rBLuongCaoNhat.TabIndex = 2;
            this.rBLuongCaoNhat.Text = "Lương Cao Nhất";
            this.rBLuongCaoNhat.UseVisualStyleBackColor = true;
            // 
            // rBMaNV
            // 
            this.rBMaNV.AutoSize = true;
            this.rBMaNV.Checked = true;
            this.rBMaNV.Location = new System.Drawing.Point(31, 37);
            this.rBMaNV.Name = "rBMaNV";
            this.rBMaNV.Size = new System.Drawing.Size(134, 24);
            this.rBMaNV.TabIndex = 0;
            this.rBMaNV.TabStop = true;
            this.rBMaNV.Text = "Mã Nhân Viên";
            this.rBMaNV.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.toolStripSeparator1,
            this.tsbReload,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = ((System.Drawing.Image)(resources.GetObject("tsbThem.Image")));
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(170, 29);
            this.tsbThem.Text = "Thêm Nhân Viên";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = ((System.Drawing.Image)(resources.GetObject("tsbSua.Image")));
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(156, 29);
            this.tsbSua.Text = "Sửa Nhân Viên";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(157, 29);
            this.tsbXoa.Text = "Xóa Nhân Viên";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbReload
            // 
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(148, 29);
            this.tsbReload.Text = "Tải lại dữ liệu ";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 34);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuTừFileToolStripMenuItem,
            this.xuấtFileToolStripMenuItem,
            this.xóaDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuTừFileToolStripMenuItem
            // 
            this.nhậpDữLiệuTừFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpDữLiệuTừFileToolStripMenuItem.Image")));
            this.nhậpDữLiệuTừFileToolStripMenuItem.Name = "nhậpDữLiệuTừFileToolStripMenuItem";
            this.nhậpDữLiệuTừFileToolStripMenuItem.Size = new System.Drawing.Size(216, 29);
            this.nhậpDữLiệuTừFileToolStripMenuItem.Text = "Nhập Dữ Liệu Từ File";
            this.nhậpDữLiệuTừFileToolStripMenuItem.Click += new System.EventHandler(this.nhậpDữLiệuTừFileToolStripMenuItem_Click_1);
            // 
            // xuấtFileToolStripMenuItem
            // 
            this.xuấtFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xuấtFileToolStripMenuItem.Image")));
            this.xuấtFileToolStripMenuItem.Name = "xuấtFileToolStripMenuItem";
            this.xuấtFileToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.xuấtFileToolStripMenuItem.Text = "Xuất File";
            this.xuấtFileToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileToolStripMenuItem_Click);
            // 
            // xóaDữLiệuToolStripMenuItem
            // 
            this.xóaDữLiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaDữLiệuToolStripMenuItem.Image")));
            this.xóaDữLiệuToolStripMenuItem.Name = "xóaDữLiệuToolStripMenuItem";
            this.xóaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.xóaDữLiệuToolStripMenuItem.Text = "Xóa Dữ Liệu ";
            this.xóaDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuToolStripMenuItem_Click);
            // 
            // fQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 631);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.fQuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.gBSapXep.ResumeLayout(false);
            this.gBSapXep.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gBTimKiem.ResumeLayout(false);
            this.gBTimKiem.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gBSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.RadioButton rBLuongThapDenCao;
        private System.Windows.Forms.RadioButton rBLuongCaoDenThap;
        private System.Windows.Forms.RadioButton rBMa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gBTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.RadioButton rBLuongThapNhat;
        private System.Windows.Forms.RadioButton rBLuongCaoNhat;
        private System.Windows.Forms.RadioButton rBMaNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuTừFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}

