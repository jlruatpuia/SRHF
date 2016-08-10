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
    public partial class frmLogin : Form
    {
        wrUsers.wsUsers usr = new wrUsers.wsUsers();
        wrUsers.Server2Client sc = new wrUsers.Server2Client();
        public int UID { get; set; }
        public string UNM { get; set; }
        public string PWD { get; set; }
        public string DPT { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            wrUsers.Users u = new wrUsers.Users();
            u.UserName = txtUNM.Text;
            u.Password = txtPWD.Text;
            sc = usr.Login(u);
            if(sc.result == true)
            {
                //Codes.MySettings g = new Codes.MySettings();
                UID = sc.count;
                UNM = txtUNM.Text;
                PWD = txtPWD.Text;
                DPT = sc.message;
                DialogResult = DialogResult.OK;
            }
            else
            {
                labelControl1.Text = sc.message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
