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
    public partial class frmHCare : Form
    {
        public int _id { get; set; }

        void Init()
        {
            dtpDOA.DateTime = DateTime.Now.Date;
            dtpDOD.DateTime = DateTime.Now.Date;
        }

        void Clear()
        {
            txtENO.Text = "";
            txtMRD.Text = "";
            txtPNM.Text = "";
            txtAGE.Text = "";
            txtSEX.Text = "";
            txtADR.Text = "";
            txtFHD.Text = "";
            txtDGN.Text = "";
            txtAMC.Text = "";
        }
        public frmHCare()
        {
            InitializeComponent();
        }

        public frmHCare(int ID)
        {
            InitializeComponent();
            _id = ID;
            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            wrRSBY.HCARE h = new wrRSBY.HCARE();
            h = ws.GetHealthCareByID(ID);
            txtENO.Text = h.EnrollmentNo.ToString();
            txtMRD.Text = h.MRDNo;
            txtFHD.Text = h.FamilyHead;
            txtAMC.Text = h.AmountClaimed.ToString();
            dtpDOA.DateTime = h.AdmissionDate;
            dtpDOD.DateTime = h.DischargeDate;
            txtDGN.Text = h.Diagnosis;

            btnSave.Text = "&Update";
        }

        private void txtMRD_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                wrPatient.Patient p = new wrPatient.Patient();
                wrPatient.wsPatient wsptn = new wrPatient.wsPatient();
                p = wsptn.GetPatientByMRD(txtMRD.Text);
                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;

                wrMRD.MRD m = new wrMRD.MRD();
                wrMRD.wsMRD wsmrd = new wrMRD.wsMRD();
                m = wsmrd.GetPatientMRD(txtMRD.Text, "MRD");
                dtpDOA.DateTime = m.AdmissionDate;
                dtpDOD.DateTime = m.DischargeDate;
                txtDGN.Text = m.Diagnosis;
            }
            catch {; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;

            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            wrRSBY.HCARE h = new wrRSBY.HCARE();
            wrRSBY.Server2Client sc = new wrRSBY.Server2Client();

            h.ID = _id;
            h.EnrollmentNo = Convert.ToInt32(txtENO.Text);
            h.MRDNo = txtMRD.Text;
            h.PName = txtPNM.Text;
            h.Address = txtADR.Text;
            h.FamilyHead = txtFHD.Text;
            h.AmountClaimed = Convert.ToDouble(txtAMC.Text);
            h.AdmissionDate = dtpDOA.DateTime.Date;
            h.DischargeDate = dtpDOD.DateTime.Date;
            h.Diagnosis = txtDGN.Text;

            if (btnSave.Text == "&Save")
            {
                sc = ws.InsertHCare(h);

                if (sc.message == null)
                {
                    MessageBox.Show("Data successfully added!");
                    Clear();
                    Init();
                    txtENO.Focus();
                }
                else
                    MessageBox.Show(sc.message);
            }
            else
            {
                sc = ws.UpdateHCare(h);
                if (sc.message == null)
                {
                    MessageBox.Show("Data successfully updated!");
                    Close();
                }
                else
                    MessageBox.Show(sc.message);
            }
        }
    }
}
