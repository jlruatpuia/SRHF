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
    public partial class frmOTH : Form
    {
        wrOTH.wsOTH op = new wrOTH.wsOTH();
        wrOTH.Server2Client sc = new wrOTH.Server2Client();

        public int _id { get; set; }

        void Init()
        {
            sc = new wrOTH.Server2Client();
            sc = op.GetDailyNo(dtpIDT.DateTime.Date);
            txtDNO.Text = sc.count.ToString();

            sc = op.GetMonthlyNo(dtpIDT.DateTime.Date);
            txtMNO.Text = sc.count.ToString();

            sc = op.GetYearlyNo(dtpIDT.DateTime.Date);
            txtYNO.Text = sc.count.ToString();

            sc = op.AnaesthetistAutoComplete();
            for(int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                cboANE.Properties.Items.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

            sc = op.SurgeonAutoComplete();
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                cboSRG.Properties.Items.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

            sc = op.AssistantAutoComplete();
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                cboAST.Properties.Items.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }
        }

        void Reset()
        {
            Init();
            txtEMR.Text = "";
            txtPNM.Text = "";
            txtADR.Text = "";
            txtAGE.Text = "";
            txtSEX.Text = "";
            txtOPN.Text = "";
            cboANE.SelectedIndex = -1;
            cboSRG.SelectedIndex = -1;
            cboAST.SelectedIndex = -1;
            txtRMK.Text = "";
        }
        public frmOTH()
        {
            InitializeComponent();
            dtpIDT.DateTime = DateTime.Now.Date;
            Init();
        }

        public frmOTH(int ID)
        {
            InitializeComponent();
            _id = ID;
            wrOTH.OpTheater o = new wrOTH.OpTheater();
            o = op.GetOpTheaterByID(ID);
            txtDNO.Text = o.DailyNo.ToString();
            txtMNO.Text = o.MonthlyNo.ToString();
            txtYNO.Text = o.YearlyNo.ToString();
            dtpIDT.DateTime = o.I_Date;
            txtEMR.Text = o.EMRNo;

            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(txtEMR.Text);
            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            txtSEX.Text = p.Sex;

            txtOPN.Text = o.OpName;
            rdoIOP.EditValue = o.PatientType;
            rdoANE.EditValue = o.Anaesthesia;
            rdoMJN.EditValue = o.OpType;
            cboANE.Text = o.Anaesthetist;
            cboSRG.Text = o.Surgeon;
            cboAST.Text = o.Assistant;
            txtRMK.Text = o.Remarks;
            btnSave.Text = "&Update";
        }

        private void txtEMR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                wrPatient.wsPatient ptn = new wrPatient.wsPatient();
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
            //error handler

            wrOTH.OpTheater o = new wrOTH.OpTheater();
            o.DailyNo = Convert.ToInt32(txtDNO.Text);
            o.MonthlyNo = Convert.ToInt32(txtMNO.Text);
            o.YearlyNo = Convert.ToInt32(txtYNO.Text);
            o.I_Date = dtpIDT.DateTime.Date;
            o.EMRNo = txtEMR.Text;
            o.OpName = txtOPN.Text;
            o.PatientType = rdoIOP.EditValue.ToString();
            o.Anaesthesia = Convert.ToInt32(rdoANE.EditValue);
            o.OpType = rdoMJN.EditValue.ToString();
            o.Anaesthetist = cboANE.Text;
            o.Surgeon = cboSRG.Text;
            o.Assistant = cboAST.Text;
            o.Remarks = txtRMK.Text;

            if(btnSave.Text == "&Save")
            {
                sc = op.AddOpTheater(o);
                if(sc.message==null)
                {
                    MessageBox.Show("Record successfully added!", "Information");
                    Reset();
                }
                else
                {
                    MessageBox.Show(sc.message);
                }
            }
            else
            {
                o.ID = _id;
                sc = op.UpdateOpTheater(o);
                if (sc.message == null)
                {
                    MessageBox.Show("Record successfully updated!", "Information");
                    Close();
                }
                else
                    MessageBox.Show(sc.message);
            }
        }
    }
}
