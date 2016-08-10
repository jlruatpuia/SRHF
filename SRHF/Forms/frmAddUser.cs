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
        wrSettings.wsSettings g = new wrSettings.wsSettings();
        wrSettings.Server2Client sc = new wrSettings.Server2Client();
        public int _id { get; set; }

        public string UNM { get; set; }
        public string PWD { get; set; }
        public string DPT { get; set; }

        public frmAddUser()
        {
            InitializeComponent();
            //sc = g.GetDepartments();
            //for(int i = 0; i <= sc.dt.Rows.Count -1; i++)
            //{
            //    cboDPT.Properties.Items.Add(sc.dt.Rows[i].ItemArray[2].ToString());
            //}
        }

        public frmAddUser(wrUsers.Users u)
        {
            InitializeComponent();
            _id = u.ID;
            sc = g.GetDepartments();
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                cboDPT.Properties.Items.Add(sc.dt.Rows[i].ItemArray[2].ToString());
            }

            txtUNM.Text = u.UserName;
            txtPWD1.Text = u.Password;
            txtPWD2.Text = u.Password;
            cboDPT.Text = u.UserType;

            btnSave.Text = "&Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            //DialogResult = DialogResult.OK;
            wrUsers.wsUsers usr = new wrUsers.wsUsers();
            wrUsers.Server2Client sc = new wrUsers.Server2Client();
            wrUsers.Users u = new wrUsers.Users();
            u.ID = _id;
            u.UserName = this.txtUNM.Text;
            u.Password = this.txtPWD2.Text;
            u.UserType = this.cboDPT.Text;

            if(btnSave.Text == "&Save")
            {
                sc = usr.AddUser(u);
                if (sc.message == null)
                {
                    MessageBox.Show("New user created successfully!");
                    txtUNM.Text = "";
                    txtPWD1.Text = "";
                    txtPWD2.Text = "";
                    cboDPT.Text = "";
                }
                else
                    MessageBox.Show(sc.message);
            }
            else
            {
                sc = usr.UpdateUser(u);
                if(sc.message == null)
                {
                    MessageBox.Show("User detail updated!");
                    Close();
                }
                else
                    MessageBox.Show(sc.message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
