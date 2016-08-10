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
    public partial class frmWard : Form
    {
        public int WNO { get; set; }
        public string WSN { get; set; }
        public string WFN { get; set; }
        public frmWard()
        {
            InitializeComponent();
        }

        public frmWard(int ID)
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            WNO = Convert.ToInt32(txtWNO.EditValue);
            WSN = txtWSN.Text;
            WFN = txtWFN.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
