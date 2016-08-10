using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmWWD : Form
    {
        wrSettings.wsSettings g = new wrSettings.wsSettings();
        DataTable dt;

        void InitDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("DMonth", typeof(int));
            dt.Columns.Add("DYear", typeof(int));
            dt.Columns.Add("WardNo", typeof(int));
            dt.Columns.Add("WardName", typeof(string));
            dt.Columns.Add("Bed", typeof(int));
            dt.Columns.Add("Admission", typeof(int));
            dt.Columns.Add("Discharge", typeof(int));
            dt.Columns.Add("Death", typeof(int));
            dt.Columns.Add("AvgStay", typeof(double));
            dt.Columns.Add("BedOccupancy", typeof(double));
        }

        bool AlreadyAdded(int WNO)
        {
            bool f = false;
            for (int i = 0; i <= grv.RowCount - 1; i++)
            {
                int wno = Convert.ToInt32(grv.GetRowCellValue(i, colWNO));
                if (WNO == wno)
                    f = true;
                else
                    f = false;
            }
            return f;
        }

        void Clear()
        {
            lueWNO.EditValue = null;
            txtBED.EditValue = 0;
            txtADM.EditValue = 0;
            txtDSC.EditValue = 0;
            txtDTH.EditValue = 0;
            txtAVG.EditValue = 0;
            txtBOC.EditValue = 0;
            lueWNO.Focus();
        }

        void InitWardWiseData(int month, int year)
        {
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            sc.dt = null;
            sc = ptn.GetWardWiseData(month, year);
            //DataRow r = dt.NewRow();
            //ID, DMonth, DYear, WardNo, WardName, Bed, Admission, Discharge, Death, AvgStay, BedOccupancy
            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                int mno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[1]);
                int yno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[2]);
                int wno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[3]);
                string wnm = sc.dt.Rows[i].ItemArray[4].ToString();
                int bed = Convert.ToInt32(sc.dt.Rows[i].ItemArray[5]);
                int adm = Convert.ToInt32(sc.dt.Rows[i].ItemArray[6]);
                int dsc = Convert.ToInt32(sc.dt.Rows[i].ItemArray[7]);
                int dth = Convert.ToInt32(sc.dt.Rows[i].ItemArray[8]);
                double avg = Convert.ToDouble(sc.dt.Rows[i].ItemArray[9]);
                double boc = Convert.ToDouble(sc.dt.Rows[i].ItemArray[10]);
                dt.Rows.Add(mno, yno, wno, wnm, bed, adm, dsc, dth, avg, boc);
            }
            grd.DataSource = dt;
            grd.Refresh();
        }
        private void InitWard()
        {
            wrSettings.Server2Client sc = new wrSettings.Server2Client();
            sc = g.GetWards();
            lueWNO.Properties.DataSource = sc.dt;
            lueWNO.Properties.DisplayMember = "WardName";
            lueWNO.Properties.ValueMember = "WardNo";
        }

        public frmWWD()
        {
            InitializeComponent();
            dt = new DataTable();

            InitWard();
            InitDataTable();

            txtYNO.Text = DateTime.Now.Year.ToString();
            cboMNO.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (!dxValidationProvider1.Validate()) return;

            if (AlreadyAdded(Convert.ToInt32(lueWNO.EditValue)))
            {
                MessageBox.Show("Data for Department " + lueWNO.Text + " is already entered!", "Information");
                return;
            }

            int mno = cboMNO.SelectedIndex + 1;
            int yno = Convert.ToInt32(txtYNO.Text);
            int wno = Convert.ToInt32(lueWNO.EditValue);
            string wnm = lueWNO.Text ;
            int bed = Convert.ToInt32(txtBED.EditValue);
            int adm = Convert.ToInt32(txtADM.EditValue);
            int dsc = Convert.ToInt32(txtDSC.EditValue);
            int dth = Convert.ToInt32(txtDTH.EditValue);
            double avg = Convert.ToDouble(txtAVG.EditValue);
            double boc = Convert.ToDouble(txtBOC.EditValue);

            dt.Rows.Add(mno, yno, wno, wnm, bed, adm, dsc, dth, avg, boc);
            grd.DataSource = dt;
            grd.Refresh();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lueWNO_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmWard frm = new frmWard();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    wrSettings.Server2Client sc = new wrSettings.Server2Client();
                    wrSettings.Wards w = new wrSettings.Wards();
                    w.WardNo = frm.WNO;
                    w.WardName = frm.WSN;
                    w.WardFullName = frm.WFN;

                    sc = g.AddWard(w);
                    if (sc.message == null)
                    {
                        InitWard();
                        lueWNO.EditValue = sc.count;
                    }
                    else
                        MessageBox.Show(sc.message);
                }
            }
        }

        private void cboMNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            grd.DataSource = null;
            grd.Refresh();
            InitWardWiseData(Convert.ToInt32(cboMNO.SelectedIndex + 1), Convert.ToInt32(txtYNO.Text));
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEDT)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lueWNO.EditValue = grv.GetRowCellValue(hi.RowHandle, colWNO);
                    txtBED.EditValue = grv.GetRowCellValue(hi.RowHandle, colBED);
                    txtADM.EditValue = grv.GetRowCellValue(hi.RowHandle, colADM);
                    txtDSC.EditValue = grv.GetRowCellValue(hi.RowHandle, colDSC); ;
                    txtDTH.EditValue = grv.GetRowCellValue(hi.RowHandle, colDTH); ;
                    txtAVG.EditValue = grv.GetRowCellValue(hi.RowHandle, colAVG); ;
                    txtBOC.EditValue = grv.GetRowCellValue(hi.RowHandle, colBOC); ;
                    
                    grv.DeleteRow(hi.RowHandle);
                    //btnADD.Text = "&Update";
                }
            }
            else if (hi.InRowCell && hi.Column == colDEL)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grv.DeleteRow(hi.RowHandle);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grv.RowCount == 0)
            {
                MessageBox.Show("Please enter some data");
                return;
            }

            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            wrPatient.WardWiseData w = new wrPatient.WardWiseData();
            w.DMonth = Convert.ToInt32(cboMNO.SelectedIndex + 1);
            w.DYear = Convert.ToInt32(txtYNO.Text);
            sc = ptn.DeleteWardWiseData(w);
            for (int i = 0; i <= grv.RowCount - 1; i++)
            {
                w.WardNo = Convert.ToInt32(grv.GetRowCellValue(i, colWNO));
                w.WardName = grv.GetRowCellValue(i, colWNM).ToString();
                w.Bed = Convert.ToInt32(grv.GetRowCellValue(i, colBED));
                w.Admission = Convert.ToInt32(grv.GetRowCellValue(i, colADM));
                w.Discharge = Convert.ToInt32(grv.GetRowCellValue(i, colDSC));
                w.Death = Convert.ToInt32(grv.GetRowCellValue(i, colDTH));
                w.AvgStay = Convert.ToInt32(grv.GetRowCellValue(i, colAVG));
                w.BedOccupancy = Convert.ToInt32(grv.GetRowCellValue(i, colBOC));

                sc = ptn.AddWardWiseData(w);
            }
            if (sc.message == null)
            {
                MessageBox.Show("Data recorded successfully!");
                Clear();
                grd.DataSource = null;
            }
            else
            {
                MessageBox.Show(sc.message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
