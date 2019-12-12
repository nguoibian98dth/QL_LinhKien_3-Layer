using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucThemNDvaoNhomND : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThemNDvaoNhomND()
        {
            InitializeComponent();
        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLLinhKienMayTinh);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.nD_NND1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.ND_NND1, ((int)(System.Convert.ChangeType(manhomNDToolStripTextBox.Text, typeof(int)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void nHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _nnd = "";
            if (nHOMNGUOIDUNGComboBox.SelectedIndex != -1)
            {
                if (this.nHOMNGUOIDUNGComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    _nnd = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();
                    this.nD_NND1TableAdapter.Fill_dk(this.qLLinhKienMayTinh.ND_NND1, ((int)(System.Convert.ChangeType(_nnd, typeof(int)))));

                }
            }
        }

        private void ucThemNDvaoNhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.ND_NND' table. You can move, or remove it, as needed.
            this.nD_NNDTableAdapter.Fill(this.qLLinhKienMayTinh.ND_NND);
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.ND_NND' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLLinhKienMayTinh.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.qLLinhKienMayTinh.NGUOIDUNG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = nGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
            int manhom = Convert.ToInt32(nHOMNGUOIDUNGComboBox.SelectedValue.ToString());
            nD_NNDTableAdapter.Insert(tk, manhom, string.Empty);
            MessageBox.Show("thêm thành công");
        }
    }
}
