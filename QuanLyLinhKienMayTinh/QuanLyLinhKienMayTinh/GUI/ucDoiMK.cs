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
using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucDoiMK : DevExpress.XtraEditors.XtraUserControl
    {

        public ucDoiMK()
        {
            InitializeComponent();
        }

        NguoiDungBUS ndBUS = new NguoiDungBUS();
        KiemTraHopLe kt = new KiemTraHopLe();

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (kt.KiemTra3DauVao(txtOldPass.Text,txtNewPass.Text,txtConfimPass.Text))
            {
                if(kt.KiemTraPresentPass(txtOldPass.Text))
                {
                    if(kt.KiemTraCofirmPassword(txtNewPass.Text,txtConfimPass.Text))
                    {
                        //update pass
                        string hashPass = ndBUS.Hash(txtConfimPass.Text);
                        ndBUS.updateNewPassword(hashPass);
                        MessageBox.Show("Cập nhật mật khẩu mới thành công", "Thông báo");
                        txtOldPass.Text = txtNewPass.Text = txtConfimPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu phải giống nhau !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác !!!","Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!","Thông báo");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        


    }
}
