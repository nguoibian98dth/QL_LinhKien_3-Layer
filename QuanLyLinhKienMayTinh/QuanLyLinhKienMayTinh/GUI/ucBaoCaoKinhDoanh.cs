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
using System.Globalization;


namespace QuanLyLinhKienMayTinh.GiaoDienDevExpress
{
    public partial class ucBaoCaoKinhDoanh : UserControl
    {
        public ucBaoCaoKinhDoanh()
        {
            InitializeComponent();
        }

        private int namBC, thangBC;
        public static string _maNV;
        ThongKeKinhDoanhBUS tkkd = new ThongKeKinhDoanhBUS();

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

       
        

        private void fillChartTheoNam()
        {
            chartDoanhThuBan.Titles.Clear();
            chartDoanhThuBan.DataSource = tkkd.layDL_DoanhThuBanTheoNam(namBC);
            chartDoanhThuBan.Series["Total_BeforeVAT"].XValueMember = "Month";
            chartDoanhThuBan.Series["Total_BeforeVAT"].YValueMembers = "Total_BeforeVAT";
            chartDoanhThuBan.Titles.Add("Tổng doanh thu thu được trong năm");
        }

        private void fillChartThangvaNam()
        {
            chartDoanhThuBan.Titles.Clear();
            chartDoanhThuBan.DataSource = tkkd.layDL_DoanhThuBanTheoThangvaNam(thangBC, namBC);
            chartDoanhThuBan.Series["Total_BeforeVAT"].XValueMember = "Day";
            chartDoanhThuBan.Series["Total_BeforeVAT"].YValueMembers = "Total_BeforeVAT";
            chartDoanhThuBan.Titles.Add("Tổng doanh thu thu được trong tháng");
        }


        private void ucBaoCaoKinhDoanh_Load(object sender, EventArgs e)
        {
            //namBC = Convert.ToInt32(numNamBC.Value);
            lblmaNV.Text = _maNV;
            lblNgay.Text = DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            
            
            //fillChart();

            if(Convert.ToInt32(numThangBC.Value)!= 0) // nếu value tháng =0 >> load nguyên năm
            {
                lblTongSLBanLK.Text = tkkd.laySLBanLKTheoThangvaNam(thangBC, namBC).ToString();
                lblTongDoanhThu.Text = String.Format("{0:0,0 VNĐ}", tkkd.layTongDoanhThuTheoThangvaNam(thangBC, namBC));
                lblLoiNhuan.Text = String.Format("{0:0,0 VNĐ}", tkkd.layTongLoiNhuanTheoThangvaNam(thangBC, namBC));

                fillChartThangvaNam();
            }
            else
            {
                lblTongSLBanLK.Text = tkkd.laySLBanLKTheoNam(namBC).ToString();
                lblTongDoanhThu.Text = String.Format("{0:0,0 VNĐ}", tkkd.layTongDoanhThuTheoNam(namBC));
                lblLoiNhuan.Text = String.Format("{0:0,0 VNĐ}", tkkd.layTongLoiNhuanTheoNam(namBC));

                fillChartTheoNam();
            }
        }

        private void numNamBC_ValueChanged(object sender, EventArgs e)
        {
            thangBC = Convert.ToInt32(numThangBC.Value);
            namBC = Convert.ToInt32(numNamBC.Value);
            ucBaoCaoKinhDoanh_Load(sender, e);
        }

        private void rbt_KD_CheckedChanged(object sender, EventArgs e)
        {
            ucBaoCaoKinhDoanh_Load(sender, e); 
        }

        private void rbt_Ton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong giai đoạn phát triển !!", "Thông báo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (e.KeyChar == '.'))
                e.Handled = true;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            thangBC = Convert.ToInt32(numThangBC.Value);
            namBC = Convert.ToInt32(numNamBC.Value);

            ucBaoCaoKinhDoanh_Load(sender, e);
        } 


    }
}
