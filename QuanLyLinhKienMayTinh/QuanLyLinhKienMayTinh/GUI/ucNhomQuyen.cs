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
    public partial class ucNhomQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNhomQuyen()
        {
            InitializeComponent();
        }

        int _flag;
        //qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();
        NhomQuyenBUS nqBUS = new NhomQuyenBUS();



        private void tenGoiTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucNhomQuyen_Load(object sender, EventArgs e)
        {
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NHOMNGUOIDUNG);

            txtTenNhom.Enabled = false;
            txtMaNhom.Enabled = false;
            AnButton2();

        }

        private void AnButton()
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void AnButton2()
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;

            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtMaNhom.Text = taoMaNhom();
            txtTenNhom.Text = "";
            txtTenNhom.Enabled = true;
            AnButton();
            _flag = 1;
        }

        private string taoMaNhom()
        {
            Random rand = new Random();
            string a = rand.Next(100,999).ToString();
            return a;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa nhóm quyền ngày không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    nHOMNGUOIDUNGTableAdapter.Delete(Convert.ToInt32(txtMaNhom.Text), txtTenNhom.Text);
                    MessageBox.Show("Xóa nhóm thành công", "Thông báo");
                    ucNhomQuyen_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int maNhom = Convert.ToInt32(txtMaNhom.Text);
                string tenNhom = txtTenNhom.Text;
                if (tenNhom.Length > 0)
                {
                    if (_flag == 1)
                    {
                        while (nqBUS.kiemTraTrungID(maNhom) == false) //nếu xảy ra trùng > Refresh mã nhómND mới sau đó kt lại
                        {
                            maNhom = Convert.ToInt32(taoMaNhom());
                        }
                        //add
                        nHOMNGUOIDUNGTableAdapter.Insert(maNhom, tenNhom);

                        ucNhomQuyen_Load(sender, e);
                        MessageBox.Show("Thêm nhóm thành công", "Thông báo");
                    }
                    else
                    {
                        //update
                        if (nqBUS.capNhatNhomQuyen(maNhom, tenNhom))
                        {
                            ucNhomQuyen_Load(sender, e);
                            MessageBox.Show("Cập nhật tên nhóm thành công", "Thông báo");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }





        private void btn_update_Click(object sender, EventArgs e)
        {
            txtTenNhom.Enabled = true;
            AnButton();
            _flag = 2;
        }

        private void btnRefreshID_Click(object sender, EventArgs e)
        {
            txtMaNhom.Text = taoMaNhom();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ucNhomQuyen_Load(sender, e);
        }
    }
}
