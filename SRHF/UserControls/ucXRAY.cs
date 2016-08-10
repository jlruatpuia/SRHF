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
    public partial class ucXRAY : UserControl
    {
        public ucXRAY()
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
            wrXRAY.wsXRAY xray = new wrXRAY.wsXRAY();
            wrXRAY.Server2Client sc = new wrXRAY.Server2Client();
            if (cboDuration.SelectedIndex == 0)
                sc = xray.GetXRAYByDate(dtpFr.Value.Date);
            else
                sc = xray.GetXRAYByDates(dtpFr.Value.Date, dtpTo.Value.Date);
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
                    frmXRAY frm = new frmXRAY(id);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDEL)
            {
                if (MessageBox.Show("Do you really want to delete this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrXRAY.wsXRAY xray = new wrXRAY.wsXRAY();
                    wrXRAY.Server2Client sc = new wrXRAY.Server2Client();
                    wrXRAY.XRAY x = new wrXRAY.XRAY();
                    x.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    sc = xray.DeleteXray(x);

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
            wrXRAY.wsXRAY xray = new wrXRAY.wsXRAY();
            wrXRAY.Server2Client sc = new wrXRAY.Server2Client();
            rptECGReport rpt;
            if (cboDuration.SelectedIndex == 0)
            {
                sc = xray.GetXRAYByDate(dtpFr.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, sc.dt);
            }
            else
            {
                sc = xray.GetXRAYByDates(dtpFr.Value.Date, dtpTo.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, dtpTo.Value.Date, sc.dt);
            }
            rpt.ShowPreviewDialog();
        }
    }
}
