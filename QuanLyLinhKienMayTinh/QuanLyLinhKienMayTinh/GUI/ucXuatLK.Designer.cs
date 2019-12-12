namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucXuatLK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_inforPN = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayXuatKho = new System.Windows.Forms.Label();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.gb_dsachban = new System.Windows.Forms.GroupBox();
            this.lbx_DanhSachHDB = new System.Windows.Forms.ListBox();
            this.gbx_ThongTin = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUXUATTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.PHIEUXUATTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.cT_PHIEUXUATTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.CT_PHIEUXUATTableAdapter();
            this.cT_PHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_inforPN.SuspendLayout();
            this.gb_dsachban.SuspendLayout();
            this.gbx_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHIEUXUATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.73F));
            this.tableLayoutPanel1.Controls.Add(this.gb_inforPN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_dsachban, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbx_ThongTin, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gb_inforPN
            // 
            this.gb_inforPN.Controls.Add(this.label6);
            this.gb_inforPN.Controls.Add(this.lblMaKH);
            this.gb_inforPN.Controls.Add(this.label4);
            this.gb_inforPN.Controls.Add(this.btn_export);
            this.gb_inforPN.Controls.Add(this.lblMaNV);
            this.gb_inforPN.Controls.Add(this.lblNgayXuatKho);
            this.gb_inforPN.Controls.Add(this.lbl_ngaynhap);
            this.gb_inforPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_inforPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gb_inforPN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gb_inforPN.Location = new System.Drawing.Point(5, 363);
            this.gb_inforPN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gb_inforPN.Name = "gb_inforPN";
            this.gb_inforPN.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gb_inforPN.Size = new System.Drawing.Size(306, 355);
            this.gb_inforPN.TabIndex = 111;
            this.gb_inforPN.TabStop = false;
            this.gb_inforPN.Text = "Thông tin phiếu xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMaKH.ForeColor = System.Drawing.Color.Indigo;
            this.lblMaKH.Location = new System.Drawing.Point(116, 143);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(254, 27);
            this.lblMaKH.TabIndex = 38;
            this.lblMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nhân viên ";
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.Blue;
            this.btn_export.Location = new System.Drawing.Point(18, 184);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(260, 42);
            this.btn_export.TabIndex = 23;
            this.btn_export.Text = "Xuất kho";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMaNV.ForeColor = System.Drawing.Color.Indigo;
            this.lblMaNV.Location = new System.Drawing.Point(116, 85);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(195, 27);
            this.lblMaNV.TabIndex = 35;
            this.lblMaNV.Text = "...";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgayXuatKho
            // 
            this.lblNgayXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNgayXuatKho.ForeColor = System.Drawing.Color.Indigo;
            this.lblNgayXuatKho.Location = new System.Drawing.Point(116, 28);
            this.lblNgayXuatKho.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayXuatKho.Name = "lblNgayXuatKho";
            this.lblNgayXuatKho.Size = new System.Drawing.Size(195, 27);
            this.lblNgayXuatKho.TabIndex = 34;
            this.lblNgayXuatKho.Text = "...";
            this.lblNgayXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ngaynhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ngaynhap.Location = new System.Drawing.Point(15, 32);
            this.lbl_ngaynhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(61, 15);
            this.lbl_ngaynhap.TabIndex = 36;
            this.lbl_ngaynhap.Text = "Ngày xuất";
            // 
            // gb_dsachban
            // 
            this.gb_dsachban.Controls.Add(this.lbx_DanhSachHDB);
            this.gb_dsachban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dsachban.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb_dsachban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gb_dsachban.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gb_dsachban.Location = new System.Drawing.Point(5, 3);
            this.gb_dsachban.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gb_dsachban.Name = "gb_dsachban";
            this.gb_dsachban.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gb_dsachban.Size = new System.Drawing.Size(306, 354);
            this.gb_dsachban.TabIndex = 109;
            this.gb_dsachban.TabStop = false;
            this.gb_dsachban.Text = "Danh sách HĐ bán sản phẩm";
            // 
            // lbx_DanhSachHDB
            // 
            this.lbx_DanhSachHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_DanhSachHDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_DanhSachHDB.FormattingEnabled = true;
            this.lbx_DanhSachHDB.ItemHeight = 19;
            this.lbx_DanhSachHDB.Location = new System.Drawing.Point(5, 20);
            this.lbx_DanhSachHDB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbx_DanhSachHDB.Name = "lbx_DanhSachHDB";
            this.lbx_DanhSachHDB.Size = new System.Drawing.Size(296, 331);
            this.lbx_DanhSachHDB.TabIndex = 0;
            this.lbx_DanhSachHDB.Click += new System.EventHandler(this.lbx_DanhSachHDB_Click);
            this.lbx_DanhSachHDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbx_DanhSachHDB_MouseClick);
            this.lbx_DanhSachHDB.SelectedValueChanged += new System.EventHandler(this.lbx_DanhSachHDB_SelectedValueChanged);
            // 
            // gbx_ThongTin
            // 
            this.gbx_ThongTin.Controls.Add(this.dgvChiTiet);
            this.gbx_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbx_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbx_ThongTin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbx_ThongTin.Location = new System.Drawing.Point(321, 3);
            this.gbx_ThongTin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbx_ThongTin.Name = "gbx_ThongTin";
            this.gbx_ThongTin.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tableLayoutPanel1.SetRowSpan(this.gbx_ThongTin, 2);
            this.gbx_ThongTin.Size = new System.Drawing.Size(834, 715);
            this.gbx_ThongTin.TabIndex = 112;
            this.gbx_ThongTin.TabStop = false;
            this.gbx_ThongTin.Text = "Chi Tiết Linh Kiện Cần Xuất";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9});
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(5, 20);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(824, 692);
            this.dgvChiTiet.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLK";
            this.Column1.HeaderText = "Ma LK";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLK";
            this.Column2.HeaderText = "Ten LK";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoai";
            this.Column3.HeaderText = "Loai LK";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NhaSX";
            this.Column4.HeaderText = "Nha SX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoLuong";
            this.Column9.HeaderText = "So Luong";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUXUATBindingSource
            // 
            this.pHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
            this.pHIEUXUATBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // pHIEUXUATTableAdapter
            // 
            this.pHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCAPTableAdapter = null;
            this.tableAdapterManager.ct_hdb_sttIsTrueTableAdapter = null;
            this.tableAdapterManager.CT_HOADONBANTableAdapter = null;
            this.tableAdapterManager.CT_HOADONMUATableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUXUATTableAdapter = this.cT_PHIEUXUATTableAdapter;
            this.tableAdapterManager.dsHDB_sttIsTrueTableAdapter = null;
            this.tableAdapterManager.GIA_LKTableAdapter = null;
            this.tableAdapterManager.HOADON_BANHANGTableAdapter = null;
            this.tableAdapterManager.HOADON_MUAHANGTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LINHKIENTableAdapter = null;
            this.tableAdapterManager.ND_NND1TableAdapter = null;
            this.tableAdapterManager.ND_NNDTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIEN_dkTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = this.pHIEUXUATTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_PHIEUXUATTableAdapter
            // 
            this.cT_PHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // cT_PHIEUXUATBindingSource
            // 
            this.cT_PHIEUXUATBindingSource.DataMember = "CT_PHIEUXUAT";
            this.cT_PHIEUXUATBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // ucXuatLK
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucXuatLK";
            this.Size = new System.Drawing.Size(1160, 721);
            this.Load += new System.EventHandler(this.ucXuatLK_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_inforPN.ResumeLayout(false);
            this.gb_inforPN.PerformLayout();
            this.gb_dsachban.ResumeLayout(false);
            this.gbx_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHIEUXUATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_dsachban;
        private System.Windows.Forms.ListBox lbx_DanhSachHDB;
        private System.Windows.Forms.GroupBox gb_inforPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayXuatKho;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.GroupBox gbx_ThongTin;
        private System.Windows.Forms.Timer timer1;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
        private QLLinhKienMayTinhTableAdapters.PHIEUXUATTableAdapter pHIEUXUATTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private QLLinhKienMayTinhTableAdapters.CT_PHIEUXUATTableAdapter cT_PHIEUXUATTableAdapter;
        private System.Windows.Forms.BindingSource cT_PHIEUXUATBindingSource;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
