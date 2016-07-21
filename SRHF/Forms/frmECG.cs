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
    public partial class frmECG : Form
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrECG.wsECG ecg = new wrECG.wsECG();

        public int ID { get; set; }
        void Init()
        {
            wrECG.Server2Client sc = new wrECG.Server2Client();
            sc = ecg.GetDailyNo(dtpIDT.Value);
            txtDNO.Text = sc.count.ToString();

            sc = ecg.GetMonthlyNo(dtpIDT.Value);
            txtMNO.Text = sc.count.ToString();
        }

        void Reset()
        {
            Init();
            txtEMR.Text = "";
            txtPNM.Clear();
            txtADR.Clear();
            txtAGE.Clear();
            txtSEX.Clear();
            txtDGN.Clear();
            txtRMK.Clear();
            txtRCP.Clear();
            txtCRG.Clear();
            txtEMR.Focus();
        }

        public frmECG()
        {
            InitializeComponent();
            Init();
        }

        public frmECG(int id)
        {
            InitializeComponent();
            ID = id;
            wrECG.wsECG ecg = new wrECG.wsECG();
            wrECG.ECG g = new wrECG.ECG();

            g = ecg.GetECGByID(id);

            txtDNO.Text = g.DailyNo.ToString();
            txtMNO.Text = g.MonthlyNo.ToString();
            dtpIDT.Value = g.I_Date;
            txtEMR.Text = g.EMRNo;
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(txtEMR.Text);

            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            txtSEX.Text = p.Sex;

            txtDGN.Text = g.Diagnosis;
            txtRMK.Text = g.Remarks;
            txtRCP.Text = g.ReceiptNo;
            txtCRG.Text = g.Charge.ToString();

            btnSave.Text = "&Update";
        }

        private void txtEMR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
            {
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtEMR.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
            }
        }

        private void txtEMR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtEMR.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Error Handler

            wrECG.Server2Client sc = new wrECG.Server2Client();
            wrECG.ECG g = new wrECG.ECG();
            g.I_Date = dtpIDT.Value.Date;
            g.DailyNo = Convert.ToInt32(txtDNO.Text);
            g.MonthlyNo = Convert.ToInt32(txtMNO.Text);
            g.EMRNo = txtEMR.Text;
            g.Diagnosis = txtDGN.Text;
            g.ReceiptNo = txtRCP.Text;
            g.Remarks = txtRMK.Text;
            g.Charge =Convert.ToDouble( txtCRG.Text);

            string msg = "";

            if (btnSave.Text == "&Save")
            {
                msg = "Registered";
                sc = ecg.AddECG(g);
                if (sc.message == null)
                {
                    MessageBox.Show(msg + " successfully!", "Information");
                    Reset();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
            else
            {
                g.ID = ID;
                sc = ecg.UpdateECG(g);
                msg = "Updated";
                if (sc.message == null)
                {
                    MessageBox.Show(msg + " successfully!", "Information");
                    Close();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }

            
        }
    }
}
