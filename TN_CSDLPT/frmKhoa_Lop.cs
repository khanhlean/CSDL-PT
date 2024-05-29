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
    public partial class frmKhoa_Lop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa_Lop()
        {
            InitializeComponent();

            this.khoaTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter1.Fill(this.ds1.KHOA);

            this.lopTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter1.Fill(this.ds1.LOP);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_MAKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}