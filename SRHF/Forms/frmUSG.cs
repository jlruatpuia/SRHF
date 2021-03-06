﻿using System;
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
    public partial class frmUSG : Form
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrUSG.wsUSG usg = new wrUSG.wsUSG();

        public int ID { get; set; }
        void Init()
        {
            wrUSG.Server2Client sc = new wrUSG.Server2Client();
            sc = usg.GetDailyNo(dtpIDT.Value);
            txtDNO.Text = sc.count.ToString();

            sc = usg.GetMonthlyNo(dtpIDT.Value);
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

        public frmUSG()
        {
            InitializeComponent();
            Init();
        }

        public frmUSG(int id)
        {
            InitializeComponent();
            ID = id;

            wrUSG.USG x = new wrUSG.USG();

            x = usg.GetUSGByID(id);

            txtDNO.Text = x.DailyNo.ToString();
            txtMNO.Text = x.MonthlyNo.ToString();
            dtpIDT.Value = x.I_Date;
            txtEMR.Text = x.EMRNo;
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(txtEMR.Text);

            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            txtSEX.Text = p.Sex;

            txtDGN.Text = x.Diagnosis;
            txtRMK.Text = x.Remarks;
            txtRCP.Text = x.ReceiptNo;
            txtCRG.Text = x.Charge.ToString();

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

            wrUSG.Server2Client sc = new wrUSG.Server2Client();
            wrUSG.USG x = new wrUSG.USG();
            x.I_Date = dtpIDT.Value.Date;
            x.DailyNo = Convert.ToInt32(txtDNO.Text);
            x.MonthlyNo = Convert.ToInt32(txtMNO.Text);
            x.EMRNo = txtEMR.Text;
            x.Diagnosis = txtDGN.Text;
            x.ReceiptNo = txtRCP.Text;
            x.Remarks = txtRMK.Text;
            x.Charge =Convert.ToDouble( txtCRG.Text);

            string msg = "";

            if (btnSave.Text == "&Save")
            {
                msg = "Registered";
                sc = usg.AddUSG(x);
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
                x.ID = ID;
                sc = usg.UpdateUSG(x);
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
