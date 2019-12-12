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
    public partial class frmLoaiLKcs : DevExpress.XtraEditors.XtraForm
    {
        int _flag;

        string tenLoai= "";
        string dvt = "";
        string thangBH = "";
        string maLoai = "";

        LinhKienBUS lkBus= new LinhKienBUS();
        

        public frmLoaiLKcs()
        {
            InitializeComponent();
        }

        private void frmLoaiLKcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.LOAI_LK' table. You can move, or remove it, as needed.
            this.lOAI_LKTableAdapter.Fill(this.qLLinhKienMayTinh.LOAI_LK);

            AnTextbox();
            AnButton2();
        }

        private void AnButton2()
        {
            btnadd.Enabled = true;
            btndelete.Enabled = true;
            btnupdate.Enabled = true;

            btnsave.Enabled = false;
        }

        private void lOAI_LKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAI_LKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void XoaTextbox()
        {
            maLoaiTextEdit.Text = "";
            tenLoaiTextEdit.Text = "";
            dVTComboBox.Text = "";
            thangBHSpinEdit.Text = "";     
        }

        public static string phatsinhMaLoaiLK()
        {
            Random rand = new Random();
            string a = rand.Next(001, 999).ToString();
            return a;
        }

        private void HienTextbox()
        {
            tenLoaiTextEdit.Enabled = true;
            dVTComboBox.Enabled = true;
            thangBHSpinEdit.Enabled = true;          
        }

        private void AnButton()
        {
            btnadd.Enabled = false;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;

            btnsave.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _flag = 1;
            XoaTextbox();
            maLoaiTextEdit.Text = phatsinhMaLoaiLK();
            HienTextbox();
            AnButton();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            _flag = 2;
            AnButton();
            HienTextbox(); 
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin Loại linh kiện này không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Hiện không thể xóa thông tin loại linh kiện này","Thông báo");
            }
        }

        private void AnTextbox()
        {
            tenLoaiTextEdit.Enabled = false;
            dVTComboBox.Enabled = false;
            thangBHSpinEdit.Enabled = false;
        }

        private void layThongTin()
        {
            maLoai = maLoaiTextEdit.Text;
            tenLoai = tenLoaiTextEdit.Text;
            dvt = dVTComboBox.Text;
            thangBH = thangBHSpinEdit.Text;
        }

        public static bool KiemTraDauVao(string _dl1, string _dl2, string _dl3)
        {
            if ((_dl1 == "") || (_dl2 == "") || (_dl3 == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                layThongTin();
                if (KiemTraDauVao(tenLoai, dvt, thangBH))
                {
                    if (_flag == 1) //btn_add clicked
                    {
                        while (lkBus.kiemTraTrungID(maLoai) == false) //nếu xảy ra trùng > Refresh mã nhómND mới sau đó kt lại
                        {
                            maLoai = phatsinhMaLoaiLK();
                        }

                        lOAI_LKTableAdapter.Insert(maLoai,tenLoai,dvt,Convert.ToInt32(thangBH));
                        MessageBox.Show("Thêm thành công","Thông báo");
                        frmLoaiLKcs_Load(sender,e);
                    }
                    else //btn_update clicked
                    {
                        if (lkBus.CapNhatLoaiLK(maLoai, tenLoai, dvt, Convert.ToInt32(thangBH)))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            frmLoaiLKcs_Load(sender, e);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}