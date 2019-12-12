using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class frmCapNhatGiaNhap : Form
    {
        public frmCapNhatGiaNhap()
        {
            InitializeComponent();
        }

        LinhKien lk = new LinhKien();
        LinhKienBUS lkBUS = new LinhKienBUS();

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lINHKIENTableAdapter.Fill(this.qLLinhKienMayTinh.LINHKIEN, cbx_NCC.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void frmCapNhatGiaNhap_Load(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(this.qLLinhKienMayTinh.NHACUNGCAP);
            this.lINHKIENTableAdapter.Fill(this.qLLinhKienMayTinh.LINHKIEN, cbx_NCC.SelectedValue.ToString());
            gv_updateGia.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_updateGia.OptionsBehavior.Editable = false;
        }

        private void cbx_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ncc = "";
            if (cbx_NCC.SelectedIndex != -1)
            {
                if (this.cbx_NCC.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    ncc = cbx_NCC.SelectedValue.ToString();
                    this.lINHKIENTableAdapter.Fill(this.qLLinhKienMayTinh.LINHKIEN, ncc);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "Cập nhật")
            {
                giaNhapTextEdit.Enabled = true;
                giaNhapTextEdit.Text = "";
                giaNhapTextEdit.Focus();
                btn_update.Text = "Lưu";
            }
            else
            {
                btn_update.Text = "Cập nhật";
                giaNhapTextEdit.Enabled = false;
                
                try
                {
                    if (giaNhapTextEdit.Text=="")
                    {
                        MessageBox.Show("Xin Vui Lòng Nhập Giá Nhập Cần Thay Đổi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int rowHandle = gv_updateGia.FocusedRowHandle;
                        lk.Str_MaLK = gv_updateGia.GetRowCellValue(rowHandle, gv_updateGia.Columns[0]).ToString();
                        lk.GiaNhap = double.Parse(giaNhapTextEdit.Text);
                        lkBUS.CapNhatGiaNhap(lk);
                        gv_updateGia.RefreshData();
                        giaNhapTextEdit.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void giaNhapTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }
    }
}
