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
    public partial class frmKQThi : DevExpress.XtraEditors.XtraForm
    {
        private String ngay = null;
        
        public frmKQThi()
        {
            InitializeComponent();
        }

        private void frmKQThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.ds1.SINHVIEN);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.ds1.LOP);
   
            comboBox_TenCN.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_TenCN.DisplayMember = "TenCS";
            comboBox_TenCN.ValueMember = "TENSERVER";
            comboBox_TenCN.SelectedItem = Program.mChinhanh;
            //coso,truong,gv dc truy cap
            if (Program.mNhom == "coso")
            {
                comboBox_TenCN.Enabled = false;
            }
            if (Program.mNhom == "sinhvien")
            {
                comboBox_TenCN.Enabled = false;
                this.lOPTableAdapter.FillByMASV(this.ds1.LOP, Program.username);
                cbboxLOP.Enabled = false;
                cbHoTenSV.Text = Program.username;
                cbHoTenSV.Enabled = false;
            }
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {

            if (cbHoTenSV.SelectedIndex == -1) {
                MessageBox.Show("Vui lòng chọn sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            string strLenh = "SELECT NGAYTHI FROM BANGDIEM WHERE LAN=" + spin_Lanthi.Value + "AND MASV= N'" + cbHoTenSV.SelectedValue.ToString() + "' AND MAMH= N'" + cbbMH.SelectedValue.ToString() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null)
            {
                Program.myReader.Close();
                MessageBox.Show("Lỗi hệ thống", "", MessageBoxButtons.OK);
        
                return;
            }
            if (Program.myReader.Read() == false)
            {
                Program.myReader.Close();
                MessageBox.Show("Không có thông tin về kết quả thi", "", MessageBoxButtons.OK);
            
                return;
            }
            ngay = Program.myReader.GetDateTime(0).ToString("dd/MM/yyyy");
            Program.myReader.Close();
 
            XtraReport_XemKetQua rpXKQ = new XtraReport_XemKetQua(cbHoTenSV.SelectedValue.ToString(),
                cbbMH.SelectedValue.ToString(), 
                short.Parse(spin_Lanthi.Value.ToString()));

            rpXKQ.xrLabelLop.Text = cbboxLOP.Text;
            rpXKQ.xrLabelHoTen.Text = cbHoTenSV.Text;
            rpXKQ.xrLabelMonThi.Text = cbbMH.Text;
            rpXKQ.xrLabelNgayThi.Text = ngay.ToString();
            rpXKQ.xrLabelLan.Text = spin_Lanthi.Text;
            rpXKQ.xrLabelNguoiTaoForm.Text = Program.mHoten;
            ReportPrintTool report = new ReportPrintTool(rpXKQ);

            report.ShowPreviewDialog();       
            
        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                this.lOPTableAdapter.Fill(this.ds1.LOP);
               
            }
        }

        private void cbHoTenSV_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView rowView = e.ListItem as DataRowView;
            if (rowView != null)
            {
                string firstName = rowView["HO"] as string;
                string lastName = rowView["TEN"] as string;
                e.Value = firstName + " " + lastName;
            }
        }
    }
}