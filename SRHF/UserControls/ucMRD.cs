using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SRHF.Forms;

namespace SRHF.UserControls
{
    public partial class ucMRD : UserControl
    {
        public string Table { get; set; }

        public ucMRD()
        {
            InitializeComponent();
            cboSDT.SelectedIndex = 0;
            cboDRN.SelectedIndex = 0;

        }

        private void cboDRN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDRN.SelectedIndex == 0)
                lciDTO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciDTO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void cboSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSDT.SelectedIndex == 0)
                Table = "AdmissionDate";
            else
                Table = "DischargeDate";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.Server2Client sc = new wrMRD.Server2Client();
            if (cboDRN.SelectedIndex == 0)
                sc = mrd.GetMRDByDate(dtpDFR.DateTime.Date, Table);
            else
                sc = mrd.GetMRDByDates(dtpDFR.DateTime.Date, dtpDTO.DateTime.Date, Table);

            grd.DataSource = sc.dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.rptMRD rpt;
            if (cboDRN.SelectedIndex == 0)
                rpt = new Reports.rptMRD(dtpDFR.DateTime.Date, Table);
            else
                rpt = new Reports.rptMRD(dtpDFR.DateTime.Date, dtpDTO.DateTime.Date, Table);
            rpt.ShowPreviewDialog();
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEDT)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    frmMRD frm = new frmMRD(id);
                    frm.ShowDialog();
                    btnShow_Click(null, null);
                }
            }
            else if (hi.InRowCell && hi.Column == colDEL)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //wrECG.wsECG ecg = new wrECG.wsECG();
                    //wrECG.Server2Client sc = new wrECG.Server2Client();
                    //wrECG.ECG g = new wrECG.ECG();
                    wrMRD.wsMRD mrd = new wrMRD.wsMRD();
                    wrMRD.Server2Client sc = new wrMRD.Server2Client();
                    wrMRD.MRD m = new wrMRD.MRD();
                    m.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    sc = mrd.DeleteMRD(m);

                    if (sc.message == null)
                    {
                        MessageBox.Show("Record deleted!", "Delete success");
                        btnShow_Click(null, null);
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
