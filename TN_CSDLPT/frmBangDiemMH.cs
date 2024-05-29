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
using DevExpress.XtraReports.UI;

namespace TN_CSDLPT
{
    public partial class frmBangDiemMH : DevExpress.XtraEditors.XtraForm
    {
  
        public frmBangDiemMH()
        {
            InitializeComponent();
        }

        private void frmBangDiemMH_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);


            comboBox_TenCN.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBox_TenCN.DisplayMember = "TenCS";
            comboBox_TenCN.ValueMember = "TENSERVER";
            comboBox_TenCN.SelectedItem = Program.mChinhanh;


            //coso,truong,gv dc truy cap
            if (Program.mNhom == "coso")
            {
                comboBox_TenCN.Enabled = false;
            }
        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TenCN.SelectedIndex == -1) return;
 
            Program.servername = comboBox_TenCN.SelectedValue.ToString();

            if (comboBox_TenCN.SelectedIndex.ToString() != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
      
            }
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {

            XtraReport_XemBangDiem rpBD = new XtraReport_XemBangDiem(cbboxLOP.SelectedValue.ToString(),
                cbboxMH.SelectedValue.ToString(),
                short.Parse(spinEditLAN.Value.ToString()));
            rpBD.lbLop.Text = cbboxLOP.Text;
            rpBD.lbMH.Text = cbboxMH.Text;
            rpBD.lbLanThi.Text = spinEditLAN.Value.ToString();
            rpBD.xrLabelNguoiTaoForm.Text = Program.mHoten;

            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}