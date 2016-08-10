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
        public int _id { get; set; }

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

            lueDGN.Properties.DataSource = sc.dt;
            lueDGN.Properties.DisplayMember = "col9";
            lueDGN.Properties.ValueMember = "col7";
        }

        void Reset()
        {
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            txtSNO.Text = mrd.GetSerialNo().ToString();
            txtEMR.Text = "";
            txtMRD.Text = "";
            txtPNM.Clear();
            txtADR.Clear();
            txtAGE.Clear();
            txtSEX.Clear();
            lueDGN.EditValue = null;
            InitDataTable();
            grd.DataSource = dt;
            txtMRD.Focus();
        }
        public frmMRD()
        {
            InitializeComponent();

            rdoDSC.SelectedIndex = 0;

            dtpDOA.DateTime = DateTime.Now.Date;
            dtpDOD.DateTime = DateTime.Now.Date;

            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            txtSNO.Text = mrd.GetSerialNo().ToString();

            InitDataTable();
            InitICD();
        }

        public frmMRD(int id)
        {
            InitializeComponent();
            InitDataTable();
            InitICD();
            _id = id;
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.MRD m = new wrMRD.MRD();
            m = mrd.GetMRDByID(id);
            txtSNO.Text = m.SlNo.ToString();
            txtMRD.Text = m.MRDNo;
            txtEMR.Text = m.EMRNo;
            cboWRD.Text = m.Ward;
            dtpDOA.DateTime = m.AdmissionDate;
            dtpDOD.DateTime = m.DischargeDate;
            //List<string> icd = m.ICDCode.Split(',').ToList<string>();
            string[] ic = m.ICDCode.Split(',');
            foreach(string d in ic)
            {
                wrICD.wsICD icd = new wrICD.wsICD();
                wrICD.ICD i = new wrICD.ICD();
                i = icd.GetICDCodeByCode(d);
                dt.Rows.Add(i.Code, i.Description);
                grd.DataSource = dt;
            }
            //txtRMK.Text = m.Remarks;
            txtHPD.Text = m.HospitalDays.ToString();
            rdoRSL.EditValue = m.Result;
            //rdoDSC.EditValue = m.Discharged;
            switch (m.Discharged)
            {
                case "Alive":
                    rdoDSC.SelectedIndex = 0;
                    break;
                case "Died":
                    rdoDSC.SelectedIndex = 1;
                    break;
            }
            rdoDCA.EditValue = m.DischargedAlive;
            rdoDCD.EditValue = m.DischargedDeath;
            txtCOD.Text = m.CauseOfDeath;
            txtDRC.Text = m.DirectCause;
            txtATC.Text = m.AntecedentCause;
            txtOTC.Text = m.OtherCause;

            btnSave.Text = "&Update";
        }

        private void txtEMR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
            {
                wrPatient.Patient p = new wrPatient.Patient();
                p = ptn.GetPatientByEMR(txtEMR.Text);

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
                p = ptn.GetPatientByEMR(txtEMR.Text);

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
                //string i_code = cboICD.SelectedValue.ToString();
                //string i_desc = cboICD.Text;
                //dt.Rows.Add(i_code, i_desc);
                //grd.DataSource = dt;
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
            if (!dxVP.Validate()) return;
            wrMRD.wsMRD mrd = new wrMRD.wsMRD();
            wrMRD.Server2Client sc = new wrMRD.Server2Client();
            wrMRD.MRD m = new wrMRD.MRD();

            m.SlNo = Convert.ToInt32(txtSNO.Text);
            m.MRDNo = txtMRD.Text;
            m.EMRNo = txtEMR.Text;
            m.Ward = cboWRD.Text;
            m.AdmissionDate = dtpDOA.DateTime.Date;
            m.DischargeDate = dtpDOD.DateTime.Date;
            m.Diagnosis = null;
            m.ICDCode = null;
            for(int i = 0; i <= grv.RowCount - 1; i++)
            {
                m.ICDCode += grv.GetRowCellValue(i, col7).ToString();
                m.ICDCode += ",";
                m.Diagnosis += grv.GetRowCellValue(i, col9).ToString();
                m.Diagnosis += ", ";
            }
            m.ICDCode = m.ICDCode.Remove(m.ICDCode.Length - 1);
            m.Diagnosis = m.Diagnosis.Remove(m.Diagnosis.Length - 2);
            m.HospitalDays = Convert.ToInt32(txtHPD.Text);
            m.Result = rdoRSL.EditValue.ToString();
            m.Discharged = rdoDSC.EditValue.ToString();
            if(m.Discharged == "Alive")
            {
                m.DischargedAlive = rdoDCA.EditValue.ToString();
                m.DischargedDeath = null;
                m.CauseOfDeath = null;
                m.DirectCause = null;
                m.AntecedentCause = null;
                m.OtherCause = null;
            }
            else
            {
                m.DischargedAlive = null;
                m.DischargedDeath = rdoDCD.EditValue.ToString();
                m.CauseOfDeath = txtCOD.Text.ToUpper();
                m.DirectCause = txtDRC.Text;
                m.AntecedentCause = txtATC.Text;
                m.OtherCause = txtOTC.Text;
            }

            if (btnSave.Text == "&Save")
            {
                sc = mrd.AddMRD(m);
                if (sc.message == null)
                {
                    MessageBox.Show("Record added successfully!");
                    Reset();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
            else
            {
                m.ID = _id;
                sc = mrd.UpdateMRD(m);
                if (sc.message == null)
                {
                    MessageBox.Show("Record updated successfully!");
                    Close();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
        }

        private void lueDGN_EditValueChanged(object sender, EventArgs e)
        {
            try { 
                string i_code = lueDGN.EditValue.ToString();
                string i_desc = lueDGN.Text;
                dt.Rows.Add(i_code, i_desc);
                grd.DataSource = dt;
            }
            catch {; }
            //lueDGN.EditValue = null;
        }

        private void txtEMR_EditValueChanged(object sender, EventArgs e)
        {
            wrPatient.Patient p = new wrPatient.Patient();
            p = ptn.GetPatientByEMR(txtEMR.Text);

            txtPNM.Text = p.PName;
            txtADR.Text = p.Address;
            txtAGE.Text = p.Age.ToString();
            txtSEX.Text = p.Sex;
        }

        private void rdoDSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdoDSC.SelectedIndex == 0)
            {
                lciDAL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciDTH.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lcgDTH.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lciDAL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciDTH.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lcgDTH.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void dtpDOA_EditValueChanged(object sender, EventArgs e)
        {
            txtHPD.Text = (dtpDOD.DateTime.Date - dtpDOA.DateTime.Date).TotalDays.ToString();
        }

        private void dtpDOD_EditValueChanged(object sender, EventArgs e)
        {
            txtHPD.Text = (dtpDOD.DateTime.Date - dtpDOA.DateTime.Date).TotalDays.ToString();
        }
    }
}
