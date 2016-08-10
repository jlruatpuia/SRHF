using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using DevExpress.XtraReports.UI;

namespace SRHF.Forms
{
    public partial class frmViewCasualty : Form
    {
        public frmViewCasualty()
        {
            InitializeComponent();
            cboSEL.SelectedIndex = 0;
            dtpFR.DateTime = DateTime.Now.Date;
            dtpTO.DateTime = DateTime.Now.Date;
        }

        private void cboSEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSEL.SelectedIndex == 0)
                lciDTFR.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            else
                lciDTFR.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            wrCasualty.Server2Client sc = new wrCasualty.Server2Client();
            wrCasualty.wsCasualty cas = new wrCasualty.wsCasualty();
            if (cboSEL.SelectedIndex == 0)
                sc = cas.GetCasualtyByDate(dtpFR.DateTime.Date);
            else
                sc = cas.GetCasualtyByDates(dtpFR.DateTime.Date, dtpTO.DateTime.Date);

            grd.DataSource = sc.dt;
        }

        private void grv_Click(object sender, EventArgs e)
        {
            wrCasualty.Server2Client sc = new wrCasualty.Server2Client();
            wrCasualty.wsCasualty cas = new wrCasualty.wsCasualty();
            wrCasualty.Casualty c = new wrCasualty.Casualty();
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdit)
            {
                if (MessageBox.Show("Do you really want to edit this record?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    frmCasualty frm = new frmCasualty(id);
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        c.ID = id;
                        c.RegNo = frm._regNo;
                        c.SlNo = frm._slNo;
                        c.RegDate = frm._regDate;
                        c.RegTime = frm._regTime;
                        c.PName = frm._pName;
                        c.Address = frm._address;
                        c.Age = frm._age;
                        c.Sex = frm._sex;
                        c.Diagnosis = frm._diagnosis;
                        c.Treatment = frm._treatment;

                        sc = cas.UpdateCasualty(c);
                        if (sc.message == null)
                        {
                            MessageBox.Show("Record updated successfully!", "Information");
                            btnSearch_Click(null, null);
                        }
                        else MessageBox.Show(sc.message, "Error");
                    }
                }
            }
            else if(hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Do you really want to remove this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                    c.ID = id;
                    sc = cas.DeleteCasualty(c);

                    if (sc.message == null)
                    {
                        MessageBox.Show("Record deleted!", "Information");
                        btnSearch_Click(null, null);
                    }
                    else
                        MessageBox.Show(sc.message, "Error");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wrCasualty.Server2Client sc = new wrCasualty.Server2Client();
            wrCasualty.wsCasualty cas = new wrCasualty.wsCasualty();
            rptCasualtyReport rpt;
            if (cboSEL.SelectedIndex == 0)
                rpt = new rptCasualtyReport(dtpFR.DateTime.Date);
            else
                rpt = new rptCasualtyReport(dtpFR.DateTime.Date, dtpTO.DateTime.Date);

            rpt.ShowPreviewDialog();
        }
    }
}
