namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucBaoCaoNH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBaoCaoNH));
            this.gv_chitietphieunhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_CTPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_chitiet = new DevExpress.XtraGrid.GridControl();
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.gc_chitietphieunhap = new System.Windows.Forms.GroupBox();
            this.gv_linhkiennhapnhieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_linhkiennhapnhieu = new DevExpress.XtraGrid.GridControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gv_solandat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_solandat = new DevExpress.XtraGrid.GridControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_bangtong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_bangtong = new DevExpress.XtraGrid.GridControl();
            this.dsHDM_TTisTrueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxdoanhthuadmin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxdoanhthutong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pdf = new System.Windows.Forms.Label();
            this.lbl_Excel = new System.Windows.Forms.Label();
            this.dsHDM_TTisTrueTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.dsHDM_TTisTrueTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.ct_hdmisTrueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_hdmisTrueTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.ct_hdmisTrueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chitietphieunhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            this.gc_chitietphieunhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_linhkiennhapnhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_linhkiennhapnhieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_solandat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_solandat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bangtong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bangtong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHDM_TTisTrueBindingSource)).BeginInit();
            this.gbxdoanhthuadmin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxdoanhthutong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_hdmisTrueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_chitietphieunhap
            // 
            this.gv_chitietphieunhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_CTPN,
            this.colMaPhieuNhap,
            this.colMaLK,
            this.colSoLuong,
            this.colGhiChu});
            this.gv_chitietphieunhap.GridControl = this.gc_chitiet;
            this.gv_chitietphieunhap.Name = "gv_chitietphieunhap";
            this.gv_chitietphieunhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMa_CTPN
            // 
            this.colMa_CTPN.FieldName = "Ma_CTPN";
            this.colMa_CTPN.Name = "colMa_CTPN";
            this.colMa_CTPN.Visible = true;
            this.colMa_CTPN.VisibleIndex = 0;
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.FieldName = "MaPhieuNhap";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.Visible = true;
            this.colMaPhieuNhap.VisibleIndex = 1;
            // 
            // colMaLK
            // 
            this.colMaLK.FieldName = "MaLK";
            this.colMaLK.Name = "colMaLK";
            this.colMaLK.Visible = true;
            this.colMaLK.VisibleIndex = 2;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            // 
            // gc_chitiet
            // 
            this.gc_chitiet.DataSource = this.ct_hdmisTrueBindingSource;
            this.gc_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_chitiet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_chitiet.Location = new System.Drawing.Point(2, 19);
            this.gc_chitiet.MainView = this.gv_chitietphieunhap;
            this.gc_chitiet.Margin = new System.Windows.Forms.Padding(2);
            this.gc_chitiet.Name = "gc_chitiet";
            this.gc_chitiet.Size = new System.Drawing.Size(257, 173);
            this.gc_chitiet.TabIndex = 0;
            this.gc_chitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_chitietphieunhap});
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gc_chitietphieunhap
            // 
            this.gc_chitietphieunhap.Controls.Add(this.gc_chitiet);
            this.gc_chitietphieunhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_chitietphieunhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_chitietphieunhap.ForeColor = System.Drawing.Color.Blue;
            this.gc_chitietphieunhap.Location = new System.Drawing.Point(619, 404);
            this.gc_chitietphieunhap.Margin = new System.Windows.Forms.Padding(2);
            this.gc_chitietphieunhap.Name = "gc_chitietphieunhap";
            this.gc_chitietphieunhap.Padding = new System.Windows.Forms.Padding(2);
            this.gc_chitietphieunhap.Size = new System.Drawing.Size(261, 194);
            this.gc_chitietphieunhap.TabIndex = 15;
            this.gc_chitietphieunhap.TabStop = false;
            this.gc_chitietphieunhap.Text = "Chi tiết phiếu nhập";
            // 
            // gv_linhkiennhapnhieu
            // 
            this.gv_linhkiennhapnhieu.GridControl = this.gc_linhkiennhapnhieu;
            this.gv_linhkiennhapnhieu.Name = "gv_linhkiennhapnhieu";
            this.gv_linhkiennhapnhieu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gc_linhkiennhapnhieu
            // 
            this.gc_linhkiennhapnhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_linhkiennhapnhieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_linhkiennhapnhieu.Location = new System.Drawing.Point(2, 19);
            this.gc_linhkiennhapnhieu.MainView = this.gv_linhkiennhapnhieu;
            this.gc_linhkiennhapnhieu.Margin = new System.Windows.Forms.Padding(2);
            this.gc_linhkiennhapnhieu.Name = "gc_linhkiennhapnhieu";
            this.gc_linhkiennhapnhieu.Size = new System.Drawing.Size(257, 179);
            this.gc_linhkiennhapnhieu.TabIndex = 0;
            this.gc_linhkiennhapnhieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_linhkiennhapnhieu});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gc_linhkiennhapnhieu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(619, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(261, 200);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Linh kiện nhập nhiều";
            // 
            // gv_solandat
            // 
            this.gv_solandat.GridControl = this.gc_solandat;
            this.gv_solandat.Name = "gv_solandat";
            this.gv_solandat.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gc_solandat
            // 
            this.gc_solandat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_solandat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_solandat.Location = new System.Drawing.Point(2, 19);
            this.gc_solandat.MainView = this.gv_solandat;
            this.gc_solandat.Margin = new System.Windows.Forms.Padding(2);
            this.gc_solandat.Name = "gc_solandat";
            this.gc_solandat.Size = new System.Drawing.Size(257, 173);
            this.gc_solandat.TabIndex = 0;
            this.gc_solandat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_solandat});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gc_solandat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(619, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(261, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lần đặt hàng NCC";
            // 
            // gv_bangtong
            // 
            this.gv_bangtong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colNgayMua,
            this.colMaNCC,
            this.colMaNV,
            this.colTongTien,
            this.colTinhTrang});
            this.gv_bangtong.GridControl = this.gc_bangtong;
            this.gv_bangtong.Name = "gv_bangtong";
            this.gv_bangtong.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaHD
            // 
            this.colMaHD.Caption = "Mã HĐ";
            this.colMaHD.FieldName = "MaHD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            // 
            // colNgayMua
            // 
            this.colNgayMua.Caption = "Ngày Mua";
            this.colNgayMua.FieldName = "NgayMua";
            this.colNgayMua.Name = "colNgayMua";
            this.colNgayMua.Visible = true;
            this.colNgayMua.VisibleIndex = 1;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã NCC";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 2;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã NV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Caption = "Tình Trạng";
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 5;
            // 
            // gc_bangtong
            // 
            this.gc_bangtong.DataSource = this.dsHDM_TTisTrueBindingSource;
            this.gc_bangtong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bangtong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_bangtong.Location = new System.Drawing.Point(2, 19);
            this.gc_bangtong.MainView = this.gv_bangtong;
            this.gc_bangtong.Margin = new System.Windows.Forms.Padding(2);
            this.gc_bangtong.Name = "gc_bangtong";
            this.gc_bangtong.Size = new System.Drawing.Size(609, 377);
            this.gc_bangtong.TabIndex = 0;
            this.gc_bangtong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bangtong});
            this.gc_bangtong.Click += new System.EventHandler(this.gc_bangtong_Click);
            // 
            // dsHDM_TTisTrueBindingSource
            // 
            this.dsHDM_TTisTrueBindingSource.DataMember = "dsHDM_TTisTrue";
            this.dsHDM_TTisTrueBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // gbxdoanhthuadmin
            // 
            this.gbxdoanhthuadmin.Controls.Add(this.gc_bangtong);
            this.gbxdoanhthuadmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxdoanhthuadmin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdoanhthuadmin.ForeColor = System.Drawing.Color.Blue;
            this.gbxdoanhthuadmin.Location = new System.Drawing.Point(2, 200);
            this.gbxdoanhthuadmin.Margin = new System.Windows.Forms.Padding(2);
            this.gbxdoanhthuadmin.Name = "gbxdoanhthuadmin";
            this.gbxdoanhthuadmin.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.SetRowSpan(this.gbxdoanhthuadmin, 2);
            this.gbxdoanhthuadmin.Size = new System.Drawing.Size(613, 398);
            this.gbxdoanhthuadmin.TabIndex = 9;
            this.gbxdoanhthuadmin.TabStop = false;
            this.gbxdoanhthuadmin.Text = "Bảng tổng nhập hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.gc_chitietphieunhap, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbxdoanhthutong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxdoanhthuadmin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbxdoanhthutong
            // 
            this.gbxdoanhthutong.Controls.Add(this.label1);
            this.gbxdoanhthutong.Controls.Add(this.lbl_Pdf);
            this.gbxdoanhthutong.Controls.Add(this.lbl_Excel);
            this.gbxdoanhthutong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxdoanhthutong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdoanhthutong.ForeColor = System.Drawing.Color.Blue;
            this.gbxdoanhthutong.Location = new System.Drawing.Point(2, 2);
            this.gbxdoanhthutong.Margin = new System.Windows.Forms.Padding(2);
            this.gbxdoanhthutong.Name = "gbxdoanhthutong";
            this.gbxdoanhthutong.Padding = new System.Windows.Forms.Padding(2);
            this.gbxdoanhthutong.Size = new System.Drawing.Size(613, 194);
            this.gbxdoanhthutong.TabIndex = 8;
            this.gbxdoanhthutong.TabStop = false;
            this.gbxdoanhthutong.Text = "Thống Kê Tổng Nhập hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 122;
            this.label1.Text = "Export Báo cáo bằng";
            // 
            // lbl_Pdf
            // 
            this.lbl_Pdf.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Pdf.Image")));
            this.lbl_Pdf.Location = new System.Drawing.Point(429, 70);
            this.lbl_Pdf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pdf.Name = "lbl_Pdf";
            this.lbl_Pdf.Size = new System.Drawing.Size(65, 55);
            this.lbl_Pdf.TabIndex = 120;
            this.lbl_Pdf.Click += new System.EventHandler(this.lbl_Pdf_Click);
            // 
            // lbl_Excel
            // 
            this.lbl_Excel.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Excel.Image")));
            this.lbl_Excel.Location = new System.Drawing.Point(341, 70);
            this.lbl_Excel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Excel.Name = "lbl_Excel";
            this.lbl_Excel.Size = new System.Drawing.Size(65, 55);
            this.lbl_Excel.TabIndex = 121;
            this.lbl_Excel.Click += new System.EventHandler(this.lbl_Excel_Click);
            // 
            // dsHDM_TTisTrueTableAdapter
            // 
            this.dsHDM_TTisTrueTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.dsHDM_TTisTrueTableAdapter = this.dsHDM_TTisTrueTableAdapter;
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
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ct_hdmisTrueBindingSource
            // 
            this.ct_hdmisTrueBindingSource.DataMember = "ct_hdmisTrue";
            this.ct_hdmisTrueBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // ct_hdmisTrueTableAdapter
            // 
            this.ct_hdmisTrueTableAdapter.ClearBeforeFill = true;
            // 
            // ucBaoCaoNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucBaoCaoNH";
            this.Size = new System.Drawing.Size(882, 600);
            this.Load += new System.EventHandler(this.ucBaoCaoNH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_chitietphieunhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            this.gc_chitietphieunhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_linhkiennhapnhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_linhkiennhapnhieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_solandat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_solandat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_bangtong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bangtong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHDM_TTisTrueBindingSource)).EndInit();
            this.gbxdoanhthuadmin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxdoanhthutong.ResumeLayout(false);
            this.gbxdoanhthutong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_hdmisTrueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gv_chitietphieunhap;
        private DevExpress.XtraGrid.GridControl gc_chitiet;
        private System.Windows.Forms.GroupBox gc_chitietphieunhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_linhkiennhapnhieu;
        private DevExpress.XtraGrid.GridControl gc_linhkiennhapnhieu;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_solandat;
        private DevExpress.XtraGrid.GridControl gc_solandat;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bangtong;
        private DevExpress.XtraGrid.GridControl gc_bangtong;
        private System.Windows.Forms.GroupBox gbxdoanhthuadmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxdoanhthutong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Pdf;
        private System.Windows.Forms.Label lbl_Excel;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMua;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private System.Windows.Forms.BindingSource dsHDM_TTisTrueBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private QLLinhKienMayTinhTableAdapters.dsHDM_TTisTrueTableAdapter dsHDM_TTisTrueTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_CTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLK;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.BindingSource ct_hdmisTrueBindingSource;
        private QLLinhKienMayTinhTableAdapters.ct_hdmisTrueTableAdapter ct_hdmisTrueTableAdapter;
    }
}
