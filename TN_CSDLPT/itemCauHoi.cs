using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TN_CSDLPT
{
    public partial class itemCauHoi : DevExpress.XtraEditors.XtraUserControl
    {
        public itemCauHoi()
        {
            InitializeComponent();
        }
        #region Properties
        private int stt;
        private int cauHoi;
        private string noiDung;
        private string a;
        private string b;
        private string c;
        private string d;
        private string dapAn;
        //dung luon radioButton da keo tha vi co da co group
        //khong can xet them dk

        [Category("Custom props")]
        public int Stt
        {
            get { return stt; }
            set { stt = value; label_STT.Text = "Câu " + value + ": "; }
        }

        [Category("Custom props")]
        public int CauHoi
        {
            get { return cauHoi; }
            set { cauHoi = value; }
        }

        [Category("Custom props")]
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; label_ND.Text = value; }
        }

        [Category("Custom props")]
        public string DapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        [Category("Custom props")]
        public string A
        {
            get { return a; }
            set { a = value; label_DA_A.Text = value; }
        }

        [Category("Custom props")]
        public string B
        {
            get { return b; }
            set { b = value; label_DA_B.Text = value; }
        }

        [Category("Custom props")]
        public string C
        {
            get { return c; }
            set { c = value; label_DA_C.Text = value; }
        }

        [Category("Custom props")]
        public string D
        {
            get { return d; }
            set { d = value; label_DA_D.Text = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_A
        {
            get { return radioButton_A; }
            set { radioButton_A = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_B
        {
            get { return radioButton_B; }
            set { radioButton_B = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_C
        {
            get { return radioButton_C; }
            set { radioButton_C = value; }
        }

        [Category("Custom props")]
        public RadioButton Rbtn_D
        {
            get { return radioButton_D; }
            set { radioButton_D = value; }
        }
        #endregion

        private void label_CH_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = radioGroup1.BackColor
                = radioButton_A.BackColor = radioButton_B.BackColor
                = radioButton_C.BackColor = radioButton_D.BackColor
                = label_DA_A.BackColor = label_DA_B.BackColor
                = label_DA_C.BackColor = label_DA_D.BackColor = Color.Silver;
        }

        private void label_CH_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = radioGroup1.BackColor
                = radioButton_A.BackColor = radioButton_B.BackColor
                = radioButton_C.BackColor = radioButton_D.BackColor
                = label_DA_A.BackColor = label_DA_B.BackColor
                = label_DA_C.BackColor = label_DA_D.BackColor = System.Drawing.SystemColors.Control;
        }

        private void label_DA_A_Click(object sender, EventArgs e)
        {
            radioButton_A.Checked = true;
        }

        private void label_DA_B_Click(object sender, EventArgs e)
        {
            radioButton_B.Checked = true;
        }

        private void label_DA_C_Click(object sender, EventArgs e)
        {
            radioButton_C.Checked = true;
        }

        private void label_DA_D_Click(object sender, EventArgs e)
        {
            radioButton_D.Checked = true;
        }

        private void radioButton_A_ForeColorChanged(object sender, EventArgs e)
        {
            label_DA_A.ForeColor = radioButton_A.ForeColor;
        }

        private void radioButton_B_ForeColorChanged(object sender, EventArgs e)
        {
            label_DA_B.ForeColor = radioButton_B.ForeColor;
        }

        private void radioButton_C_ForeColorChanged(object sender, EventArgs e)
        {
            label_DA_C.ForeColor = radioButton_C.ForeColor;
        }

        private void radioButton_D_ForeColorChanged(object sender, EventArgs e)
        {
            label_DA_D.ForeColor = radioButton_D.ForeColor;
        }
    }
}
