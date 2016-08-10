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

namespace SRHF.UserControls
{
    public partial class ucPatients : UserControl
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        wrPatient.Server2Client sc = new wrPatient.Server2Client();
        public ucPatients()
        {
            InitializeComponent();
            sc = ptn.GetPatients();
            grd.DataSource = sc.dt;
        }

        private void txtSRC_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSRC.Text != "")
            {
                sc = ptn.GetPatientsByEmrName(txtSRC.EditValue.ToString());
                grd.DataSource = sc.dt;
            }
            else
            {
                sc = ptn.GetPatients();
                grd.DataSource = sc.dt;
            }
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdit)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrPatient.Patient p = new wrPatient.Patient();
                    p.ID = Convert.ToInt32(grv.GetRowCellValue(hi.RowHandle, colID));
                    p.EMRNo = grv.GetRowCellValue(hi.RowHandle, colEMR).ToString();
                    frmPTN frm = new frmPTN(p.ID);
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        p.PName = frm.PNM;
                        p.Address = frm.ADR;
                        p.Age = frm.AGE;
                        p.Sex = frm.SEX;
                        sc = ptn.UpdatePatient(p);
                        if (sc.message == null)
                        {
                            MessageBox.Show("Patient detail updated!");
                            sc = ptn.GetPatients();
                            grd.DataSource = sc.dt;
                        }
                        else
                            MessageBox.Show(sc.message);
                    }

                }
            }
            else if (hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    wrPatient.Patient p = new wrPatient.Patient();
                    p.ID = Convert.ToInt32(grv.GetRowCellValue(hi.RowHandle, colID));
                    sc = ptn.DeletePatient(p);
                    if (sc.message == null)
                    {
                        MessageBox.Show("Patient record deleted!");
                        sc = ptn.GetPatients();
                        grd.DataSource = sc.dt;
                    }
                    else
                        MessageBox.Show(sc.message);
                }
            }
        }
    }
}
