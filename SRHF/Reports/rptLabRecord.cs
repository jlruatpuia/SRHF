using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptLabRecord : DevExpress.XtraReports.UI.XtraReport
    {
        wrLAB.wsLAB lab = new wrLAB.wsLAB();
        wrLAB.Server2Client sc = new wrLAB.Server2Client();
        void Show(DataTable dt)
        {
            DataSource = dt;
            GroupField idt = new GroupField("I_Date");
            GroupHeader1.GroupFields.Add(idt);
            lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
            lbSNO.DataBindings.Add("Text", null, "SlNo");
            lbDNO.DataBindings.Add("Text", null, "DailyNo");
            lbEMR.DataBindings.Add("Text", null, "EMRNo");
            lbPTP.DataBindings.Add("Text", null, "PatientType");
            lbWRD.DataBindings.Add("Text", null, "Ward");
            lbTPF.DataBindings.Add("Text", null, "TestPerformed");
            lbCRG.DataBindings.Add("Text", null, "Charge");
            lbRMK.DataBindings.Add("Text", null, "Remarks");
            lbCNT.Text = dt.Rows.Count.ToString();
        }
        public rptLabRecord()
        {
            InitializeComponent();

        }

        public rptLabRecord(DateTime dt)
        {
            InitializeComponent();
            sc = lab.GetLabRecordByDate(dt);
            lbHDT.Text = "ON " + dt.Date.ToShortDateString();
            Show(sc.dt);
        }

        public rptLabRecord(DateTime df, DateTime dt)
        {
            InitializeComponent();
            sc = lab.GetLabRecordByDates(df, dt);
            lbHDT.Text = "BETWEEN " + df.Date.ToShortDateString() + " AND " + dt.Date.ToShortDateString();
            Show(sc.dt);
        }
    }
}
