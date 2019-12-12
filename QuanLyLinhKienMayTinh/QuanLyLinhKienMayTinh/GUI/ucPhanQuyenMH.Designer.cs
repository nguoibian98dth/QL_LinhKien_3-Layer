namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucPhanQuyenMH
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNhomND = new System.Windows.Forms.TextBox();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControlPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.test1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlNhomND = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nHOMNGUOIDUNGTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.test1TableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.test1TableAdapter();
            this.pHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANQUYENTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.PHANQUYENTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPQ)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 543F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 543);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNhomND);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(355, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 537);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtMaNhomND
            // 
            this.txtMaNhomND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOMNGUOIDUNGBindingSource, "ID", true));
            this.txtMaNhomND.Location = new System.Drawing.Point(32, 80);
            this.txtMaNhomND.Name = "txtMaNhomND";
            this.txtMaNhomND.Size = new System.Drawing.Size(100, 28);
            this.txtMaNhomND.TabIndex = 2;
            this.txtMaNhomND.TextChanged += new System.EventHandler(this.txtMaNhomND_TextChanged);
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 64);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControlPhanQuyen);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(531, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 537);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách màn hình Hệ thống";
            // 
            // gridControlPhanQuyen
            // 
            this.gridControlPhanQuyen.DataSource = this.test1BindingSource;
            this.gridControlPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhanQuyen.Location = new System.Drawing.Point(3, 19);
            this.gridControlPhanQuyen.MainView = this.gridViewPQ;
            this.gridControlPhanQuyen.Name = "gridControlPhanQuyen";
            this.gridControlPhanQuyen.Size = new System.Drawing.Size(340, 515);
            this.gridControlPhanQuyen.TabIndex = 6;
            this.gridControlPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPQ});
            // 
            // test1BindingSource
            // 
            this.test1BindingSource.DataMember = "test1";
            this.test1BindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // gridViewPQ
            // 
            this.gridViewPQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaManHinh,
            this.colTenManHinh,
            this.colCoQuyen});
            this.gridViewPQ.GridControl = this.gridControlPhanQuyen;
            this.gridViewPQ.Name = "gridViewPQ";
            this.gridViewPQ.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaManHinh
            // 
            this.colMaManHinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMaManHinh.AppearanceCell.Options.UseFont = true;
            this.colMaManHinh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaManHinh.AppearanceHeader.Options.UseFont = true;
            this.colMaManHinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaManHinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaManHinh.Caption = "Mã màn hình";
            this.colMaManHinh.FieldName = "MaManHinh";
            this.colMaManHinh.Name = "colMaManHinh";
            this.colMaManHinh.OptionsColumn.AllowEdit = false;
            this.colMaManHinh.OptionsColumn.ReadOnly = true;
            this.colMaManHinh.Visible = true;
            this.colMaManHinh.VisibleIndex = 0;
            // 
            // colTenManHinh
            // 
            this.colTenManHinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenManHinh.AppearanceCell.Options.UseFont = true;
            this.colTenManHinh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenManHinh.AppearanceHeader.Options.UseFont = true;
            this.colTenManHinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenManHinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenManHinh.Caption = "Tên màn hình";
            this.colTenManHinh.FieldName = "TenManHinh";
            this.colTenManHinh.Name = "colTenManHinh";
            this.colTenManHinh.OptionsColumn.AllowEdit = false;
            this.colTenManHinh.OptionsColumn.ReadOnly = true;
            this.colTenManHinh.Visible = true;
            this.colTenManHinh.VisibleIndex = 1;
            // 
            // colCoQuyen
            // 
            this.colCoQuyen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colCoQuyen.AppearanceCell.Options.UseFont = true;
            this.colCoQuyen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCoQuyen.AppearanceHeader.Options.UseFont = true;
            this.colCoQuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.colCoQuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCoQuyen.Caption = "Có quyền";
            this.colCoQuyen.FieldName = "CoQuyen";
            this.colCoQuyen.Name = "colCoQuyen";
            this.colCoQuyen.Visible = true;
            this.colCoQuyen.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlNhomND);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 537);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm ND";
            // 
            // gridControlNhomND
            // 
            this.gridControlNhomND.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.gridControlNhomND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhomND.Location = new System.Drawing.Point(3, 19);
            this.gridControlNhomND.MainView = this.gridViewNhom;
            this.gridControlNhomND.Name = "gridControlNhomND";
            this.gridControlNhomND.Size = new System.Drawing.Size(340, 515);
            this.gridControlNhomND.TabIndex = 5;
            this.gridControlNhomND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhom});
            // 
            // gridViewNhom
            // 
            this.gridViewNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhom,
            this.colTenNhom});
            this.gridViewNhom.GridControl = this.gridControlNhomND;
            this.gridViewNhom.Name = "gridViewNhom";
            this.gridViewNhom.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // MaNhom
            // 
            this.MaNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaNhom.AppearanceCell.Options.UseFont = true;
            this.MaNhom.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.MaNhom.AppearanceHeader.Options.UseFont = true;
            this.MaNhom.AppearanceHeader.Options.UseTextOptions = true;
            this.MaNhom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaNhom.Caption = "Mã nhóm";
            this.MaNhom.FieldName = "ID";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.ReadOnly = true;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 0;
            // 
            // colTenNhom
            // 
            this.colTenNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTenNhom.AppearanceCell.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenNhom.AppearanceHeader.Options.UseFont = true;
            this.colTenNhom.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenNhom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenNhom.Caption = "Tên nhóm";
            this.colTenNhom.FieldName = "TenGoi";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 1;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIEN_dkTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // test1TableAdapter
            // 
            this.test1TableAdapter.ClearBeforeFill = true;
            // 
            // pHANQUYENBindingSource
            // 
            this.pHANQUYENBindingSource.DataMember = "PHANQUYEN";
            this.pHANQUYENBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // pHANQUYENTableAdapter
            // 
            this.pHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // ucPhanQuyenMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPhanQuyenMH";
            this.Size = new System.Drawing.Size(880, 543);
            this.Load += new System.EventHandler(this.ucPhanQuyenMH_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPQ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControlPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPQ;
        private DevExpress.XtraGrid.Columns.GridColumn colMaManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colCoQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlNhomND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhom;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaNhomND;
        private System.Windows.Forms.BindingSource test1BindingSource;
        private QLLinhKienMayTinhTableAdapters.test1TableAdapter test1TableAdapter;
        private System.Windows.Forms.BindingSource pHANQUYENBindingSource;
        private QLLinhKienMayTinhTableAdapters.PHANQUYENTableAdapter pHANQUYENTableAdapter;
    }
}
