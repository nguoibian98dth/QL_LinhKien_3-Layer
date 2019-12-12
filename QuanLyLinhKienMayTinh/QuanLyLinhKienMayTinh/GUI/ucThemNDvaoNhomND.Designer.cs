namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucThemNDvaoNhomND
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
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.nD_NND1TableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.ND_NND1TableAdapter();
            this.nHOMNGUOIDUNGTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.nGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nD_NND1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nD_NND1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGComboBox = new System.Windows.Forms.ComboBox();
            this.nD_NNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nD_NNDTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.ND_NNDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NND1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NND1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NNDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCAPTableAdapter = null;
            this.tableAdapterManager.GIA_LKTableAdapter = null;
            this.tableAdapterManager.ND_NND1TableAdapter = this.nD_NND1TableAdapter;
            this.tableAdapterManager.ND_NNDTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nD_NND1TableAdapter
            // 
            this.nD_NND1TableAdapter.ClearBeforeFill = true;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNGDataGridView
            // 
            this.nGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.nGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.nGUOIDUNGDataGridView.DataSource = this.nGUOIDUNGBindingSource;
            this.nGUOIDUNGDataGridView.Location = new System.Drawing.Point(12, 55);
            this.nGUOIDUNGDataGridView.Name = "nGUOIDUNGDataGridView";
            this.nGUOIDUNGDataGridView.RowTemplate.Height = 24;
            this.nGUOIDUNGDataGridView.Size = new System.Drawing.Size(438, 544);
            this.nGUOIDUNGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TaiKhoan";
            this.dataGridViewTextBoxColumn1.HeaderText = "TaiKhoan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TinhTrang";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TinhTrang";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // nD_NND1BindingSource
            // 
            this.nD_NND1BindingSource.DataMember = "ND_NND1";
            this.nD_NND1BindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // nD_NND1DataGridView
            // 
            this.nD_NND1DataGridView.AutoGenerateColumns = false;
            this.nD_NND1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nD_NND1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nD_NND1DataGridView.DataSource = this.nD_NND1BindingSource;
            this.nD_NND1DataGridView.Location = new System.Drawing.Point(734, 82);
            this.nD_NND1DataGridView.Name = "nD_NND1DataGridView";
            this.nD_NND1DataGridView.RowTemplate.Height = 24;
            this.nD_NND1DataGridView.Size = new System.Drawing.Size(265, 517);
            this.nD_NND1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TaiKhoanND";
            this.dataGridViewTextBoxColumn3.HeaderText = "TaiKhoanND";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomND";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomND";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // nHOMNGUOIDUNGComboBox
            // 
            this.nHOMNGUOIDUNGComboBox.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nHOMNGUOIDUNGComboBox.DisplayMember = "TenGoi";
            this.nHOMNGUOIDUNGComboBox.FormattingEnabled = true;
            this.nHOMNGUOIDUNGComboBox.Location = new System.Drawing.Point(734, 55);
            this.nHOMNGUOIDUNGComboBox.Name = "nHOMNGUOIDUNGComboBox";
            this.nHOMNGUOIDUNGComboBox.Size = new System.Drawing.Size(265, 24);
            this.nHOMNGUOIDUNGComboBox.TabIndex = 4;
            this.nHOMNGUOIDUNGComboBox.ValueMember = "ID";
            this.nHOMNGUOIDUNGComboBox.SelectedIndexChanged += new System.EventHandler(this.nHOMNGUOIDUNGComboBox_SelectedIndexChanged);
            // 
            // nD_NNDBindingSource
            // 
            this.nD_NNDBindingSource.DataMember = "ND_NND";
            this.nD_NNDBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // nD_NNDTableAdapter
            // 
            this.nD_NNDTableAdapter.ClearBeforeFill = true;
            // 
            // ucThemNDvaoNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nHOMNGUOIDUNGComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nD_NND1DataGridView);
            this.Controls.Add(this.nGUOIDUNGDataGridView);
            this.Name = "ucThemNDvaoNhomND";
            this.Size = new System.Drawing.Size(1016, 655);
            this.Load += new System.EventHandler(this.ucThemNDvaoNhomND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NND1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NND1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nD_NNDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QLLinhKienMayTinhTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private QLLinhKienMayTinhTableAdapters.ND_NND1TableAdapter nD_NND1TableAdapter;
        private System.Windows.Forms.DataGridView nGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource nD_NND1BindingSource;
        private QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.DataGridView nD_NND1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.ComboBox nHOMNGUOIDUNGComboBox;
        private System.Windows.Forms.BindingSource nD_NNDBindingSource;
        private QLLinhKienMayTinhTableAdapters.ND_NNDTableAdapter nD_NNDTableAdapter;

    }
}
