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
    public partial class frmViewICD : Form
    {
        wrICD.Server2Client sc = new wrICD.Server2Client();
        wrICD.wsICD icd = new wrICD.wsICD();
        public frmViewICD()
        {
            InitializeComponent();
            sc = icd.GetICDCode();

            grd.DataSource = sc.dt;
        }

        private void txtSearch_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            sc = icd.SearchICDCode(txtSearch.Text);
            grd.DataSource = sc.dt;
        }
    }
}
