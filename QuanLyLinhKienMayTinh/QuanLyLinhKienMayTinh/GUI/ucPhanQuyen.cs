using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucPhanQuyen : UserControl
    {
        public ucPhanQuyen()
        {
            InitializeComponent();
        }

        private void ucPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.ND_NND' table. You can move, or remove it, as needed.
            this.nD_NNDTableAdapter.Fill(this.qLLinhKienMayTinh.ND_NND);
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.ND_NND' table. You can move, or remove it, as needed.
            this.nD_NND1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.ND_NND1,1);
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.ND_NND' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NGUOIDUNG);

            gridViewND.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewND.OptionsBehavior.Editable = false;

            gridViewND_Nhom.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewND_Nhom.OptionsBehavior.Editable = false; 
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _nnd = "";
            if (nHOMNGUOIDUNGComboBox.SelectedIndex != -1)
            {
                if (this.nHOMNGUOIDUNGComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    _nnd = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();
                    this.nD_NND1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.ND_NND1, ((int)(System.Convert.ChangeType(_nnd, typeof(int)))));
                }
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {            
            int rowHandle = gridViewND.FocusedRowHandle;
            string tennd = gridViewND.GetRowCellValue(rowHandle, "TaiKhoan").ToString();
            string tennhomND = nHOMNGUOIDUNGComboBox.Text;
            if (MessageBox.Show("Xác nhận thông tin bạn có muốn thêm nhóm quyền cho tài khoản [" + tennd +"] "+">>"+" [ "+tennhomND+" ] "+"này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kiemTraTonTai(tennd))
                {
                    rowHandle = gridViewND.FocusedRowHandle;
                    tennd = gridViewND.GetRowCellValue(rowHandle, "TaiKhoan").ToString();
                    int nhomnd = Convert.ToInt32(nHOMNGUOIDUNGComboBox.SelectedValue.ToString());
                    nD_NNDTableAdapter.Insert(tennd, nhomnd, string.Empty);
                    MessageBox.Show("Thêm thành công !!", "Thông báo");
                    loadComboNhomND();
                }
                else
                {
                    MessageBox.Show("Tài khoản ["+tennd+"] này đã nằm trong nhóm quyền ["+tennhomND+"] này rồi !!", "Thông báo");
                }
            }
        }

       private bool kiemTraTonTai(string _tkAdded)
        {
            DataTable dt = nD_NND1TableAdapter.GetData_dk(Convert.ToInt32(nHOMNGUOIDUNGComboBox.SelectedValue.ToString()));
            foreach (DataRow drct in dt.Rows)
            {
                if (drct["TaiKhoanND"].ToString() == _tkAdded)
                    return false;
            }
            return true;        
        }

        private void loadComboNhomND()
        {
            try
            {
                this.nD_NND1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.ND_NND1, Convert.ToInt32(nHOMNGUOIDUNGComboBox.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowHandle = gridViewND_Nhom.FocusedRowHandle;
            string tennd = gridViewND_Nhom.GetRowCellValue(rowHandle, "TaiKhoanND").ToString();
            string tennhomND = nHOMNGUOIDUNGComboBox.Text;
            if (MessageBox.Show("Xác nhận thông tin bạn có chắc muốn xóa nhóm quyền cho tài khoản [" + tennd + "] " + "<<" + " [ " + tennhomND + " ] " + "này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rowHandle = gridViewND_Nhom.FocusedRowHandle; //lấy dòng hiện tại
                tennd = gridViewND_Nhom.GetRowCellValue(rowHandle, "TaiKhoanND").ToString();
                int nhomnd = Convert.ToInt32(nHOMNGUOIDUNGComboBox.SelectedValue.ToString());
                nD_NNDTableAdapter.Delete(tennd, nhomnd, string.Empty);
                MessageBox.Show("Xóa thành công !!", "Thông báo");
                loadComboNhomND();
            }
        }
    }
}
