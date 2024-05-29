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

namespace TN_CSDLPT
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Fill(this.dS_DSGV_CHUATK.V_DS_GIAOVIENCHUACOTK);
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            //set ve tai khoan cu
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TenCS";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedItem = Program.mChinhanh;

            if (comboBox_CN.SelectedIndex == -1) return;
            try
            {
                Program.servername = comboBox_CN.SelectedValue.ToString();
            }
            catch (Exception) { }
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Fill(this.dS_DSGV_CHUATK.V_DS_GIAOVIENCHUACOTK);

            if (Program.mNhom.Equals("truong"))
            {
                Program.servername = comboBox_CN.SelectedValue.ToString();
                radioButton_Truong.Checked = true;
                radioButton_Coso.Enabled = false;
                radioButton_Giangvien.Enabled = false;
            }
            else if (Program.mNhom.Equals("coso"))
            {
                radioButton_Truong.Enabled = false;
                radioButton_Coso.Checked = true;
                radioButton_Giangvien.Enabled = true;
                comboBox_CN.Enabled = false;
            }
            if (bdsGV.Count == 0)
            {
                button_DK.Enabled = false;
            }
        }



        private void button_DK_Click(object sender, EventArgs e)
        {

            if (textBox_LoginName.Text.Trim() == "" || textBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password của giảng viên không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            String role = "";
            if (radioButton_Truong.Checked)
            {
                role = "truong";

            }
            else if (radioButton_Coso.Checked)
            {
                role = "coso";
            }
            else
            {
                role = "giangvien";
            }

            Program.servername = comboBox_CN.SelectedValue.ToString();
            if (comboBox_CN.SelectedIndex.ToString() != Program.mChinhanh)
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
            
            string strLenh = "EXEC SP_TAOTAIKHOAN '" +
                textBox_LoginName.Text.Trim() + "', '" + textBox_Password.Text.Trim()
                + "', '" + TextBox_Username.Text.Trim() + "', '" + role + "'";
            int kq = Program.ExecSqlNonQuery(strLenh);

            if (kq != 0) return;
            MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);

            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Fill(this.dS_DSGV_CHUATK.V_DS_GIAOVIENCHUACOTK);//reload
            if (bdsGV.Count == 0)
            {
                button_DK.Enabled = false;
            }
        }

        private void bdsGV_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void hOTENComboBox_Format(object sender, ListControlConvertEventArgs e)
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