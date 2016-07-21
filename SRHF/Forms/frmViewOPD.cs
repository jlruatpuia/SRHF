using SRHF.Reports;
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
    public partial class frmViewOPD : Form
    {
        public frmViewOPD()
        {
            InitializeComponent();
            cboDuration.SelectedIndex = 0;

        }

        private void cboDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDuration.SelectedIndex == 0)
                lciDtpTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciDtpTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            wrOPD.wsOPD opd = new wrOPD.wsOPD();
            wrOPD.Server2Client sc = new wrOPD.Server2Client();
            rptRegisteredPatients rpt = new rptRegisteredPatients();

            if (cboDuration.SelectedIndex == 0)
            {
                sc = opd.GetOPDByDate(dtpFr.Value.Date);
                rpt.lbIDT.Text = "ON " + dtpFr.Value.Date.ToShortDateString();
            }
            else
            {
                sc = opd.GetOPDByDates(dtpFr.Value.Date, dtpTo.Value.Date);
                rpt.lbIDT.Text = "BETWEEN " + dtpFr.Value.ToShortDateString() + " AND " + dtpTo.Value.ToShortDateString();
            }

            rpt.DataSource = sc.dt;
            rpt.lbEMR.DataBindings.Add("Text", null, "EMRNo");
            rpt.lbPNM.DataBindings.Add("Text", null, "PName");
            rpt.lbADR.DataBindings.Add("Text", null, "Address");
            rpt.lbAGE.DataBindings.Add("Text", null, "Age");
            rpt.lbSEX.DataBindings.Add("Text", null, "Sex");
            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }
    }
}
