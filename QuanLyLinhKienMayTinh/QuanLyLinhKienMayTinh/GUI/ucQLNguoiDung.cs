using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucQLNguoiDung : UserControl
    {
        public ucQLNguoiDung()
        {
            InitializeComponent();
        }

        NguoiDungBUS ndBUS = new NguoiDungBUS();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string _taiKhoan = taiKhoanTextEdit.Text;
            DialogResult re=MessageBox.Show("Bạn có chắc muốn reset mật khẩu của tài khoản [" + _taiKhoan + "] này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                ndBUS.resetPassword(_taiKhoan);
                MessageBox.Show("Tài khoản [" + _taiKhoan + "] đã được khôi phục về mật khẩu mặc định. Mật khẩu mặc định là [111111]", "Thông báo");
            }
        }

        private void ucQLNguoiDung_Load(object sender, EventArgs e)
        {
            this.nGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NGUOIDUNG);  
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int rowHandle = gridViewNguoiDung.FocusedRowHandle;
            string _tk = gridViewNguoiDung.GetRowCellValue(rowHandle, "TaiKhoan").ToString();
            if (MessageBox.Show("Xác nhận thông tin. Bạn muốn thay đổi TÌNH TRẠNG (những) Tài Khoản đã chọn đúng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);
                MessageBox.Show("Đã thay đổi TÌNH TRẠNG (những) Tài Khoản thành công", "Thông báo");
                ucQLNguoiDung_Load(sender, e);
            }
        }
    }
}
