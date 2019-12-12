using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucQLLinhKien : UserControl
    {
        public ucQLLinhKien()
        {
            InitializeComponent();
        }
        //
        DateTime now = DateTime.Now;
        LinhKien lk = new LinhKien();
        Gia_LK glk = new Gia_LK();
        string _loailk = "1";
        string _ncc = "NCC001";
        bool _flag;
        int NumStrong;
        int _selectedRowIndex;
        LinhKienBUS lkBUS = new LinhKienBUS();
        KiemTraHopLe kt = new KiemTraHopLe();
        //

        private void ucQLLinhKien_Load(object sender, EventArgs e)
        {
            dgvDanhSachLK.DataSource = lkBUS.DanhsachLK();
            BingdingThongTinLK();
            LayGiaTri();
            dgvBangGiaLK.DataSource = lkBUS.DanhsachGiaLK(lk);
            //
            cbxLoaiLK.DataSource = lkBUS.LayDSLoaiLK();
            cbxLoaiLK.ValueMember = "MaLoai";
            cbxLoaiLK.DisplayMember = "TenLoai";

            cbxNhaCC.DataSource = lkBUS.LayDSNhaCC();
            cbxNhaCC.ValueMember = "MaNCC";
            cbxNhaCC.DisplayMember = "TenNCC";
            
            AnTextBox();
            AnButtonLuuHuy();

            

            btnThemLK.Enabled = true;
            btnXoaLK.Enabled = true;
            btnSuaLK.Enabled = true;
            btnSuaTTLK.Enabled = false;
            btnSuaGiaLK.Enabled = false;
        }

        private void BingdingThongTinLK()
        {
            txtMaLK.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[0].Value.ToString();
            txtTenLK.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[1].Value.ToString();
            cbxLoaiLK.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[2].Value.ToString();         
            txtNhaSX.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[4].Value.ToString();
            txtXuatXu.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[5].Value.ToString();
            txtNamSX.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[6].Value.ToString();
            cbxNhaCC.Text = dgvDanhSachLK.Rows[_selectedRowIndex].Cells[7].Value.ToString();
            double gia = Convert.ToDouble(dgvDanhSachLK.Rows[_selectedRowIndex].Cells[3].Value.ToString());
            txtDonGia.Text = String.Format("{0:0,0}", gia);

        }

        private void LayGiaTri()
        {
            lk.Str_MaLK = txtMaLK.Text;
            lk.Str_TenLK = txtTenLK.Text;
            lk.NamSX1 = Convert.ToInt32(txtNamSX.Text);
            lk.Str_NSX = txtNhaSX.Text;
            lk.Str_XuatXu = txtXuatXu.Text;
            lk.Str_MaNCC = _ncc;
            lk.Str_LoaiLK = _loailk;
            lk.SoLuong1 = 0;
            //
            glk.GiaBan1 = txtDonGia.Text;
            //glk.NgayApDung1 = now.ToString();
            glk.NgayApDung1 = "1/1/1990";
            glk.Str_maLK = lk.Str_MaLK;

        }

        private void AnTextBox()
        {
            txtMaLK.Enabled = false;
            txtTenLK.Enabled = false;
            txtNhaSX.Enabled = false;
            txtXuatXu.Enabled = false;
            txtNamSX.Enabled = false;
            txtDonGia.Enabled = false;
            cbxLoaiLK.Enabled = false;
            cbxNhaCC.Enabled = false;
        }
        private void HienTextBox()
        {
            // txtMaLK.Enabled = true;
            txtTenLK.Enabled = true;
            txtNhaSX.Enabled = true;
            txtXuatXu.Enabled = true;
            txtNamSX.Enabled = true;
            txtDonGia.Enabled = true;
            cbxLoaiLK.Enabled = true;
            cbxNhaCC.Enabled = true;
        }

        private void AnButtonLuuHuy()
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void HienButtonLuuHuy()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void dgvDanhSachLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRowIndex = e.RowIndex;
            if (_selectedRowIndex != -1)
            {
                BingdingThongTinLK();
                LayGiaTri();
                dgvBangGiaLK.DataSource = lkBUS.DanhsachGiaLK(lk);
            }
            else
            {
                _selectedRowIndex = 1;
                BingdingThongTinLK();
            }

            btnInMa.Enabled = true;
        }

        private void txtMaLK_TextChanged(object sender, EventArgs e)
        {
            string barCode = txtMaLK.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picboxBarcode.Image = brcode.Draw(barCode, 60);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInMa_Click(object sender, EventArgs e)
        {
            Gia_LK glk = new Gia_LK();
            glk = lkBUS.LayGiaLinhKien(txtMaLK.Text);
            string laygia = String.Format("{0:0,0}", glk.GiaBan1);
            if (laygia != "0.0000")
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += doc_PrintPage;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
            else
            {
                MessageBox.Show("Hiện chưa có giá cho linh kiện này nên không thể in !!", "Thông báo");
            }
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Gia_LK glk = new Gia_LK();
                glk = lkBUS.LayGiaLinhKien(txtMaLK.Text);
                double giaLK = Convert.ToDouble(glk.GiaBan1);
                string laygia = String.Format("{0:0,0}", giaLK);
                if (laygia != "00")
                {
                    Bitmap bm = new Bitmap(picboxBarcode.Width, picboxBarcode.Height);
                    picboxBarcode.DrawToBitmap(bm, new Rectangle(0, 0, picboxBarcode.Width, picboxBarcode.Height));
                    e.Graphics.DrawImage(bm, 0, 0);
                    //in malk
                    e.Graphics.DrawString(txtMaLK.Text, new System.Drawing.Font("Tahoma", 9), new SolidBrush(Color.Black), new PointF(45f, 79f));
                    //in gia
                    e.Graphics.DrawString(laygia + " VNĐ", new System.Drawing.Font("Tahoma", 9), new SolidBrush(Color.Black), new PointF(45f, 0f));
                    bm.Dispose();
                }
                else
                {
                    MessageBox.Show("Hiện chưa có giá cho linh kiện này nên không thể in !!", "Thông báo");
                }
            }
            catch
            { 
            }
        }

        private void btnThemLK_Click(object sender, EventArgs e)
        {
            HienTextBox();
            ClearTextboxes();
            txtMaLK.Text = lkBUS.TaoMa();
            HienButtonLuuHuy();
            btnSuaLK.Enabled = false;
            btnXoaLK.Enabled = false;
            btnThemLK.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonGia.Text = "0";
            _flag = true;
            NumStrong = 1;
        }

        private void ClearTextboxes()
        {
            // txtMaLK.Clear();
            txtTenLK.Clear();
            txtDonGia.Clear();
            txtNamSX.Clear();
            txtNhaSX.Clear();
            txtXuatXu.Clear();
        }

        private void btnXoaLK_Click(object sender, EventArgs e)
        {
            try
            {
                LayGiaTri();
                DialogResult re = MessageBox.Show("Bạn có chắc muốn xóa thông tin linh kiện [" + lk.Str_TenLK.ToString() + "] này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    if(lkBUS.XoaLK(lk, glk))
                    {
                        MessageBox.Show("Xóa thông tin linh kiện [" + lk.Str_TenLK.ToString() + "] thành công", " Thông báo");
                      
                        ucQLLinhKien_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaLK_Click(object sender, EventArgs e)
        {
            btnSuaLK.Enabled = false;
            btnSuaTTLK.Enabled = true;
            btnThemLK.Enabled = false;
            btnXoaLK.Enabled = false;
            btnInMa.Enabled = false;
            _flag = true;
        }

        private void btnSuaGiaLK_Click(object sender, EventArgs e)
        {
            txtDonGia.Enabled = true;
            btnSuaTTLK.Enabled = false;
            HienButtonLuuHuy();
            NumStrong = 2;
        }

        private void btnSuaTTLK_Click(object sender, EventArgs e)
        {
            btnSuaTTLK.Enabled = false;
            HienTextBoxSuaTT();
            btnSuaGiaLK.Enabled = false;
            HienButtonLuuHuy();
            NumStrong = 3;
        }


        private void HienTextBoxSuaTT()
        {
            txtTenLK.Enabled = true;
            txtNhaSX.Enabled = true;
            txtXuatXu.Enabled = true;
            txtNamSX.Enabled = true;
            cbxLoaiLK.Enabled = true;
            cbxNhaCC.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt.KiemTraDauVao(txtTenLK.Text, cbxLoaiLK.Text, txtNhaSX.Text, txtXuatXu.Text, txtNamSX.Text, cbxNhaCC.Text, txtDonGia.Text) == true)
                {
                    if (_flag == true)
                    {
                        LayGiaTri();
                        while (lkBUS.kiemtraTrungIdLK(lk.Str_MaLK) == false) //nếu xảy ra trùng > Refresh mã lk mới sau đó kt lại
                        {
                            lk.Str_MaLK = lkBUS.TaoMa();
                        }
                        if (NumStrong == 1)// btn thêm đang bật
                        {
                            //LayGiaTri();
                            if (lkBUS.ThemLinhKien(lk))
                            {
                                if (lkBUS.ThemGia_LK(glk))
                                {
                                    MessageBox.Show("Thêm Linh Kiện [" + lk.Str_TenLK.ToString() + "] Thành Công", "Thông báo");
                                    ucQLLinhKien_Load(sender, e);
                                }
                            }
                        }
                        if (NumStrong == 2)//btn sua giá lk đang bật
                        {
                        //    lkBUS.CapNhatGiaLinhKien(glk);
                        //    dgvDanhSachLK.DataSource = lkBUS.DanhsachLK();
                        //    dgvBangGiaLK.DataSource = lkBUS.DanhsachGiaLK(lk);
                        //    txtDonGia.Enabled = false;
                        //    ucQLLinhKien_Load(sender, e);
                        }
                        if (NumStrong == 3)//btn sua thong tin linh kiện đang bật
                        {
                            LayGiaTri();
                            if (lkBUS.SuaTTLinhKien(lk))
                            {
                                MessageBox.Show("Sửa thông tin linh kiện thành công", "Thông báo");
                                ucQLLinhKien_Load(sender, e);
                            }
                        }                      
                    }                  
                }

                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin hiện có !!");
                    btnLuu.Enabled = true;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ucQLLinhKien_Load(sender,e);
            btnSuaLK.Enabled = true;
            btnThemLK.Enabled = true;
            btnXoaLK.Enabled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (e.KeyChar == '.'))
                e.Handled = true;
        }

        private void cbxLoaiLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLoaiLK.SelectedIndex != -1)
            {
                if (this.cbxLoaiLK.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    _loailk = cbxLoaiLK.SelectedValue.ToString();
                }
            }
        }

        private void cbxNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNhaCC.SelectedIndex != -1)
            {
                if (this.cbxNhaCC.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    _ncc = cbxNhaCC.SelectedValue.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoaiLKcs loailk = new frmLoaiLKcs();
            loailk.ShowDialog();
        }
    }
}
