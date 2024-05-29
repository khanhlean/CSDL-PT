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

    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void openForm(Form newFrm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == newFrm.GetType())
                {
                    //MessageBox.Show("Form đang được mở.");
                    f.Activate();
                    return;
                }
            }
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmKhoa_GiaoVien());
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Visible = false;
            //frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            //f.Show();
            openForm(new frmTaoTaiKhoan());
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmDsDkThi());
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmMonHoc());
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmLop_SinhVien());
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmKhoa_Lop());
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmChuanBiThi());
        }

        private static frmThi openedForm = null;
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openedForm == null || openedForm.IsDisposed)
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
                openedForm = f;

                if (Program.mNhom != "sinhvien")
                {
                    f.Text = "Thi thử";
                    MessageBox.Show("Giáo viên chỉ có thể thi thử và không ghi điểm!", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                openedForm.BringToFront();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmNhapDe());
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmKQThi());
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(new frmBangDiemMH());
        }

        private void toolStripStatusLabel_MaUser_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn đăng xuất khỏi tài khoản '"
            //    + Program.mloginDN + "' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    Application.Restart();
            //}
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.username = "";
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;

                Program.mloginDN = Program.remotelogin;
                Program.passwordDN = Program.remotelogin;

                Program.mNhom = "";
                Program.mHoten = "";
                Program.dangXuat = true;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }

                this.Visible = false;
                FormDangNhap f = new FormDangNhap();

                f.Visible = true;
            }
        }

        public void HienThiMenu()
        {
            btnDX.Enabled = true;
            btnDN.Enabled = false;
            if (Program.isGV)
            {
                toolStripStatusLabel_MaUser.Text = "Mã giảng viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mNhom;
            }
            else
            {
                toolStripStatusLabel_MaUser.Text = "Mã sinh viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mNhom;
            }
            //phan quyen
            ribbonPage_BaoCao.Visible = true;
            if (Program.isGV)
            {
                barButtonItem17.Caption = "Thi thử";
                ribbonPage_DM.Visible = true;
                if (Program.mNhom == "giangvien")
                {
                    //barButtonItem12.Enabled = false; // btn monhoc
                    //barButtonItem10.Enabled = false; // btn khoaGV
                    //barButtonItem11.Enabled = false; // btn lopSV
                    ribbonPageGroupTTK.Visible = false;

                    ribbonPageGroup_Subform.Visible = false;
                    ribbonPageGroup_SimpleForm.Visible = false;
                    ribbonPage_BaoCao.Visible = false;
                    ribbonPageGroup_DSDKT.Visible = false;
                    ribbonPageGroup_BDMH.Visible = false;
                    ribbonPageGroup_BT.Visible = false;
                }
                else
                {
                    //barButtonItem5.Enabled = false; // btn baithi
                    ribbonPageGroup_BT.Visible = true;
                    //ribbonPage_PhanQuyen.Visible = true;
                    //barButtonItem13.Enabled = true; // btn taotaikhoan
                    if (Program.mNhom == "truong")
                    {
                        ribbonPageGroup_Thi.Visible = false;
                      
                    }
                }
            }
            else
            {
                ribbonPageGroupTTK.Visible = false;

                ribbonPage_DM.Visible = true;
                ribbonPageGroup_CBT.Visible = false;
                ribbonPageGroup_SimpleForm.Visible = false;
                ribbonPageGroup_Subform.Visible = false;
                ribbonPageGroup3.Visible = false;
                ribbonPage_PhanQuyen.Visible = false;
                
                ribbonPageGroup_DSDKT.Visible = false;
                ribbonPageGroup_BDMH.Visible = false;
            }
        }
    }
}