using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT
{
    public partial class XtraReport_XemBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_XemBangDiem(String maLop, String MaMH, short lanThi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lanThi;
            this.sqlDataSource1.Fill();
        }

        private void tableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            float diemValue = Convert.ToSingle(GetCurrentColumnValue("DIEM"));

            string words = ConvertNumberToWords(diemValue);
            cell.Text = words;
        }
    }
}
