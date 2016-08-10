using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptCasualtyReport : DevExpress.XtraReports.UI.XtraReport
    {
        wrCasualty.wsCasualty cas = new wrCasualty.wsCasualty();
        wrCasualty.Server2Client sc = new wrCasualty.Server2Client();

        public rptCasualtyReport()
        {
            InitializeComponent();
        }

        void Show(DataTable dt)
        {
            DataSource = dt;
            GroupField idt = new GroupField("RegDate");
            grpDate.GroupFields.Add(idt);
            lbIDT.DataBindings.Add("Text", null, "RegDate", "{0:dd-MM-yyyy}");
            lbSNO.DataBindings.Add("Text", null, "SlNo");
            lbRTM.DataBindings.Add("Text", null, "RegTime", "{0:t}");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbAGE.DataBindings.Add("Text", null, "Age");
            lbSEX.DataBindings.Add("Text", null, "Sex");
            lbDGN.DataBindings.Add("Text", null, "Diagnosis");
            lbTRM.DataBindings.Add("Text", null, "Treatment");
            lbCNT.Text = dt.Rows.Count.ToString();
        }

        public rptCasualtyReport(DateTime dt)
        {
            InitializeComponent();
            sc = cas.GetCasualtyByDate(dt);
            lbHDT.Text = "ON " + dt.Date.ToShortDateString();
            Show(sc.dt);
        }

        public rptCasualtyReport(DateTime df, DateTime dt)
        {
            InitializeComponent();
            sc = cas.GetCasualtyByDates(df, dt);
            lbHDT.Text = "BETWEEN " + df.Date.ToShortDateString() + " AND " + dt.Date.ToShortDateString();
            Show(sc.dt);
        }
    }
}
