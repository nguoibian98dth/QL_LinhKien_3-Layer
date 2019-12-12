namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class frmCapNhatGiaNhap
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
            System.Windows.Forms.Label lbl_gianhap;
            this.lINHKIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.lINHKIENTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.LINHKIENTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.cbx_NCC = new System.Windows.Forms.ComboBox();
            this.nHACUNGCAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHACUNGCAPTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NHACUNGCAPTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.giaNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gv_updateGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_updateGia = new DevExpress.XtraGrid.GridControl();
            this.btn_exit = new System.Windows.Forms.Button();
            lbl_gianhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_updateGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_updateGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_gianhap
            // 
            lbl_gianhap.AutoSize = true;
            lbl_gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_gianhap.Location = new System.Drawing.Point(553, 45);
            lbl_gianhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_gianhap.Name = "lbl_gianhap";
            lbl_gianhap.Size = new System.Drawing.Size(109, 25);
            lbl_gianhap.TabIndex = 13;
            lbl_gianhap.Text = "Giá Nhập:";
            // 
            // lINHKIENBindingSource
            // 
            this.lINHKIENBindingSource.DataMember = "LINHKIEN";
            this.lINHKIENBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINHKIENTableAdapter
            // 
            this.lINHKIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LINHKIENTableAdapter = this.lINHKIENTableAdapter;
            this.tableAdapterManager.LOAI_LKTableAdapter = null;
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
            // cbx_NCC
            // 
            this.cbx_NCC.DataSource = this.nHACUNGCAPBindingSource1;
            this.cbx_NCC.DisplayMember = "TenNCC";
            this.cbx_NCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NCC.FormattingEnabled = true;
            this.cbx_NCC.Location = new System.Drawing.Point(13, 38);
            this.cbx_NCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbx_NCC.Name = "cbx_NCC";
            this.cbx_NCC.Size = new System.Drawing.Size(208, 30);
            this.cbx_NCC.TabIndex = 9;
            this.cbx_NCC.ValueMember = "MaNCC";
            this.cbx_NCC.SelectedIndexChanged += new System.EventHandler(this.cbx_NCC_SelectedIndexChanged);
            // 
            // nHACUNGCAPBindingSource1
            // 
            this.nHACUNGCAPBindingSource1.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource1.DataSource = this.qLLinhKienMayTinh;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(833, 34);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 46);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // giaNhapTextEdit
            // 
            this.giaNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lINHKIENBindingSource, "GiaNhap", true));
            this.giaNhapTextEdit.Enabled = false;
            this.giaNhapTextEdit.Location = new System.Drawing.Point(680, 41);
            this.giaNhapTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.giaNhapTextEdit.Name = "giaNhapTextEdit";
            this.giaNhapTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaNhapTextEdit.Properties.Appearance.Options.UseFont = true;
            this.giaNhapTextEdit.Size = new System.Drawing.Size(133, 32);
            this.giaNhapTextEdit.TabIndex = 14;
            this.giaNhapTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giaNhapTextEdit_KeyPress);
            // 
            // gv_updateGia
            // 
            this.gv_updateGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLK,
            this.colTenLK,
            this.colLoaiLK,
            this.colNhaSX,
            this.colXuatXu,
            this.colNamSX,
            this.colMaNCC,
            this.colSOLUONG,
            this.colGiaNhap});
            this.gv_updateGia.GridControl = this.gc_updateGia;
            this.gv_updateGia.Name = "gv_updateGia";
            this.gv_updateGia.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // colXuatXu
            // 
            this.colXuatXu.Caption = "Xuất xứ";
            this.colXuatXu.FieldName = "XuatXu";
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.Visible = true;
            this.colXuatXu.VisibleIndex = 4;
            // 
            // colNamSX
            // 
            this.colNamSX.Caption = "Năm SX";
            this.colNamSX.FieldName = "NamSX";
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.Visible = true;
            this.colNamSX.VisibleIndex = 5;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã NCC";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 6;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 7;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.Caption = "Giá nhập";
            this.colGiaNhap.FieldName = "GiaNhap";
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.Visible = true;
            this.colGiaNhap.VisibleIndex = 8;
            // 
            // gc_updateGia
            // 
            this.gc_updateGia.DataSource = this.lINHKIENBindingSource;
            this.gc_updateGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_updateGia.Location = new System.Drawing.Point(3, 106);
            this.gc_updateGia.MainView = this.gv_updateGia;
            this.gc_updateGia.Margin = new System.Windows.Forms.Padding(4);
            this.gc_updateGia.Name = "gc_updateGia";
            this.gc_updateGia.Size = new System.Drawing.Size(936, 366);
            this.gc_updateGia.TabIndex = 0;
            this.gc_updateGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_updateGia});
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(716, 479);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(177, 39);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmCapNhatGiaNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(955, 530);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(lbl_gianhap);
            this.Controls.Add(this.giaNhapTextEdit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cbx_NCC);
            this.Controls.Add(this.gc_updateGia);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatGiaNhap";
            this.Text = "frmCapNhatGiaNhap";
            this.Load += new System.EventHandler(this.frmCapNhatGiaNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_updateGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_updateGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource lINHKIENBindingSource;
        private QLLinhKienMayTinhTableAdapters.LINHKIENTableAdapter lINHKIENTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbx_NCC;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private QLLinhKienMayTinhTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource1;
        private DevExpress.XtraEditors.TextEdit giaNhapTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_updateGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLK;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLK;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiLK;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSX;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaNhap;
        private DevExpress.XtraGrid.GridControl gc_updateGia;
        private System.Windows.Forms.Button btn_exit;
    }
}