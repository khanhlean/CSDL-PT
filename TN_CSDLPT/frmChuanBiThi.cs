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
    public partial class frmChuanBiThi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        List<string> khoaChinh = new List<string>();
        public frmChuanBiThi()
        {
            InitializeComponent();

        }
        private void frmChuanBiThi_Load(object sender, EventArgs e)
        {
            ds1.EnforceConstraints = false;

            this.giaovieN_DANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.giaovieN_DANGKYTableAdapter1.Fill(this.ds1.GIAOVIEN_DANGKY);

            this.monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter1.Fill(this.ds1.MONHOC);

            this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter1.Fill(this.ds1.LOP);

            reLoadKhoaChinh();//list khoa chinh table

            if (bdsGVDK.Count > 0)
            {
                //fix loi dong dau combobox
                ComboBox_MAMH.SelectedValue = ((DataRowView)bdsGVDK[0])["MAMH"].ToString();
                ComboBox_MALOP.SelectedValue = ((DataRowView)bdsGVDK[0])["MALOP"].ToString();
            }

            macn = Program.GetMaCS();
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TenCS";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedItem = Program.mChinhanh;//sau khi load lai khi tat form dang o site pm thi se bat event combobox tu dong chuyen ve site 1
            //phan quyen
            //coso,giangvien,truong dc truy cap formCBT
            if (Program.mNhom == "coso")
            {
                comboBox_CN.Enabled = false;
                btnThoat.Enabled = false;
            }
            else if (Program.mNhom == "truong")
            {
                comboBox_CN.Enabled = true;
                btnThem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = btnXoa.Enabled = false;
            }
            else if (Program.mNhom == "giangvien")
            {
                comboBox_CN.Enabled = false;
                btnThoat.Enabled = false;
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reLoadKhoaChinh()
        {
            khoaChinh.Clear();

            for (int i = 0; i < bdsGVDK.Count; i++)
            {
                string str = ((DataRowView)bdsGVDK[i])["MAMH"].ToString().Trim()
                    + ";" + ((DataRowView)bdsGVDK[i])["MALOP"].ToString().Trim()
                    + ";" + ((DataRowView)bdsGVDK[i])["LAN"].ToString().Trim();
                khoaChinh.Add(str);
            }
        }

        private void comboBox_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CN.SelectedIndex == -1) return;
            if (comboBox_CN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.giaovieN_DANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.giaovieN_DANGKYTableAdapter1.Fill(this.ds1.GIAOVIEN_DANGKY);
                this.monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.monhocTableAdapter1.Fill(this.ds1.MONHOC);
                this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lopTableAdapter1.Fill(this.ds1.LOP);
                macn = Program.GetMaCS();
                reLoadKhoaChinh();//list khoa chinh table
                                  //if (Program.mNhom == "giangvien")
                                  //{
                                  //    Program.frmChinh.fixLoiChuyenSiteFormCBT();
                                  //}
                if (bdsGVDK.Count > 0)
                {
                    //fix loi dong dau combobox
                    ComboBox_MAMH.SelectedValue = ((DataRowView)bdsGVDK[0])["MAMH"].ToString();
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.AddNew();
            vitri = bdsGVDK.Position;
            TextBox_MAGV.Text = Program.username;
            ComboBox_MAMH.SelectedIndex = 0;
            ComboBox_MALOP.SelectedIndex = 0;
            ComboBox_TD.SelectedIndex = -1;

            DateEdit_NgayThi.DateTime = DateTime.Now.Date;
            SpinEdit_LAN.Value = SpinEdit_LAN.Properties.MinValue;
            SpinEdit_SCT.Value = SpinEdit_SCT.Properties.MinValue;
            SpinEdit_TG.Value = SpinEdit_TG.Properties.MinValue;

            btnThoat.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_GVDK.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = bdsGVDK.Position;
            //check da co sv thi ko cho sua
            string chuoi = khoaChinh[i];
            string[] mangChuoi = chuoi.Split(';');
            string strLenh = "EXEC SP_CHECKSVDATHI N'"
                    + mangChuoi[0] + "', N'"
                    + mangChuoi[1] + "', "
                    + mangChuoi[2];
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0) return;

            if (MessageBox.Show("Bạn có thật sự muốn xóa GVDK này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsGVDK.RemoveCurrent();
                    this.giaovieN_DANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.giaovieN_DANGKYTableAdapter1.Update(this.ds1.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa GVDK. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    return;
                }
                reLoadKhoaChinh();//list khoa chinh table
            }
            if (bdsGVDK.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ComboBox_TD.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "", MessageBoxButtons.OK);
                ComboBox_TD.Focus();
                return;
            }
            if (string.IsNullOrEmpty(DateEdit_NgayThi.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày thi!", "", MessageBoxButtons.OK);
                DateEdit_NgayThi.Focus();
                return;
            }
            if (DateEdit_NgayThi.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thi không thể ở quá khứ!", "", MessageBoxButtons.OK);
                DateEdit_NgayThi.Focus();
                return;
            }
            if (btnThem.Enabled == false)
            {
                //check khoa chinh GVDK --co the ko can check site pm vi gvdk la phan hoach theo malop
                string strLenh = "EXEC SP_CHECKLapLichThi N'"
                        + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                        + ComboBox_MALOP.SelectedValue.ToString() + "', "                    
                        + SpinEdit_LAN.Value+ ", '"
                        + DateEdit_NgayThi.Text+ "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0) return;
            }
            else //sua
            {
                int i = bdsGVDK.Position;

                //check da co sv thi ko cho sua
                string chuoi = khoaChinh[i];
                string[] mangChuoi = chuoi.Split(';');
                string strLenh2 = "EXEC SP_CHECKSVDATHI N'"
                        + mangChuoi[0] + "', N'"
                        + mangChuoi[1] + "', "
                        + mangChuoi[2];
                int kq2 = Program.ExecSqlNonQuery(strLenh2);
                if (kq2 != 0) return;

                //check 3 khoa chinh
                string str = ComboBox_MAMH.SelectedValue.ToString().Trim()
                    + ";" + ComboBox_MALOP.SelectedValue.ToString().Trim()
                    + ";" + SpinEdit_LAN.Value;
                int vt = khoaChinh.IndexOf(str);//vi tri tim dc khoa chinh
                if (i != vt && vt != -1)
                {
                    MessageBox.Show("Thông tin đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
            }

            //check sp so cau thi
            string strLenh1 = "EXEC SP_CHECKSOCAUTHI N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                    + ComboBox_TD.SelectedItem.ToString() + "', "
                    + SpinEdit_SCT.Value;
            int kq1 = Program.ExecSqlNonQuery(strLenh1);
            if (kq1 == 1) return;

            try
            {
                bdsGVDK.EndEdit();
                bdsGVDK.ResetCurrentItem();
                this.giaovieN_DANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.giaovieN_DANGKYTableAdapter1.Update(this.ds1.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CK_TRINHDO"))
                {
                    MessageBox.Show("Bạn chưa chọn trình độ hoặc trình độ " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("PK_GIAOVIEN_DANGKY"))
                {
                    MessageBox.Show("Thông tin đã bị trùng!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi giáo viên đăng ký.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            reLoadKhoaChinh();//list khoa chinh table
            MessageBox.Show("Đăng ký thi thành công!", "", MessageBoxButtons.OK);

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_GVDK.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.giaovieN_DANGKYTableAdapter1.Fill(this.ds1.GIAOVIEN_DANGKY);
                this.monhocTableAdapter1.Fill(this.ds1.MONHOC);
                this.lopTableAdapter1.Fill(this.ds1.LOP);

                reLoadKhoaChinh();//list khoa chinh table
                if (bdsGVDK.Count > 0)
                {
                    //fix loi dong dau combobox
                    ComboBox_MAMH.SelectedValue = ((DataRowView)bdsGVDK[0])["MAMH"].ToString();
                    ComboBox_MALOP.SelectedValue = ((DataRowView)bdsGVDK[0])["MALOP"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.RemoveAt(vitri);
            bdsGVDK.CancelEdit();
            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_GVDK.Enabled = true;
            btnReload.PerformClick();
            if (bdsGVDK.Count > 0)
            {
                gridView1.MoveLast();
            }
        }
    }
}