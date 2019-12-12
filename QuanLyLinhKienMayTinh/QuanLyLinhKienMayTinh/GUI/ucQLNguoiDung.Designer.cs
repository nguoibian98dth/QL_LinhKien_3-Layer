namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucQLNguoiDung
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tinhTrangCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.taiKhoanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.nGUOIDUNGTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTextEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 751);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simpleButton2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(478, 528);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 220);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(124, 132);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(227, 46);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Lưu thay đổi";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tinhTrangCheckEdit);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.taiKhoanTextEdit);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tinhTrangCheckEdit
            // 
            this.tinhTrangCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "TinhTrang", true));
            this.tinhTrangCheckEdit.Enabled = false;
            this.tinhTrangCheckEdit.Location = new System.Drawing.Point(217, 151);
            this.tinhTrangCheckEdit.Name = "tinhTrangCheckEdit";
            this.tinhTrangCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tinhTrangCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.tinhTrangCheckEdit.Properties.Caption = "Có";
            this.tinhTrangCheckEdit.Size = new System.Drawing.Size(100, 25);
            this.tinhTrangCheckEdit.TabIndex = 12;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(93, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Đang hoạt động";
            // 
            // taiKhoanTextEdit
            // 
            this.taiKhoanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "TaiKhoan", true));
            this.taiKhoanTextEdit.Enabled = false;
            this.taiKhoanTextEdit.Location = new System.Drawing.Point(217, 76);
            this.taiKhoanTextEdit.Name = "taiKhoanTextEdit";
            this.taiKhoanTextEdit.Size = new System.Drawing.Size(240, 22);
            this.taiKhoanTextEdit.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tài khoản";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.nGUOIDUNGGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // nGUOIDUNGGridControl
            // 
            this.nGUOIDUNGGridControl.DataSource = this.nGUOIDUNGBindingSource;
            this.nGUOIDUNGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGUOIDUNGGridControl.Location = new System.Drawing.Point(3, 24);
            this.nGUOIDUNGGridControl.MainView = this.gridViewNguoiDung;
            this.nGUOIDUNGGridControl.Name = "nGUOIDUNGGridControl";
            this.nGUOIDUNGGridControl.Size = new System.Drawing.Size(1177, 492);
            this.nGUOIDUNGGridControl.TabIndex = 0;
            this.nGUOIDUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguoiDung});
            // 
            // gridViewNguoiDung
            // 
            this.gridViewNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaiKhoan,
            this.colTinhTrang});
            this.gridViewNguoiDung.GridControl = this.nGUOIDUNGGridControl;
            this.gridViewNguoiDung.Name = "gridViewNguoiDung";
            this.gridViewNguoiDung.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.FieldName = "TaiKhoan";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.OptionsColumn.AllowEdit = false;
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 0;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.FieldName = "TinhTrang";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(953, 528);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(83, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(227, 46);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Reset password";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIEN_dkTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ucQLNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQLNguoiDung";
            this.Size = new System.Drawing.Size(1189, 751);
            this.Load += new System.EventHandler(this.ucQLNguoiDung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTextEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit tinhTrangCheckEdit;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private DevExpress.XtraEditors.TextEdit taiKhoanTextEdit;
        private QLLinhKienMayTinhTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl nGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
    }
}
