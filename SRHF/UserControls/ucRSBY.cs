using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRHF.Forms;
using SRHF.Reports;
using DevExpress.XtraReports.UI;

namespace SRHF.UserControls
{
    public partial class ucRSBY : UserControl
    {
        wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
        wrRSBY.Server2Client sc = new wrRSBY.Server2Client();
        public ucRSBY()
        {
            InitializeComponent();
            cboSEL.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSEL.SelectedIndex == 0)
                sc = ws.GetAllRSBY();
            else if (cboSEL.SelectedIndex == 1)
                sc = ws.GetRSBYByRemarks("Received");
            else
                sc = ws.GetRSBYByRemarks("Not Received");
            grd.DataSource = sc.dt;
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRSBY frm = new frmRSBY();
            frm.ShowDialog();
            btnSearch_Click(null, null);
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            frmRSBY frm = new frmRSBY(id);
            frm.ShowDialog();
            btnSearch_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cboSEL.SelectedIndex == 0)
                sc = ws.GetAllRSBY();
            else if (cboSEL.SelectedIndex == 1)
                sc = ws.GetRSBYByRemarks("Received");
            else
                sc = ws.GetRSBYByRemarks("Not Received");
            rptRSBY rpt = new rptRSBY(sc.dt);
            rpt.ShowPreviewDialog();
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                sc = ws.DeleteRSBY(id);
                if(sc.message == null)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btnSearch_Click(null, null);
                }
            }
        }
    }
}
