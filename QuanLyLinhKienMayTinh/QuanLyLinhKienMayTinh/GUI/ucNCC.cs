using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucNCC : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNCC()
        {
            InitializeComponent();
        }

        NhaCungCap ncc = new NhaCungCap();
        bool _flag;
        int _selectedRowIndex;
        KiemTraHopLe kt = new KiemTraHopLe();
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        LinhKienBUS lkBUS = new LinhKienBUS();

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void ucNCC_Load(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(this.qLLinhKienMayTinh.NHACUNGCAP);
            AnTextBox();
            AnButtonLuuHuy();

            gv_NCC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_NCC.OptionsBehavior.Editable = false; 
        }


        private void AnTextBox()
        {
            maNCCLabel2.Enabled = false;
            tenNCCTextEdit1.Enabled = false;
            diaChiTextEdit1.Enabled = false;
            dienThoaiTextEdit1.Enabled = false;
            soTaiKhoanTextEdit1.Enabled = false;
            ngayDangKyDateEdit1.Enabled = false;
        }

        private void HienTexBox()
        {
            maNCCLabel2.Enabled = false;
            tenNCCTextEdit1.Enabled = true;
            diaChiTextEdit1.Enabled = true;
            dienThoaiTextEdit1.Enabled = true;
            soTaiKhoanTextEdit1.Enabled = true;
            ngayDangKyDateEdit1.Enabled = true;
        }

        private void XoaTextBox()
        {
            maNCCLabel2.Text = "";
            tenNCCTextEdit1.Text = "";
            diaChiTextEdit1.Text = "";
            dienThoaiTextEdit1.Text = "";
            soTaiKhoanTextEdit1.Text = "";
            ngayDangKyDateEdit1.Text = null;
        }

        private void AnButtonLuuHuy()
        {
            btn_cancel.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_add.Enabled = true;
        }

        private void HienButtonLuuHuy()
        {
            btn_cancel.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = true;
        }

        public void LayGiaTri()
        {
            ncc.MaNCC = maNCCLabel2.Text;
            ncc.TenNCC = tenNCCTextEdit1.Text;
            ncc.DiaChi = diaChiTextEdit1.Text;
            ncc.DienThoai = dienThoaiTextEdit1.Text;
            ncc.SoTaiKhoan = soTaiKhoanTextEdit1.Text;
            ncc.NgayDangKy = DateTime.Parse(ngayDangKyDateEdit1.Text);
        }

        public string taomaNCC()
        {
            string title = "NCC";
            Random rand = new Random();
            string a = rand.Next(100, 999).ToString();
            return title + a;
        }

        private void tenNCCTextEdit_TextChanged(object sender, EventArgs e)
        {
            
            //if (btn_add.Text == "Lưu")
            //{
            //   maNCCLabel2.Text = taomaNCC();
            //}
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_add.Text == "Thêm")
            {
                XoaTextBox();
                HienTexBox();

                btn_add.Text = "Lưu";
                //maNCCLabel2.Text = "";
                tenNCCTextEdit1.Focus();

               // gc_NCC.Enabled = false;
                maNCCLabel2.Enabled = false;

                btn_cancel.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                maNCCLabel2.Text = taomaNCC();
            }
            else
            {
                btn_add.Text = "Thêm";
                btn_cancel.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                
              //  gc_NCC.Enabled = true;
                try
                {
                    
                    if (kt.KiemTraDauVao(tenNCCTextEdit1.Text, diaChiTextEdit1.Text, dienThoaiTextEdit1.Text, soTaiKhoanTextEdit1.Text, ngayDangKyDateEdit1.Text, "0", "0") == true)
                    {
                        if (nccBUS.KiemTraKhiThemNCC(tenNCCTextEdit1.Text, diaChiTextEdit1.Text) == true)
                        {
                            //taomaNCC();
                            LayGiaTri();
                            while (nccBUS.kiemtraTrungIdNCC(maNCCLabel2.Text) == false) //nếu xảy ra trùng > Refresh mã CTHD_Ban mới sau đó kt lại
                            {
                                maNCCLabel2.Text = taomaNCC();
                            }


                            if (nccBUS.ThemNCC(ncc))
                            {
                                MessageBox.Show("Thêm thành công !!", "Thông báo");
                                ucNCC_Load(sender, e);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin Vui Lòng Nhập Đầy Đủ Thông Tin !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "Cập nhật")
            {
                btn_update.Text = "Lưu";
                HienTexBox();
                btn_cancel.Enabled = true;
                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                maNCCLabel2.Text = taomaNCC();
               // gc_NCC.Enabled = false;
            }
            else
            {
                btn_update.Text = "Cập nhật";
                btn_cancel.Enabled = false;
                btn_add.Enabled = true;
                btn_delete.Enabled = true;
              //  gc_NCC.Enabled = true;
                try
                {
                    if (nccBUS.KiemTraKhiCapNhatNCC(tenNCCTextEdit1.Text, diaChiTextEdit1.Text, _selectedRowIndex) == true)
                    {
                        if (nccBUS.KiemTraKhiCapNhatNCC(tenNCCTextEdit1.Text, diaChiTextEdit1.Text, _selectedRowIndex) == true)
                        {
                            LayGiaTri();
                            if (nccBUS.CapNhatNCC(ncc))
                            {
                                MessageBox.Show("Cập nhật thành công !!", "Thông báo");
                                ucNCC_Load(sender, e);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Thông Tin !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa Nhà Cung Cấp: [ " + tenNCCTextEdit1.Text.ToString() + " ] hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    ncc.MaNCC = maNCCLabel2.Text.ToString();
                    if (nccBUS.XoaNCC(ncc))
                    {
                        MessageBox.Show("Xóa thành công !!", "Thông báo");
                        ucNCC_Load(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            XoaTextBox();
           // gc_NCC.Enabled = true;
            if (btn_add.Text == "Lưu")
            {
                btn_add.Text = "Thêm";
            }
            if (btn_update.Text == "Lưu")
            {
                btn_update.Text = "Cập Nhật";
            }

            ucNCC_Load(sender, e);
        }

        private void dienThoaiTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tenNCCTextEdit1_Leave(object sender, EventArgs e)
        {

        }

        private void dienThoaiTextEdit1_Leave(object sender, EventArgs e)
        {

        }

        private void soTaiKhoanTextEdit1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
