using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptOTHReport : DevExpress.XtraReports.UI.XtraReport
    {
        wrOTH.wsOTH o = new wrOTH.wsOTH();
        wrOTH.Server2Client sc = new wrOTH.Server2Client();

        void Show(DataTable dt)
        {
            GroupField idt = new GroupField("I_Date");
            GroupHeader1.GroupFields.Add(idt);
            lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
            lbEMR.DataBindings.Add("Text", null, "EMRNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbAGX.DataBindings.Add("Text", null, "AgeSex");
            lbIOP.DataBindings.Add("Text", null, "PatientType");
            lbANE.DataBindings.Add("Text", null, "Anaesthesia");
            lbOTP.DataBindings.Add("Text", null, "OpType");
            lbANT.DataBindings.Add("Text", null, "Anaesthetist");
            lbSRG.DataBindings.Add("Text", null, "Surgeon");
            lbAST.DataBindings.Add("Text", null, "Assistant");
            lbRMK.DataBindings.Add("Text", null, "Remarks");
        }

        public rptOTHReport()
        {
            InitializeComponent();
        }

        public rptOTHReport(DateTime dt)
        {
            InitializeComponent();
            sc = o.GetOpTheaterByDate(dt);
            DataSource = sc.dt;
            lbHDT.Text = "ON " + dt.Date.ToShortDateString();
            lbCNT.Text = sc.dt.Rows.Count.ToString();
            Show(sc.dt);
        }

        public rptOTHReport(DateTime df, DateTime dt)
        {
            InitializeComponent();
            sc = o.GetOpTheaterByDates(df, dt);
            DataSource = sc.dt;
            lbHDT.Text = "ON " + dt.Date.ToShortDateString();
            lbCNT.Text = sc.dt.Rows.Count.ToString();
            Show(sc.dt);
        }
    }
}
