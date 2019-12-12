namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucQLKhachHang
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
            System.Windows.Forms.Label maKHLabel1;
            System.Windows.Forms.Label tenKHLabel1;
            System.Windows.Forms.Label diaChiLabel1;
            System.Windows.Forms.Label dienThoaiLabel1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.gridViewKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maKHTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tenKHTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.diaChiTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dienThoaiTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.kHACHHANGTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            maKHLabel1 = new System.Windows.Forms.Label();
            tenKHLabel1 = new System.Windows.Forms.Label();
            diaChiLabel1 = new System.Windows.Forms.Label();
            dienThoaiLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit1.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maKHLabel1
            // 
            maKHLabel1.AutoSize = true;
            maKHLabel1.Location = new System.Drawing.Point(101, 78);
            maKHLabel1.Name = "maKHLabel1";
            maKHLabel1.Size = new System.Drawing.Size(54, 17);
            maKHLabel1.TabIndex = 4;
            maKHLabel1.Text = "Ma KH:";
            // 
            // tenKHLabel1
            // 
            tenKHLabel1.AutoSize = true;
            tenKHLabel1.Location = new System.Drawing.Point(101, 128);
            tenKHLabel1.Name = "tenKHLabel1";
            tenKHLabel1.Size = new System.Drawing.Size(60, 17);
            tenKHLabel1.TabIndex = 6;
            tenKHLabel1.Text = "Ten KH:";
            // 
            // diaChiLabel1
            // 
            diaChiLabel1.AutoSize = true;
            diaChiLabel1.Location = new System.Drawing.Point(91, 79);
            diaChiLabel1.Name = "diaChiLabel1";
            diaChiLabel1.Size = new System.Drawing.Size(57, 17);
            diaChiLabel1.TabIndex = 8;
            diaChiLabel1.Text = "Dia Chi:";
            // 
            // dienThoaiLabel1
            // 
            dienThoaiLabel1.AutoSize = true;
            dienThoaiLabel1.Location = new System.Drawing.Point(91, 128);
            dienThoaiLabel1.Name = "dienThoaiLabel1";
            dienThoaiLabel1.Size = new System.Drawing.Size(81, 17);
            dienThoaiLabel1.TabIndex = 10;
            dienThoaiLabel1.Text = "Dien Thoai:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1304, 766);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 614);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1298, 150);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Blue;
            this.btn_cancel.Location = new System.Drawing.Point(921, 60);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_update.Location = new System.Drawing.Point(346, 60);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(248, 55);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Blue;
            this.btn_save.Location = new System.Drawing.Point(633, 60);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(248, 55);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1298, 379);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHACHHANGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 23);
            this.gridControl1.MainView = this.gridViewKH;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1292, 354);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKH});
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewKH
            // 
            this.gridViewKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colDiaChi,
            this.colDienThoai});
            this.gridViewKH.GridControl = this.gridControl1;
            this.gridViewKH.Name = "gridViewKH";
            this.gridViewKH.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            // 
            // colTenKH
            // 
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(maKHLabel1);
            this.groupBox3.Controls.Add(this.maKHTextEdit1);
            this.groupBox3.Controls.Add(tenKHLabel1);
            this.groupBox3.Controls.Add(this.tenKHTextEdit1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 385);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(646, 225);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            // 
            // maKHTextEdit1
            // 
            this.maKHTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "MaKH", true));
            this.maKHTextEdit1.Location = new System.Drawing.Point(188, 74);
            this.maKHTextEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maKHTextEdit1.Name = "maKHTextEdit1";
            this.maKHTextEdit1.Size = new System.Drawing.Size(249, 22);
            this.maKHTextEdit1.TabIndex = 5;
            // 
            // tenKHTextEdit1
            // 
            this.tenKHTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "TenKH", true));
            this.tenKHTextEdit1.Location = new System.Drawing.Point(188, 126);
            this.tenKHTextEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenKHTextEdit1.Name = "tenKHTextEdit1";
            this.tenKHTextEdit1.Size = new System.Drawing.Size(249, 22);
            this.tenKHTextEdit1.TabIndex = 7;
            this.tenKHTextEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenKHTextEdit1_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(diaChiLabel1);
            this.groupBox4.Controls.Add(this.diaChiTextEdit1);
            this.groupBox4.Controls.Add(this.dienThoaiTextEdit1);
            this.groupBox4.Controls.Add(dienThoaiLabel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(655, 385);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(646, 225);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // diaChiTextEdit1
            // 
            this.diaChiTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "DiaChi", true));
            this.diaChiTextEdit1.Location = new System.Drawing.Point(177, 74);
            this.diaChiTextEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiTextEdit1.Name = "diaChiTextEdit1";
            this.diaChiTextEdit1.Size = new System.Drawing.Size(249, 22);
            this.diaChiTextEdit1.TabIndex = 9;
            // 
            // dienThoaiTextEdit1
            // 
            this.dienThoaiTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "DienThoai", true));
            this.dienThoaiTextEdit1.Location = new System.Drawing.Point(177, 126);
            this.dienThoaiTextEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dienThoaiTextEdit1.Name = "dienThoaiTextEdit1";
            this.dienThoaiTextEdit1.Size = new System.Drawing.Size(249, 22);
            this.dienThoaiTextEdit1.TabIndex = 11;
            this.dienThoaiTextEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dienThoaiTextEdit1_KeyPress);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.LINHKIENTableAdapter = null;
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
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(1304, 766);
            this.Load += new System.EventHandler(this.ucQLKhachHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKHTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKHTextEdit1.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKH;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private QLLinhKienMayTinhTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit maKHTextEdit1;
        private DevExpress.XtraEditors.TextEdit tenKHTextEdit1;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit1;
        private DevExpress.XtraEditors.TextEdit dienThoaiTextEdit1;
    }
}
