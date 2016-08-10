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
    public partial class frmPTN : Form
    {
        public int _ID { get; set; }
        public string PNM { get; set; }
        public string ADR { get; set; }
        public int AGE { get; set; }
        public string SEX { get; set; }

        public frmPTN()
        {
            InitializeComponent();
        }

        public frmPTN(int id)
        {
            InitializeComponent();
            wrPatient.Patient p = new wrPatient.Patient();
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();

            p = ptn.GetPatientByID(id);
            _ID = p.ID;
            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            rdoSEX.EditValue = p.Sex;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;
            PNM = txtPNM.Text;
            ADR = txtADR.Text;
            AGE = Convert.ToInt32(txtAGE.Text);
            SEX = rdoSEX.EditValue.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
