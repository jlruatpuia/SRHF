using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdit)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colUID));
                    wrUsers.Users u = new wrUsers.Users();
                    u.ID = Convert.ToInt32(grv.GetRowCellValue(hi.RowHandle, colUID));
                    u.UserName = grv.GetRowCellValue(hi.RowHandle, colUNM).ToString();
                    u.Password = "";
                    u.UserType = grv.GetRowCellValue(hi.RowHandle, colUTP).ToString();
                    frmAddUser frm = new frmAddUser(u);
                    frm.ShowDialog();
                    sc = usr.GetUsers();

                    grd.DataSource = sc.dt;
                    //btnShow_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrUsers.Users u = new wrUsers.Users();
                    wrUsers.Server2Client sc = new wrUsers.Server2Client();
                    wrUsers.wsUsers usr = new wrUsers.wsUsers();
                    
                    u.ID = Convert.ToInt32(grv.GetRowCellValue(hi.RowHandle, colUID));
                    sc = usr.DeleteUser(u);

                    if (sc.message == null)
                    {
                        MessageBox.Show("Record deleted!", "Delete success");
                        sc = usr.GetUsers();

                        grd.DataSource = sc.dt;
                    }
                    else
                    {
                        MessageBox.Show(sc.message, "Error");
                    }
                }
            }
        }
    }
}
