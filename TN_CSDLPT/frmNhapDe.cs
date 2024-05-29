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
using System.Collections;

namespace TN_CSDLPT
{
    public partial class frmNhapDe : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
     
        Stack undolist = new Stack();
        String state = "SUA";

        string selectedCH = "";
        string selectedMAMH = "";
        string selectedTD = "";
        string selectedMAGV = "";
        string selectedND = "";
        string selectedA = "";
        string selectedB = "";
        string selectedC = "";
        string selectedD = "";
        string selectedDA = "";
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.CHITIETTHI' table. You can move, or remove it, as needed.
            this.cHITIETTHITableAdapter.Fill(this.ds1.CHITIETTHI);

            ds1.EnforceConstraints = false;
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            if (Program.mNhom == "truong")
            { 
                this.bODETableAdapter.Fill(this.ds1.BODE);
            }
           else
            {
                this.bODETableAdapter.FillBy(this.ds1.BODE, Program.username);
            }
                

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);

          

            //truong,coso,giangvien dc truy cap formNhapDe
            if (Program.mNhom == "truong")
            {
                btnThem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = btnXoa.Enabled = false;
            }
            else if (Program.mNhom == "coso" || Program.mNhom == "giangvien")
            {
                btnThoat.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.AddNew();

            state = "THEM";
            string query = "SELECT MAX(CAUHOI) FROM BODE";
            Program.myReader = Program.ExecSqlDataReader(query);

            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false) return;
            
            int maxMaCH = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            int newMaCH = maxMaCH + 1;
            TextBox_CH.Text = newMaCH.ToString();

            vitri = bdsBD.Position;
  
            TextBox_MAGV.Text = Program.username;
            ComboBox_MAMH.SelectedIndex = 0;
            ComboBox_DA.SelectedIndex = -1;
            ComboBox_TD.SelectedIndex = -1;

            btnThoat.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled  = true;
            GridControl_BODE.Enabled = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            state = "XOA";

            if (bdsCTTHI.Count > 0)
            {
                MessageBox.Show("Bộ đề đã được thi", "",
                       MessageBoxButtons.OK);
                return;
            }
            String mach = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mach = ((DataRowView)bdsBD[bdsBD.Position])["CAUHOI"].ToString(); 
                    
                    undolist.Push(
                        TextBox_CH.Text + "#" +
                        ComboBox_MAMH.SelectedIndex + "#" +
                        ComboBox_TD.SelectedIndex + "#" +
                        TextBox_MAGV.Text + "#" +
                        TextBox_ND.Text + "#" +
                        TextBox_A.Text + "#" +
                        TextBox_B.Text + "#" +
                        TextBox_C.Text + "#" +
                        TextBox_D.Text + "#" +
                        ComboBox_DA.Text);
                    undolist.Push("XOA");

                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Update(this.ds1.BODE);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(this.ds1.BODE);
                    bdsMH.Position = bdsMH.Find("CAUHOI", mach);
                    return;
                }
            }
            if (bdsBD.Count == 0) btnXoa.Enabled = false; 
            btnUndo.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ComboBox_TD.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "", MessageBoxButtons.OK);
                ComboBox_TD.Focus();
                return;
            }
            if (ComboBox_DA.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đáp án!", "", MessageBoxButtons.OK);
                ComboBox_DA.Focus();
                return;
            }
            try
            {
                bdsBD.EndEdit();
                bdsBD.ResetCurrentItem();

                this.bODETableAdapter.Update(this.ds1.BODE);
                switch (state)
                {
                    case "THEM":
                        undolist.Push(TextBox_CH.Text);
                        undolist.Push("THEM");
                        
                        break;
                    case "SUA":
                                         undolist.Push(
                            selectedCH + "#" +
                            selectedMAMH + "#" +
                            selectedTD + "#" +
                            selectedMAGV + "#" +
                            selectedND + "#" +
                            selectedA + "#" +
                            selectedB + "#" +
                            selectedC + "#" +
                            selectedD + "#" +
                            selectedDA);
                        undolist.Push("SUA");
                        
                        break;
                }
                state = "SUA";
                btnThoat.Enabled = false;
                btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = true;
                GridControl_BODE.Enabled = true;

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CK_BODE"))
                {
                    MessageBox.Show("Bạn chưa chọn trình độ hoặc trình độ " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("CK_DAPAN"))
                {
                    MessageBox.Show("Bạn chưa chọn đáp án hoặc đáp án " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi bộ đề.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

           
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("XOA"))
                {
                    this.bdsBD.AddNew();
                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    TextBox_CH.Text = TT_Kho[0];
                    ComboBox_MAMH.SelectedIndex = Int16.Parse(TT_Kho[1]);
                    ComboBox_TD.SelectedIndex = Int16.Parse(TT_Kho[2]);
                    TextBox_MAGV.Text = TT_Kho[3];
                    TextBox_ND.Text = TT_Kho[4];
                    TextBox_A.Text = TT_Kho[5];
                    TextBox_B.Text = TT_Kho[6];
                    TextBox_C.Text = TT_Kho[7];
                    TextBox_D.Text = TT_Kho[8];
                    ComboBox_DA.Text = TT_Kho[9];
                    this.bdsBD.EndEdit();
                    this.bODETableAdapter.Update(this.ds1.BODE);
                }
                else if (statement.Equals("THEM"))
                {
                
                    String CAUHOI = undolist.Pop().ToString();

                    int vitrixoa = bdsBD.Find("CAUHOI", CAUHOI);
                    bdsBD.Position = vitrixoa;
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.ds1.BODE);
                }
                else if (statement.Equals("SUA"))
                {

                    String TT = undolist.Pop().ToString();
                    String[] TT_Kho = TT.Split('#');
                    bdsBD.Position = bdsBD.Find("CAUHOI", TT_Kho[0]);
                  
                    ComboBox_MAMH.SelectedItem = TT_Kho[1];
                    ComboBox_TD.SelectedItem = TT_Kho[2];
                    TextBox_MAGV.Text = TT_Kho[3];
                    TextBox_ND.Text = TT_Kho[4];
                    TextBox_A.Text = TT_Kho[5];
                    TextBox_B.Text = TT_Kho[6];
                    TextBox_C.Text = TT_Kho[7];
                    TextBox_D.Text = TT_Kho[8];
                    ComboBox_DA.SelectedItem = TT_Kho[9];
                    this.bdsBD.EndEdit();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.ds1.BODE);

                }
            }
            if (undolist.Count == 0) btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e){
            try
            {
                if( Program.mNhom == "truong")
                    this.bODETableAdapter.Fill(this.ds1.BODE);
                else
                    this.bODETableAdapter.FillBy(this.ds1.BODE, Program.username);

                this.mONHOCTableAdapter.Fill(this.ds1.MONHOC);

                if (bdsBD.Count > 0)
                {
                    //fix loi dong dau combobox
                    ComboBox_MAMH.SelectedValue = ((DataRowView)bdsBD[0])["MAMH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine("Undo List Contents:");
            foreach(var action in undolist)
            {
                Console.WriteLine(action);
            }


        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            state = "SUA";
            if (undolist.Count > 0)
            {
                undolist.Pop();
                undolist.Pop();
            }
            bdsBD.RemoveAt(vitri);
            bdsBD.CancelEdit();

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_BODE.Enabled = true;
            btnReload.PerformClick();

            if (bdsBD.Count > 0)
            {
              
                this.bODETableAdapter.FillBy(this.ds1.BODE, Program.username);
                gridView1.MoveLast();
            }

        }

        private void TextBox_MAGV_TextChanged(object sender, EventArgs e)
        {       
        }

        private void ComboBox_TD_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GridControl_BODE_Click(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                DataRowView selectedRow = (DataRowView)gridView1.GetRow(selectedRowHandle);
                 selectedCH = selectedRow["CAUHOI"].ToString();
                 selectedMAMH = selectedRow["MAMH"].ToString();
                 selectedTD = selectedRow["TRINHDO"].ToString();
                 selectedMAGV = selectedRow["MAGV"].ToString();
                 selectedND = selectedRow["NOIDUNG"].ToString();
                 selectedA = selectedRow["A"].ToString();
                 selectedB = selectedRow["B"].ToString();
                 selectedC = selectedRow["C"].ToString();
                 selectedD = selectedRow["D"].ToString();
                 selectedDA = selectedRow["DAP_AN"].ToString();
            }
        }
    }
}