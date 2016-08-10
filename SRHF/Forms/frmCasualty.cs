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
    public partial class frmCasualty : Form
    {
        wrCasualty.wsCasualty cas = new wrCasualty.wsCasualty();
        public int _id { get; set; }
        public string _regNo { get; set; }
        public int _slNo { get; set; }
        public DateTime _regDate { get; set; }
        public DateTime _regTime { get; set; }
        public string _pName { get; set; }
        public string _address { get; set; }
        public int _age { get; set; }
        public string _sex { get; set; }
        public string _diagnosis { get; set; }
        public string _treatment { get; set; }


        void Init()
        {
            dtpIDT.DateTime = DateTime.Now.Date;

            wrCasualty.Server2Client sc = new wrCasualty.Server2Client();
            sc = cas.SerialNo(dtpIDT.DateTime);
            txtSNO.Text = sc.count.ToString();

            //sc = cas.RegdNo(dtpIDT.DateTime);
            string yr = dtpIDT.DateTime.Year.ToString().Substring(2);
            txtRNO.Text = yr + sc.count.ToString("00000");
        }
        public frmCasualty()
        {
            InitializeComponent();
            Init();
            timer1.Start();
            //dtpITM.Text = dtpIDT.DateTime.ToShortTimeString();
        }

        public frmCasualty(int ID)
        {
            InitializeComponent();
            _id = ID;
            btnSave.Text = "&Update";
            
            wrCasualty.Casualty c = new wrCasualty.Casualty();
            c = cas.GetCasualtyByID(ID);
            txtRNO.Text = c.RegNo;
            txtSNO.Text = c.SlNo.ToString();
            dtpIDT.EditValue = c.RegDate;
            dtpITM.EditValue = c.RegTime;
            txtPNM.Text = c.PName;
            txtADR.Text = c.Address;
            txtAGE.Text = c.Age.ToString();
            cboSEX.Text = c.Sex;
            txtDGN.Text = c.Diagnosis;
            txtTRM.Text = c.Treatment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;
            wrCasualty.Server2Client sc = new wrCasualty.Server2Client();
            wrCasualty.Casualty c = new wrCasualty.Casualty();
            if (btnSave.Text == "&Save")
            {
                c.RegNo = txtRNO.Text;
                c.SlNo = Convert.ToInt32(txtSNO.Text);
                c.RegDate = dtpIDT.DateTime.Date;
                c.RegTime = DateTime.Parse(dtpITM.Text);
                c.PName = txtPNM.Text;
                c.Address = txtADR.Text;
                c.Age = Convert.ToInt32(txtAGE.Text);
                c.Sex = cboSEX.Text;
                c.Diagnosis = txtDGN.Text;
                c.Treatment = txtTRM.Text;

                sc = cas.AddCasualty(c);
                if (sc.message == null)
                {
                    MessageBox.Show("Record added successfully!", "Information");
                    Clear();
                }
                else
                    MessageBox.Show(sc.message, "Error");
            }
            else
            {
                //c.ID = _id;
                _regNo = txtRNO.Text;
                _slNo = Convert.ToInt32(txtSNO.Text);
                _regDate = dtpIDT.DateTime.Date;
                _regTime = DateTime.Parse(dtpITM.Text);
                _pName = txtPNM.Text;
                _address = txtADR.Text;
                _age = Convert.ToInt32(txtAGE.Text);
                _sex = cboSEX.Text;
                _diagnosis = txtDGN.Text;
                _treatment = txtTRM.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void Clear()
        {
            txtPNM.Text = "";
            txtADR.Text = "";
            txtAGE.Text = "";
            cboSEX.Text = "";
            txtDGN.Text = "";
            txtTRM.Text = "";
            Init();
            txtPNM.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpITM.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
