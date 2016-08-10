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
    public partial class frmViewLAB : Form
    {
        public frmViewLAB()
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
            wrLAB.wsLAB lab = new wrLAB.wsLAB();
            wrLAB.Server2Client sc = new wrLAB.Server2Client();
            if (cboDuration.SelectedIndex == 0)
                sc = lab.GetLabRecordByDate(dtpFr.Value.Date);
            else
                sc = lab.GetLabRecordByDates(dtpFr.Value.Date, dtpTo.Value.Date);
            grd.DataSource = sc.dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptLabRecord rpt;
            if (cboDuration.SelectedIndex == 0)
                rpt = new rptLabRecord(dtpFr.Value.Date);
            else
                rpt = new rptLabRecord(dtpFr.Value.Date, dtpTo.Value.Date);
            rpt.ShowPreviewDialog();
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEDT)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colLID));
                    frmLAB frm = new frmLAB(id);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDEL)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //wrECG.wsECG ecg = new wrECG.wsECG();
                    wrLAB.wsLAB lab = new wrLAB.wsLAB();
                    wrLAB.Server2Client sc = new wrLAB.Server2Client();
                    wrLAB.LAB b = new wrLAB.LAB();
                    b.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colLID));
                    sc = lab.DeleteLabRecord(b);

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
    }
}
