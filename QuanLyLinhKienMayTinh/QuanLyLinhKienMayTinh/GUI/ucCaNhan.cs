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
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucCaNhan : DevExpress.XtraEditors.XtraUserControl
    {
        public ucCaNhan()
        {
            InitializeComponent();
        }
        //khai bao
        public static string _maNV;

        KiemTraHopLe kt = new KiemTraHopLe();
        NhanVienBUS nvBUS = new NhanVienBUS();
        //

        private void nHANVIEN_dkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIEN_dkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void nHANVIEN_dkBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIEN_dkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void nHANVIEN_dkBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIEN_dkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void fill_dkToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void ucCaNhan_Load(object sender, EventArgs e)
        {
            AnTextBox();
            this.nHANVIEN_dkTableAdapter.Fill_dk(this.qLLinhKienMayTinh.NHANVIEN_dk, _maNV);
            lbMaNV.Text = _maNV;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
        }

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            HienTextBox();
            btn_update.Enabled = false;
            btn_save.Enabled = true;
        }

        private void AnTextBox()
        {
            hoTenTextEdit1.Enabled = false;
            ngaySinhDateEdit1.Enabled = false;
            diaChiTextEdit1.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            dienThoaiTextEdit1.Enabled = false;
            cMNDTextEdit1.Enabled = false;
            emailTextEdit1.Enabled = false;
        }

        private void HienTextBox()
        {
            hoTenTextEdit1.Enabled = true;
            ngaySinhDateEdit1.Enabled = true;
            diaChiTextEdit1.Enabled = true;
            gioiTinhComboBox.Enabled = true;
            dienThoaiTextEdit1.Enabled = true;
            cMNDTextEdit1.Enabled = true;
            emailTextEdit1.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (kt.KiemTraDauVao(hoTenTextEdit1.Text, ngaySinhDateEdit1.DateTime.ToString(), diaChiTextEdit1.Text, gioiTinhComboBox.Text, cMNDTextEdit1.Text, dienThoaiTextEdit1.Text, emailTextEdit1.Text))
                {
                    if (nvBUS.KiemTraTuoi(ngaySinhDateEdit1.DateTime))
                    {
                        //update for LINQ
                        string manv = lbMaNV.Text;
                        string HoTen = hoTenTextEdit1.Text;
                        DateTime NgaySinh = ngaySinhDateEdit1.DateTime;
                        string GioiTinh = gioiTinhComboBox.SelectedItem.ToString();
                        string Email = emailTextEdit1.Text;
                        string CMND = cMNDTextEdit1.Text;
                        string DiaChi = diaChiTextEdit1.Text;
                        string DienThoai = dienThoaiTextEdit1.Text;

                        nvBUS.capnhatNVlinQ(manv, HoTen, NgaySinh, GioiTinh, Email, CMND, DiaChi, DienThoai);

                        AnTextBox();
                        ucCaNhan_Load(sender, e);
                        MessageBox.Show("Cập nhật thông tin cá nhân thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Em chưa 18 !!", "Thông báo");
                    }
                }
                else
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ Dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
