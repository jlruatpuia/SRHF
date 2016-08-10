using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SRHF.Reports
{
    public partial class rptPMR : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPMR()
        {
            InitializeComponent();
        }

        public rptPMR(string query, string field)
        {
            InitializeComponent();

            

            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.MRD m = new wrMRD.MRD();
            m = mrd.GetPatientMRD(query, field);

            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(m.EMRNo);

            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            txtSEX.Text = p.Sex;

            txtMRD.Text = m.MRDNo;
            txtWRD.Text = m.Ward;
            txtDOA.Text = m.AdmissionDate.ToShortDateString();
            txtDOD.Text = m.DischargeDate.ToShortDateString();
            txtHPD.Text = m.HospitalDays.ToString();
            txtDGN.Text = m.Diagnosis;
            txtDGN2.Text = m.Diagnosis.ToUpper();
            txtICD.Text = m.ICDCode;

            string rslt = m.Result;
            switch (rslt)
            {
                case "Recovered":
                    chkRsREC.Checked = true;
                    break;
                case "Improved":
                    chkRsIMP.Checked = true;
                    break;
                case "Unchanged":
                    chkRsUNC.Checked = true;
                    break;
                case null:
                    break;
            }
            switch (m.DischargedAlive)
            {
                case "With Medical Advice":
                    chkdcWMA.Checked = true;
                    break;
                case "L.A.M.A":
                    chkdcLAMA.Checked = true;
                    break;
                case "Absconded":
                    chkdcABS.Checked = true;
                    break;
                case null:
                    break;
            }
            switch (m.DischargedDeath)
            {
                case "Under 48 Hrs":
                    chkdcU48.Checked = true;
                    break;
                case "Over 48 Hrs":
                    chkdcO48.Checked = true;
                    break;
                case null:
                    break;
            }
            txtCOD.Text = m.CauseOfDeath;
            txtDRC.Text = m.DirectCause;
            txtANC.Text = m.AntecedentCause;
            txtOTC.Text = m.OtherCause;
        }
    }
}
