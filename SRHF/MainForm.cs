using SRHF.Codes;
using SRHF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRHF
{
    public partial class MainForm : Form
    {
        wrUsers.wsUsers usr = new wrUsers.wsUsers();
        wrUsers.Server2Client sc = new wrUsers.Server2Client();
        public MainForm()
        {
            InitializeComponent();
            WindowSettings.GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
        }

        private void mnuAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            wrUsers.Users u = new wrUsers.Users();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                u.UserName = frm.UNM;
                u.Password = frm.PWD;
                u.UserType = frm.DPT;

                sc = usr.AddUser(u);
                if (sc.message == null)
                    MessageBox.Show("New user successfully created!", "Information");
                else
                    MessageBox.Show(sc.message, "Error");
            }
        }

        private void mnuViewUser_Click(object sender, EventArgs e)
        {
            frmViewUsers frm = new frmViewUsers();
            frm.ShowDialog();
        }

        private void mnuPtnReg_Click(object sender, EventArgs e)
        {
            frmOPD frm = new frmOPD();
            frm.ShowDialog();
        }

        private void viewRegisteredPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewOPD frm = new frmViewOPD();
            frm.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmECG frm = new frmECG();
            frm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.WindowTheme = dlaf.LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.WindowGeometry = WindowSettings.GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewECG frm = new frmViewECG();
            frm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRD frm = new frmMRD();
            frm.ShowDialog();
        }
    }
}
