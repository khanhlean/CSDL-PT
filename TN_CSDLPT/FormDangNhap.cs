using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FormDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private System.Windows.Forms.BindingSource bdsPM;
        public static frmMain frmChinh;

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TenCS"; cbCoSo.ValueMember = "TENSERVER";
        }

        public FormDangNhap()
        {
            InitializeComponent();
            
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher!=null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.");
                return 0;
            }
        }

        private void FormDangNhap_Load(Object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("Select * from V_DS_PHANMANH");
            cbCoSo.SelectedIndex = 1; cbCoSo.SelectedIndex = 0;
        }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (btnGV.Checked)
            {
                Program.isGV = true;//giang vien
                if (inputTaiKhoan.Text.Trim() == "" || inputMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và password của giảng viên không được để trống!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = inputTaiKhoan.Text;
                Program.password = inputMatKhau.Text;
            }
            else
            {
                Program.isGV = false;//sinh vien
                if (inputTaiKhoan.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mlogin = "sinhvien";
                Program.password = "1";
                masv = inputTaiKhoan.Text;
            }

            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cbCoSo.SelectedValue.ToString();
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            if (Program.isGV == true)
            {
                string strLenh = "EXEC [sp_LayTTDangNhap] N'" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
            }
            else
            {
                string strLenh = "EXEC [sp_LayTTDangNhapSV] N'" + masv + "', N'" + inputMatKhau.Text.Trim() + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;

                if (Program.myReader.Read() == false)
                {
                    MessageBox.Show("Mã sinh viên hoặc mật khẩu không đúng!", "", MessageBoxButtons.OK);
                    Program.mChinhanh = "";
                    Program.bds_dspm = new BindingSource();
                    Program.mloginDN = "";
                    Program.passwordDN = "";
                    Program.mlogin = "";
                    Program.password = "";
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }
            }

            Program.username = Program.myReader.GetString(0);

            if (Program.myReader.IsDBNull(1))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                return;
            }
         
            Program.mHoten = Program.myReader.GetString(1);
            Program.mNhom = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            this.Visible = false;
            frmMain f = new frmMain();

            f.HienThiMenu();

            f.Show();
            MessageBox.Show("Đăng nhập thành công!");
            //this.Hide();
            
        }

        private void btnGV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
