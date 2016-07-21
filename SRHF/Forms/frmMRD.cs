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
    public partial class frmMRD : Form
    {
        wrPatient.wsPatient ptn = new wrPatient.wsPatient();
        public DataTable dt { get; set; }

        public void InitDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("col7", typeof(string));
            dt.Columns.Add("col9", typeof(string));
        }

        void InitICD()
        {
            wrICD.wsICD icd = new wrICD.wsICD();
            wrICD.Server2Client sc = new wrICD.Server2Client();
            sc = icd.GetICDCode();
            cboICD.DataSource = sc.dt;
            cboICD.DisplayMember = "col9";
            cboICD.ValueMember = "col7";

            for (int i = 0; i <= sc.dt.Rows.Count - 1; i++)
            {
                cboICD.AutoCompleteCustomSource.Add(sc.dt.Rows[i].ItemArray[1].ToString());
            }

            cboICD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboICD.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void Reset()
        {
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            txtSNO.Text = mrd.GetSerialNo().ToString();
            txtMRD.Text = "";
            txtPNM.Clear();
            txtADR.Clear();
            txtAGE.Clear();
            txtSEX.Clear();
            txtDGN.Clear();
            InitDataTable();
            grd.DataSource = dt;
            txtMRD.Focus();
        }
        public frmMRD()
        {
            InitializeComponent();

            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            txtSNO.Text = mrd.GetSerialNo().ToString();

            InitDataTable();
            InitICD();
        }

        private void txtEMR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
            {
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtMRD.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
            }
        }

        private void txtEMR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtMRD.Text);

                txtPNM.Text = p.PName;
                txtADR.Text = p.Address;
                txtAGE.Text = p.Age.ToString();
                txtSEX.Text = p.Sex;
            }
        }

        private void cboICD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string i_code = cboICD.SelectedValue.ToString();
                string i_desc = cboICD.Text;
                dt.Rows.Add(i_code, i_desc);
                grd.DataSource = dt;
            }
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colEdit)
            {
                if (MessageBox.Show("Do you really want to remove this?", "Confirm remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grv.DeleteRow(hi.RowHandle);
                    grv.RefreshData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.Server2Client sc = new wrMRD.Server2Client();
            wrMRD.MRD m = new wrMRD.MRD();

            m.SlNo = Convert.ToInt32(txtSNO.Text);
            m.MRDNo = txtMRD.Text;
            m.EMRNo = txtMRD.Text;
            m.Diagnosis = txtDGN.Text;
            m.ICDCode = null;
            for(int i = 0; i <= grv.RowCount - 1; i++)
            {
                m.ICDCode += grv.GetRowCellValue(i, col7).ToString();
                m.ICDCode += ",";
            }
            m.ICDCode.Remove(m.ICDCode.Length - 1);

            sc = mrd.AddMRD(m);
            if (sc.message == null)
            {
                MessageBox.Show("Record added successfully!");
                Reset();
            }
            else
                MessageBox.Show(sc.message, "Error");
        }
    }
}
