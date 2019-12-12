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
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using BUS;
using DTO;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucMuaLK : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMuaLK()
        {
            InitializeComponent();
        }

        public static string _maNV;
        DataTable dtGH = new DataTable("ds_MuaLK");
        DateTime _ngaymua;
        decimal _tongtien =0;
        int _danhsacLKIndex;
        string maHDM, maNV,maNCC;
        int _muaToiDa, _tonToiDa;
        DataTable dtThamSo = new DataTable();
        int _flag = 0;
        HoaDonMuaBUS hdmBUS = new HoaDonMuaBUS();
        LinhKienBUS lkBUS = new LinhKienBUS();

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lINHKIENTableAdapter.Fill(this.qlLinhKienMayTinh1.LINHKIEN, cbx_select.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ucMuaLK_Load(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(this.qlLinhKienMayTinh1.NHACUNGCAP);
            this.lINHKIENTableAdapter.Fill(this.qlLinhKienMayTinh1.LINHKIEN, cbx_select.SelectedValue.ToString());
            gv_dsLinhKien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_dsLinhKien.OptionsBehavior.Editable = false;
            gv_dsMuaLK.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_dsMuaLK.OptionsBehavior.Editable = false;
            gv_dsLinhKien.RowCellClick += gv_dsLinhKien_RowCellClick;

            dtThamSo = hdmBUS.LayDuLieuThamSo();
            _muaToiDa = int.Parse(dtThamSo.Rows[0].ItemArray[0].ToString());
            _tonToiDa = int.Parse(dtThamSo.Rows[0].ItemArray[1].ToString());

            cbx_select.Text = "[Chọn Nhà Cung Cấp]";
            timerNM_Tick(sender, e);
            AnThemXoa();
            AnLuuHuy();
            lblNhanVien.Text = _maNV;
            txt_SoLuong.Focus();
            ThemColvaoBang();
            
        }

        void gv_dsLinhKien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gv_dsLinhKien.SelectedRowsCount > 0)
            {
                try
                {
                    _danhsacLKIndex = e.RowHandle;
                    HienLuuHuy();
                    btn_add.Enabled = true;
                    btn_delete.Enabled = true;
                }
                catch
                {
                    return;
                }
            }
        }

        private void timerNM_Tick(object sender, EventArgs e)
        {
            string t = System.DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            lblNgayMua.Text = t;
        }

        private void cbx_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ncc = "";
            if (cbx_select.SelectedIndex != -1)
            {
                if (this.cbx_select.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    ncc = cbx_select.SelectedValue.ToString();
                    this.lINHKIENTableAdapter.Fill(this.qlLinhKienMayTinh1.LINHKIEN, ncc);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try{
                bool tinhTrangHDM = false;
                LayGiaTri();
                if (gv_dsMuaLK.RowCount > 0)
                {
                    if (hdmBUS.kiemtraTrungIdHDMua(maHDM))
                    {
                        hOADON_MUAHANGTableAdapter.Insert(maHDM, _ngaymua, maNCC, maNV, _tongtien, tinhTrangHDM);
                    }

                    for (int i = 0; i <= gv_dsMuaLK.RowCount - 1; i++)
                    {
                        string maLK = gv_dsMuaLK.GetRowCellValue(i, gv_dsMuaLK.Columns[0]).ToString();
                        string maCTHD = taoMaCTHDMua();
                        int slmua = int.Parse(gv_dsMuaLK.GetRowCellValue(i, gv_dsMuaLK.Columns[7]).ToString());
                        while (hdmBUS.kiemtraTrungIdCTHDMua(maCTHD) == false)
                        {
                            maCTHD = taoMaCTHDMua();
                        }

                        decimal _dongia = decimal.Parse(gv_dsMuaLK.GetRowCellValue(i, gv_dsMuaLK.Columns[8]).ToString());
                        decimal _thanhTien = slmua * _dongia ;

                        cT_HOADONMUATableAdapter.Insert(maCTHD, maHDM, maLK, slmua, _dongia, _thanhTien);
                    }
                    MessageBox.Show("Đã Lập Phiếu Mua Linh Kiện Của nhà cung cấp << " + cbx_select.SelectedValue.ToString() + " >>", "Thông Báo");
                    for (int i = 0; i < gv_dsMuaLK.RowCount; )
                    {
                        gv_dsMuaLK.DeleteRow(i);
                    }
                    AnLuuHuy();
                    cbx_select.Text = "[Chon Nha Cung Cap]";
                    btn_add.Enabled = false;
                    //btn_delete.Enabled = false;
                    txt_SoLuong.Clear();
                    txt_Total.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Vui Lòng Chọn Các Linh Kiện Cần Mua Trước Khi Lập Phiếu Nhập!!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double tong;
            if (txt_SoLuong.Text == "")
            {
                MessageBox.Show("Xin Nhập Số Lượng Cần Mua", "Thông Báo");
                txt_SoLuong.Focus();
            }
            else
            {
                int _slTon = hdmBUS.LaySoLuongTon(gv_dsLinhKien.GetRowCellValue(_danhsacLKIndex, gv_dsLinhKien.Columns[0]).ToString());
                if (_slTon <= _tonToiDa)
                {
                    if (int.Parse(txt_SoLuong.Text) <= _muaToiDa)
                    {
                        if (gv_dsMuaLK.RowCount > 0)
                        {
                            //for(int i=0;i<=gv_dsMuaLK.RowCount-1;i++)
                            //{
                            if (String.Compare(gv_dsLinhKien.GetRowCellValue(_danhsacLKIndex, gv_dsLinhKien.Columns[6]).ToString(), gv_dsMuaLK.GetRowCellValue(gv_dsMuaLK.FocusedRowHandle, "MaNCC").ToString(), true) == 0)
                            {
                                for (int j = 0; j <= gv_dsMuaLK.RowCount - 1; j++)
                                {
                                    if (String.Compare(gv_dsLinhKien.GetRowCellValue(_danhsacLKIndex, gv_dsLinhKien.Columns[0]).ToString(), gv_dsMuaLK.GetRowCellValue(j, "MaLK").ToString(), true) == 0)
                                    {
                                        DialogResult dr = MessageBox.Show("Linh Kiện << " + gv_dsMuaLK.GetRowCellValue(j, gv_dsLinhKien.Columns[1]).ToString() + " >> Đã Có Trong Danh Sách." + "\n Bạn Vẫn Muốn Thêm Linh Kiện này Vào Danh Sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dr == DialogResult.Yes)
                                        {
                                            string index = (gv_dsMuaLK.GetRowCellValue(j, gv_dsMuaLK.Columns[7]).ToString());
                                            int sl = Convert.ToInt32(index) + Convert.ToInt32(txt_SoLuong.Text);
                                            gv_dsMuaLK.SetRowCellValue(j, gv_dsMuaLK.Columns[7], sl);

                                            _flag = 1;
                                            tong = tongTien();
                                            txt_Total.Text = String.Format("{0:0,0}",tong);
                                            txt_SoLuong.Clear();
                                            HienLuuHuy();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        _flag = 0;
                                    }
                                }
                                if (_flag != 1)
                                {
                                    ThemGioHang();
                                    _flag = 0;
                                    tong = tongTien();
                                    txt_Total.Text = String.Format("{0:0,0}",tong);
                                    txt_SoLuong.Clear();
                                    HienLuuHuy();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Một Đơn Đặt Hàng Chỉ Được Một Nhà Cung Cấp!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_SoLuong.Clear();
                            }
                        }
                        else
                        {
                            ThemGioHang();
                            tong = tongTien();
                            txt_Total.Text = String.Format("{0:0,0}",tong);
                            txt_SoLuong.Clear();
                            HienLuuHuy();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số Linh Kiện Được Mua Tối Đa Là << " + _muaToiDa.ToString() + " >>", "Thông Báo");
                        txt_SoLuong.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ Được Mua Khi Số Lượng Tồn Trong Kho Dưới << " + _tonToiDa.ToString() + " >>", "Thong Bao");
                    txt_SoLuong.Clear();
                }
            }
        }
            
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (gv_dsMuaLK.RowCount > 0)
            {
                gv_dsMuaLK.DeleteRow(gv_dsMuaLK.FocusedRowHandle);
                double tong = tongTien();
                txt_Total.Text = String.Format("{0:0,0}",tong);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_dsMuaLK.RowCount; )
            {
                gv_dsMuaLK.DeleteRow(i);
            }
            AnLuuHuy();
            cbx_select.Text = "[Chon Nha Cung Cap]";
            btn_add.Enabled = false;
            //btn_delete.Enabled = false;
            txt_SoLuong.Clear();
            txt_Total.Clear();
        }

        private void btn_capnhatGia_Click(object sender, EventArgs e)
        {
            frmCapNhatGiaNhap gn = new frmCapNhatGiaNhap();
            gn.ShowDialog();
           // ucMuaLK_Load(sender, e);
        }

        public void AnLuuHuy()
        {
            btn_save.Enabled = false;
            btn_huy.Enabled = false;
        }

        public void HienLuuHuy()
        {
            btn_save.Enabled = true;
            btn_huy.Enabled = true;
        }

        public void AnThemXoa()
        {
            btn_add.Enabled = false;
           // btn_delete.Enabled = false;
        }

        public void HienThemXoa()
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
        }

        public void XoaTextBox()
        {
            txt_SoLuong.Text = "";
            txt_Total.Text = "";
        }

        public void LayGiaTri()
        {
            maHDM = taoMaHDMua();
            _ngaymua = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            maNV = lblNhanVien.Text;
            maNCC = lbl_MaNCC.Text;
           _tongtien = Convert.ToDecimal(txt_Total.Text);
        }

        private double tongTien()
        {
            double s = 0;
            for (int i = 0; i < gv_dsMuaLK.RowCount; i++)
            {
                string sl = gv_dsMuaLK.GetRowCellValue(i, gv_dsMuaLK.Columns[7]).ToString();
                string gianhap = gv_dsMuaLK.GetRowCellValue(i, gv_dsMuaLK.Columns[8]).ToString();
                s += Convert.ToDouble(sl) * Convert.ToDouble(gianhap);
            }
            return s;
        }

        public void ThemColvaoBang()
        {
            DataColumn col = new DataColumn("MaLK", typeof(string));
            dtGH.Columns.Add(col);
            dtGH.Columns.Add("TenLK",typeof(string));
            dtGH.Columns.Add("LoaiLK",typeof(string));
            dtGH.Columns.Add("NhaSX",typeof(string));
            dtGH.Columns.Add("Xuatxu",typeof(string));
            dtGH.Columns.Add("NamSX",typeof(int));
            dtGH.Columns.Add("MaNCC",typeof(string));
            dtGH.Columns.Add("Soluong",typeof(int));
            dtGH.Columns.Add("Gianhap",typeof(decimal));
        }

        public void ThemGioHang()
        {
            try
            {
                DataRow dr = dtGH.NewRow();
                int rowHandle = gv_dsLinhKien.FocusedRowHandle;
                dr["MaLK"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[0]).ToString();
                dr["TenLK"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[1]).ToString();
                dr["LoaiLK"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[2]).ToString();
                dr["NhaSX"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[3]).ToString();
                dr["Xuatxu"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[4]).ToString();
                dr["NamSX"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[5]).ToString();
                dr["MaNCC"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[6]).ToString();
                dr["Soluong"] = txt_SoLuong.Text.ToString();
                dr["Gianhap"] = gv_dsLinhKien.GetRowCellValue(rowHandle, gv_dsLinhKien.Columns[8]).ToString();
                dtGH.Rows.Add(dr);
                gc_dsMuaLK.DataSource = dtGH;
            }
            catch
            {
                MessageBox.Show("Linh kiện hiện đang chưa có GIÁ NHẬP. Vui lòng cập nhật !!","Thông báo");
            }
        }

        private string taoMaCTHDMua()
        {
            Random rand = new Random();
            string a = rand.Next(1000000, 9999999).ToString();
            return a + lkBUS.RandomString(4, true);
        }

        private string taoMaHDMua()
        {
            string title = "HD";
            Random rand = new Random();
            string a = rand.Next(100000, 999999).ToString();
            return title + a + lkBUS.RandomString(3, true);
        }

        

        private void gc_dsMuaLK_ProcessGridKey(object sender, KeyEventArgs e)
        {     
            if (e.KeyCode==Keys.Delete)
            {
                if (XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Linh Kiện Này Khỏi Danh Sách Mua?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtGH.Rows.RemoveAt(gv_dsMuaLK.FocusedRowHandle);
                    double tong = tongTien();
                    txt_Total.Text = tong.ToString();
                }
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (e.KeyChar == '.'))
                e.Handled = true;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
