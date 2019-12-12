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
using DTO;
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucInHDB : DevExpress.XtraEditors.XtraUserControl
    {
        public ucInHDB()
        {
            InitializeComponent();
        }

        HoaDonBanBUS hdbBUS = new HoaDonBanBUS();
        public static string _maNV;


        private void ucInHDB_Load(object sender, EventArgs e)
        {
            dgvHDB.DataSource= hdbBUS.LayDSHoaDonBan(_maNV);
        }

        

        private void addButtonInDGV()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "In hóa đơn";
            button.Name = "btnInHDB";
            button.Text = "In HĐB";
            button.UseColumnTextForButtonValue = true;
            dgvHDB.Columns.Add(button);
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string _maHDB="";
            string _maKH="";
            if (e.ColumnIndex == 0 && e.RowIndex != -1 )
            {
                _maHDB = dgvHDB.Rows[e.RowIndex].Cells[1].Value.ToString();
                _maKH = dgvHDB.Rows[e.RowIndex].Cells[3].Value.ToString();

                //truyền biến
                frmReport re = new frmReport();
                frmReport._maHD = _maHDB;
                re.Show();
            }          
        }

        private void dgvHDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

    }
}
