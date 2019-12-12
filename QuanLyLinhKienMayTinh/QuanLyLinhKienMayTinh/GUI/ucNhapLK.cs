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
using System.Globalization;
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucNhapLK : UserControl
    {
        public ucNhapLK()
        {
            InitializeComponent();
        }

        public static string _maNV;

        LinhKienBUS lkB = new LinhKienBUS();
        NhapLinhKienBUS nlk = new NhapLinhKienBUS();
        //HOADON_MUAHANG hdm = new HOADON_MUAHANG();
        DataTable dtCT_LK = new DataTable();
        LinhKienBUS lkBUS = new LinhKienBUS();
        
        int _DSrong = 0, _trangThai = 0;
        int _itemIndex=0;
        string _maMuaLK, _maNCC, _maPN, _maCTPN, _maHDM;
        DateTime _ngayNhap;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string n = DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            lblNgayNhapKho.Text = n;
        }

        private void ucNhapLK_Load(object sender, EventArgs e)
        {
            LayDLCholbxDanhSachHDM();
            timer1_Tick(sender, e);
            lblNhanVien.Text = _maNV;
            lblNhaCC.Text = "";
            gc_CTHDM.DataSource = null;
        }

        private string taoMaPN()
        {
            string title = "PN";
            Random rand = new Random();
            string a = rand.Next(100000, 999999).ToString();
            return title + a + lkBUS.RandomString(3, true);
        }

        private string taoMaCTPN()
        {
            Random rand = new Random();
            string a = rand.Next(10000000, 99999999).ToString();
            return a + lkBUS.RandomString(3, true);
        }

        public void LayDLCholbxDanhSachHDM()
        {
            dtCT_LK = nlk.getHDM();
            int count = nlk.CountHDM();
            if (count > 0)
            {
                _DSrong = 1;
                for (int i = 0; i < count; i++)
                {
                    lbx_dsHoaDonMua.Items.Add(dtCT_LK.Rows[i].ItemArray[0].ToString());
                }
            }
            else
            {
                lbx_dsHoaDonMua.Items.Add("[ DS Rỗng ]");
                lbx_dsHoaDonMua.Enabled = false;
            }
        }

        private void LayGiaTri()
        {
            _ngayNhap = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _maHDM = lbx_dsHoaDonMua.SelectedItem.ToString();
            _maNCC = nlk.layIdNCC(_maHDM);
            _maCTPN = taoMaCTPN();
        }

        private void lbx_dsHoaDonMua_MouseClick(object sender, MouseEventArgs e)
        {
            if (_DSrong == 1)
            {
                _trangThai = 1;
                btn_import.Enabled = true;
            }
        }

        private void lbx_dsHoaDonMua_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbx_dsHoaDonMua.SelectedIndex != -1)
            {
                if (lbx_dsHoaDonMua.Items[_itemIndex].ToString() != "")
                {
                    if (_trangThai == 1)
                    {
                        _maMuaLK = lbx_dsHoaDonMua.Items[_itemIndex].ToString();
                        dtCT_LK = nlk.ToDataTable(nlk.LayCT_HoaDonMua(_maMuaLK));

                        lblNhaCC.Text = _maNCC;
                        gc_CTHDM.DataSource = dtCT_LK;
                        lblNhaCC.Text = nlk.layIdNCC(lbx_dsHoaDonMua.Items[_itemIndex].ToString()) + " - " +nlk.layTenNCC(nlk.layIdNCC(lbx_dsHoaDonMua.Items[_itemIndex].ToString())) ;
                    }
                }
            }
        }

        private void lbx_dsHoaDonMua_Click(object sender, EventArgs e)
        {
            if (lbx_dsHoaDonMua.Items.Count > 0)
            {
                try
                {
                    _itemIndex = lbx_dsHoaDonMua.SelectedIndex;
                }
                catch
                {
                    return;
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            if (lblNhaCC.Text != "")
            {
                LayGiaTri();

                _maPN = taoMaPN();
                while (nlk.kiemtraTrungIdPN(_maPN) == false) //nếu xảy ra trùng > Refresh mã CTPN mới sau đó kt lại
                {
                    _maPN = taoMaPN();
                }
                //1.add phieu nhap
                pHIEUNHAPTableAdapter.Insert(_maPN, _maHDM, _ngayNhap, _maNCC, _maNV);
                //2.add ct phieu nhap
                for (int i = 0; i < gv_CThoadonmua.RowCount; i++)
                {
                    string _maLK = gv_CThoadonmua.GetRowCellValue(i, gv_CThoadonmua.Columns[0]).ToString();

                    //cập nhật giá bán cho sp vừa nhập
                    lkB.CapNhatDonGiaLK(_maLK);

                    _maCTPN = taoMaCTPN();
                    while (nlk.kiemtraTrungIdCTPN(_maCTPN) == false) //nếu xảy ra trùng > Refresh mã CTPN mới sau đó kt lại
                    {
                        _maCTPN = taoMaCTPN();
                    }

                    int sl = Convert.ToInt32(gv_CThoadonmua.GetRowCellValue(i, gv_CThoadonmua.Columns[4]).ToString());

                    cT_PHIEUNHAPTableAdapter.Insert(_maCTPN, _maPN, _maLK, sl, string.Empty);
                    nlk.capNhatTinhTrangHDM(_maHDM);
                    lkBUS.CapNhatLaiSoLuongKhiMua(_maLK, _maHDM);
                }

                if (MessageBox.Show("Vui Lòng Kiểm Tra Đầy Đủ Hàng Trước Khi Nhập Kho !! Nhấn OK để tiếp tục", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MessageBox.Show("Nhập Kho Thành Công !!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    lbx_dsHoaDonMua.Items.Clear();
                    ucNhapLK_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Hóa Đơn Mua Để Nhập Kho!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }
    }
}
