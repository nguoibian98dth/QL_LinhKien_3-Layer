using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        public static string _maNV;
        NguoiDungBUS ndBUS = new NguoiDungBUS();

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            List<int> listMaNhomND = ndBUS.ListMaNhomND(_maNV);
            load_PhanQuyen2(_maNV);

            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucIntroduction user = new ucIntroduction();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucIntroduction"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }

        }

        private void load_PhanQuyen2(string MaNV)
        {
            List<string> quyen = timMHVisable(MaNV);

            foreach (var item in ribbonControl1.Items)
            {
                if (item is BarButtonItem)
                {
                    BarButtonItem bbi = item as BarButtonItem;

                    if (quyen.Contains(bbi.Name) == true)
                        bbi.Visibility = BarItemVisibility.Always;
                }
            }
        }

        private List<string> timMHVisable(string maNV)
        {
            DataTable pq = ndBUS.layMaManHinhVisible(maNV);
            List<string> listMH = new List<string>();
            foreach (DataRow dr in pq.Rows)
            {
                listMH.Add(dr["MaManHinh"].ToString());
            }
            return listMH;
        }

        private void load_PhanQuyen(List<int> dsNhom)
        {
            foreach (int maNhom in dsNhom)
            {
                List<string> quyen = timMHLocked(maNhom);

                foreach (var item in ribbonControl1.Items)
                {
                    if (item is BarButtonItem)
                    {
                        BarButtonItem bbi = item as BarButtonItem;

                        if (quyen.Contains(bbi.Name) == true)
                            bbi.Visibility = BarItemVisibility.Never;
                    }
                }
            }
        }

        private List<string> timMHLocked(int maNhomND)
        { 
            DataTable pq= ndBUS.layMaManHinhBiKhoa(maNhomND);
            List<string> listMH = new List<string>();
            foreach (DataRow dr in pq.Rows)
            {
                if (Convert.ToInt32(dr["MaNhomND"].ToString()) == maNhomND && Convert.ToBoolean(dr["CoQuyen"].ToString()) == false)
                    listMH.Add(dr["MaManHinh"].ToString());
            }
            return listMH;
        }


        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucPhanQuyen user = new ucPhanQuyen();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucPhanQuyen"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucNhomQuyen user = new ucNhomQuyen();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucNhomQuyen"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucQLKhachHang user = new ucQLKhachHang();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucQLKhachHang"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucQLNhanVien user = new ucQLNhanVien();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucQLNhanVien"].BringToFront();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucNCC user = new ucNCC();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucNCC"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucNhapLK user = new ucNhapLK();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucNhapLK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucXuatLK user = new ucXuatLK();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucXuatLK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucMuaLK user = new ucMuaLK();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucMuaLK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {

            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucBaoCaoNH user = new ucBaoCaoNH();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucBaoCaoNH"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucBaoCaoBH user = new ucBaoCaoBH();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucBaoCaoBH"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void bbiLK_KD_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucBanLK user = new ucBanLK();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucBanLK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucBaoCaoKinhDoanh user = new ucBaoCaoKinhDoanh();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucBaoCaoKinhDoanh"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucQLNguoiDung user = new ucQLNguoiDung();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucQLNguoiDung"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucCaNhan user = new ucCaNhan();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucCaNhan"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucDoiMK user = new ucDoiMK();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucDoiMK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucInHDB user = new ucInHDB();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucInHDB"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucPhanQuyenMH user = new ucPhanQuyenMH();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucPhanQuyenMH"].BringToFront();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void M10_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucQLLinhKien user = new ucQLLinhKien();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucLK"].BringToFront();
            }
            catch (Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
        }

        private void M20_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (UserControl item in pnuser.Controls)
            {
                pnuser.Controls.Remove(item);
            }
            try
            {
                ucThamSo user = new ucThamSo();
                user.Dock = DockStyle.Fill;
                pnuser.Controls.Add(user);
                pnuser.Controls["ucThamSo"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            frmTacGia tg = new frmTacGia();
            tg.ShowDialog();

        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();

                frmDangNhap_dev f = new frmDangNhap_dev();
                f.Show();
            }
        }
    }
}