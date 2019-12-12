namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class ucThamSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThamSo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmaTS = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_BanToiDa = new System.Windows.Forms.TextBox();
            this.txt_TonToiThieu = new System.Windows.Forms.TextBox();
            this.txt_TonToiDa = new System.Windows.Forms.TextBox();
            this.txt_MuaToiDa = new System.Windows.Forms.TextBox();
            this.txt_TiGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.qLLinhKienMayTinh = new QuanLyLinhKienMayTinh.QLLinhKienMayTinh();
            this.gIA_LKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIA_LKTableAdapter = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.GIA_LKTableAdapter();
            this.tableAdapterManager = new QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIA_LKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmaTS);
            this.groupBox2.Controls.Add(this.lbl5);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.txt_BanToiDa);
            this.groupBox2.Controls.Add(this.txt_TonToiThieu);
            this.groupBox2.Controls.Add(this.txt_TonToiDa);
            this.groupBox2.Controls.Add(this.txt_MuaToiDa);
            this.groupBox2.Controls.Add(this.txt_TiGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(749, 542);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tham Số Định Mức";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblmaTS
            // 
            this.lblmaTS.AutoSize = true;
            this.lblmaTS.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmaTS.Location = new System.Drawing.Point(540, 225);
            this.lblmaTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmaTS.Name = "lblmaTS";
            this.lblmaTS.Size = new System.Drawing.Size(50, 17);
            this.lblmaTS.TabIndex = 114;
            this.lblmaTS.Text = "Mã TS";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl5.Location = new System.Drawing.Point(29, 246);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(186, 25);
            this.lbl5.TabIndex = 111;
            this.lbl5.Text = "Số lượng bán tối đa:";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl4.Location = new System.Drawing.Point(8, 196);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(200, 25);
            this.lbl4.TabIndex = 113;
            this.lbl4.Text = "Số lượng tồn tối thiểu:";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl3.Location = new System.Drawing.Point(33, 148);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(180, 25);
            this.lbl3.TabIndex = 112;
            this.lbl3.Text = "Số lượng tồn tối đa:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl2.Location = new System.Drawing.Point(21, 98);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(191, 25);
            this.lbl2.TabIndex = 115;
            this.lbl2.Text = "Số lượng mua tối đa:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1.Location = new System.Drawing.Point(69, 50);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 25);
            this.lbl1.TabIndex = 114;
            this.lbl1.Text = "Tỉ lệ % giá bán:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_BanToiDa
            // 
            this.txt_BanToiDa.BackColor = System.Drawing.Color.White;
            this.txt_BanToiDa.ForeColor = System.Drawing.Color.Black;
            this.txt_BanToiDa.Location = new System.Drawing.Point(240, 242);
            this.txt_BanToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BanToiDa.Name = "txt_BanToiDa";
            this.txt_BanToiDa.Size = new System.Drawing.Size(200, 30);
            this.txt_BanToiDa.TabIndex = 108;
            this.txt_BanToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TiGia_KeyPress);
            // 
            // txt_TonToiThieu
            // 
            this.txt_TonToiThieu.BackColor = System.Drawing.Color.White;
            this.txt_TonToiThieu.ForeColor = System.Drawing.Color.Black;
            this.txt_TonToiThieu.Location = new System.Drawing.Point(243, 192);
            this.txt_TonToiThieu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TonToiThieu.Name = "txt_TonToiThieu";
            this.txt_TonToiThieu.Size = new System.Drawing.Size(197, 30);
            this.txt_TonToiThieu.TabIndex = 107;
            this.txt_TonToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TiGia_KeyPress);
            // 
            // txt_TonToiDa
            // 
            this.txt_TonToiDa.BackColor = System.Drawing.Color.White;
            this.txt_TonToiDa.ForeColor = System.Drawing.Color.Black;
            this.txt_TonToiDa.Location = new System.Drawing.Point(240, 144);
            this.txt_TonToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TonToiDa.Name = "txt_TonToiDa";
            this.txt_TonToiDa.Size = new System.Drawing.Size(200, 30);
            this.txt_TonToiDa.TabIndex = 106;
            this.txt_TonToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TiGia_KeyPress);
            // 
            // txt_MuaToiDa
            // 
            this.txt_MuaToiDa.BackColor = System.Drawing.Color.White;
            this.txt_MuaToiDa.ForeColor = System.Drawing.Color.Black;
            this.txt_MuaToiDa.Location = new System.Drawing.Point(240, 95);
            this.txt_MuaToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MuaToiDa.Name = "txt_MuaToiDa";
            this.txt_MuaToiDa.Size = new System.Drawing.Size(200, 30);
            this.txt_MuaToiDa.TabIndex = 109;
            this.txt_MuaToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TiGia_KeyPress);
            // 
            // txt_TiGia
            // 
            this.txt_TiGia.BackColor = System.Drawing.Color.White;
            this.txt_TiGia.ForeColor = System.Drawing.Color.Black;
            this.txt_TiGia.Location = new System.Drawing.Point(240, 47);
            this.txt_TiGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TiGia.Name = "txt_TiGia";
            this.txt_TiGia.Size = new System.Drawing.Size(200, 30);
            this.txt_TiGia.TabIndex = 109;
            this.txt_TiGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TiGia_KeyPress);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(489, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 175);
            this.label7.TabIndex = 105;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(147, 310);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(165, 47);
            this.btn_update.TabIndex = 113;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(429, 310);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(171, 47);
            this.btn_cancel.TabIndex = 113;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // qLLinhKienMayTinh
            // 
            this.qLLinhKienMayTinh.DataSetName = "QLLinhKienMayTinh";
            this.qLLinhKienMayTinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIA_LKBindingSource
            // 
            this.gIA_LKBindingSource.DataMember = "GIA_LK";
            this.gIA_LKBindingSource.DataSource = this.qLLinhKienMayTinh;
            // 
            // gIA_LKTableAdapter
            // 
            this.gIA_LKTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIA_LKTableAdapter = this.gIA_LKTableAdapter;
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
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyLinhKienMayTinh.QLLinhKienMayTinhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ucThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucThamSo";
            this.Size = new System.Drawing.Size(749, 542);
            this.Load += new System.EventHandler(this.ucThamSo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLinhKienMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIA_LKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_BanToiDa;
        private System.Windows.Forms.TextBox txt_TonToiThieu;
        private System.Windows.Forms.TextBox txt_TonToiDa;
        private System.Windows.Forms.TextBox txt_MuaToiDa;
        private System.Windows.Forms.TextBox txt_TiGia;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lblmaTS;
        private QLLinhKienMayTinh qLLinhKienMayTinh;
        private System.Windows.Forms.BindingSource gIA_LKBindingSource;
        private QLLinhKienMayTinhTableAdapters.GIA_LKTableAdapter gIA_LKTableAdapter;
        private QLLinhKienMayTinhTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
