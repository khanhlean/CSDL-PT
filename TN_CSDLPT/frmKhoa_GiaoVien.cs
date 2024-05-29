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
    public partial class frmKhoa_GiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa_GiaoVien()
        {
            InitializeComponent();

            

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsGV.RemoveCurrent();
            thoatToolStripMenuItem.Enabled = false;
            themGVToolStripMenuItem.Enabled = true;
            xoaGVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            themGVToolStripMenuItem.Enabled = btnReload.Enabled = xoaGVToolStripMenuItem.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gridControl_KH.Enabled = true;
            gridControl_GV.Enabled = true;
            groupControl2.Enabled = true;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoaTableAdapter2.Fill(this.ds3.KHOA);
                this.gIAOVIENTableAdapter.Fill(this.ds3.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmKhoa_GiaoVien_Load(object sender, EventArgs e)
        {
            ds3.EnforceConstraints = false;
            this.khoaTableAdapter2.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter2.Fill(this.ds3.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.ds3.GIAOVIEN);

            comboBox_CS.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBox_CS.DisplayMember = "TenCS";
            comboBox_CS.ValueMember = "TENSERVER";
            comboBox_CS.SelectedItem = Program.mChinhanh;


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // them SV
            bdsGV.AddNew();
            btnThoat.Enabled = true;
            themGVToolStripMenuItem.Enabled = false;
            xoaGVToolStripMenuItem.Enabled = false;

            //btnThoat.Enabled = false;
            themGVToolStripMenuItem.Enabled = btnReload.Enabled = xoaGVToolStripMenuItem.Enabled = btnUndo.Enabled = false;
            btnGhi.Enabled = true;
            gridControl_KH.Enabled = true;
            gridControl_GV.Enabled = true;
            groupControl2.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xoa SV
            String masv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.ds3.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.ds3.GIAOVIEN);
                    bdsGV.Position = bdsGV.Find("MASV", masv);
                    return;
                }
            }
            if (bdsGV.Count == 0) xoaGVToolStripMenuItem.Enabled = false;
        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CS.SelectedIndex == -1) return;
            if (comboBox_CS.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_CS.SelectedValue.ToString();

            if (comboBox_CS.SelectedItem != Program.mChinhanh)
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

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.ds3.GIAOVIEN);

                this.khoaTableAdapter2.Connection.ConnectionString = Program.connstr;
                this.khoaTableAdapter2.Fill(this.ds3.KHOA);

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// ghi SV
            if (TextBox_MAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã GV không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MAGV.Focus();
                return;
            }
            if (textBoxHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ GV không được thiếu!", "", MessageBoxButtons.OK);
                textBoxHo.Focus();
                return;
            }
            if (textBoxTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ GV không được thiếu!", "", MessageBoxButtons.OK);
                textBoxTen.Focus();
                return;
            }
            if (textBoxHocVi.Text.Trim() == "")
            {
                MessageBox.Show("Học vị không được thiếu!", "", MessageBoxButtons.OK);
                textBoxHocVi.Focus();
                return;
            }
            if (comboBoxMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                comboBoxMaKH.Focus();
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
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.ds3.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi GV.\n" + ex.Message, "", MessageBoxButtons.OK);
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
            themGVToolStripMenuItem.Enabled = true;
            xoaGVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            themGVToolStripMenuItem.Enabled = btnReload.Enabled = xoaGVToolStripMenuItem.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gridControl_KH.Enabled = true;
            gridControl_GV.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bdsGV_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}