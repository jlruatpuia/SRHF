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
    public partial class frmOPD : Form
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrOPD.wsOPD opd = new wrOPD.wsOPD();

        public string Sex { get; set; }
        void InitNos()
        {
            wrOPD.Server2Client sc = new wrOPD.Server2Client();
            sc = opd.GetDailyNo(dtpIDT.Value);
            txtDNO.Text = sc.count.ToString();

            sc = opd.GetMonthlyNo(dtpIDT.Value);
            txtMNO.Text = sc.count.ToString();

            sc = opd.GetYearlyNo(dtpIDT.Value);
            txtYNO.Text = sc.count.ToString();

            sc = opd.GetEMRNo(dtpIDT.Value);
            txtEMR.Text = dtpIDT.Value.Year.ToString().Substring(2) + sc.count.ToString("00000");
        }

        void AutoComplete()
        {
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            sc = ptn.GetAddressAutoComplete();
            for(int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                txtADR.AutoCompleteCustomSource.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

            txtADR.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtADR.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void Reset()
        {
            InitNos();
            txtPNM.Clear();
            txtADR.Clear();
            txtAGE.Clear();
            txtOPD.Clear();
            txtPNM.Focus();
        }

        public frmOPD()
        {
            InitializeComponent();

            InitNos();
            AutoComplete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Error Handler goes here

            wrPatient.Server2Client scp = new wrPatient.Server2Client();
            wrPatient.Patient p = new wrPatient.Patient();
            p.EMRNo = txtEMR.Text;
            p.PName = txtPNM.Text;
            p.Address = txtADR.Text;
            p.Age = Convert.ToInt32(txtAGE.Text);
            p.Sex = cboSex.Text;

            scp = ptn.AddPatient(p);

            if (scp.message == null)
            {
                wrOPD.Server2Client sco = new wrOPD.Server2Client();
                wrOPD.OPD o = new wrOPD.OPD();

                o.I_Date = dtpIDT.Value.Date;
                o.DailyNo = Convert.ToInt32(txtDNO.Text);
                o.MonthlyNo = Convert.ToInt32(txtMNO.Text);
                o.YearlyNo = Convert.ToInt32(txtYNO.Text);
                o.EMRNo = txtEMR.Text;
                o.OPDNo = Convert.ToInt32(txtOPD.Text);

                sco = opd.AddOPD(o);

                if (sco.message == null)
                {
                    MessageBox.Show("Registration successful!", "Information");
                    Reset();
                }
                else
                    MessageBox.Show(sco.message);
            }
            else
                MessageBox.Show(scp.message);
        }

        
    }
}
