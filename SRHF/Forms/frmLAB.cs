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
    public partial class frmLAB : Form
    {
        wrLAB.wsLAB lab = new wrLAB.wsLAB();
        public int _id { get; set; }

        void Init()
        {
            dtpIDT.DateTime = DateTime.Now.Date;
            txtSNO.Text = lab.GetYearlySerialNo(dtpIDT.DateTime).ToString();
            txtDNO.Text = lab.GetDailySerialNo(dtpIDT.DateTime).ToString();
            
        }

        void Reset()
        {
            Init();
            txtEMR.Text = "";
            txtRCP.Clear();
            txtPNM.Clear();
            txtADR.Clear();
            txtAGE.Clear();
            txtSEX.Clear();
            cboIOP.SelectedIndex = -1;
            txtWRD.Clear();
            txtTPF.Clear();
            txtRMK.Clear();
            txtCRG.Text = "";
            txtEMR.Focus();
        }

        void WardAutoComplete()
        {
            wrLAB.Server2Client sc = new wrLAB.Server2Client();
            sc = lab.GetWardAutoComplete();
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                txtWRD.AutoCompleteCustomSource.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

            txtWRD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtWRD.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void TestsAutoComplete()
        {
            wrLAB.Server2Client sc = new wrLAB.Server2Client();
            sc = lab.GetTestsAutoComplete();
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                txtTPF.AutoCompleteCustomSource.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

            txtTPF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTPF.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public frmLAB()
        {
            InitializeComponent();
            Init();
            WardAutoComplete();
            TestsAutoComplete();
        }

        public frmLAB(int ID)
        {
            InitializeComponent();
            _id = ID;
            Init();
            WardAutoComplete();
            TestsAutoComplete();
            wrLAB.LAB b = new wrLAB.LAB();
            b = lab.GetLabRecordByID(ID);
            txtSNO.Text = b.SlNo.ToString();
            txtDNO.Text = b.DailyNo.ToString();
            dtpIDT.DateTime = b.I_Date;
            txtEMR.Text = b.EMRNo;
            txtRCP.Text = b.ReceiptNo;
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Patient x = new wrPatient.Patient();
            x = ptn.GetPatientByEMR(txtEMR.Text);

            txtPNM.Text = x.PName;
            txtADR.Text = x.Address;
            txtAGE.Text = x.Age.ToString();
            txtSEX.Text = x.Sex;
            cboIOP.Text = b.PatientType;
            txtWRD.Text = b.Ward;
            txtTPF.Text = b.TestPerformed;
            txtRMK.Text = b.Remarks;
            txtCRG.Text = b.Charge.ToString();
            btnSave.Text = "&Update";

        }
        private void txtEMR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                wrPatient.wsPatient ptn = new wrPatient.wsPatient();
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtEMR.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
                //txtRCP.Text = txtEMR.Text;
            }
        }

        private void txtEMR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wrPatient.wsPatient ptn = new wrPatient.wsPatient();
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtEMR.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
                //txtRCP.Text = txtEMR.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Error Handler
            wrLAB.LAB b = new wrLAB.LAB();
            b.ID = _id;
            b.I_Date = dtpIDT.DateTime;
            b.SlNo = Convert.ToInt32(txtSNO.Text);
            b.DailyNo = Convert.ToInt32(txtDNO.Text);
            b.ReceiptNo = txtRCP.Text;
            b.EMRNo = txtEMR.Text;
            b.PatientType = cboIOP.Text;
            b.Ward = txtWRD.Text;
            b.MRDNo = txtEMR.Text;
            b.TestPerformed = txtTPF.Text;
            double c = txtCRG.Text != "" ? Convert.ToDouble(txtCRG.Text) : 0;
            b.Charge = c;
            b.Remarks = txtRMK.Text;

            wrLAB.Server2Client sc = new wrLAB.Server2Client();
            if (btnSave.Text == "&Save")
            {
                sc = lab.AddLabRecord(b);

                if (sc.message == null)
                {
                    MessageBox.Show("Record added successfully!", "Information");
                    Reset();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
            else
            {
                sc = lab.UpdateLabRecord(b);
                if (sc.message == null)
                {
                    MessageBox.Show("Record updated successfully!", "Information");
                    Reset();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
        }

        private void cboIOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboIOP.SelectedIndex == 1)
            {
                txtWRD.ReadOnly = true;
                txtWRD.TabStop = false;
            }
            else if(cboIOP.SelectedIndex == 0)
            {
                txtWRD.ReadOnly = false;
                txtWRD.TabStop = true;
            }
        }
    }
}
