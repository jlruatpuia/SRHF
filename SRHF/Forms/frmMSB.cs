using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRHF.Forms
{
    public partial class frmMSB : Form
    {
        public bool AlreadyEntered { get; set; }
        public int MSBID { get; set; }

        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        public frmMSB()
        {
            InitializeComponent();
            txtBLTYR.Text = DateTime.Now.Year.ToString();
            cboBLTMN.SelectedIndex = DateTime.Now.Month - 1;
            
            Init();
        }

        private void Init()
        {
            wrPatient.MSB b = new wrPatient.MSB();
            b = ptn.RecollectMSB(cboBLTMN.SelectedIndex + 1, Convert.ToInt32(txtBLTYR.Text));
            if (b.ID == 0)
            {
                b = ptn.CollectMSB(cboBLTMN.SelectedIndex + 1, Convert.ToInt32(txtBLTYR.Text));
                AlreadyEntered = false;
            }
            else
            {
                b = ptn.RecollectMSB(cboBLTMN.SelectedIndex + 1, Convert.ToInt32(txtBLTYR.Text));
                AlreadyEntered = true;
            }
            txtBEDST.Text = b.BedStrength.ToString();
            txtTPCOP.Text = b.TotalPatientCareOPD.ToString();
            txtTPCCS.Text = b.TotalPatientCareCAS.ToString();
            txtTPCNC.Text = b.TotalPatientCareNew.ToString();
            txtTPCOC.Text = b.TotalPatientCareOld.ToString();
            txtTAFOP.Text = b.TotalAdmissionFromOPD.ToString();
            txtTAFCS.Text = b.TotalAdmissionFromCAS.ToString();
            txtIFULAB.Text = b.InvestigationLAB.ToString();
            txtIFUXRAY.Text = b.InvestigationXRAY.ToString();
            txtIFUEND.Text = b.InvestigationENDO.ToString();
            txtIFUUSG.Text = b.InvestigationUSG.ToString();
            txtIFUECG.Text = b.InvestigationECG.ToString();
            txtIFUBRN.Text = b.InvestigationBRON.ToString();
            txtIFUCOL.Text = b.InvestigationCOLON.ToString();
            txtIFURAD.Text = b.InvestigationRADIO.ToString();
            txtIFUEEG.Text = b.InvestigationEEG.ToString();
            txtIFUECH.Text = b.InvestigationECHO.ToString();
            txtIFUPFT.Text = b.InvestigationPFT.ToString();
            txtIFUDTC.Text = b.InvestigationDIET.ToString();
            txtIFUDIA.Text = b.InvestigationDIAL.ToString();
            txtIFUCHE.Text = b.InvestigationCHEMO.ToString();
            txtIFUPHY.Text = b.InvestigationPMR.ToString();
            txtOPRMMJ.Text = b.OperationMajor.ToString();
            txtOPRMN.Text = b.OperationMinor.ToString();
            txtDELLBM.Text = b.DeliveryLiveMale.ToString();
            txtDELLBF.Text = b.DeliveryLiveFemale.ToString();
            txtDELSBM.Text = b.DeliveryStillMale.ToString();
            txtDELSBF.Text = b.DeliveryStillFemale.ToString();
            txtDSCALV.Text = b.DischargeAlive.ToString();
            txtDSCDTH.Text = b.DischargeDeath.ToString();
            txtDSCU48.Text = b.DischargeDeathU48.ToString();
            txtDSCO48.Text = b.DischargeDeathO48.ToString();
            txtTHDPD.Text = b.PatientDischargedDays.ToString();
            txtAVGLS.Text = b.AverageLengthOfStay.ToString();
            txtTIPCS.Text = b.TotalInPatientCensus.ToString();
            txtAVGBO.Text = b.AvgPercOfBedOccupancy.ToString();
            txtBTOVR.Text = b.BedTurnOverRate.ToString();
            txtIPMAX.Text = b.DailyCensusOfIndoorPatientMAX.ToString();
            txtIPMIN.Text = b.DailyCensusOfIndoorPatientMIN.ToString();
            txtAUTOP.Text = b.NoOfAutopsy.ToString();
            txtCROM.Text = b.CaseReferredOutsideMizoram.ToString();
            txtHCARE.Text = b.HealthCare.ToString();
            txtRSBY.Text = b.RSBY.ToString();
            MSBID = b.ID;
                
            
        }

        private void wc_FinishClick(object sender, CancelEventArgs e)
        {
            if(MessageBox.Show("Confirm data entry?", "Confirm submit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                wrPatient.MSB b = new wrPatient.MSB();
                b.HospitalName = txtHSPNM.Text;
                b.Month = cboBLTMN.SelectedIndex + 1;
                b.Year = Convert.ToInt32(txtBLTYR.Text);
                b.BedStrength = Convert.ToInt32(txtBEDST.Text);
                b.TotalPatientCareOPD = Convert.ToInt32(txtTPCOP.Text);
                b.TotalPatientCareCAS = Convert.ToInt32(txtTPCCS.Text);
                b.TotalPatientCareNew = Convert.ToInt32(txtTPCNC.Text);
                b.TotalPatientCareOld = Convert.ToInt32(txtTPCOC.Text);
                b.TotalAdmissionFromOPD = Convert.ToInt32(txtTAFOP.Text);
                b.TotalAdmissionFromCAS = Convert.ToInt32(txtTAFCS.Text);
                b.InvestigationLAB = Convert.ToInt32(txtIFULAB.Text);
                b.InvestigationXRAY = Convert.ToInt32(txtIFUXRAY.Text);
                b.InvestigationENDO = Convert.ToInt32(txtIFUEND.Text);
                b.InvestigationUSG = Convert.ToInt32(txtIFUUSG.Text);
                b.InvestigationECG = Convert.ToInt32(txtIFUECG.Text);
                b.InvestigationBRON = Convert.ToInt32(txtIFUBRN.Text);
                b.InvestigationCOLON = Convert.ToInt32(txtIFUCOL.Text);
                b.InvestigationRADIO = Convert.ToInt32(txtIFURAD.Text);
                b.InvestigationEEG = Convert.ToInt32(txtIFUEEG.Text);
                b.InvestigationECHO = Convert.ToInt32(txtIFUECH.Text);
                b.InvestigationPFT = Convert.ToInt32(txtIFUPFT.Text);
                b.InvestigationDIET = Convert.ToInt32(txtIFUDTC.Text);
                b.InvestigationDIAL = Convert.ToInt32(txtIFUDIA.Text);
                b.InvestigationCHEMO = Convert.ToInt32(txtIFUCHE.Text);
                b.InvestigationPMR = Convert.ToInt32(txtIFUPHY.Text);
                b.OperationMajor = Convert.ToInt32(txtOPRMMJ.Text);
                b.OperationMinor = Convert.ToInt32(txtOPRMN.Text);
                b.DeliveryLiveMale = Convert.ToInt32(txtDELLBM.Text);
                b.DeliveryLiveFemale = Convert.ToInt32(txtDELLBF.Text);
                b.DeliveryStillMale = Convert.ToInt32(txtDELSBM.Text);
                b.DeliveryStillFemale = Convert.ToInt32(txtDELSBF.Text);
                b.DischargeAlive = Convert.ToInt32(txtDSCALV.Text);
                b.DischargeDeath = Convert.ToInt32(txtDSCDTH.Text);
                b.DischargeDeathU48 = Convert.ToInt32(txtDSCU48.Text);
                b.DischargeDeathO48 = Convert.ToInt32(txtDSCO48.Text);
                b.PatientDischargedDays = Convert.ToInt32(txtTHDPD.Text);
                b.AverageLengthOfStay = Convert.ToDouble(txtAVGLS.Text);
                b.TotalInPatientCensus = Convert.ToDouble(txtTIPCS.Text);
                b.AvgPercOfBedOccupancy = Convert.ToDouble(txtAVGBO.Text);
                b.BedTurnOverRate = Convert.ToDouble(txtBTOVR.Text);
                b.DailyCensusOfIndoorPatientMAX = Convert.ToDouble(txtIPMAX.Text);
                b.DailyCensusOfIndoorPatientMIN = Convert.ToDouble(txtIPMIN.Text);
                b.NoOfAutopsy = Convert.ToInt32(txtAUTOP.Text);
                b.CaseReferredOutsideMizoram = Convert.ToInt32(txtCROM.Text);
                b.HealthCare = Convert.ToDouble(txtHCARE.Text);
                b.RSBY = Convert.ToDouble(txtRSBY.Text);

                wrPatient.Server2Client sc = new wrPatient.Server2Client();
                if (!AlreadyEntered)
                {
                    sc = ptn.AddMSB(b);
                    if (sc.message == null)
                        MessageBox.Show("Record added successfully!", "Information");
                    else
                        MessageBox.Show(sc.message, "Error");
                }
                else
                {
                    sc = ptn.UpdateMSB(b);
                    if (sc.message == null)
                        MessageBox.Show("Record updated successfully!", "Information");
                    else
                        MessageBox.Show(sc.message, "Error");
                }
            }
        }

        private void txtTPCOP_EditValueChanged(object sender, EventArgs e)
        {
            txtTPCTT.EditValue = Convert.ToInt32(txtTPCOP.EditValue) + Convert.ToInt32(txtTPCCS.EditValue);
        }

        private void txtTPCCS_EditValueChanged(object sender, EventArgs e)
        {
            txtTPCTT.EditValue = Convert.ToInt32(txtTPCOP.EditValue) + Convert.ToInt32(txtTPCCS.EditValue);
        }

        private void txtTAFOP_EditValueChanged(object sender, EventArgs e)
        {
            txtTAFTT.EditValue = Convert.ToInt32(txtTAFOP.EditValue) + Convert.ToInt32(txtTAFCS.EditValue);
        }

        private void txtTAFCS_EditValueChanged(object sender, EventArgs e)
        {
            txtTAFTT.EditValue = Convert.ToInt32(txtTAFOP.EditValue) + Convert.ToInt32(txtTAFCS.EditValue);
        }

        private void txtOPRMMJ_EditValueChanged(object sender, EventArgs e)
        {
            txtOPRTT.EditValue = Convert.ToInt32(txtOPRMMJ.EditValue) + Convert.ToInt32(txtOPRMN.EditValue);
        }

        private void txtOPRMN_EditValueChanged(object sender, EventArgs e)
        {
            txtOPRTT.EditValue = Convert.ToInt32(txtOPRMMJ.EditValue) + Convert.ToInt32(txtOPRMN.EditValue);
        }

        private void txtDELLBM_EditValueChanged(object sender, EventArgs e)
        {
            txtDELLBT.EditValue = Convert.ToInt32(txtDELLBM.EditValue) + Convert.ToInt32(txtDELLBF.EditValue);
        }

        private void txtDELLBF_EditValueChanged(object sender, EventArgs e)
        {
            txtDELLBT.EditValue = Convert.ToInt32(txtDELLBM.EditValue) + Convert.ToInt32(txtDELLBF.EditValue);
        }

        private void txtDELSBM_EditValueChanged(object sender, EventArgs e)
        {
            txtDELSBT.EditValue = Convert.ToInt32(txtDELSBM.EditValue) + Convert.ToInt32(txtDELSBF.EditValue);
        }

        private void txtDELSBF_EditValueChanged(object sender, EventArgs e)
        {
            txtDELSBT.EditValue = Convert.ToInt32(txtDELSBM.EditValue) + Convert.ToInt32(txtDELSBF.EditValue);
        }

        private void txtDSCALV_EditValueChanged(object sender, EventArgs e)
        {
            txtDSCTTL.EditValue = Convert.ToInt32(txtDSCALV.EditValue) + Convert.ToInt32(txtDSCDTH.EditValue);
        }

        private void txtDSCDTH_EditValueChanged(object sender, EventArgs e)
        {
            txtDSCTTL.EditValue = Convert.ToInt32(txtDSCALV.EditValue) + Convert.ToInt32(txtDSCDTH.EditValue);
        }

        private void cboBLTMN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Init();
        }
    }
}
