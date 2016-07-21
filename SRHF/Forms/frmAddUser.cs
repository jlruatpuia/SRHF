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
    public partial class frmAddUser : Form
    {

        //wrUsers.Users u = new wrUsers.Users();
        public string UNM { get; set; }
        public string PWD { get; set; }
        public string DPT { get; set; }

        public frmAddUser()
        {
            InitializeComponent();
        }

        public frmAddUser(wrUsers.Users u)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UNM = this.txtUNM.Text;
            PWD = this.txtPWD2.Text;
            DPT = this.cboDPT.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
