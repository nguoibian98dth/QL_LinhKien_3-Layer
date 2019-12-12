namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucNCC
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
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label tenNCCLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label soTaiKhoanLabel;
            System.Windows.Forms.Label ngayDangKyLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.gb_Suppliers = new System.Windows.Forms.GroupBox();
            this.maNCCLabel2 = new System.Windows.Forms.Label();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.tenNCCTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gb_Supplier = new System.Windows.Forms.GroupBox();
            this.gc_NCC = new DevExpress.XtraGrid.GridControl();
            this.gv_NCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngayDangKyDateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.soTaiKhoanTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dienThoaiTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.nHACUNGCAPTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NHACUNGCAPTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            maNCCLabel = new System.Windows.Forms.Label();
            tenNCCLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            soTaiKhoanLabel = new System.Windows.Forms.Label();
            ngayDangKyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNCCTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit1.Properties)).BeginInit();
            this.gb_Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NCC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDangKyDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDangKyDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTaiKhoanTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Font = new System.Drawing.Font("Tahoma", 7.8F);
            maNCCLabel.Location = new System.Drawing.Point(34, 60);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(61, 17);
            maNCCLabel.TabIndex = 0;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // tenNCCLabel
            // 
            tenNCCLabel.AutoSize = true;
            tenNCCLabel.Font = new System.Drawing.Font("Tahoma", 7.8F);
            tenNCCLabel.Location = new System.Drawing.Point(34, 116);
            tenNCCLabel.Name = "tenNCCLabel";
            tenNCCLabel.Size = new System.Drawing.Size(67, 17);
            tenNCCLabel.TabIndex = 2;
            tenNCCLabel.Text = "Ten NCC:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Tahoma", 7.8F);
            diaChiLabel.Location = new System.Drawing.Point(34, 177);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(55, 17);
            diaChiLabel.TabIndex = 4;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(38, 66);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(77, 17);
            dienThoaiLabel.TabIndex = 6;
            dienThoaiLabel.Text = "Dien Thoai:";
            // 
            // soTaiKhoanLabel
            // 
            soTaiKhoanLabel.AutoSize = true;
            soTaiKhoanLabel.Location = new System.Drawing.Point(38, 123);
            soTaiKhoanLabel.Name = "soTaiKhoanLabel";
            soTaiKhoanLabel.Size = new System.Drawing.Size(93, 17);
            soTaiKhoanLabel.TabIndex = 8;
            soTaiKhoanLabel.Text = "So Tai Khoan:";
            // 
            // ngayDangKyLabel
            // 
            ngayDangKyLabel.AutoSize = true;
            ngayDangKyLabel.Location = new System.Drawing.Point(38, 180);
            ngayDangKyLabel.Name = "ngayDangKyLabel";
            ngayDangKyLabel.Size = new System.Drawing.Size(102, 17);
            ngayDangKyLabel.TabIndex = 10;
            ngayDangKyLabel.Text = "Ngay Dang Ky:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_Suppliers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_Supplier, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1339, 775);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 621);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1333, 152);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Blue;
            this.btn_add.Location = new System.Drawing.Point(188, 60);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(248, 55);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Blue;
            this.btn_cancel.Location = new System.Drawing.Point(1009, 60);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(248, 55);
            this.btn_cancel.TabIndex = 47;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(456, 60);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(248, 55);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Blue;
            this.btn_delete.Location = new System.Drawing.Point(732, 60);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(248, 55);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // gb_Suppliers
            // 
            this.gb_Suppliers.Controls.Add(this.maNCCLabel2);
            this.gb_Suppliers.Controls.Add(this.tenNCCTextEdit1);
            this.gb_Suppliers.Controls.Add(this.diaChiTextEdit1);
            this.gb_Suppliers.Controls.Add(maNCCLabel);
            this.gb_Suppliers.Controls.Add(tenNCCLabel);
            this.gb_Suppliers.Controls.Add(diaChiLabel);
            this.gb_Suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Suppliers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Suppliers.Location = new System.Drawing.Point(3, 391);
            this.gb_Suppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Suppliers.Name = "gb_Suppliers";
            this.gb_Suppliers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Suppliers.Size = new System.Drawing.Size(663, 224);
            this.gb_Suppliers.TabIndex = 38;
            this.gb_Suppliers.TabStop = false;
            // 
            // maNCCLabel2
            // 
            this.maNCCLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "MaNCC", true));
            this.maNCCLabel2.ForeColor = System.Drawing.Color.Red;
            this.maNCCLabel2.Location = new System.Drawing.Point(154, 54);
            this.maNCCLabel2.Name = "maNCCLabel2";
            this.maNCCLabel2.Size = new System.Drawing.Size(132, 23);
            this.maNCCLabel2.TabIndex = 7;
            this.maNCCLabel2.Text = "label1";
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenNCCTextEdit1
            // 
            this.tenNCCTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "TenNCC", true));
            this.tenNCCTextEdit1.Location = new System.Drawing.Point(158, 113);
            this.tenNCCTextEdit1.Name = "tenNCCTextEdit1";
            this.tenNCCTextEdit1.Size = new System.Drawing.Size(278, 22);
            this.tenNCCTextEdit1.TabIndex = 9;
            this.tenNCCTextEdit1.TextChanged += new System.EventHandler(this.tenNCCTextEdit_TextChanged);
            // 
            // diaChiTextEdit1
            // 
            this.diaChiTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "DiaChi", true));
            this.diaChiTextEdit1.Location = new System.Drawing.Point(158, 175);
            this.diaChiTextEdit1.Name = "diaChiTextEdit1";
            this.diaChiTextEdit1.Size = new System.Drawing.Size(278, 22);
            this.diaChiTextEdit1.TabIndex = 11;
            // 
            // gb_Supplier
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gb_Supplier, 2);
            this.gb_Supplier.Controls.Add(this.gc_NCC);
            this.gb_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gb_Supplier.Location = new System.Drawing.Point(3, 4);
            this.gb_Supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Supplier.Name = "gb_Supplier";
            this.gb_Supplier.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Supplier.Size = new System.Drawing.Size(1333, 379);
            this.gb_Supplier.TabIndex = 37;
            this.gb_Supplier.TabStop = false;
            this.gb_Supplier.Text = "Danh sách nhà cung cấp";
            // 
            // gc_NCC
            // 
            this.gc_NCC.DataSource = this.nHACUNGCAPBindingSource;
            this.gc_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NCC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_NCC.Location = new System.Drawing.Point(3, 25);
            this.gc_NCC.MainView = this.gv_NCC;
            this.gc_NCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_NCC.Name = "gc_NCC";
            this.gc_NCC.Size = new System.Drawing.Size(1327, 350);
            this.gc_NCC.TabIndex = 1;
            this.gc_NCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NCC});
            // 
            // gv_NCC
            // 
            this.gv_NCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colDiaChi,
            this.colDienThoai,
            this.colSoTaiKhoan,
            this.colNgayDangKy});
            this.gv_NCC.GridControl = this.gc_NCC;
            this.gv_NCC.Name = "gv_NCC";
            this.gv_NCC.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 0;
            // 
            // colTenNCC
            // 
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            // 
            // colSoTaiKhoan
            // 
            this.colSoTaiKhoan.FieldName = "SoTaiKhoan";
            this.colSoTaiKhoan.Name = "colSoTaiKhoan";
            this.colSoTaiKhoan.Visible = true;
            this.colSoTaiKhoan.VisibleIndex = 4;
            // 
            // colNgayDangKy
            // 
            this.colNgayDangKy.FieldName = "NgayDangKy";
            this.colNgayDangKy.Name = "colNgayDangKy";
            this.colNgayDangKy.Visible = true;
            this.colNgayDangKy.VisibleIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(soTaiKhoanLabel);
            this.groupBox2.Controls.Add(ngayDangKyLabel);
            this.groupBox2.Controls.Add(dienThoaiLabel);
            this.groupBox2.Controls.Add(this.ngayDangKyDateEdit1);
            this.groupBox2.Controls.Add(this.soTaiKhoanTextEdit1);
            this.groupBox2.Controls.Add(this.dienThoaiTextEdit1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(672, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(664, 228);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // ngayDangKyDateEdit1
            // 
            this.ngayDangKyDateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "NgayDangKy", true));
            this.ngayDangKyDateEdit1.EditValue = null;
            this.ngayDangKyDateEdit1.Location = new System.Drawing.Point(181, 177);
            this.ngayDangKyDateEdit1.Name = "ngayDangKyDateEdit1";
            this.ngayDangKyDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDangKyDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDangKyDateEdit1.Size = new System.Drawing.Size(246, 22);
            this.ngayDangKyDateEdit1.TabIndex = 17;
            // 
            // soTaiKhoanTextEdit1
            // 
            this.soTaiKhoanTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "SoTaiKhoan", true));
            this.soTaiKhoanTextEdit1.Location = new System.Drawing.Point(181, 115);
            this.soTaiKhoanTextEdit1.Name = "soTaiKhoanTextEdit1";
            this.soTaiKhoanTextEdit1.Size = new System.Drawing.Size(246, 22);
            this.soTaiKhoanTextEdit1.TabIndex = 15;
            this.soTaiKhoanTextEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dienThoaiTextEdit_KeyPress);
            // 
            // dienThoaiTextEdit1
            // 
            this.dienThoaiTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "DienThoai", true));
            this.dienThoaiTextEdit1.Location = new System.Drawing.Point(181, 63);
            this.dienThoaiTextEdit1.Name = "dienThoaiTextEdit1";
            this.dienThoaiTextEdit1.Size = new System.Drawing.Size(246, 22);
            this.dienThoaiTextEdit1.TabIndex = 13;
            this.dienThoaiTextEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dienThoaiTextEdit_KeyPress);
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.dsHDM_TTisTrueTableAdapter = null;
            this.tableAdapterManager.GIA_LKTableAdapter = null;
            this.tableAdapterManager.HOADON_BANHANGTableAdapter = null;
            this.tableAdapterManager.HOADON_MUAHANGTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LINHKIENTableAdapter = null;
            this.tableAdapterManager.LOAI_LKTableAdapter = null;
            this.tableAdapterManager.ND_NND1TableAdapter = null;
            this.tableAdapterManager.ND_NNDTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = this.nHACUNGCAPTableAdapter;
            this.tableAdapterManager.NHANVIEN_dkTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ucNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucNCC";
            this.Size = new System.Drawing.Size(1339, 775);
            this.Load += new System.EventHandler(this.ucNCC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb_Suppliers.ResumeLayout(false);
            this.gb_Suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNCCTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit1.Properties)).EndInit();
            this.gb_Supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NCC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDangKyDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDangKyDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTaiKhoanTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_Supplier;
        private System.Windows.Forms.GroupBox gb_Suppliers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private DevExpress.XtraGrid.GridControl gc_NCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDangKy;
        private System.Windows.Forms.Label maNCCLabel2;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private DevExpress.XtraEditors.TextEdit tenNCCTextEdit1;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit1;
        private DevExpress.XtraEditors.TextEdit dienThoaiTextEdit1;
        private DevExpress.XtraEditors.TextEdit soTaiKhoanTextEdit1;
        private DevExpress.XtraEditors.DateEdit ngayDangKyDateEdit1;
        private QLLinhKienMayTinhTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;



    }
}
