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
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucXuatLK : DevExpress.XtraEditors.XtraUserControl
    {
        public ucXuatLK()
        {
            InitializeComponent();
        }


        XuatLinhKienBUS xlkBUS = new XuatLinhKienBUS();
        LinhKienBUS lkBUS = new LinhKienBUS();

        public static string _maNV;

        int _DSrong = 0, _trangThai = 0;
        int _itemIndex;
        string _maBanLK, _tenKH , _maPX, _maCTPX;
        string _maHDB;
        string _maKH;
        DateTime _ngayXuat;

        DataTable dtCT_BanLK = new DataTable();

        public void LayDLCholbxDanhSachHDB()
        {
            DataTable dtBanLK = xlkBUS.LayDSHoaDon_BanHang();
            if (dtBanLK.Rows.Count > 0)
            {
                _DSrong = 1;
                for (int i = 0; i < dtBanLK.Rows.Count; i++)
                {
                    lbx_DanhSachHDB.Items.Add(dtBanLK.Rows[i].ItemArray[0].ToString());
                }
            }
            else
            {
                lbx_DanhSachHDB.Items.Add("[ DS Rỗng ]");
                lbx_DanhSachHDB.Enabled = false;
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucXuatLK_Load(object sender, EventArgs e)
        {
            LayDLCholbxDanhSachHDB();
            timer1_Tick(sender, e);
            lblMaNV.Text = _maNV;
            lblMaKH.Text = "";
            dgvChiTiet.DataSource ="";
            
        }

        private void lbx_DanhSachHDB_MouseClick(object sender, MouseEventArgs e)
        {
            if (_DSrong == 1)
            {
                _trangThai = 1;
                btn_export.Enabled = true;
                
            }
        }

        private void getAllInfo()
        {
           _ngayXuat = Convert.ToDateTime(DateTime.Now.ToShortDateString());           
           _maHDB=lbx_DanhSachHDB.SelectedItem.ToString();
           _maKH = xlkBUS.layIdKH(_maHDB);
           _maCTPX = taoMaCTPX();
        }

        private string taoMaCTPX()
        {
            Random rand = new Random();
            string a = rand.Next(10000000, 99999999).ToString();
            return  a + lkBUS.RandomString(3, true);
        }

        private string taoMaPX()
        {
            string title = "PX";
            Random rand = new Random();
            string a = rand.Next(100000, 999999).ToString();
            return title + a + lkBUS.RandomString(3, true);
        }

        private void lbx_DanhSachHDB_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (lbx_DanhSachHDB.SelectedIndex != -1)
            {
                if (lbx_DanhSachHDB.Items[_itemIndex].ToString() != "")
                {
                    if (_trangThai == 1)
                    {
                        _maBanLK = lbx_DanhSachHDB.Items[_itemIndex].ToString();
                        dtCT_BanLK = xlkBUS.LayCT_HoaDonBan(_maBanLK);
                        lblMaKH.Text = _tenKH;
                        dgvChiTiet.DataSource = dtCT_BanLK;
                        string _maKH = xlkBUS.layIdKH(lbx_DanhSachHDB.Items[_itemIndex].ToString());
                        string _tenKH2 = xlkBUS.layTenKH(_maKH);
                        lblMaKH.Text = _maKH + " - " + _tenKH2;
                    }
                }
            }
        }


        private void lbx_DanhSachHDB_Click(object sender, EventArgs e)
        {
            if (lbx_DanhSachHDB.Items.Count > 0)
            {
                try
                {
                    _itemIndex = lbx_DanhSachHDB.SelectedIndex;
                }
                catch
                {
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            lblNgayXuatKho.Text = s;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (lblMaKH.Text != "")
            {
                getAllInfo();

                _maPX = taoMaPX();
                while (xlkBUS.kiemtraTrungIdPX(_maPX) == false) //nếu xảy ra trùng > Refresh mã CTPX mới sau đó kt lại
                {
                    _maPX = taoMaPX();
                }
                //1.add phieu xuat
                pHIEUXUATTableAdapter.Insert(_maPX, _maHDB, _maKH, _maNV, _ngayXuat);
                //2.add ct phieu xuất
                for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                {
                    string _maLK= dgvChiTiet.Rows[i].Cells[0].Value.ToString();

                    _maCTPX = taoMaCTPX();
                    while (xlkBUS.kiemtraTrungIdCTPX(_maCTPX) == false) //nếu xảy ra trùng > Refresh mã CTPX mới sau đó kt lại
                    {
                        _maCTPX = taoMaCTPX();
                    }

                    int _sl= Convert.ToInt32(dgvChiTiet.Rows[i].Cells[4].Value.ToString());
                    
                    cT_PHIEUXUATTableAdapter.Insert(_maCTPX, _maPX, _maLK, _sl,string.Empty);
                    
                }
                //3.cap nhập true cho hdb
                xlkBUS.capNhatTinhTrangHDB(_maHDB);


                if (MessageBox.Show("Vui lòng kiểm tra dầy đủ hàng trước khi xuất kho !! Nhấn OK để tiếp tục", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MessageBox.Show("Xuất kho thành công !!", "Thông báo");
                    lbx_DanhSachHDB.Items.Clear();                  
                    ucXuatLK_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Hóa đơn cần lập Phiếu Xuất kho !!", "Thông báo");
            }
        }

        private void pHIEUXUATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUXUATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void pHIEUXUATBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUXUATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }
    }
}
