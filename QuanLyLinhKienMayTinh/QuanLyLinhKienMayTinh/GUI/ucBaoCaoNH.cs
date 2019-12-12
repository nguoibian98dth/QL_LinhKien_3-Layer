using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;


namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucBaoCaoNH : UserControl
    {
        BaoCaoNhapHangBUS bc = new BaoCaoNhapHangBUS();
        public ucBaoCaoNH()
        {
            InitializeComponent();
        }
        string maHDM = "";

        private void ucBaoCaoNH_Load(object sender, EventArgs e)
        {
            gc_solandat.DataSource = bc.GetSoLanDat();
            gc_linhkiennhapnhieu.DataSource = bc.GetLKnhapnhieu();

            this.dsHDM_TTisTrueTableAdapter.Fill(this.qLLinhKienMayTinh.dsHDM_TTisTrue);

            gv_bangtong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_bangtong.OptionsBehavior.Editable = false;

            gv_solandat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_solandat.OptionsBehavior.Editable = false;

            gv_linhkiennhapnhieu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_linhkiennhapnhieu.OptionsBehavior.Editable = false;

            gv_chitietphieunhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gv_chitietphieunhap.OptionsBehavior.Editable = false; 
        }

        private void gc_bangtong_Click(object sender, EventArgs e)
        {
            int rowHandle = gv_bangtong.FocusedRowHandle;
            maHDM = gv_bangtong.GetRowCellValue(rowHandle, "MaHD").ToString();

            this.ct_hdmisTrueTableAdapter.Fill(this.qLLinhKienMayTinh.ct_hdmisTrue, maHDM);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void lbl_Excel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thông tin Export", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FolderBrowserDialog chuc = new FolderBrowserDialog();

                if (chuc.ShowDialog() == DialogResult.OK)
                {
                    string filePath = chuc.SelectedPath + "\\Export_BaoCao.xls";
                    gv_bangtong.ExportToXls(filePath);
                }
            }
        }

        private void lbl_Pdf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thông tin Export", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FolderBrowserDialog chuc = new FolderBrowserDialog();

                if (chuc.ShowDialog() == DialogResult.OK)
                {
                    string filePath = chuc.SelectedPath + "\\Export_BaoCao.pdf";
                    gv_bangtong.ExportToPdf(filePath);
                }
            }
        }
    }
}
