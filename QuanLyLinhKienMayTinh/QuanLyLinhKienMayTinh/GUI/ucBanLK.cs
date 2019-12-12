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
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucBanLK : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBanLK()
        {
            InitializeComponent();
        }

        public static string _maNV;
        private string _barCodeLK="";
        private int _danhsachLKIndex, _muaLKIndex;

        string _maHDBan;
        DateTime _ngayLapHDB;
        string _maNV2;

        string _maKH;
        string _tenKH;
        string _sdtKH;
        string _dchiKH;
        decimal _tongThanhToan = 0;

        LinhKienBUS lkBUS = new LinhKienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        HoaDonBanBUS hdbBUS = new HoaDonBanBUS();
        KiemTraHopLe kt = new KiemTraHopLe();

        private void lblNgay_Click(object sender, EventArgs e)
        {

        }

        private void timkiemtuongdoi(TextBox txtSDT_KH)
        {
            txtSDT_KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSDT_KH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                SqlDataReader drd = lkBUS.getKH();
                while (drd.Read())
                {
                    coll.Add(drd["DienThoai"].ToString());
                }
                txtSDT_KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSDT_KH.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSDT_KH.AutoCompleteCustomSource = coll;
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucBanLK_Load(object sender, EventArgs e)
        {
            dgvDSLK.DataSource = lkBUS.DanhsachLKBanLK();
            timkiemtuongdoi(txtSDT_KH);
            timer1_Tick(sender, e);
            lbMaHDBan.Text =hdbBUS.taoMaHDBan();
            lbNhanVien.Text = _maNV;
            txtScanBarcode.Focus();
            txtTongThanhToan.Text = "0";
            txtVAT.Text = "0";
            txtTienChuaVAT.Text = "0";
            txtSDT_KH.Clear();
            dgvBanLK.Rows.Clear();
        }

       
        public string Get_tgian()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 10);
            return str;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  lbtgBanHang.Text = DateTime.Now.ToShortDateString();

            string s = DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            lbtgBanHang.Text = s;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_KH_TextChanged(object sender, EventArgs e)
        {
            string sdtKhach = txtSDT_KH.Text;
            fillDataOnTextbox(sdtKhach);
        }

        private void fillDataOnTextbox(string sdtKhach)
        {
            lbMaKH.Text = hdbBUS.fillDataOnTextbox(sdtKhach)[0];
            tenKHTextEdit.Text = hdbBUS.fillDataOnTextbox(sdtKhach)[1];
            diaChiTextEdit.Text = hdbBUS.fillDataOnTextbox(sdtKhach)[2];
        }

        private void txtScanBarcode_Enter(object sender, EventArgs e)
        {
        }

        private void ucBanLK_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtScanBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                _barCodeLK = txtScanBarcode.Text.ToUpper();
                hopLeBarcode(_barCodeLK);
                double _tong = tongThanhToan();
                double _VAT = tongVAT();
                txtTongThanhToan.Text = String.Format("{0:0,0}", _tong);
                txtVAT.Text = String.Format("{0:0,0}",_VAT);
                double _tienChuaVAT= _tong - _VAT;                
                //txtTienChuaVAT.Text = _tienChuaVAT.ToString();
                txtTienChuaVAT.Text= String.Format("{0:0,0}", _tienChuaVAT);
                txtScanBarcode.Clear();
            }
        }

        private double tongThanhToan()
        {
            double s = 0;
            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
            {
                string sl = dgvBanLK.Rows[i].Cells[3].Value.ToString();
                string dongia = dgvBanLK.Rows[i].Cells[4].Value.ToString();
                s += Convert.ToInt32(sl)* Convert.ToDouble(dongia); 
            }
            return s;
        }

        private double tongVAT()
        {
            return tongThanhToan() / 10;
        }

        private void hopLeBarcode(string _barCodeLK)
        {
            if (dataTimKiem(_barCodeLK) == -1)
            {
                //ko co barcode trong dgvDSLK
                MessageBox.Show("Mã vạch không hợp lệ", "Thông báo");
                return;
            }
            if (dataTimKiem(_barCodeLK) == -2)
            {
                //ko co barcode trong dgvDSLK
                MessageBox.Show("Mặt hàng này hiện tại đã hết hàng", "Thông báo");
                return;
            }
            else
            {
                //có barcode trong dgvDSLK
                int _soluongMacDinh = 1;
                int _flag = dataTimKiem(_barCodeLK);
                if (timKiemBarcodeInCart(_barCodeLK))//đã có barcode trong cart hiện tại
                {
                    //update lại sl (thay đổi giá trị sl của rows hiện tại trong cart
                    int _vitriRowTK = viTriRowTK(_barCodeLK);
                    if (_vitriRowTK != -1)
                    {
                        int s = Convert.ToInt32(dgvBanLK.Rows[_vitriRowTK].Cells[3].Value.ToString()) +1;
                        dgvBanLK.Rows[_vitriRowTK].Cells[3].Value = s ;
                    }

                }
                else
                {
                    //barcode chưa có trong cart >> tiến hành add vào cart
                    dgvBanLK.Rows.Add(_barCodeLK, dgvDSLK.Rows[_flag].Cells[1].Value.ToString(), dgvDSLK.Rows[_flag].Cells[2].Value.ToString(),
                                                 _soluongMacDinh.ToString(), dgvDSLK.Rows[_flag].Cells[4].Value.ToString(), dgvDSLK.Rows[_flag].Cells[5].Value.ToString(),
                                                 dgvDSLK.Rows[_flag].Cells[6].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[7].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[8].Value.ToString(), txt_SoLuong.Text.ToString());
                }
            }

        }

        private int viTriRowTK(string _barcode)
        {
            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
            {
                if (dgvBanLK.Rows[i].Cells[0].Value.ToString() == _barcode)
                    return i;
            }
            return -1;

        }

        private int dataTimKiem(string _barCodeLK)
        {
            int pos = -1;
                for (int i = 0; i < dgvDSLK.RowCount; i++)
                    if (dgvDSLK.Rows[i].Cells[0].Value.ToString() == _barCodeLK)
                    {
                        //kiểm tra hàng trong kho
                        if (Int32.Parse(dgvDSLK.Rows[i].Cells[3].Value.ToString()) > 0) // nếu sl hàng trong kho > 0
                        {
                            
                            //nếu còn >>  kiểm tra hàng trc mới cập nhật
                            //nếu không còn >>thông báo hết hàng
                            pos = i;
                            break;
                        }
                        else
                        {
                            pos = -2;
                            break;
                        }
                    }
                return pos;

            }





        private void dgvDSLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _danhsachLKIndex = e.RowIndex;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int _soluongTonKho = Convert.ToInt16(dgvDSLK.Rows[_danhsachLKIndex].Cells[3].Value.ToString());
            string _maLK_KT = dgvDSLK.Rows[_danhsachLKIndex].Cells[0].Value.ToString();
            if (_soluongTonKho > 0)
            {
                if (txt_SoLuong.Text != "")
                {
                    if (timKiemBarcodeInCart(_maLK_KT))//đã có barcode trong cart hiện tại
                    {
                        //update lại sl (thay đổi giá trị sl của rows hiện tại trong cart
                        int _vitriRowTK = viTriRowTK(_maLK_KT);
                        if (_vitriRowTK != -1)
                        {
                            int s = Convert.ToInt32(dgvBanLK.Rows[_vitriRowTK].Cells[3].Value.ToString()) + Convert.ToInt32(txt_SoLuong.Text);
                            dgvBanLK.Rows[_vitriRowTK].Cells[3].Value = s;
                            txt_SoLuong.Text = "";
                        }
                    }
                        else
                        {
                            dgvBanLK.Rows.Add(dgvDSLK.Rows[_danhsachLKIndex].Cells[0].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[1].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[2].Value.ToString(),
                                                txt_SoLuong.Text.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[4].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[5].Value.ToString(),
                                                dgvDSLK.Rows[_danhsachLKIndex].Cells[6].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[7].Value.ToString(), dgvDSLK.Rows[_danhsachLKIndex].Cells[8].Value.ToString());
                        }
                        double _tong = tongThanhToan();
                        double _VAT = tongVAT();
                        txtTongThanhToan.Text = _tong.ToString();
                        txtVAT.Text = _VAT.ToString();
                        double _tienChuaVAT = _tong - _VAT;
                        txtTienChuaVAT.Text = _tienChuaVAT.ToString();
                        txt_SoLuong.Text = "";
                }
                
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng linh kiện mà khách cần mua", "Thông tin");
                    }
                }
                else
                {
                    MessageBox.Show("Linh kiện " + dgvDSLK.Rows[_danhsachLKIndex].Cells[1].Value.ToString() + " này hiện tại đã hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBanLK.Rows.Count > 0)
                {
                    dgvBanLK.Rows.RemoveAt(_muaLKIndex);
                    double _tong = tongThanhToan();
                    double _VAT = tongVAT();
                    txtTongThanhToan.Text = _tong.ToString();
                    txtVAT.Text = _VAT.ToString();
                    double _tienChuaVAT = _tong - _VAT;
                    txtTienChuaVAT.Text = _tienChuaVAT.ToString();
                    //return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn Linh kiện cần xóa !!","Thông báo");
            }
        }

        private void dgvBanLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBanLK.SelectedRows.Count > 0)
            {
                try
                {
                    _muaLKIndex = e.RowIndex;
                   // btn_delete.Enabled = true;
                   // btn_add.Enabled = false;
                }
                catch
                {
                    return;
                }
            }
        }

        private void LayThongTin()
        {
            _maHDBan = lbMaHDBan.Text;
            _ngayLapHDB = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _maNV2 = lbNhanVien.Text;

            _maKH = lbMaKH.Text;
            _tenKH = tenKHTextEdit.Text;
            _sdtKH = txtSDT_KH.Text;
            _dchiKH = diaChiTextEdit.Text;

            _tongThanhToan = Convert.ToDecimal(txtTongThanhToan.Text);
        }


        private void txtSDT_KH_Leave(object sender, EventArgs e)
        {
            string _sdtKH = txtSDT_KH.Text;

            if (_sdtKH.Length < 10 || _sdtKH.Length > 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại", "Thông báo");
                txtSDT_KH.Clear();
                txtSDT_KH.Focus();

            }
            else
            {
                if (khBUS.kiemtraTrungSDT(_sdtKH))
                {
                    //nếu ko trùng
                    lbMaKH.Text = khBUS.taoMaKH();
                }
                else
                {
                    //nếu trùng
                    fillDataOnTextbox(_sdtKH);
                }
            }
        }

        private void txtSDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (kt.KiemTra3DauVao(tenKHTextEdit.Text, diaChiTextEdit.Text, txtSDT_KH.Text))
            {
                LayThongTin();
                if (dgvBanLK.Rows.Count > 0)
                {
                    //trùng id >> bỏ qua insert khách hàng                    
                    if (hdbBUS.kiemtraTrungIdHDBan(_maHDBan))
                    {
                        if(kiemtraLKTrongKho() == 1)
                        {
                            //insert khách hàng(nếu chưa có)
                            if (khBUS.kiemtraTrungIdKH(_maKH))
                            {
                                //ID KH KHÔNG trùng >>KH chưa có trong hệ thống >> insert KH 
                                kHACHHANGTableAdapter.Insert(_maKH, _tenKH, _dchiKH, _sdtKH);
                                MessageBox.Show("Thêm khách hàng " + _tenKH + " thành công", "Thông báo");
                            }
                            //nếu KHÔNG trùng hd
                            bool tinhTrangHDB = false;
                            //insert Hóa đơn bán
                            hOADON_BANHANGTableAdapter.Insert(_maHDBan, _ngayLapHDB, _maKH, _maNV2, _tongThanhToan, tinhTrangHDB);

                            //insert CTHD bán
                            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
                            {
                                string _changeID = hdbBUS.taoMaCTHDBan();
                                while (hdbBUS.kiemtraTrungIdCTHDBan(_changeID) == false) //nếu xảy ra trùng > Refresh mã CTHD_Ban mới sau đó kt lại
                                {
                                    _changeID = hdbBUS.taoMaCTHDBan();
                                }
                                cT_HOADONBANTableAdapter.Insert(_changeID, _maHDBan, dgvBanLK.Rows[i].Cells[0].Value.ToString(),
                                    Convert.ToInt32(dgvBanLK.Rows[i].Cells[3].Value.ToString()), Convert.ToDecimal(dgvBanLK.Rows[i].Cells[4].Value.ToString()),
                                    ThanhTien(Convert.ToInt32(dgvBanLK.Rows[i].Cells[3].Value.ToString()), Convert.ToDecimal(dgvBanLK.Rows[i].Cells[4].Value.ToString())));
                                //cap nhat lại số lượng trong kho
                                lkBUS.CapNhatLaiSoLuongKhiBan(dgvBanLK.Rows[i].Cells[0].Value.ToString(), _maHDBan);
                            }
                            MessageBox.Show("Thêm hóa đơn " + _maHDBan + " thành công", "Thông báo");                
                            ucBanLK_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Có linh kiện" + listTenLKVuotSLTon() + "trong giỏ hàng không đủ số lượng để cung cấp (Số lượng tồn < Số lượng cần bán) !! Vui lòng kiểm tra lại");
                        }
                         
                    }
                    else
                    {
                        MessageBox.Show("Trùng Mã Hóa đơn bán trong hệ thống !! Vui lòng thử lại","Thông báo");
                        ucBanLK_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Giỏ hàng đàng rỗng !!", "Thông báo");
                    txt_SoLuong.Focus();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập điền đầy đủ thông tin","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private string listTenLKVuotSLTon()
        {
            string s = "";
            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
                if (lkBUS.laySLLK_LINHKIEN(dgvBanLK.Rows[i].Cells[0].Value.ToString()) < Convert.ToInt32(dgvBanLK.Rows[i].Cells[3].Value.ToString()))
                {
                    s +=" ["+ dgvBanLK.Rows[i].Cells[0].Value.ToString() + "] ";
                }
            return s;
        }

        private int kiemtraLKTrongKho()
        {
            int _flag = 1;
            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
                if (lkBUS.laySLLK_LINHKIEN(dgvBanLK.Rows[i].Cells[0].Value.ToString()) < Convert.ToInt32(dgvBanLK.Rows[i].Cells[3].Value.ToString()))
                {
                    return 0;
                    break;
                }
            return _flag;
        }



        private bool timKiemBarcodeInCart(string _barcode)
        {
            for (int i = 0; i < dgvBanLK.Rows.Count; i++)
            {
                if (dgvBanLK.Rows[i].Cells[0].Value.ToString() == _barcode)
                {
                    return true;
                    break;
                }
            }
                return false;
        }

        private decimal? ThanhTien(int p1, decimal p2)
        {
            return p1 * p2;
        }    

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlLinhKienMayTinh1);

        }

        private void txt_SoLuong_Leave(object sender, EventArgs e)
        {
            if (!IsNumber(txt_SoLuong.Text))
            {
                MessageBox.Show("Thông tin Số lượng không hợp lệ !!","Thông tin");
                txt_SoLuong.Text = "";
            }
        }

        public bool IsNumber(string pValue)
        {
                 foreach (Char c in pValue)
                 {
                        if (!Char.IsDigit(c) || c=='0')
                             return false;
                 }
                 return true;
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
