using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using SRHF.Forms;
using SRHF.Reports;
using System;
using System.Windows.Forms;

namespace SRHF.UserControls
{
    public partial class ucUSG : UserControl
    {
        public ucUSG()
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
            wrUSG.wsUSG usg = new wrUSG.wsUSG();
            //wrECG.Server2Client sc = new wrECG.Server2Client();
            wrUSG.Server2Client sc = new wrUSG.Server2Client();
            if (cboDuration.SelectedIndex == 0)
                sc = usg.GetUSGByDate(dtpFr.Value.Date);
            else
                sc = usg.GetUSGByDates(dtpFr.Value.Date, dtpTo.Value.Date);
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
                    frmUSG frm = new frmUSG(id);
                    //frmECG frm = new frmECG(id);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Do you really want to delete this data?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    wrUSG.wsUSG u = new wrUSG.wsUSG();
                    wrUSG.Server2Client sc = new wrUSG.Server2Client();
                    wrUSG.USG g = new wrUSG.USG();
                    g.ID = id;
                    sc = u.DeleteUSG(g);

                    if (sc.message == null)
                    {
                        MessageBox.Show("Data successfully deleted!");
                        btnSearch_Click(null, null);
                    }
                    else
                        MessageBox.Show(sc.message);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wrUSG.wsUSG usg = new wrUSG.wsUSG();
            wrUSG.Server2Client sc = new wrUSG.Server2Client();
            rptECGReport rpt;
            if (cboDuration.SelectedIndex == 0)
            {
                sc = usg.GetUSGByDate(dtpFr.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, sc.dt);
            }
            else
            {
                sc = usg.GetUSGByDates(dtpFr.Value.Date, dtpTo.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, dtpTo.Value.Date, sc.dt);
            }
            rpt.ShowPreviewDialog();
        }
    }
}
