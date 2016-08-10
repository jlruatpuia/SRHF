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
    public partial class frmDeptSingleEntry : Form
    {
        public int DNO { get; set; }
        public string DSN { get; set; }
        public string DFN { get; set; }

        public frmDeptSingleEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DNO = Convert.ToInt32(txtDNO.EditValue);
            DSN = txtDSN.Text;
            DFN = txtDFN.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
