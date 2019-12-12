using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucQLKhachHang : UserControl
    {
        public ucQLKhachHang()
        {
            InitializeComponent();
        }

       
        KhachHang kh = new KhachHang();
        bool _flag;
        int _selectedRowIndex;

        KiemTraHopLe kt = new KiemTraHopLe();
        KhachHangBUS khBUS = new KhachHangBUS();

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Fill(this.qLLinhKienMayTinh.KHACHHANG);
            AnButtonLuuHuy();
            AnTextBox();

            gridViewKH.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewKH.OptionsBehavior.Editable = false; 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            ucQLKhachHang_Load(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            _flag = false;
            HienButtonLuuHuy();
            HienTexBox();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (kt.KiemTraDauVao(tenKHTextEdit1.Text, diaChiTextEdit1.Text, dienThoaiTextEdit1.Text, "0", "0", "0", "0") == false)
            {
                MessageBox.Show("Xin Nhập Đầy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                laygiatri();
                try
                {
                    if (khBUS.CapNhatKH(kh))
                    {
                        MessageBox.Show("Cập nhật thành công !!", "Thông báo");
                        ucQLKhachHang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }

        private void AnTextBox()
        {
            maKHTextEdit1.Enabled = false;
            tenKHTextEdit1.Enabled = false;
            diaChiTextEdit1.Enabled = false;
            dienThoaiTextEdit1.Enabled = false;
        }

        private void HienTexBox()
        {
            maKHTextEdit1.Enabled = false;
            tenKHTextEdit1.Enabled = true;
            diaChiTextEdit1.Enabled = true;
            dienThoaiTextEdit1.Enabled = true;
        }

        private void XoaTextBox()
        {
            maKHTextEdit1.Text = "";
            tenKHTextEdit1.Text = "";
            diaChiTextEdit1.Text = "";
            dienThoaiTextEdit1.Text = "";
        }

        private void AnButtonLuuHuy()
        {
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_update.Enabled = true;
        }

        private void HienButtonLuuHuy()
        {
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_update.Enabled = false;

        }

        private void laygiatri()
        {
            kh.MaKH = maKHTextEdit1.Text;
            kh.TenKH = tenKHTextEdit1.Text;
            kh.DiaChi = diaChiTextEdit1.Text;
            kh.DienThoai = dienThoaiTextEdit1.Text;
        }

        private void tenKHTextEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void dienThoaiTextEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

    }
}
