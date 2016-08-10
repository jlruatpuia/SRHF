using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptMRD : DevExpress.XtraReports.UI.XtraReport
    {
        wrMRD.wsMRD mrd = new wrMRD.wsMRD();
        wrMRD.Server2Client sc = new wrMRD.Server2Client();
        string t = null;

        void Show(DataTable dt)
        {
            DataSource = dt;
            lbMRD.DataBindings.Add("Text", null, "MRDNo");
            lbEMR.DataBindings.Add("Text", null, "EMRNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbAGX.DataBindings.Add("Text", null, "AgeSex");
            lbDGN.DataBindings.Add("Text", null, "ICDCode");
            lbADT.DataBindings.Add("Text", null, "AdmissionDate", "{0:dd-MM-yyyy}");
            lbDDT.DataBindings.Add("Text", null, "DischargeDate", "{0:dd-MM-yyyy}");
            lbRMK.DataBindings.Add("Text", null, "Remarks");
        }
        public rptMRD()
        {
            InitializeComponent();
        }

        public rptMRD(DateTime dt, string field)
        {
            InitializeComponent();
            sc = mrd.GetMRDByDate(dt, field);
            if (field == "AdmissionDate")
                t = "Admission Date";
            else
                t = "Discharge Date";
            lbHDT.Text = t + " on " + dt.ToShortDateString();
            Show(sc.dt);
        }

        public rptMRD(DateTime df, DateTime dt, string field)
        {
            InitializeComponent();
            sc = mrd.GetMRDByDates(df, dt, field);
            if (field == "AdmissionDate")
                t = "Admission Date";
            else
                t = "Discharge Date";
            lbHDT.Text = t + " between " + df.ToShortDateString() + " and " + dt.ToShortDateString();
            Show(sc.dt);
        }
    }
}
