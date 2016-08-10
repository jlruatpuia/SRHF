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
    public partial class frmEditUser : Form
    {
        
        

        public int UID { get; set; }
        public string UNM { get; set; }
        public string PWD { get; set; }
        public string DPT { get; set; }

        public frmEditUser()
        {
            InitializeComponent();
        }

        public frmEditUser(wrUsers.Users u)
        {
            InitializeComponent();
            UID = u.ID;
            UNM = u.UserName;
            txtUNM.Text = UNM;
            PWD = u.Password;
            DPT = u.UserType;
            cboDPT.Text = DPT;
            txtUNM.Properties.ReadOnly = true;
            cboDPT.Properties.ReadOnly = true;
        }
        public frmEditUser(int ID)
        {

        }

        bool ErrorFound()
        {
            bool f = false;

            DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dx = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            if(string.Compare(txtPW0.Text, PWD) != 0)
            {
                dx.SetError(txtPW0, "Old pwssword incorrect!");
                f = true;
            }
            else
            {
                dx.SetError(txtPW0, "");
            }
            return f;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;
            if (ErrorFound()) return;

            wrUsers.wsUsers usr = new wrUsers.wsUsers();
            wrUsers.Server2Client sc = new wrUsers.Server2Client();
            wrUsers.Users u = new wrUsers.Users();

            u.ID = UID;
            u.UserName = txtUNM.Text;
            u.Password = txtPW2.Text;
            u.UserType = cboDPT.Text;

            sc = usr.UpdateUser(u);
            if (sc.message == null)
            {
                MessageBox.Show("User updated successfully!");
                Close();
            }
            else MessageBox.Show(sc.message);
        }
    }
}
