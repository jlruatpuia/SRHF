using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace SRHF.Reports
{
    public partial class rptHCare : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHCare()
        {
            InitializeComponent();
        }

        public rptHCare(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
            lbENO.DataBindings.Add("Text", null, "EnrollmentNo");
            lbMRD.DataBindings.Add("Text", null, "MRDNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbFHD.DataBindings.Add("Text", null, "FamilyHead");
            lbAMC.DataBindings.Add("Text", null, "AmountClaimed");
            lbDOA.DataBindings.Add("Text", null, "AdmissionDate", "{0:dd/MM/yyyy}");
            lbDOD.DataBindings.Add("Text", null, "DischargeDate", "{0:dd/MM/yyyy}");
            lbDGN.DataBindings.Add("Text", null, "Diagnosis");
        }
    }
}
