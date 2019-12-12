using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLinhKienMayTinh.connectionEntity;


namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucNhomND : UserControl
    {
        public ucNhomND()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'qLLinhKienMayTinh.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
                this.nHOMNGUOIDUNGTableAdapter2.Fill(this.qLLinhKienMayTinh2.NHOMNGUOIDUNG);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void nHOMNGUOIDUNGBindingSource2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nHOMNGUOIDUNGBindingSource2.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.qLLinhKienMayTinh2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void nHOMNGUOIDUNGBindingSource2BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

    }
}
