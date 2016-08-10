using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRHF.Reports;

namespace SRHF.Forms
{
    public partial class frmViewMSB : Form
    {
        public frmViewMSB()
        {
            InitializeComponent();
            cboMNO.SelectedIndex = DateTime.Now.Month - 1;
            txtYNO.Text = DateTime.Now.Year.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            int m = cboMNO.SelectedIndex + 1;
            int y = Convert.ToInt32(txtYNO.Text);
            rptMSBPage1 rptm = new rptMSBPage1();
            wrPatient.MSB b = new wrPatient.MSB();
            b = ptn.CollectMSB(m, y);
            rptm.lbHNAME.Text = "STATE REFERRAL HOSPITAL, FALKAWN";
            rptm.lbMNTH.Text = Codes.MySettings.MonthName(m);
            rptm.lbYEAR.Text = y.ToString();
            rptm.lbBEDSTR.Text = b.BedStrength.ToString();
            rptm.lbTPCOPD.Text = b.TotalPatientCareOPD.ToString();
            rptm.lbTPCCAS.Text = b.TotalPatientCareCAS.ToString();
            rptm.lbTPCTTL.Text = (b.TotalPatientCareOPD + b.TotalPatientCareCAS).ToString();
            rptm.lbTPCNEW.Text = b.TotalPatientCareNew.ToString();
            rptm.lbTPCOLD.Text = b.TotalPatientCareOld.ToString();
            rptm.lbTAFOPD.Text = b.TotalAdmissionFromOPD.ToString();
            rptm.lbTAFCAS.Text = b.TotalAdmissionFromCAS.ToString();
            rptm.lbIFULAB.Text = b.InvestigationLAB.ToString();
            rptm.lbIFUXRY.Text = b.InvestigationXRAY.ToString();
            rptm.lbIFUEND.Text = b.InvestigationENDO.ToString();
            rptm.lbIFUUSG.Text = b.InvestigationUSG.ToString();
            rptm.lbIFUECG.Text = b.InvestigationECG.ToString();
            rptm.lbIFUBRO.Text = b.InvestigationBRON.ToString();
            rptm.lbIFUCOL.Text = b.InvestigationCOLON.ToString();
            rptm.lbIFURAD.Text = b.InvestigationRADIO.ToString();
            rptm.lbIFUEEG.Text = b.InvestigationEEG.ToString();
            rptm.lbIFUECH.Text = b.InvestigationECHO.ToString();
            rptm.lbIFUPFT.Text = b.InvestigationPFT.ToString();
            rptm.lbIFUDIE.Text = b.InvestigationDIET.ToString();
            rptm.lbIFUDIA.Text = b.InvestigationDIAL.ToString();
            rptm.lbIFUCTS.Text = b.InvestigationCTSCAN.ToString();
            rptm.lbIFUCHE.Text = b.InvestigationCHEMO.ToString();
            rptm.lbIFUPHY.Text = b.InvestigationPMR.ToString();
            rptm.lbOPRMJR.Text = b.OperationMajor.ToString();
            rptm.lbOPRMNR.Text = b.OperationMinor.ToString();
            rptm.lbOPRTTL.Text = (b.OperationMajor + b.OperationMinor).ToString();
            rptm.lbDELLBM.Text = b.DeliveryLiveMale.ToString();
            rptm.lbDELLBF.Text = b.DeliveryLiveFemale.ToString();
            rptm.lbDELLBT.Text = (b.DeliveryLiveMale + b.DeliveryLiveFemale).ToString();
            rptm.lbDELSBM.Text = b.DeliveryStillMale.ToString();
            rptm.lbDELSBF.Text = b.DeliveryStillFemale.ToString();
            rptm.lbDELSBT.Text = (b.DeliveryStillMale + b.DeliveryStillFemale).ToString();
            rptm.lbDSCALV.Text = b.DischargeAlive.ToString();
            rptm.lbDSCDTH.Text = b.DischargeDeath.ToString();
            rptm.lbDSCTTL.Text = (b.DischargeAlive + b.DischargeDeath).ToString();
            rptm.lbDSCU48.Text = b.DischargeDeathU48.ToString();
            rptm.lbDSCO48.Text = b.DischargeDeathO48.ToString();
            rptm.lbTHDOPD.Text = b.PatientDischargedDays.ToString();
            rptm.lbAVGLOS.Text = b.AverageLengthOfStay.ToString();
            rptm.lbTTIPCS.Text = b.TotalInPatientCensus.ToString();
            rptm.lbAPOBOC.Text = b.AvgPercOfBedOccupancy.ToString();
            rptm.lbBEDTOR.Text = b.BedTurnOverRate.ToString();
            rptm.lbDIPMAX.Text = b.DailyCensusOfIndoorPatientMAX.ToString();
            rptm.lbDIPMIN.Text = b.DailyCensusOfIndoorPatientMIN.ToString();
            rptm.lbNOFAUT.Text = b.NoOfAutopsy.ToString();
            rptm.lbCROMZR.Text = b.CaseReferredOutsideMizoram.ToString();
            rptm.lbHLTCRE.Text = b.HealthCare.ToString();
            rptm.lbRSBY.Text = b.RSBY.ToString();

            rptDWD rptd = new rptDWD();
            sc = ptn.GetDepartmentWiseData(m, y);
            rptd.lbMYR.Text = "OPD FOR THE MONTH OF " + Codes.MySettings.MonthName(m) + ", " + y.ToString();
            rptd.DataSource = sc.dt;
            rptd.lbDNM.DataBindings.Add("Text", null, "DeptName");
            rptd.lbNEW.DataBindings.Add("Text", null, "NewCase");
            rptd.lbOLD.DataBindings.Add("Text", null, "OldCase");
            rptd.lbTOT.DataBindings.Add("Text", null, "Total");
            rptd.lbAVG.DataBindings.Add("Text", null, "Average");

            rptWWD rptw = new rptWWD();
            //WardNo, WardName, Bed, Admission, Discharge, Death, AvgStay, BedOccupancy
            sc = ptn.GetWardWiseData(m, y);
            rptw.lbMYR.Text = "OPD FOR THE MONTH OF " + Codes.MySettings.MonthName(m) + ", " + y.ToString();
            rptw.DataSource = sc.dt;
            rptw.lbWNM.DataBindings.Add("Text", null, "WardName");
            rptw.lbBED.DataBindings.Add("Text", null, "Bed");
            rptw.lbADM.DataBindings.Add("Text", null, "Admission");
            rptw.lbDSC.DataBindings.Add("Text", null, "Discharge");
            rptw.lbDTH.DataBindings.Add("Text", null, "Death");
            rptw.lbAVG.DataBindings.Add("Text", null, "AvgStay");
            rptw.lbBOC.DataBindings.Add("Text", null, "BedOccupancy");

            rptMonthlyBulletin rpt = new rptMonthlyBulletin();
            rpt.srMSB.ReportSource = rptm;
            rpt.srDWD.ReportSource = rptd;
            rpt.srWWD.ReportSource = rptw;
            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);

        }
    }
}
