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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmMonHoc()
        {
            InitializeComponent();

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            ds1.EnforceConstraints = false;

            this.monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.monhocTableAdapter1.Fill(this.ds1.MONHOC);

            //chi co Coso va Truong vao dc formMH
            if (Program.mNhom == "coso")
            {
                this.bangdiemTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.bangdiemTableAdapter1.Fill(this.ds1.BANGDIEM);

                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.ds1.BODE);

                this.giaovieN_DANGKYTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.giaovieN_DANGKYTableAdapter1.Fill(this.ds1.GIAOVIEN_DANGKY);

                btnThoat.Enabled = false;
            }
            else if (Program.mNhom == "truong")
            {
                btnThem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = btnXoa.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.AddNew();

            vitri = bdsMH.Position;
            groupControl1.Enabled = true;
            btnThoat.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_MH.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mamh = "";
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã tồn tại trong bộ đề", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong bảng điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã được đăng ký", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mamh = ((DataRowView)bdsMH[bdsMH.Position])["MAMH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsMH.RemoveCurrent();
                    this.monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.monhocTableAdapter1.Update(this.ds1.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.monhocTableAdapter1.Fill(this.ds1.MONHOC);
                    bdsMH.Position = bdsMH.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMH.Count == 0) btnXoa.Enabled = false;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void GridControl_BangDiem_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextBox_MaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MaMH.Focus();
                return;
            }
            if (TextBox_TenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TenMH.Focus();
                return;
            }
            if (btnThem.Enabled == false) //dang them moi check
            {
                string strLenh = "EXEC [SP_TonTaiMaMH] N'" + TextBox_MaMH.Text.Trim() +"'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0) return;
            }
            else //sua
            {
                int viTriDangSua = bdsMH.Position;
                int vt = bdsMH.Find("MAMH", TextBox_MaMH.Text);
                int vt1 = bdsMH.Find("TENMH", TextBox_TenMH.Text);
                if (viTriDangSua != vt && vt != -1) //trung
                {
                    MessageBox.Show("Lỗi mã môn học bị trùng", "SP", MessageBoxButtons.OK);
                    return;
                }
                if (viTriDangSua != vt1 && vt1 != -1) //trung
                {
                    MessageBox.Show("Lỗi tên môn học bị trùng", "SP", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.monhocTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.monhocTableAdapter1.Update(this.ds1.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GridControl_MH.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            groupControl1.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.RemoveAt(vitri);
            bdsMH.CancelEdit();
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            GridControl_MH.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.monhocTableAdapter1.Fill(this.ds1.MONHOC);
                if (Program.mNhom == "coso")
                {
                    this.bangdiemTableAdapter1.Fill(this.ds1.BANGDIEM);
                    this.bODETableAdapter.Fill(this.ds1.BODE);
                    this.giaovieN_DANGKYTableAdapter1.Fill(this.ds1.GIAOVIEN_DANGKY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}