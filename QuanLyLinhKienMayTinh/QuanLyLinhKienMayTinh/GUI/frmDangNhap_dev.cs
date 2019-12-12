using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class frmDangNhap_dev : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap_dev()
        {
            InitializeComponent();
        }

        configBUS conf = new configBUS();
        public static string _manv;
        NguoiDungBUS ndBUS = new NguoiDungBUS();

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                this.Close();              
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            NguoiDung ndung = new NguoiDung();
            ndung.Str_MaNV = txttk.Text;
            ndung.Str_MatKhau = txtmkhau.Text;
            if (conf.Check_Config() == 0)
            {
                int flag = ndBUS.KiemTraNguoiDungv2(ndung);
                
                if (flag == 1)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công");
                    RibbonForm1 main = new RibbonForm1();
                    _manv = txttk.Text;

                    //truyen bien MaNV qua ucCaNhan
                    RibbonForm1._maNV = _manv;
                    ucCaNhan._maNV = _manv;
                    //ndBUS._maNV = _manv;
                    ucBanLK._maNV = _manv;
                    ucXuatLK._maNV = _manv;
                    ucInHDB._maNV = _manv;
                    ucBaoCaoKinhDoanh._maNV = _manv;
                    ucMuaLK._maNV = _manv;
                    ucNhapLK._maNV = _manv;
                    KiemTraHopLe._maNV = _manv;
                    //end Truyền biến

                    main.Show();
                    // this.Close();
                }
                if (flag == 2)
                {
                    MessageBox.Show("Tài khoản này bị bị khóa Vui lòng liên hệ với Quản trị");
                    txttk.Clear();
                    txtmkhau.Clear();
                    txttk.Focus();
                }
                if (flag == 0)
                {
                    MessageBox.Show("Bạn nhập sai Tên Đăng Nhập hoặc Mật Khẩu!", "Thông Báo");
                    txttk.Clear();
                    txtmkhau.Clear();
                    txttk.Focus();
                }
            }
            else if (conf.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không hợp lệ !!", "Thông báo");
                frmCauHinhcs fch = new frmCauHinhcs();
                fch.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tài !!", "Thông báo");
                frmCauHinhcs fch = new frmCauHinhcs();
                fch.ShowDialog();
            }
        }


        private void frmDangNhap_dev_Load(object sender, EventArgs e)
        {
            lblDBname.Text = conf.GetNameDatabase();
        }
    }
}