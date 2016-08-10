using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SRHF.Forms;
using SRHF.Reports;
using DevExpress.XtraReports.UI;

namespace SRHF.UserControls
{
    public partial class ucOPD : UserControl
    {
        public ucOPD()
        {
            InitializeComponent();
            cboDuration.SelectedIndex = 0;
            dtpFr.Value = DateTime.Now.Date;
            dtpTo.Value = DateTime.Now.Date;
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
            wrOPD.wsOPD opd = new wrOPD.wsOPD();
            wrOPD.Server2Client sc = new wrOPD.Server2Client();

            if (cboDuration.SelectedIndex == 0)
            {
                sc = opd.GetOPDByDate(dtpFr.Value.Date);
            }
            else
            {
                sc = opd.GetOPDByDates(dtpFr.Value.Date, dtpTo.Value.Date);
            }
            grd.DataSource = sc.dt;
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdt)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int oid = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    int pid = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
                    frmOPD frm = new frmOPD(oid, pid);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrOPD.wsOPD opd = new wrOPD.wsOPD();
                    wrOPD.Server2Client sc = new wrOPD.Server2Client();
                    wrOPD.OPD o = new wrOPD.OPD();
                    o.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    sc = opd.DeleteOPD(o);

                    if (sc.message == null)
                    {
                        MessageBox.Show("Record deleted!", "Delete success");
                        btnSearch_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show(sc.message, "Error");
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptOPDReport rpt;
            if (cboDuration.SelectedIndex == 0)
                rpt = new rptOPDReport(dtpFr.Value.Date);
            else
                rpt = new rptOPDReport(dtpFr.Value.Date, dtpTo.Value.Date);
            rpt.ShowPreviewDialog();
        }
    }
}
