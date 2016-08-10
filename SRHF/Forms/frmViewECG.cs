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
    public partial class frmViewECG : Form
    {
        public frmViewECG()
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
            wrECG.wsECG ecg = new wrECG.wsECG();
            wrECG.Server2Client sc = new wrECG.Server2Client();
            if (cboDuration.SelectedIndex == 0)
                sc = ecg.GetECGByDate(dtpFr.Value.Date);
            else
                sc = ecg.GetECGByDates(dtpFr.Value.Date, dtpTo.Value.Date);
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
                    frmECG frm = new frmECG(id);
                    frm.ShowDialog();
                    btnSearch_Click(null, null);
                }
            }
            else if(hi.InRowCell && hi.Column == colDel)
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrECG.wsECG ecg = new wrECG.wsECG();
                    wrECG.Server2Client sc = new wrECG.Server2Client();
                    wrECG.ECG g = new wrECG.ECG();
                    g.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    sc = ecg.DeleteECG(g);

                    if(sc.message == null)
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
            wrECG.wsECG ecg = new wrECG.wsECG();
            wrECG.Server2Client sc = new wrECG.Server2Client();
            rptECGReport rpt;
            if (cboDuration.SelectedIndex == 0)
            {
                sc = ecg.GetECGByDate(dtpFr.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, sc.dt);
            }
            else
            {
                sc = ecg.GetECGByDates(dtpFr.Value.Date, dtpTo.Value.Date);
                rpt = new rptECGReport(dtpFr.Value.Date, dtpTo.Value.Date, sc.dt);
            }
                //grd.DataSource = sc.dt;
             
               
            rpt.ShowPreviewDialog();
        }
    }
}
