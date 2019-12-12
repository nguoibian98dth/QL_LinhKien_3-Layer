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

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucPhanQuyenMH : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPhanQuyenMH()
        {
            InitializeComponent();
        }

        int _maNhom = 1;

        PhanQuyenMHBUS pqmhBUS = new PhanQuyenMHBUS();

        private void ucPhanQuyenMH_Load(object sender, EventArgs e)
        {
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NHOMNGUOIDUNG);
            loadDataMH(_maNhom);
            //txtMaNhomND.Text = _maNhom.ToString();
            getMaNhomND();
            txtMaNhomND.Visible = false;

            gridViewNhom.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewNhom.OptionsBehavior.Editable = false;           
        }



        private void loadDataMH(int _maNhom)
        {
            this.test1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.test1, _maNhom);
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void gridControlNhomND_Click(object sender, EventArgs e)
        {
        }

        private void txtMaNhomND_TextChanged(object sender, EventArgs e)
        {
            _maNhom = Convert.ToInt32(txtMaNhomND.Text);
            loadDataMH(_maNhom);
        }

        private int getMaNhomND()
        {
            int rowHandle = gridViewNhom.FocusedRowHandle;
            int maNhomND = Convert.ToInt32(gridViewNhom.GetRowCellValue(rowHandle, "MaNhom"));
            return maNhomND;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thông tin. Bạn có chắc muốn THÊM (hoặc BỎ) quyền thấy Màn hình của Nhóm ["+txtMaNhomND.Text+"] không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                insertTest1(_maNhom);
                MessageBox.Show("Thành công", "Thông báo");
                MessageBox.Show("Để áp dụng những thay đổi trên (những) tài khoản thuộc nhóm quyền. Vui lòng đăng nhập lại Hệ thống !!","Thông báo");
                loadDataMH(_maNhom);
            }
        }

        private void insertTest1(int _maNhom)
        {
            for (int i = 0; i < gridViewPQ.RowCount; i++)
            {
                string mamh = gridViewPQ.GetRowCellValue(i, "MaManHinh").ToString();
                object quyen = gridViewPQ.GetRowCellValue(i, "CoQuyen");
                if (quyen == DBNull.Value)
                    quyen = false;
                
                if (pqmhBUS.kiemTraTrungID(mamh,_maNhom))// _manhom và maMH ko tồn tại trong PhanQuyen >>Insert
                {                
                    if (Convert.ToBoolean(quyen) == false)
                    {
                        pHANQUYENTableAdapter.Insert(mamh, _maNhom, false);
                    }
                    else
                    {
                        pHANQUYENTableAdapter.Insert(mamh, _maNhom, true);
                    }
                }
                else// _manhom và maMH đã tồn tại trong PhanQuyen >>Update CoQuyen
                {
                    pqmhBUS.updateCoQuyen(mamh,_maNhom,quyen);
                }
                
            }
        }


        private void fill_dkToolStripButton_Click_1(object sender, EventArgs e)
        {
        }

        

        private void gridControlNhomND_MouseDown(object sender, MouseEventArgs e)
        {
        }



    }
}
