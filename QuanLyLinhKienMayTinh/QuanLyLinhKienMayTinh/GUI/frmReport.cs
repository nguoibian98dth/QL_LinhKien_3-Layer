using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }
        public static string _maHD;

        private void btnshow_Click(object sender, EventArgs e)
        {

            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 rep = new CrystalReport1();
            rep.SetDatabaseLogon("sa", "sa2012");
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
            rep.SetParameterValue("MaHDB", _maHD);
        }
    }
}