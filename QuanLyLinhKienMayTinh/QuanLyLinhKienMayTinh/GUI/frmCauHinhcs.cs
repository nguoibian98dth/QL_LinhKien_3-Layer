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
using BUS;

namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class frmCauHinhcs : DevExpress.XtraEditors.XtraForm
    {
        public frmCauHinhcs()
        {
            InitializeComponent();
        }

        string _serverName = "";
        configBUS conf = new configBUS();

        private void frmCauHinhcs_Load(object sender, EventArgs e)
        {          
        }



        private bool CheckedBeforSearchNameDB()
        {
            if (cbx_serverName.Text == string.Empty)
            {
                XtraMessageBox.Show("Server Name chưa được chọn hoặc nhập", "Thông Báo");
                return false;
            }
            if (txtUserId.Text == string.Empty)
            {
                XtraMessageBox.Show("User Name chưa được nhập", "Thông Báo");
                return false;
            }
            if (txtPass.Text == string.Empty)
            {
                XtraMessageBox.Show("Password chưa được nhập", "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            conf.ChangeConnectionString(cbx_serverName.Text, cbx_DBname.Text,
                txtUserId.Text, txtPass.Text);
            this.Close();
        }

        private void cbx_serverName_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbx_DBname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_serverName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbx_serverName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = conf.GetServerName();
            cbx_serverName.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cbx_serverName.Items.Add(row[col]);
                }
            }
        }

        private void cbx_DBname_DropDown(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbx_DBname.Items.Clear();
                List<string> _list = conf.GetDatabaseName(cbx_serverName.Text,
                txtUserId.Text, txtPass.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cbx_DBname.Items.Add(item);
                }
            }
        }

    }
}