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
using DevExpress.XtraReports.UI;

namespace SRHF.UserControls
{
    public partial class ucHCare : UserControl
    {
        void Init()
        {
            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            wrRSBY.Server2Client sc = new wrRSBY.Server2Client();

            sc = ws.GetAllHealthCare();

            grd.DataSource = sc.dt;
        }
        public ucHCare()
        {
            InitializeComponent();
            Init();
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHCare frm = new frmHCare();
            frm.ShowDialog();
            Init();
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            frmHCare frm = new frmHCare(id);
            frm.ShowDialog();
            Init();
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            wrRSBY.Server2Client sc = new wrRSBY.Server2Client();
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            
            if(MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sc = ws.DeleteHCare(id);
                if (sc.message == null)
                {
                    MessageBox.Show("Data successfully added!");
                    Init();
                }
                else
                    MessageBox.Show(sc.message);
            }
        }

        private void bSearch_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bSearch.Checked)
                grv.OptionsFind.AlwaysVisible = true;
            else
                grv.OptionsFind.AlwaysVisible = false;
        }

        private void bPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrRSBY.wsRSBY ws = new wrRSBY.wsRSBY();
            wrRSBY.Server2Client sc = new wrRSBY.Server2Client();

            sc = ws.GetAllHealthCare();

            Reports.rptHCare rpt = new Reports.rptHCare(sc.dt);
            rpt.ShowPreviewDialog();
        }
    }
}
