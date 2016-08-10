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
    public partial class frmDept : Form
    {
        wrSettings.wsSettings g = new wrSettings.wsSettings();
        wrSettings.Server2Client sc = new wrSettings.Server2Client();

        void Init()
        {
            sc = g.GetDepartments();
            grd.DataSource = sc.dt;
        }
        public frmDept()
        {
            InitializeComponent();

            Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wrSettings.Dept d = new wrSettings.Dept();
            d.DeptNo = Convert.ToInt32(txtDNO.Text);
            d.DeptShortName = txtDSN.Text;
            d.DeptFullName = txtDFN.Text;

            if (btnSave.Text == "&Save")
            {
                sc = g.SetDepartments(d);

                if (sc.message == null)
                {
                    MessageBox.Show("New Department added!", "Information");
                    txtDNO.Text = "";
                    txtDSN.Text = "";
                    txtDFN.Text = "";
                    Init();
                }
                else
                    MessageBox.Show(sc.message);
            }
            else
            {
                d.ID = Convert.ToInt32(grv.GetFocusedRowCellValue(colDID));
                sc = g.UpdateDepartments(d);
                if (sc.message == null)
                {
                    MessageBox.Show("Department updated!", "Information");
                    Init();
                    Reset();
                    btnSave.Text = "&Save";
                }
                else
                    MessageBox.Show(sc.message);
            }
        }

        private void Reset()
        {
            txtDNO.Text = "";
            txtDSN.Text = "";
            txtDFN.Text = "";
        }

        private void grv_DoubleClick(object sender, EventArgs e)
        {
            txtDNO.Text = grv.GetFocusedRowCellValue(colDNO).ToString();
            txtDSN.Text = grv.GetFocusedRowCellValue(colDSN).ToString();
            txtDFN.Text = grv.GetFocusedRowCellValue(colDFN).ToString();
            btnSave.Text = "&Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            btnSave.Text = "&Save";
        }
    }
}
