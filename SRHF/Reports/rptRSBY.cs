using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptRSBY : DevExpress.XtraReports.UI.XtraReport
    {
        wrRSBY.wsRSBY r = new wrRSBY.wsRSBY();
        wrRSBY.Server2Client sc = new wrRSBY.Server2Client();

        public rptRSBY()
        {
            InitializeComponent();


        }

        public rptRSBY(DataTable dt)
        {
            InitializeComponent();

            DataSource = dt;
            lbSNO.DataBindings.Add("Text", null, "SlNo");
            lbMRD.DataBindings.Add("Text", null, "MRDNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbFHD.DataBindings.Add("Text", null, "FamilyHead");
            lbCNO.DataBindings.Add("Text", null, "ContactNo");
            lbWRD.DataBindings.Add("Text", null, "Ward");
            lbDOA.DataBindings.Add("Text", null, "AdmissionDate", "{0:dd-MM-yyyy}");
            lbDOD.DataBindings.Add("Text", null, "DischargeDate", "{0:dd-MM-yyyy}");
            lbPKG.DataBindings.Add("Text", null, "Packages");
            lbTBL.DataBindings.Add("Text", null, "TotalBill", "{0:C2}");
            lbAMT.DataBindings.Add("Text", null, "ActualAmount", "{0:C2}");
            lbHSH.DataBindings.Add("Text", null, "HospitalShare", "{0:C2}");
            lbURN.DataBindings.Add("Text", null, "URN");
            lbRMK.DataBindings.Add("Text", null, "Remarks");
        }

    }
}
