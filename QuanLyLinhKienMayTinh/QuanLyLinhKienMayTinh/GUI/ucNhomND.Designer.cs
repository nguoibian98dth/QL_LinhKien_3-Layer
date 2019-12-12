namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucNhomND
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tenGoiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhomND));
            this.qLLinhKienMayTinh2 = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.nHOMNGUOIDUNGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter2 = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager2 = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.nHOMNGUOIDUNGDataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSpinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.tenGoiTextEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            iDLabel = new System.Windows.Forms.Label();
            tenGoiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource2BindingNavigator)).BeginInit();
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGoiTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(15, 49);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(27, 17);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // tenGoiLabel
            // 
            tenGoiLabel.AutoSize = true;
            tenGoiLabel.Location = new System.Drawing.Point(15, 77);
            tenGoiLabel.Name = "tenGoiLabel";
            tenGoiLabel.Size = new System.Drawing.Size(59, 17);
            tenGoiLabel.TabIndex = 4;
            tenGoiLabel.Text = "Ten Goi:";
            // 
            // qLLinhKienMayTinh2
            // 
            this.qLLinhKienMayTinh2.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOMNGUOIDUNGBindingSource2
            // 
            this.nHOMNGUOIDUNGBindingSource2.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource2.DataSource = this.qLLinhKienMayTinh2;
            // 
            // nHOMNGUOIDUNGTableAdapter2
            // 
            this.nHOMNGUOIDUNGTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.BANGCAPTableAdapter = null;
            this.tableAdapterManager2.GIA_LKTableAdapter = null;
            this.tableAdapterManager2.ND_NND1TableAdapter = null;
            this.tableAdapterManager2.ND_NNDTableAdapter = null;
            this.tableAdapterManager2.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager2.NHANVIENTableAdapter = null;
            this.tableAdapterManager2.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHOMNGUOIDUNGBindingSource2BindingNavigator
            // 
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.AddNewItem = this.toolStripButton11;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.BindingSource = this.nHOMNGUOIDUNGBindingSource2;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.CountItem = this.toolStripLabel2;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.DeleteItem = this.toolStripButton12;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.toolStripButton11,
            this.toolStripButton12,
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem,
            this.toolStripButton13});
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.MoveFirstItem = this.toolStripButton7;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.MoveLastItem = this.toolStripButton10;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.MoveNextItem = this.toolStripButton9;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.MovePreviousItem = this.toolStripButton8;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.Name = "nHOMNGUOIDUNGBindingSource2BindingNavigator";
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.PositionItem = this.toolStripTextBox2;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.Size = new System.Drawing.Size(973, 27);
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.TabIndex = 0;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.Text = "bindingNavigator1";
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.RefreshItems += new System.EventHandler(this.nHOMNGUOIDUNGBindingSource2BindingNavigator_RefreshItems);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton11.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton12.Text = "Delete";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton7.Text = "Move first";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton8.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton9.Text = "Move next";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton10.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem
            // 
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Image")));
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Name = "nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem";
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Text = "Save Data";
            this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem.Click += new System.EventHandler(this.nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton13.Text = "toolStripButton13";
            // 
            // nHOMNGUOIDUNGDataGridView2
            // 
            this.nHOMNGUOIDUNGDataGridView2.AutoGenerateColumns = false;
            this.nHOMNGUOIDUNGDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHOMNGUOIDUNGDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nHOMNGUOIDUNGDataGridView2.DataSource = this.nHOMNGUOIDUNGBindingSource2;
            this.nHOMNGUOIDUNGDataGridView2.Location = new System.Drawing.Point(70, 109);
            this.nHOMNGUOIDUNGDataGridView2.Name = "nHOMNGUOIDUNGDataGridView2";
            this.nHOMNGUOIDUNGDataGridView2.RowTemplate.Height = 24;
            this.nHOMNGUOIDUNGDataGridView2.Size = new System.Drawing.Size(300, 220);
            this.nHOMNGUOIDUNGDataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenGoi";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenGoi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iDSpinEdit2
            // 
            this.iDSpinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource2, "ID", true));
            this.iDSpinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit2.Location = new System.Drawing.Point(84, 46);
            this.iDSpinEdit2.Name = "iDSpinEdit2";
            this.iDSpinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDSpinEdit2.Size = new System.Drawing.Size(100, 22);
            this.iDSpinEdit2.TabIndex = 3;
            // 
            // tenGoiTextEdit2
            // 
            this.tenGoiTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource2, "TenGoi", true));
            this.tenGoiTextEdit2.Location = new System.Drawing.Point(84, 74);
            this.tenGoiTextEdit2.Name = "tenGoiTextEdit2";
            this.tenGoiTextEdit2.Size = new System.Drawing.Size(159, 22);
            this.tenGoiTextEdit2.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.iDSpinEdit2);
            this.groupControl2.Controls.Add(iDLabel);
            this.groupControl2.Controls.Add(this.tenGoiTextEdit2);
            this.groupControl2.Controls.Add(tenGoiLabel);
            this.groupControl2.Location = new System.Drawing.Point(399, 109);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(260, 131);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Chi tiết";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.nHOMNGUOIDUNGDataGridView2);
            this.Controls.Add(this.nHOMNGUOIDUNGBindingSource2BindingNavigator);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(973, 508);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource2BindingNavigator)).EndInit();
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.ResumeLayout(false);
            this.nHOMNGUOIDUNGBindingSource2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenGoiTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.BindingNavigator nHOMNGUOIDUNGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nHOMNGUOIDUNGBindingNavigatorSaveItem;
        private QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenGoiTextEdit;
        private System.Windows.Forms.DataGridView nHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private QLLinhKienMayTinh qLLinhKienMayTinh1;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource1;
        private QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter1;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator nHOMNGUOIDUNGBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton nHOMNGUOIDUNGBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nHOMNGUOIDUNGDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit1;
        private DevExpress.XtraEditors.TextEdit tenGoiTextEdit1;
        private QLLinhKienMayTinh qLLinhKienMayTinh2;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource2;
        private QLLinhKienMayTinhTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter2;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator nHOMNGUOIDUNGBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nHOMNGUOIDUNGDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit2;
        private DevExpress.XtraEditors.TextEdit tenGoiTextEdit2;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
