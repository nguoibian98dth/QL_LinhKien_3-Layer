namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class frmLoaiLKcs
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
            System.Windows.Forms.Label maLoaiLabel;
            System.Windows.Forms.Label tenLoaiLabel;
            System.Windows.Forms.Label thangBHLabel;
            System.Windows.Forms.Label dVTLabel1;
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.lOAI_LKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAI_LKTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.LOAI_LKTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.lOAI_LKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maLoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenLoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.thangBHSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dVTComboBox = new System.Windows.Forms.ComboBox();
            maLoaiLabel = new System.Windows.Forms.Label();
            tenLoaiLabel = new System.Windows.Forms.Label();
            thangBHLabel = new System.Windows.Forms.Label();
            dVTLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_LKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_LKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangBHSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiLabel
            // 
            maLoaiLabel.AutoSize = true;
            maLoaiLabel.Location = new System.Drawing.Point(29, 42);
            maLoaiLabel.Name = "maLoaiLabel";
            maLoaiLabel.Size = new System.Drawing.Size(53, 17);
            maLoaiLabel.TabIndex = 1;
            maLoaiLabel.Text = "Mã loại:";
            // 
            // tenLoaiLabel
            // 
            tenLoaiLabel.AutoSize = true;
            tenLoaiLabel.Location = new System.Drawing.Point(29, 70);
            tenLoaiLabel.Name = "tenLoaiLabel";
            tenLoaiLabel.Size = new System.Drawing.Size(59, 17);
            tenLoaiLabel.TabIndex = 3;
            tenLoaiLabel.Text = "Tên loại:";
            // 
            // thangBHLabel
            // 
            thangBHLabel.AutoSize = true;
            thangBHLabel.Location = new System.Drawing.Point(457, 70);
            thangBHLabel.Name = "thangBHLabel";
            thangBHLabel.Size = new System.Drawing.Size(114, 17);
            thangBHLabel.TabIndex = 7;
            thangBHLabel.Text = "Tháng Bảo hành:";
            // 
            // dVTLabel1
            // 
            dVTLabel1.AutoSize = true;
            dVTLabel1.Location = new System.Drawing.Point(457, 38);
            dVTLabel1.Name = "dVTLabel1";
            dVTLabel1.Size = new System.Drawing.Size(80, 17);
            dVTLabel1.TabIndex = 13;
            dVTLabel1.Text = "Đơn vị tính:";
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAI_LKBindingSource
            // 
            this.lOAI_LKBindingSource.DataMember = "LOAI_LK";
            this.lOAI_LKBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // lOAI_LKTableAdapter
            // 
            this.lOAI_LKTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOAI_LKTableAdapter = this.lOAI_LKTableAdapter;
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
            // lOAI_LKGridControl
            // 
            this.lOAI_LKGridControl.DataSource = this.lOAI_LKBindingSource;
            this.lOAI_LKGridControl.Location = new System.Drawing.Point(32, 182);
            this.lOAI_LKGridControl.MainView = this.gridView1;
            this.lOAI_LKGridControl.Name = "lOAI_LKGridControl";
            this.lOAI_LKGridControl.Size = new System.Drawing.Size(731, 244);
            this.lOAI_LKGridControl.TabIndex = 1;
            this.lOAI_LKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.lOAI_LKGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // maLoaiTextEdit
            // 
            this.maLoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAI_LKBindingSource, "MaLoai", true));
            this.maLoaiTextEdit.Enabled = false;
            this.maLoaiTextEdit.Location = new System.Drawing.Point(108, 39);
            this.maLoaiTextEdit.Name = "maLoaiTextEdit";
            this.maLoaiTextEdit.Size = new System.Drawing.Size(191, 22);
            this.maLoaiTextEdit.TabIndex = 2;
            // 
            // tenLoaiTextEdit
            // 
            this.tenLoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAI_LKBindingSource, "TenLoai", true));
            this.tenLoaiTextEdit.Location = new System.Drawing.Point(108, 67);
            this.tenLoaiTextEdit.Name = "tenLoaiTextEdit";
            this.tenLoaiTextEdit.Size = new System.Drawing.Size(191, 22);
            this.tenLoaiTextEdit.TabIndex = 4;
            // 
            // thangBHSpinEdit
            // 
            this.thangBHSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAI_LKBindingSource, "ThangBH", true));
            this.thangBHSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.thangBHSpinEdit.Location = new System.Drawing.Point(572, 67);
            this.thangBHSpinEdit.Name = "thangBHSpinEdit";
            this.thangBHSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thangBHSpinEdit.Size = new System.Drawing.Size(191, 22);
            this.thangBHSpinEdit.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(32, 124);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 37);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(190, 124);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(133, 37);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(354, 124);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(133, 37);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(522, 124);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(133, 37);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dVTComboBox
            // 
            this.dVTComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAI_LKBindingSource, "DVT", true));
            this.dVTComboBox.FormattingEnabled = true;
            this.dVTComboBox.Items.AddRange(new object[] {
            "Cái",
            "Ổ",
            "Thùng",
            "Bịch",
            "Thanh"});
            this.dVTComboBox.Location = new System.Drawing.Point(572, 35);
            this.dVTComboBox.Name = "dVTComboBox";
            this.dVTComboBox.Size = new System.Drawing.Size(191, 24);
            this.dVTComboBox.TabIndex = 14;
            // 
            // frmLoaiLKcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(dVTLabel1);
            this.Controls.Add(this.dVTComboBox);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(maLoaiLabel);
            this.Controls.Add(this.maLoaiTextEdit);
            this.Controls.Add(tenLoaiLabel);
            this.Controls.Add(this.tenLoaiTextEdit);
            this.Controls.Add(thangBHLabel);
            this.Controls.Add(this.thangBHSpinEdit);
            this.Controls.Add(this.lOAI_LKGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLoaiLKcs";
            this.Text = "Loại Linh kiện";
            this.Load += new System.EventHandler(this.frmLoaiLKcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_LKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAI_LKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangBHSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource lOAI_LKBindingSource;
        private QLLinhKienMayTinhTableAdapters.LOAI_LKTableAdapter lOAI_LKTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAI_LKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit maLoaiTextEdit;
        private DevExpress.XtraEditors.TextEdit tenLoaiTextEdit;
        private DevExpress.XtraEditors.SpinEdit thangBHSpinEdit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox dVTComboBox;

    }
}