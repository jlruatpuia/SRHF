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
    public partial class frmDWD : Form
    {
        wrSettings.wsSettings g = new wrSettings.wsSettings();
        DataTable dt;

        void InitDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("DMonth", typeof(int));
            dt.Columns.Add("DYear", typeof(int));
            dt.Columns.Add("DeptNo", typeof(int));
            dt.Columns.Add("DeptName", typeof(string));
            dt.Columns.Add("NewCase", typeof(int));
            dt.Columns.Add("OldCase", typeof(int));
            dt.Columns.Add("Total", typeof(int));
            dt.Columns.Add("Average", typeof(double));
        }

        bool AlreadyAdded(int DNO)
        {
            bool f = false;
            for (int i = 0; i <= grv.RowCount - 1; i++)
            {
                int dno = Convert.ToInt32(grv.GetRowCellValue(i, colDNO));
                if (DNO == dno)
                    f = true;
                else
                    f = false;
            }
            return f;
        }

        void Clear()
        {
            lueDNO.EditValue = null;
            txtNCS.EditValue = 0;
            txtOCS.EditValue = 0;
            txtTTL.EditValue = 0;
            txtAVG.EditValue = 0;
            lueDNO.Focus();
        }

        void InitDepartmentWiseData(int month, int year)
        {
            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            sc.dt = null;
            sc = ptn.GetDepartmentWiseData(month, year);
            DataRow r = dt.NewRow();
            for(int i = 0; i<= sc.dt.Rows.Count - 1; i++)
            {
                int mno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[1]);
                int yno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[2]);
                int dno = Convert.ToInt32(sc.dt.Rows[i].ItemArray[3]);
                string dnm = sc.dt.Rows[i].ItemArray[4].ToString();
                int ncs = Convert.ToInt32(sc.dt.Rows[i].ItemArray[5]); 
                int ocs = Convert.ToInt32(sc.dt.Rows[i].ItemArray[6]); 
                int ttl = Convert.ToInt32(sc.dt.Rows[i].ItemArray[7]); 
                double avg = Convert.ToDouble(sc.dt.Rows[i].ItemArray[8]);
                dt.Rows.Add(mno, yno, dno, dnm, ncs, ocs, ttl, avg);
                
            }
            grd.DataSource = dt;
            grd.Refresh();
        }

        public frmDWD()
        {
            InitializeComponent();
            dt = new DataTable();

            InitDept();
            InitDataTable();

            txtYNO.Text = DateTime.Now.Year.ToString();
            cboMNO.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void InitDept()
        {
            wrSettings.Server2Client sc = new wrSettings.Server2Client();
            sc = g.GetDepartments();
            lueDNO.Properties.DataSource = sc.dt;
            lueDNO.Properties.DisplayMember = "DeptFullName";
            lueDNO.Properties.ValueMember = "DeptNo";
        }

        private void txtNCS_EditValueChanged(object sender, EventArgs e)
        {
            txtTTL.EditValue = Convert.ToInt32(txtNCS.EditValue) + Convert.ToInt32(txtOCS.EditValue);
        }

        private void txtOCS_EditValueChanged(object sender, EventArgs e)
        {
            txtTTL.EditValue = Convert.ToInt32(txtNCS.EditValue) + Convert.ToInt32(txtOCS.EditValue);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            if (AlreadyAdded(Convert.ToInt32(lueDNO.EditValue)))
            {
                MessageBox.Show("Data for Department " + lueDNO.Text + " is already entered!", "Information");
                return;
            }
           
            int mno = cboMNO.SelectedIndex + 1;
            int yno = Convert.ToInt32(txtYNO.Text);
            int dno = Convert.ToInt32(lueDNO.EditValue);
            string dnm = lueDNO.Text;
            int ncs = Convert.ToInt32(txtNCS.EditValue);
            int ocs = Convert.ToInt32(txtOCS.EditValue);
            int ttl = Convert.ToInt32(txtTTL.EditValue);
            double avg = Convert.ToDouble(txtAVG.Text);

            dt.Rows.Add(mno, yno, dno, dnm, ncs, ocs, ttl, avg);
            grd.DataSource = dt;
            grd.Refresh();
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(grv.RowCount == 0)
            {
                MessageBox.Show("Please enter some data");
                return;
            }

            wrPatient.wsPatient ptn = new wrPatient.wsPatient();
            wrPatient.Server2Client sc = new wrPatient.Server2Client();
            wrPatient.DepartmentWiseData d = new wrPatient.DepartmentWiseData();
            d.DMonth = Convert.ToInt32(cboMNO.SelectedIndex + 1);
            d.DYear = Convert.ToInt32(txtYNO.Text);
            sc = ptn.DeleteDepartmentWiseDataEntry(d);
            for (int i = 0; i <= grv.RowCount - 1; i++)
            {
                d.DMonth = Convert.ToInt32(grv.GetRowCellValue(i, colMNO));
                d.DYear = Convert.ToInt32(grv.GetRowCellValue(i, colYNO));
                d.DeptNo = Convert.ToInt32(grv.GetRowCellValue(i, colDNO));
                d.DeptName = grv.GetRowCellValue(i, colDNM).ToString();
                d.NewCase = Convert.ToInt32(grv.GetRowCellValue(i, colNCS));
                d.OldCase = Convert.ToInt32(grv.GetRowCellValue(i, colOCS));
                d.Total = Convert.ToInt32(grv.GetRowCellValue(i, colTTL));
                d.Average = Convert.ToDouble(grv.GetRowCellValue(i, colAVG));
                
                sc = ptn.AddDepartmentWiseDataEntry(d);
            }
            if(sc.message == null)
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

        private void btnCLR_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lueDNO_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 1)
            {
                frmDeptSingleEntry frm = new frmDeptSingleEntry();
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    wrSettings.Server2Client sc = new wrSettings.Server2Client();
                    wrSettings.Dept d = new wrSettings.Dept();
                    d.DeptNo = frm.DNO;
                    d.DeptShortName = frm.DSN;
                    d.DeptFullName = frm.DFN;

                    sc = g.SetDepartments(d);
                    if (sc.message == null)
                    {
                        InitDept();
                        lueDNO.EditValue = sc.count;
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
            InitDepartmentWiseData(Convert.ToInt32(cboMNO.SelectedIndex + 1), Convert.ToInt32(txtYNO.Text));
        }

        private void txtYNO_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdt)
            {
                if (MessageBox.Show("Do you really want to edit this data?", "Confirm edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lueDNO.EditValue = grv.GetRowCellValue(hi.RowHandle, colDNO);
                    txtNCS.EditValue = grv.GetRowCellValue(hi.RowHandle, colNCS);
                    txtOCS.EditValue = grv.GetRowCellValue(hi.RowHandle, colOCS);
                    txtAVG.EditValue = grv.GetRowCellValue(hi.RowHandle, colAVG);
                    grv.DeleteRow(hi.RowHandle);
                    //btnADD.Text = "&Update";
                }
            }
            else if (hi.InRowCell && hi.Column == colDel)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grv.DeleteRow(hi.RowHandle);
                }
            }
        }
    }
}
