using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptOPDReport : DevExpress.XtraReports.UI.XtraReport
    {
        wrOPD.wsOPD opd = new wrOPD.wsOPD();
        wrOPD.Server2Client sc = new wrOPD.Server2Client();
        public rptOPDReport()
        {
            InitializeComponent();
        }


        public rptOPDReport(DateTime d)
        {
            InitializeComponent();
            sc = opd.GetOPDByDate(d);
            lbHDT.Text = "ON " + d.Date.ToShortDateString();
            Show(sc.dt);
        }

        public rptOPDReport(DateTime d1, DateTime d2)
        {
            InitializeComponent();
            sc = opd.GetOPDByDates(d1, d2);
            lbHDT.Text = "BETWEEN " + d1.Date.ToShortDateString() + " AND " + d2.Date.ToShortDateString();
            Show(sc.dt);
        }

        void Show(DataTable dt)
        {
            DataSource = dt;
            GroupField idt = new GroupField("I_Date");
            GroupHeader1.GroupFields.Add(idt);
            lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
            lbDNO.DataBindings.Add("Text", null, "DailyNo");
            lbEMR.DataBindings.Add("Text", null, "EMRNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbAGE.DataBindings.Add("Text", null, "Age");
            lbSEX.DataBindings.Add("Text", null, "Sex");
            lbCSE.DataBindings.Add("Text", null, "Cases");
            lbOPD.DataBindings.Add("Text", null, "OPDNo");
            lbCNT.Text = dt.Rows.Count.ToString();
        }
    }
}
