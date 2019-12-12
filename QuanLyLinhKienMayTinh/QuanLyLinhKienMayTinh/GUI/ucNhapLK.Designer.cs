namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucNhapLK
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
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayNhapKho = new System.Windows.Forms.Label();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.gb_ctlknhap = new System.Windows.Forms.GroupBox();
            this.gc_CTHDM = new DevExpress.XtraGrid.GridControl();
            this.gv_CThoadonmua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_dsHoaDonMua = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.PHIEUNHAPTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.cT_PHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHIEUNHAPTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.CT_PHIEUNHAPTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_inforPN.SuspendLayout();
            this.gb_ctlknhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CThoadonmua)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.gb_inforPN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_ctlknhap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 987);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gb_inforPN
            // 
            this.gb_inforPN.Controls.Add(this.label6);
            this.gb_inforPN.Controls.Add(this.lblNhaCC);
            this.gb_inforPN.Controls.Add(this.label4);
            this.gb_inforPN.Controls.Add(this.btn_import);
            this.gb_inforPN.Controls.Add(this.lblNhanVien);
            this.gb_inforPN.Controls.Add(this.lblNgayNhapKho);
            this.gb_inforPN.Controls.Add(this.lbl_ngaynhap);
            this.gb_inforPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_inforPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gb_inforPN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gb_inforPN.Location = new System.Drawing.Point(4, 487);
            this.gb_inforPN.Margin = new System.Windows.Forms.Padding(4);
            this.gb_inforPN.Name = "gb_inforPN";
            this.gb_inforPN.Padding = new System.Windows.Forms.Padding(4);
            this.gb_inforPN.Size = new System.Drawing.Size(317, 475);
            this.gb_inforPN.TabIndex = 112;
            this.gb_inforPN.TabStop = false;
            this.gb_inforPN.Text = "Thông tin phiếu nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nhà Cung Cấp:";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNhaCC.ForeColor = System.Drawing.Color.Indigo;
            this.lblNhaCC.Location = new System.Drawing.Point(130, 172);
            this.lblNhaCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(171, 29);
            this.lblNhaCC.TabIndex = 38;
            this.lblNhaCC.Text = "Nhà CC";
            this.lblNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nhân viên:";
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.Blue;
            this.btn_import.Location = new System.Drawing.Point(8, 215);
            this.btn_import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(292, 51);
            this.btn_import.TabIndex = 23;
            this.btn_import.Text = "Nhập kho";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNhanVien.ForeColor = System.Drawing.Color.Indigo;
            this.lblNhanVien.Location = new System.Drawing.Point(130, 102);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(171, 29);
            this.lblNhanVien.TabIndex = 35;
            this.lblNhanVien.Text = "Nhân viên";
            this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgayNhapKho
            // 
            this.lblNgayNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNgayNhapKho.ForeColor = System.Drawing.Color.Indigo;
            this.lblNgayNhapKho.Location = new System.Drawing.Point(130, 34);
            this.lblNgayNhapKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhapKho.Name = "lblNgayNhapKho";
            this.lblNgayNhapKho.Size = new System.Drawing.Size(171, 29);
            this.lblNgayNhapKho.TabIndex = 34;
            this.lblNgayNhapKho.Text = "Ngày nhập";
            this.lblNgayNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ngaynhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ngaynhap.Location = new System.Drawing.Point(17, 39);
            this.lbl_ngaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(69, 15);
            this.lbl_ngaynhap.TabIndex = 36;
            this.lbl_ngaynhap.Text = "Ngày nhập:";
            // 
            // gb_ctlknhap
            // 
            this.gb_ctlknhap.Controls.Add(this.gc_CTHDM);
            this.gb_ctlknhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_ctlknhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb_ctlknhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gb_ctlknhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gb_ctlknhap.Location = new System.Drawing.Point(329, 4);
            this.gb_ctlknhap.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ctlknhap.Name = "gb_ctlknhap";
            this.gb_ctlknhap.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.SetRowSpan(this.gb_ctlknhap, 2);
            this.gb_ctlknhap.Size = new System.Drawing.Size(861, 958);
            this.gb_ctlknhap.TabIndex = 109;
            this.gb_ctlknhap.TabStop = false;
            this.gb_ctlknhap.Text = "Chi tiết linh kiện cần nhập";
            // 
            // gc_CTHDM
            // 
            this.gc_CTHDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CTHDM.Location = new System.Drawing.Point(4, 21);
            this.gc_CTHDM.MainView = this.gv_CThoadonmua;
            this.gc_CTHDM.Name = "gc_CTHDM";
            this.gc_CTHDM.Size = new System.Drawing.Size(853, 933);
            this.gc_CTHDM.TabIndex = 0;
            this.gc_CTHDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CThoadonmua});
            // 
            // gv_CThoadonmua
            // 
            this.gv_CThoadonmua.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLK,
            this.colTenLK,
            this.colLoaiLK,
            this.colNhaSX,
            this.colSoLuong});
            this.gv_CThoadonmua.GridControl = this.gc_CTHDM;
            this.gv_CThoadonmua.Name = "gv_CThoadonmua";
            this.gv_CThoadonmua.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaLK
            // 
            this.colMaLK.Caption = "Mã LK";
            this.colMaLK.FieldName = "MaLK";
            this.colMaLK.Name = "colMaLK";
            this.colMaLK.Visible = true;
            this.colMaLK.VisibleIndex = 0;
            // 
            // colTenLK
            // 
            this.colTenLK.Caption = "Tên LK";
            this.colTenLK.FieldName = "TenLK";
            this.colTenLK.Name = "colTenLK";
            this.colTenLK.Visible = true;
            this.colTenLK.VisibleIndex = 1;
            // 
            // colLoaiLK
            // 
            this.colLoaiLK.Caption = "Loại LK";
            this.colLoaiLK.FieldName = "LoaiLK";
            this.colLoaiLK.Name = "colLoaiLK";
            this.colLoaiLK.Visible = true;
            this.colLoaiLK.VisibleIndex = 2;
            // 
            // colNhaSX
            // 
            this.colNhaSX.Caption = "Nhà SX";
            this.colNhaSX.FieldName = "NhaSX";
            this.colNhaSX.Name = "colNhaSX";
            this.colNhaSX.Visible = true;
            this.colNhaSX.VisibleIndex = 3;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_dsHoaDonMua);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(317, 475);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách HĐ mua linh kiện";
            // 
            // lbx_dsHoaDonMua
            // 
            this.lbx_dsHoaDonMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_dsHoaDonMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_dsHoaDonMua.FormattingEnabled = true;
            this.lbx_dsHoaDonMua.ItemHeight = 19;
            this.lbx_dsHoaDonMua.Location = new System.Drawing.Point(4, 21);
            this.lbx_dsHoaDonMua.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_dsHoaDonMua.Name = "lbx_dsHoaDonMua";
            this.lbx_dsHoaDonMua.Size = new System.Drawing.Size(309, 450);
            this.lbx_dsHoaDonMua.TabIndex = 0;
            this.lbx_dsHoaDonMua.Click += new System.EventHandler(this.lbx_dsHoaDonMua_Click);
            this.lbx_dsHoaDonMua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbx_dsHoaDonMua_MouseClick);
            this.lbx_dsHoaDonMua.SelectedValueChanged += new System.EventHandler(this.lbx_dsHoaDonMua_SelectedValueChanged);
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
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCAPTableAdapter = null;
            this.tableAdapterManager.ct_hdb_sttIsTrueTableAdapter = null;
            this.tableAdapterManager.CT_HOADONBANTableAdapter = null;
            this.tableAdapterManager.CT_HOADONMUATableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUXUATTableAdapter = null;
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
            this.tableAdapterManager.PHIEUNHAPTableAdapter = this.pHIEUNHAPTableAdapter;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_PHIEUNHAPBindingSource
            // 
            this.cT_PHIEUNHAPBindingSource.DataMember = "CT_PHIEUNHAP";
            this.cT_PHIEUNHAPBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // cT_PHIEUNHAPTableAdapter
            // 
            this.cT_PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // ucNhapLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "ucNhapLK";
            this.Size = new System.Drawing.Size(1194, 987);
            this.Load += new System.EventHandler(this.ucNhapLK_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_inforPN.ResumeLayout(false);
            this.gb_inforPN.PerformLayout();
            this.gb_ctlknhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CThoadonmua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_ctlknhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_dsHoaDonMua;
        private System.Windows.Forms.GroupBox gb_inforPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayNhapKho;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl gc_CTHDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CThoadonmua;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLK;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLK;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiLK;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private QLLinhKienMayTinhTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cT_PHIEUNHAPBindingSource;
        private QLLinhKienMayTinhTableAdapters.CT_PHIEUNHAPTableAdapter cT_PHIEUNHAPTableAdapter;

    }
}
