using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using SRHF.Reports;
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
    public partial class frmViewOT : Form
    {
        wrOTH.wsOTH op = new wrOTH.wsOTH();
        wrOTH.Server2Client sc = new wrOTH.Server2Client();
        public frmViewOT()
        {
            InitializeComponent();
            cboDuration.SelectedIndex = 0;
        }

        private void cboDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDuration.SelectedIndex == 0)
                lciDtpTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciDtpTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboDuration.SelectedIndex == 0)
                sc = op.GetOpTheaterByDate(dtpFr.Value.Date);
            else
                sc = op.GetOpTheaterByDates(dtpFr.Value.Date, dtpTo.Value.Date);
            grd.DataSource = sc.dt;
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdit)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    frmOTH frm = new frmOTH(id);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if(hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    wrOTH.OpTheater o = new wrOTH.OpTheater();
                    o.ID = id;
                    sc = op.DeleteOpTheater(o);
                    if (sc.message == null)
                    {
                        MessageBox.Show("Record deleted successfully!", "Delete success");
                        btnSearch_Click(null, null);
                    }
                    else
                        MessageBox.Show(sc.message);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptOTHReport rpt;
            if (cboDuration.SelectedIndex == 0)
                rpt = new rptOTHReport(dtpFr.Value.Date);
            else
                rpt = new rptOTHReport(dtpFr.Value.Date, dtpTo.Value.Date);
            rpt.ShowPreviewDialog();
        }
    }
}
