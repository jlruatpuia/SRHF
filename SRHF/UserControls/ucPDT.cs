using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRHF.Reports;
using DevExpress.XtraReports.UI;

namespace SRHF.UserControls
{
    public partial class ucPDT : UserControl
    {
        public ucPDT()
        {
            InitializeComponent();
            txtEMR.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string emr = txtEMR.Text;

            rptPtnDetail rpt = new rptPtnDetail();

            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(emr);
            rpt.lbEMR.Text = p.EMRNo;
            rpt.lbPNM.Text = p.PName;
            rpt.lbADR.Text = p.Address;
            rpt.lbAGE.Text = p.Age.ToString();
            rpt.lbSEX.Text = p.Sex;

            

            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.Server2Client scmrd = new wrMRD.Server2Client();
            scmrd = mrd.GetMRDByEMR(emr);
            if(scmrd.dt .Rows.Count > 0)
            {
                rptPtnMRD rptmrd = new rptPtnMRD();
                rptmrd.DataSource = scmrd.dt;
                rptmrd.lbMRD.DataBindings.Add("Text", null, "MRDNo");
                rptmrd.lbDGN.DataBindings.Add("Text", null, "ICDCode");
                rptmrd.lbDOA.DataBindings.Add("Text", null, "AdmissionDate", "{0:dd-MM-yyyy}");
                rptmrd.lbDOD.DataBindings.Add("Text", null, "DischargeDate", "{0:dd-MM-yyyy}");
                //rptmrd.lbRMK.DataBindings.Add("Text", null, "Remarks");

                //XRSubreport srptMRD = new XRSubreport();
                //srptMRD.ReportSource = rptmrd;
                //rpt.Detail.Controls.Add(srptMRD);
                rpt.xrSubreport1.ReportSource = rptmrd;
            }

            wrLAB.wsLAB lab = new wrLAB.wsLAB();
            wrLAB.Server2Client sclab = new wrLAB.Server2Client();
            sclab = lab.GetLabRecordByEMR(emr);
            if(sclab.dt.Rows.Count > 0)
            {
                rptPtnLab rptlab = new rptPtnLab() { DataSource = sclab.dt };
                rptlab.lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
                rptlab.lbTPF.DataBindings.Add("Text", null, "TestPerformed");
                rptlab.lbRMK.DataBindings.Add("Text", null, "Remarks");
                rptlab.lbRNO.DataBindings.Add("Text", null, "ReceiptNo");
                rptlab.lbCRG.DataBindings.Add("Text", null, "Charge", "{0:C2}");
                //XRSubreport srptLAB = new XRSubreport();
                //srptLAB.ReportSource = rptlab;
                //rpt.Detail.Controls.Add(srptLAB);
                rpt.xrSubreport2.ReportSource = rptlab;
            }

            wrOTH.wsOTH oth = new wrOTH.wsOTH();
            wrOTH.Server2Client scoth = new wrOTH.Server2Client();
            scoth = oth.GetOpTheaterByEMR(emr);
            if(scoth.dt.Rows.Count > 0)
            {
                rptPtnOth rptoth = new rptPtnOth() { DataSource = scoth.dt };
                rptoth.lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
                rptoth.lbONM.DataBindings.Add("Text", null, "Opname");
                rptoth.lbANE.DataBindings.Add("Text", null, "Anaesthesia");
                rptoth.lbOTP.DataBindings.Add("Text", null, "OpType");
                rptoth.lbANT.DataBindings.Add("Text", null, "Anaesthetist");
                rptoth.lbSGN.DataBindings.Add("Text", null, "Surgeon");
                rptoth.lbAST.DataBindings.Add("Text", null, "Assistant");
                rptoth.lbRMK.DataBindings.Add("Text", null, "Remarks");

                rpt.xrSubreport3.ReportSource = rptoth;
            }

            wrXRAY.wsXRAY xray = new wrXRAY.wsXRAY();
            wrXRAY.Server2Client scx = new wrXRAY.Server2Client();
            scx = xray.GetXrayByEMR(emr);
            if(scx.dt.Rows.Count > 0)
            {
                rptPtnXRAY rptx = new rptPtnXRAY() { DataSource = scx.dt };
                rptx.lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
                rptx.lbDGN.DataBindings.Add("Text", null, "Diagnosis");
                rptx.lbRMK.DataBindings.Add("Text", null, "Remarks");
                rptx.lbRNO.DataBindings.Add("Text", null, "ReceiptNo");
                rptx.lbCRG.DataBindings.Add("Text", null, "Charge", "{0:C2}");

                rpt.xrSubreport4.ReportSource = rptx;
            }

            wrECG.wsECG ecg = new wrECG.wsECG();
            wrECG.Server2Client scecg = new wrECG.Server2Client();
            scecg = ecg.GetECGByEMR(emr);
            if(scecg.dt.Rows.Count > 0)
            {
                rptPtnECG rptx = new rptPtnECG() { DataSource = scecg.dt };
                rptx.lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
                rptx.lbDGN.DataBindings.Add("Text", null, "Diagnosis");
                rptx.lbRMK.DataBindings.Add("Text", null, "Remarks");
                rptx.lbRNO.DataBindings.Add("Text", null, "ReceiptNo");
                rptx.lbCRG.DataBindings.Add("Text", null, "Charge", "{0:C2}");

                rpt.xrSubreport5.ReportSource = rptx;
            }

            wrUSG.wsUSG usg = new wrUSG.wsUSG();
            wrUSG.Server2Client scusg = new wrUSG.Server2Client();
            scusg = usg.GetUSGByEMR(emr);
            if(scusg.dt.Rows.Count > 0)
            {
                rptPtnUSG rptx = new rptPtnUSG() { DataSource = scusg.dt };
                rptx.lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
                rptx.lbDGN.DataBindings.Add("Text", null, "Diagnosis");
                rptx.lbRMK.DataBindings.Add("Text", null, "Remarks");
                rptx.lbRNO.DataBindings.Add("Text", null, "ReceiptNo");
                rptx.lbCRG.DataBindings.Add("Text", null, "Charge", "{0:C2}");

                rpt.xrSubreport6.ReportSource = rptx;
            }

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }
    }
}
