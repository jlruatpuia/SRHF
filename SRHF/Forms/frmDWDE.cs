using SRHF.UserControls;
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
    public partial class frmDWDE : Form
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrPatient.Server2Client sc = new wrPatient.Server2Client();

        public frmDWDE()
        {
            InitializeComponent();

            ucDW uc = new ucDW() { Dock = DockStyle.Fill };
            //pnlMSB.Controls.Clear();
            //pnlMSB.Controls.Add(uc);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wrPatient.DepartmentWiseData d = new wrPatient.DepartmentWiseData();

        }
    }
}
