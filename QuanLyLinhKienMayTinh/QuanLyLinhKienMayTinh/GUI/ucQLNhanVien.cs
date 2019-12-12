using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucQLNhanVien : UserControl
    {
        int _selectedRowIndex;
        string _bc = "BC01";
        string pass = "111111";
        int _flag;
        int _special = 0;
        NhanVien nv = new NhanVien();

        string tenNV = "";
        DateTime ngaysinh = DateTime.Now;
        string diachi = "";
        string sdt = "";
        string email = "";
        string cmnd = "";
        string maBC = "";
        string gt = "";

        NhanVienBUS nvBUS = new NhanVienBUS();
        KiemTraHopLe kt = new KiemTraHopLe();
       

        public ucQLNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucQLNhanVien_Load(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.qLLinhKienMayTinh.NHANVIEN);

            this.bANGCAPTableAdapter.Fill(this.qLLinhKienMayTinh.BANGCAP);

            //rdNam.Checked = true;
            AnTextbox();
            AnButton2();

            gridViewNV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewNV.OptionsBehavior.Editable = false; 
  
        }

        

        private void AnTextbox()
        {
            maNVTextEdit.Enabled= false;
            hoTenTextEdit.Enabled = false;
            ngaySinhDateEdit.Enabled = false;
            diaChiTextEdit.Enabled = false;
            dienThoaiTextEdit.Enabled = false;
            emailTextEdit.Enabled = false;
            cMNDTextEdit.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            bANGCAPComboBox.Enabled = false;
        }

        private void LayGiaTri()
        {
            nv.Str_MaBC = bANGCAPComboBox.SelectedValue.ToString();
            nv.Str_GT = gioiTinhComboBox.SelectedItem.ToString();
            nv.Str_MaNV = maNVTextEdit.Text;
            nv.Str_TenNV = hoTenTextEdit.Text;
            nv.NgaySinh1=ngaySinhDateEdit.DateTime;
            nv.Str_DiaChi= diaChiTextEdit.Text;
            nv.Str_DienThoai= dienThoaiTextEdit.Text;
            nv.Str_Email= emailTextEdit.Text;
            nv.Str_cmnd=cMNDTextEdit.Text;
        }

        private void HienTextbox()
        {
            hoTenTextEdit.Enabled = true;
            ngaySinhDateEdit.Enabled = true;
            diaChiTextEdit.Enabled = true;
            dienThoaiTextEdit.Enabled = true;
            emailTextEdit.Enabled = true;
            cMNDTextEdit.Enabled = true;
            gioiTinhComboBox.Enabled = true;
            bANGCAPComboBox.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _flag = 1;
            XoaTextbox();
            maNVTextEdit.Text = nvBUS.phatsinhMaNV();
            HienTextbox();
            AnButton();

        }

        private void XoaTextbox()
        {
            maNVTextEdit.Text = "";
            hoTenTextEdit.Text = "";
            ngaySinhDateEdit.Text = "";
            diaChiTextEdit.Text = "";
            dienThoaiTextEdit.Text = "";
            emailTextEdit.Text = "";
            cMNDTextEdit.Text = "";
        }

        private void bANGCAPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {               
                string maNV = maNVTextEdit.Text;
                layThongTin();
                if (kt.KiemTraDauVao(maNV, tenNV, ngaysinh.ToString(), diachi,
                    sdt, email, cmnd))
                {
                    if (_flag == 1) //btn_add clicking
                    {
                        if (nvBUS.KiemTraTuoi(ngaysinh))
                        {
                            
                            while (nvBUS.kiemTraTrungID(maNV) == false) //nếu xảy ra trùng > Refresh mã nv mới sau đó kt lại
                            {
                                maNV = nvBUS.phatsinhMaNV();
                            }
                            //them nhan vien
                            nHANVIENTableAdapter.Insert(maNV,tenNV, ngaysinh, diachi, sdt
                                , email, cmnd, maBC, gt);

                            string passDefault = nvBUS.Hash(pass);
                            //them tai khoan
                            nGUOIDUNGTableAdapter.Insert(maNV, passDefault, false);
                            MessageBox.Show("Thêm thành công");
                            //AnButton2();
                            ucQLNhanVien_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Người dùng này chưa đủ 18 tuổi !!", "Thông báo");
                        }
                    }
                    else
                    {
                        LayGiaTri();
                        if (nvBUS.CapNhatNhanVien(nv))
                        {
                            MessageBox.Show("Sửa thông tin nhân viên thành công","Thông báo");
                            ucQLNhanVien_Load(sender, e);
                        }
                    }
                }
               
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void layThongTin()
        {
            tenNV = hoTenTextEdit.Text;
            ngaysinh = ngaySinhDateEdit.DateTime;
            diachi = diaChiTextEdit.Text;
            sdt = dienThoaiTextEdit.Text;
            email = emailTextEdit.Text;
            cmnd = cMNDTextEdit.Text;
            maBC =bANGCAPComboBox.SelectedValue.ToString();
            gt= gioiTinhComboBox.SelectedItem.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo);
            try
            {
                if (re == DialogResult.Yes)
                {
                    //xóa sẽ ảnh hưởng đến bảng khác
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnButton()
        {
            btn_add.Enabled = false;
            //btn_delete.Enabled = false;
            btn_update.Enabled = false;

            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void AnButton2()
        {
            btn_add.Enabled = true;
            //btn_delete.Enabled = true;
            btn_update.Enabled = true;

            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            _flag = 2;
            AnButton();
            HienTextbox();  
        }

        private void nHANVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void bANGCAPComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ucQLNhanVien_Load(sender, e);
        }

        private void btnRefreshID_Click(object sender, EventArgs e)
        {
            maNVTextEdit.Text = nvBUS.phatsinhMaNV();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void nHANVIENGridControl_Click_1(object sender, EventArgs e)
        {

        }


        }
    }

