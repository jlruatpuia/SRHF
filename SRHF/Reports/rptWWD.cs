using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SRHF.Reports
{
    public partial class rptWWD : DevExpress.XtraReports.UI.XtraReport
    {
        public rptWWD()
        {
            InitializeComponent();
        }

        public rptWWD(int month, int year)
        {
            InitializeComponent();
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            sc = ptn.GetWardWiseData(month, year);
            lbMYR.Text = "OPD FOR THE MONTH OF " + Codes.MySettings.MonthName(month) + ", YEAR " + year.ToString();
            DataSource = sc.dt;
            lbWNM.DataBindings.Add("Text", null, "DeptName");
            lbBED.DataBindings.Add("Text", null, "NewCase");
            lbADM.DataBindings.Add("Text", null, "OldCase");
            lbDSC.DataBindings.Add("Text", null, "Total");
            lbDTH.DataBindings.Add("Text", null, "Average");
        }
    }
}
