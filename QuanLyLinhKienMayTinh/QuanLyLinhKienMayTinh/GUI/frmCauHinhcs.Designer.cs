namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    partial class frmCauHinhcs
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
            this.cbx_serverName = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.cbx_DBname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_serverName
            // 
            this.cbx_serverName.FormattingEnabled = true;
            this.cbx_serverName.Location = new System.Drawing.Point(126, 36);
            this.cbx_serverName.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_serverName.Name = "cbx_serverName";
            this.cbx_serverName.Size = new System.Drawing.Size(243, 24);
            this.cbx_serverName.TabIndex = 28;
            this.cbx_serverName.DropDown += new System.EventHandler(this.cbx_serverName_DropDown);
            this.cbx_serverName.SelectedIndexChanged += new System.EventHandler(this.cbx_serverName_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 212);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "Lưu lại";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ServerName";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(126, 122);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(243, 23);
            this.txtPass.TabIndex = 22;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(126, 81);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(243, 23);
            this.txtUserId.TabIndex = 21;
            // 
            // cbx_DBname
            // 
            this.cbx_DBname.FormattingEnabled = true;
            this.cbx_DBname.Location = new System.Drawing.Point(126, 166);
            this.cbx_DBname.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_DBname.Name = "cbx_DBname";
            this.cbx_DBname.Size = new System.Drawing.Size(243, 24);
            this.cbx_DBname.TabIndex = 30;
            this.cbx_DBname.DropDown += new System.EventHandler(this.cbx_DBname_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCauHinhcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_DBname);
            this.Controls.Add(this.cbx_serverName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserId);
            this.Name = "frmCauHinhcs";
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.frmCauHinhcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_serverName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.ComboBox cbx_DBname;
        private System.Windows.Forms.Button button1;
    }
}