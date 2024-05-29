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
    public partial class frmLop_SinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmLop_SinhVien()
        {
            int vitri = 0;
            string macn = "";
            InitializeComponent();

            this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter1.Fill(this.ds1.LOP);

            this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter1.Fill(this.ds1.SINHVIEN);

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLop_SinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            //this.gIAOVIEN_DANGKYTableAdapter.Fill(this.ds1.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'ds1.BANGDIEM' table. You can move, or remove it, as needed.
            //this.bANGDIEMTableAdapter.Fill(this.ds1.BANGDIEM);




            ds1.EnforceConstraints = false;

            this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter1.Fill(this.ds1.LOP);

            this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter1.Fill(this.ds1.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.ds1.BANGDIEM);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.ds1.GIAOVIEN_DANGKY);

            this.khoaTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter1.Fill(this.ds1.KHOA);


            comboBox_CN.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBox_CN.DisplayMember = "TenCS";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedItem = Program.mChinhanh;
            //phan quyen
            //coso,truong dc truy cap formLopSV
            if (Program.mNhom.Equals("coso"))
            {
                comboBox_CN.Enabled = false;
                btnThoat.Enabled = false;
                thoatToolStripMenuItem.Enabled = false;
            }
            else if (Program.mNhom.Equals("truong"))
            {
                comboBox_CN.Enabled = true;
                themSVToolStripMenuItem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = xoaSVToolStripMenuItem.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // them SV
            bdsSV.AddNew();
            btnThoat.Enabled = true;
            themSVToolStripMenuItem.Enabled = false;
            xoaSVToolStripMenuItem.Enabled = false;

            //btnThoat.Enabled = false;
            themSVToolStripMenuItem.Enabled = btnReload.Enabled = xoaSVToolStripMenuItem.Enabled =  btnUndo.Enabled=false;
            btnGhi.Enabled = true;
            GridControl_Lop.Enabled = true;
            DataGridView_SV.Enabled = true;
            groupControl2.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xoa SV
            String masv = "";
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSV.RemoveCurrent();
                    this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.sinhvienTableAdapter1.Update(this.ds1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sinhvienTableAdapter1.Fill(this.ds1.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSV.Count == 0) xoaSVToolStripMenuItem.Enabled = false;
        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CN.SelectedIndex == -1) return;
            if (comboBox_CN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_CN.SelectedValue.ToString();

            if (comboBox_CN.SelectedItem != Program.mChinhanh)
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
                this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.lopTableAdapter1.Fill(this.ds1.LOP);
                this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sinhvienTableAdapter1.Fill(this.ds1.SINHVIEN);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.ds1.BANGDIEM);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.ds1.GIAOVIEN_DANGKY);
                this.khoaTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.khoaTableAdapter1.Fill(this.ds1.KHOA);
              
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsSV.RemoveCurrent();
            thoatToolStripMenuItem.Enabled = false;
            themSVToolStripMenuItem.Enabled = true;
            xoaSVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            themSVToolStripMenuItem.Enabled = btnReload.Enabled = xoaSVToolStripMenuItem.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lopTableAdapter1.Fill(this.ds1.LOP);
                this.sinhvienTableAdapter1.Fill(this.ds1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// ghi SV
            if (TextBox_MASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã SV không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MASV.Focus();
                return;
            }
            if (TextBox_HoSV.Text.Trim() == "")
            {
                MessageBox.Show("Họ SV không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_HoSV.Focus();
                return;
            }
            if (TextBox_TenSV.Text.Trim() == "")
            {
                MessageBox.Show("Họ SV không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TenSV.Focus();
                return;
            }

           
            //int viTriDangSua = bdsSV.Position;
            //int vt = bdsSV.Find("MASV", TextBox_MASV.Text);

            //int vt1 = bdsMH.Find("TENMH", TextBox_TenMH.Text);
            //if (viTriDangSua != vt && vt != -1) //trung
            //{
            //    MessageBox.Show("Lỗi mã môn học bị trùng", "SP", MessageBoxButtons.OK);
            //    return;
            //}
            //if (viTriDangSua != vt1 && vt1 != -1) //trung
            //{
            //    MessageBox.Show("Lỗi tên môn học bị trùng", "SP", MessageBoxButtons.OK);
            //    return;
            //}
           
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sinhvienTableAdapter1.Update(this.ds1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi SV.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            ////dang them
            //if (themSVToolStripMenuItem.Enabled == false)
            //{
            //    int index = bdsSV.Count - 1;
            //    //check thong tin giang vien moi nhap vao
            //    string maSV = this.DataGridView_SV.Rows[index].Cells[0].Value.ToString();

            //    if (string.IsNullOrEmpty(maSV.Trim()))
            //    {
            //        MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
            //        DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
            //        DataGridView_SV.BeginEdit(true);
            //        return;
            //    }
            //    string strLenh = "EXEC SP_CHECKSV_TRACUU N'" + maSV.Trim() + "'";
            //    int kq = Program.ExecSqlNonQuery(strLenh);
            //    if (kq == 1)
            //    {
            //        DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
            //        DataGridView_SV.BeginEdit(true);
            //        return;
            //    }
            //}
            //else //sua
            //{
            //    string maSV = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0].Value.ToString();

            //    if (string.IsNullOrEmpty(maSV.Trim()))
            //    {
            //        MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
            //        DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
            //        DataGridView_SV.BeginEdit(true);
            //        return;
            //    }
            //    string strLenh = "EXEC SP_CHECKSV_PM N'" + maSV.Trim() + "'";
            //    int kq = Program.ExecSqlNonQuery(strLenh);
            //    if (kq == 1)
            //    {
            //        DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
            //        DataGridView_SV.BeginEdit(true);
            //        return;
            //    }
            //}
            ////ghi
            //try
            //{
            //    bdsSV.EndEdit();
            //    bdsSV.ResetCurrentItem();
            //    this.sinhvienTableAdapter1.Connection.ConnectionString = Program.connstr;
            //    this.sinhvienTableAdapter1.Update(this.ds1.SINHVIEN);
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message.Contains("PK_SINHVIEN"))
            //    {
            //        MessageBox.Show("Lỗi mã sinh viên bị trùng", "", MessageBoxButtons.OK);
            //        DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
            //        DataGridView_SV.BeginEdit(true);
            //    }
            //    else
            //    {
            //        this.bdsSV.RemoveCurrent();
            //        MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
            //    }
            //    return;
            //}
            thoatToolStripMenuItem.Enabled = false;
            themSVToolStripMenuItem.Enabled = true;
            xoaSVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            themSVToolStripMenuItem.Enabled = btnReload.Enabled = xoaSVToolStripMenuItem.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            groupControl2.Enabled = true;
        }
    }
}