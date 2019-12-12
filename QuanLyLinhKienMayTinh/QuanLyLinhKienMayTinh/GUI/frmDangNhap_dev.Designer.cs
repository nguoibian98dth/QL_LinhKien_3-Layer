namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class frmDangNhap_dev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap_dev));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtmkhau = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDBname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "PHẦN MỀM QUẢN LÝ LINH KIỆN MÁY TÍNH";
            this.label4.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtmkhau
            // 
            this.txtmkhau.Location = new System.Drawing.Point(283, 224);
            this.txtmkhau.Name = "txtmkhau";
            this.txtmkhau.PasswordChar = '*';
            this.txtmkhau.Size = new System.Drawing.Size(180, 23);
            this.txtmkhau.TabIndex = 34;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(381, 256);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 33);
            this.btnthoat.TabIndex = 36;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(283, 257);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(82, 33);
            this.btnok.TabIndex = 35;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtmk
            // 
            this.txtmk.AutoSize = true;
            this.txtmk.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(196, 224);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(78, 21);
            this.txtmk.TabIndex = 30;
            this.txtmk.Text = "Mật khẩu";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(283, 192);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(180, 23);
            this.txttk.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tài khoản";
            // 
            // lblDBname
            // 
            this.lblDBname.AutoSize = true;
            this.lblDBname.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDBname.Location = new System.Drawing.Point(515, 9);
            this.lblDBname.Name = "lblDBname";
            this.lblDBname.Size = new System.Drawing.Size(56, 17);
            this.lblDBname.TabIndex = 37;
            this.lblDBname.Text = "Tên db";
            // 
            // frmDangNhap_dev
            // 
            this.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 365);
            this.Controls.Add(this.lblDBname);
            this.Controls.Add(this.txtmkhau);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap_dev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_dev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmkhau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDBname;


    }
}