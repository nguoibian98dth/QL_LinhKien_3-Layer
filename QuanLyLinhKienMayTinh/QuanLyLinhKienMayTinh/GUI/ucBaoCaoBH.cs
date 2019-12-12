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
    public partial class ucBaoCaoBH : UserControl
    {
        BaoCaoBanHangBUS bc = new BaoCaoBanHangBUS();
        public ucBaoCaoBH()
        {
            InitializeComponent();
        }

        string maHDB = "";

        private void gbxdoanhthuadmin_Enter(object sender, EventArgs e)
        {

        }


        private void ucBaoCaoBH_Load(object sender, EventArgs e)
        {
            grdBXH_LK.DataSource = bc.layDuLieuBXH_LK();
            grdBXH_NV.DataSource = bc.layDuLieuBXH_NV();
            //grdHDB.DataSource = BaoCaoBanHangBUS.layDuLieuHDB();

            this.dsHDB_sttIsTrueTableAdapter.Fill(this.qLLinhKienMayTinh.dsHDB_sttIsTrue);
 
            gridViewHDB.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewHDB.OptionsBehavior.Editable = false;

            gridViewBXH_LK.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewBXH_LK.OptionsBehavior.Editable = false;

            gridViewBXH_NV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewBXH_NV.OptionsBehavior.Editable = false; 

        }

        private void grdHDB_Click(object sender, EventArgs e)
        {
            int rowHandle = gridViewHDB.FocusedRowHandle;
            maHDB = gridViewHDB.GetRowCellValue(rowHandle, "MaHD").ToString();

            this.ct_hdb_sttIsTrueTableAdapter.Fill_dk(this.qLLinhKienMayTinh.ct_hdb_sttIsTrue, maHDB);
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Excel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận thông tin Export","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                FolderBrowserDialog chuc = new FolderBrowserDialog();
      
                if (chuc.ShowDialog()==DialogResult.OK)
                {
                    string filePath = chuc.SelectedPath + "\\Export_BaoCao.xls";
                    grdHDB.ExportToXls(filePath); 
                }
            }
        }

        private void lbl_Word_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Pdf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thông tin Export", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FolderBrowserDialog chuc = new FolderBrowserDialog();
               
                if (chuc.ShowDialog() == DialogResult.OK)
                {
                    string filePath = chuc.SelectedPath + "\\Export_BaoCao.pdf";
                    grdHDB.ExportToPdf(filePath);
                }
            }
        }

    }
}
