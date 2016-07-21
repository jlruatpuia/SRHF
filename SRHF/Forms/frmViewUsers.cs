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
    public partial class frmViewUsers : Form
    {
        wrUsers.wsUsers usr = new wrUsers.wsUsers();
        wrUsers.Server2Client sc = new wrUsers.Server2Client();

        public frmViewUsers()
        {
            InitializeComponent();

            sc = usr.GetUsers();

            grd.DataSource = sc.dt;
        }
    }
}
