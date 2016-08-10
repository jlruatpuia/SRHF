using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRHF.UserControls
{
    public partial class ucPMR : UserControl
    {
        wrMRD.wsMRD mrd = new wrMRD.wsMRD();
        wrMRD.Server2Client sc = new wrMRD.Server2Client();
        public ucPMR()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string qry = txtSRC.Text;
            string fld = cboSwitch.Text;

            Reports.rptPMR rpt = new Reports.rptPMR(qry, fld);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }
    }
}
