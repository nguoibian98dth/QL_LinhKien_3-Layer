using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using BUS;
using DTO;


namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucThamSo : UserControl
    {
        public ucThamSo()
        {
            InitializeComponent();
        }

        ThamSoBUS tsB = new ThamSoBUS();
        ThamSo ts = new ThamSo();
        DataTable dtThamso = new DataTable();
        int flag = 0;
        LinhKienBUS lkBUS = new LinhKienBUS();

        private void ucThamSo_Load(object sender, EventArgs e)
        {
            dtThamso = tsB.getTS();
        
            LayMaTS();
            HienThongTin();
            AnTextBox();
        }

        public void AnTextBox()
        {
            txt_MuaToiDa.Enabled = false;
            txt_TonToiDa.Enabled = false;
            txt_TonToiThieu.Enabled = false;
            txt_TiGia.Enabled = false;
            txt_BanToiDa.Enabled = false;
        }

        public void HienTextBox()
        {
            txt_MuaToiDa.Enabled = true;
            txt_TonToiDa.Enabled = true;
            txt_TonToiThieu.Enabled = true;
            txt_TiGia.Enabled = true;
            txt_BanToiDa.Enabled = true;
        }

        public void LayMaTS()
        {
            if (dtThamso.Rows.Count > 0)
            {
                for (int i = 0; i < dtThamso.Rows.Count; i++)
                {
                    lblmaTS.Text = dtThamso.Rows[i].ItemArray[0].ToString();
                }
            }
            else
            {
                lblmaTS.Text = "";
            }
        }

        private bool checkDauVao()
        {

            if (txt_TiGia.Text == string.Empty || txt_MuaToiDa.Text == string.Empty || txt_TonToiDa.Text == string.Empty || txt_BanToiDa.Text == string.Empty)
                return false;
            return true;
        }

        public void LayGiaTriThamSo()
        {
            ts.TiLeGiaBan = int.Parse(txt_TiGia.Text);
            ts.SLMuaToiDa = int.Parse(txt_MuaToiDa.Text);
            ts.SLTonToiDa = int.Parse(txt_TonToiDa.Text);
            ts.SLTonToiThieu = int.Parse(txt_TonToiThieu.Text);
            ts.SLBanToiDa = int.Parse(txt_BanToiDa.Text);
        }

        public void HienThongTin()
        {
            txt_TiGia.Text = dtThamso.Rows[0].ItemArray[1].ToString();
            txt_MuaToiDa.Text = dtThamso.Rows[0].ItemArray[2].ToString();
            txt_TonToiDa.Text = dtThamso.Rows[0].ItemArray[3].ToString();
            txt_TonToiThieu.Text = dtThamso.Rows[0].ItemArray[4].ToString();
            txt_BanToiDa.Text = dtThamso.Rows[0].ItemArray[5].ToString();
        }

        

        private void btn_update_Click(object sender, EventArgs e)
        {            
            if (flag == 0)
            {
                btn_update.Text = "Lưu";
                btn_cancel.Enabled = true;
                flag = 1;
                HienTextBox();
                txt_TiGia.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn thay đổi những Tham số này không ? Việc thay đổi này sẽ cập nhật lại toàn bộ giá bán Linh kiện hiện tại. Bấm OK nếu bạn muốn tiếp tục.\n[Gợi ý]: Nên thay đổi tham số khi cuối ngày để tránh ảnh hưởng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        if (checkDauVao())
                        {
                            if(Convert.ToInt32(txt_TiGia.Text) <= 100)
                            {
                                LayGiaTriThamSo();
                                if (tsB.UpdateTS(lblmaTS.Text,int.Parse(txt_TiGia.Text),int.Parse(txt_MuaToiDa.Text),int.Parse(txt_TonToiDa.Text),int.Parse(txt_TonToiThieu.Text),int.Parse(txt_BanToiDa.Text)))
                                {
                                    btn_update.Text = "Cập Nhật";


                                    List<string> listIDlk = new List<string>();
                                    listIDlk = (List<string>)lkBUS.getIDsLK();

                                    List<decimal?> listGiaNhap = new List<decimal?>();
                                    listGiaNhap = lkBUS.getAllGiaNhapLK();

                                    for (int i = 0; i < listIDlk.Count; i++)
                                    {
                                        double loiNhuan = Int32.Parse(txt_TiGia.Text) / 100.0;
                                        decimal? gialkMoi = listGiaNhap[i] + (decimal)loiNhuan * listGiaNhap[i];
                                        gIA_LKTableAdapter.Insert(listIDlk[i].ToString(), Convert.ToDateTime(DateTime.Now.ToShortDateString()), gialkMoi);
                                    }
                                    ucThamSo_Load(sender, e);
                                    flag = 0;
                                    MessageBox.Show("Sửa Thông Tin Của Tham Số <<" + lblmaTS.Text.ToString() + ">> và cập nhật giá Linh kiện mới Thành Công!!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ucThamSo_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Sửa Thông Tin Của Tham Số <<" + lblmaTS.Text.ToString() + ">> Thất Bại!!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ucThamSo_Load(sender, e);
                            }
                        }
                        else
                            {
                                MessageBox.Show("Tỉ lệ giá bán phải <= 100% !!","Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tham số định mức chỉ được thay đổi 1 lần/ngày !!", "Thông báo");
                        ucThamSo_Load(sender, e);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ucThamSo_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listIDlk = new List<string>();
                listIDlk = (List<string>)lkBUS.getIDsLK();

                List<decimal?> listGiaNhap = new List<decimal?>();
                listGiaNhap = lkBUS.getAllGiaNhapLK();

                for (int i = 0; i < listIDlk.Count; i++)
                {
                    double loiNhuan = Int32.Parse(txt_TiGia.Text) / 100.0 ;
                    decimal? gialkMoi = listGiaNhap[i] + (decimal)loiNhuan*listGiaNhap[i];
                    gIA_LKTableAdapter.Insert(listIDlk[i].ToString(), Convert.ToDateTime(DateTime.Now.ToShortDateString()), gialkMoi);
                }

                MessageBox.Show("Thành công !!");
            }
            catch
            {
                MessageBox.Show("Tham số định mức chỉ được thay đổi 1 lần/ngày !!", "Thông báo");
            }
        }

        private void gIA_LKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIA_LKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void txt_TiGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (e.KeyChar == '.'))
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
