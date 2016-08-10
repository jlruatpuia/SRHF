using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SRHF.Reports
{
    public partial class rptMSBPage1 : XtraReport
    {
        public rptMSBPage1()
        {
            InitializeComponent();
        }

        public rptMSBPage1(int month, int year)
        {
            InitializeComponent();
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();

            wrPatient.MSB b = new wrPatient.MSB();
            b = ptn.CollectMSB(month, year);
            lbHNAME.Text = "STATE REFERRAL HOSPITAL, FALKAWN";
            lbMNTH.Text = Codes.MySettings.MonthName(month);
            lbYEAR.Text = year.ToString();
            lbBEDSTR.Text = b.BedStrength.ToString();
            lbTPCOPD.Text = b.TotalPatientCareOPD.ToString();
            lbTPCCAS.Text = b.TotalPatientCareCAS.ToString();
            lbTPCNEW.Text = b.TotalPatientCareNew.ToString();
            lbTPCOLD.Text = b.TotalPatientCareOld.ToString();
            lbTAFOPD.Text = b.TotalAdmissionFromOPD.ToString();
            lbTAFCAS.Text = b.TotalAdmissionFromCAS.ToString();
            lbIFULAB.Text = b.InvestigationLAB.ToString();
            lbIFUXRY.Text = b.InvestigationXRAY.ToString();
            lbIFUEND.Text = b.InvestigationENDO.ToString();
            lbIFUUSG.Text = b.InvestigationUSG.ToString();
            lbIFUECG.Text = b.InvestigationECG.ToString();
            lbIFUBRO.Text = b.InvestigationBRON.ToString();
            lbIFUCOL.Text = b.InvestigationCOLON.ToString();
            lbIFURAD.Text = b.InvestigationRADIO.ToString();
            lbIFUEEG.Text = b.InvestigationEEG.ToString();
            lbIFUECH.Text = b.InvestigationECHO.ToString();
            lbIFUPFT.Text = b.InvestigationPFT.ToString();
            lbIFUDIE.Text = b.InvestigationDIET.ToString();
            lbIFUDIA.Text = b.InvestigationDIAL.ToString();
            lbIFUCHE.Text = b.InvestigationCHEMO.ToString();
            lbIFUPHY.Text = b.InvestigationPMR.ToString();
            lbOPRMJR.Text = b.OperationMajor.ToString();
            lbOPRMNR.Text = b.OperationMinor.ToString();
            lbDELLBM.Text = b.DeliveryLiveMale.ToString();
            lbDELLBF.Text = b.DeliveryLiveFemale.ToString();
            lbDELSBM.Text = b.DeliveryStillMale.ToString();
            lbDELSBF.Text = b.DeliveryStillFemale.ToString();
            lbDSCALV.Text = b.DischargeAlive.ToString();
            lbDSCDTH.Text = b.DischargeDeath.ToString();
            lbDSCU48.Text = b.DischargeDeathU48.ToString();
            lbDSCO48.Text = b.DischargeDeathO48.ToString();
            lbTHDOPD.Text = b.PatientDischargedDays.ToString();
            lbAVGLOS.Text = b.AverageLengthOfStay.ToString();
            lbTTIPCS.Text = b.TotalInPatientCensus.ToString();
            lbAPOBOC.Text = b.AvgPercOfBedOccupancy.ToString();
            lbBEDTOR.Text = b.BedTurnOverRate.ToString();
            lbDIPMAX.Text = b.DailyCensusOfIndoorPatientMAX.ToString();
            lbDIPMIN.Text = b.DailyCensusOfIndoorPatientMIN.ToString();
            lbNOFAUT.Text = b.NoOfAutopsy.ToString();
            lbCROMZR.Text = b.CaseReferredOutsideMizoram.ToString();
            lbHLTCRE.Text = b.HealthCare.ToString();
            lbRSBY.Text = b.RSBY.ToString();
        }

    }
}
