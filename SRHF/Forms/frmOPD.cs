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
        public int _oid { get; set; }
        public DateTime _iDate { get; set; }
        public int _dailyNo { get; set; }
        public int _monthlyNo { get; set; }
        public int _yearlyNo { get; set; }
        public string _emrNo { get; set; }
        public int _pid { get; set; }
        public int _opdNo { get; set; }
        public string _case { get; set; }

        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrOPD.wsOPD opd = new wrOPD.wsOPD();

        public string Sex { get; set; }
        void InitNos()
        {
            wrOPD.Server2Client sc = new wrOPD.Server2Client();
            sc = opd.GetDailyNo(dtpIDT.DateTime.Date);
            txtDNO.Text = sc.count.ToString();

            sc = opd.GetMonthlyNo(dtpIDT.DateTime.Date);
            txtMNO.Text = sc.count.ToString();

            sc = opd.GetYearlyNo(dtpIDT.DateTime.Date);
            txtYNO.Text = sc.count.ToString();

            sc = opd.GetEMRNo(dtpIDT.DateTime.Date);
            txtEMR.Text = dtpIDT.DateTime.Year.ToString().Substring(2) + sc.count.ToString("00000");
        }

        void AutoComplete()
        {
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            sc = ptn.GetAddressAutoComplete();
            txtADR.Properties.Items.Add("");
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                txtADR.Properties.Items.Add(sc.dt.Rows[i].ItemArray[0].ToString());
            }

        }

        void Reset()
        {
            InitNos();
            rdoCase.SelectedIndex = 0;
            txtPNM.Text = "";
            txtADR.Text = "";
            txtAGE.Text = "";
            txtOPD.Text = "";
            txtPNM.Focus();
        }

        public frmOPD()
        {
            InitializeComponent();
            rdoCase.SelectedIndex = 0;
            dtpIDT.DateTime = DateTime.Now.Date;
            InitNos();
            AutoComplete();
        }

        public frmOPD(int oid, int pid)
        {
            InitializeComponent();
            _oid = oid;
            _pid = pid;
            AutoComplete();
            wrOPD.OPD o = new wrOPD.OPD();
            o = opd.GetOPDByID(oid);
            
            dtpIDT.DateTime = o.I_Date;
            txtDNO.Text = o.DailyNo.ToString();
            txtMNO.Text = o.MonthlyNo.ToString();
            txtYNO.Text = o.YearlyNo.ToString();
            if (o.Cases == "new")
                rdoCase.SelectedIndex = 0;
            else
                rdoCase.SelectedIndex = 1;
            txtEMR.Text = o.EMRNo;
            srcEMR.Text = o.EMRNo;
            txtOPD.Text = o.OPDNo.ToString();

            btnSave.Text = "&Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;

            wrPatient.Server2Client scp = new wrPatient.Server2Client();
            wrPatient.Patient p = new wrPatient.Patient();
            
            p.PName = txtPNM.Text;
            p.Address = txtADR.Text;
            p.Age = Convert.ToInt32(txtAGE.Text);
            p.Sex = cboSex.Text;

            if(btnSave.Text == "&Save")
            {
                if (_case == "new")
                {
                    p.EMRNo = txtEMR.Text;
                    scp = ptn.AddPatient(p);
                }
                else
                    p.EMRNo = srcEMR.Text;

                if (scp.message == null)
                {
                    wrOPD.Server2Client sco = new wrOPD.Server2Client();
                    wrOPD.OPD o = new wrOPD.OPD();

                    o.I_Date = dtpIDT.DateTime.Date;
                    o.DailyNo = Convert.ToInt32(txtDNO.Text);
                    o.MonthlyNo = Convert.ToInt32(txtMNO.Text);
                    o.YearlyNo = Convert.ToInt32(txtYNO.Text);
                    if (_case == "new")
                        o.EMRNo = txtEMR.Text;
                    else
                        o.EMRNo = srcEMR.Text;
                    o.OPDNo = Convert.ToInt32(txtOPD.Text);
                    o.Cases = _case;

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
            else
            {
                if (_case == "new")
                    p.EMRNo = txtEMR.Text;
                else
                    p.EMRNo = srcEMR.Text;
                p.ID = _pid;
                scp = ptn.UpdatePatient(p);
                if (scp.message == null)
                {
                    wrOPD.Server2Client sco = new wrOPD.Server2Client();
                    wrOPD.OPD o = new wrOPD.OPD();
                    o.ID = _oid;
                    o.I_Date = dtpIDT.DateTime.Date;
                    o.DailyNo = Convert.ToInt32(txtDNO.Text);
                    o.MonthlyNo = Convert.ToInt32(txtMNO.Text);
                    o.YearlyNo = Convert.ToInt32(txtYNO.Text);
                    if (_case == "new")
                        o.EMRNo = txtEMR.Text;
                    else
                        o.EMRNo = srcEMR.Text;
                    o.OPDNo = Convert.ToInt32(txtOPD.Text);
                    o.Cases = _case;

                    sco = opd.UpdateOPD(o);

                    if (sco.message == null)
                    {
                        MessageBox.Show("OPD data updated successfully!", "Information");
                        Close();
                    }
                    else
                        MessageBox.Show(sco.message);
                }
                else
                    MessageBox.Show(scp.message);

            }
            
        }

        private void rdoCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            _case = rdoCase.SelectedIndex == 0 ? "new" : "old";
            if(rdoCase.SelectedIndex == 0)
            {
                _case = "new";
                lciEMRA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciEMRS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                _case = "old";
                lciEMRA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciEMRS.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void srcEMR_EditValueChanged(object sender, EventArgs e)
        {
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(srcEMR.Text);

            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            cboSex.Text = p.Sex;
        }
    }
}
