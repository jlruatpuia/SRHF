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
    public partial class frmRSBY : Form
    {
        public int _id { get; set; }
        void Init()
        {
            wrRSBY.wsRSBY rsby = new wrRSBY.wsRSBY();
            txtSNO.Text = rsby.GetSerialNo().ToString();

            dtpDOA.DateTime = DateTime.Now.Date;
            dtpDOD.DateTime = DateTime.Now.Date;

            wrSettings.wsSettings g = new wrSettings.wsSettings();
            wrSettings.Server2Client scg = new wrSettings.Server2Client();
            scg = g.GetWards();
            for(int i = 0; i <= scg.dt.Rows.Count - 1; i++)
            {
                cboWRD.Properties.Items.Add(scg.dt.Rows[i].ItemArray[2].ToString());
            }

        }

        void Clear()
        {
            txtMRD.Text = "";
            txtPNM.Text = "";
            txtAGE.Text = "";
            txtSEX.Text = "";
            txtADR.Text = "";
            txtFHD.Text = "";
            txtCNO.Text = "";
            cboWRD.Text = "";
            txtPKG.Text = "";
            txtTBL.Text = "";
            txtAMT.Text = "";
            txtHSH.Text = "";
            txtURN.Text = "";
            rdoRMK.SelectedIndex = -1;
        }
        public frmRSBY()
        {
            InitializeComponent();
            Init();
        }

        public frmRSBY(int ID)
        {
            InitializeComponent();
            _id = ID;
            wrRSBY.RSBY r = new wrRSBY.RSBY();
            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            r = ws.GetRSBYByID(ID);
            txtSNO.Text = r.SlNo.ToString();
            txtMRD.Text = r.MRDNo;
            txtFHD.Text = r.FamilyHead;
            txtCNO.Text = r.ContactNo;
            cboWRD.Text = r.Ward;
            dtpDOA.DateTime = r.AdmissionDate;
            dtpDOD.DateTime = r.DischargeDate;
            txtPKG.Text = r.Packages;
            txtTBL.Text = r.TotalBill.ToString();
            txtAMT.Text = r.ActualAmount.ToString();
            txtHSH.Text = r.HospitalShare.ToString();
            txtURN.Text = r.URN;
            rdoRMK.EditValue = r.Remarks.ToString();
            btnSave.Text = "&Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;
            wrRSBY.wsRSBY rsby = new wrRSBY.wsRSBY();
            wrRSBY.Server2Client sc = new wrRSBY.Server2Client();
            wrRSBY.RSBY r = new wrRSBY.RSBY();
            r.ID = _id;
            r.SlNo = Convert.ToInt32(txtSNO.Text);
            r.MRDNo = txtMRD.Text;
            r.PName = txtPNM.Text;
            r.Address = txtADR.Text;
            r.FamilyHead = txtFHD.Text;
            r.ContactNo = txtCNO.Text;
            r.Ward = cboWRD.Text;
            r.AdmissionDate = dtpDOA.DateTime.Date;
            r.DischargeDate = dtpDOD.DateTime.Date;
            r.Packages = txtPKG.Text;
            r.TotalBill =Convert.ToDouble( txtTBL.Text);
            r.ActualAmount = Convert.ToDouble(txtAMT.Text);
            r.HospitalShare = Convert.ToDouble(txtHSH.Text);
            r.URN = txtURN.Text;
            r.Remarks = rdoRMK.EditValue.ToString();


            if(btnSave.Text == "&Save")
            {
                sc = rsby.InsertRSBY(r);
                if (sc.message == null)
                {
                    MessageBox.Show("Data successfully added!");
                    Clear();
                    Init();
                    txtMRD.Focus();
                }
                else
                    MessageBox.Show(sc.message);
            }
            else
            {
                sc = rsby.UpdateRSBY(r);
                if (sc.message == null)
                {
                    MessageBox.Show("Data successfully updated!");
                    Close();
                }
                else
                    MessageBox.Show(sc.message);
            }
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
                
            }
            catch {; }
        }
    }
}
