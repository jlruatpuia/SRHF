using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SRHF.Reports
{
    public partial class rptECGReport : XtraReport
    {
        wrECG.wsECG ecg = new wrECG.wsECG();
        wrECG.Server2Client sc = new wrECG.Server2Client();

        void Show(DataTable dt)
        {
            //ecg.ID, ecg.I_Date, ecg.DailyNo, ecg.MonthlyNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex='Male' THEN 'M' ELSE 'F' END AS Sex, ecg.Diagnosis, ecg.ReceiptNo, ecg.Remarks, ecg.Charge
            //DataSource = dt;
            GroupField idt = new GroupField("I_Date");
            GroupHeader1.GroupFields.Add(idt);
            lbIDT.DataBindings.Add("Text", null, "I_Date", "{0:dd-MM-yyyy}");
            lbDNO.DataBindings.Add("Text", null, "DailyNo");
            lbMNO.DataBindings.Add("Text", null, "MonthlyNo");
            lbEMR.DataBindings.Add("Text", null, "EMRNo");
            lbPNM.DataBindings.Add("Text", null, "PName");
            lbADR.DataBindings.Add("Text", null, "Address");
            lbAGE.DataBindings.Add("Text", null, "Age");
            lbSEX.DataBindings.Add("Text", null, "Sex");
            lbDGN.DataBindings.Add("Text", null, "Diagnosis");
            lbRNO.DataBindings.Add("Text", null, "ReceiptNo");
            lbRMK.DataBindings.Add("Text", null, "Remarks");
            lbCRG.DataBindings.Add("Text", null, "Charge");
            
        }

        public rptECGReport()
        {
            InitializeComponent();
        }

        public rptECGReport(DateTime dt, DataTable d)
        {
            InitializeComponent();
            //sc = ecg.GetECGByDate(dt);
            DataSource = d;
            lbHDT.Text = "ON " + dt.Date.ToShortDateString();
            lbCNT.Text = d.Rows.Count.ToString();
            Show(sc.dt);
        }

        public rptECGReport(DateTime df, DateTime dt, DataTable d)
        {
            InitializeComponent();
            //sc = ecg.GetECGByDates(df, dt);
            DataSource = d;
            lbHDT.Text = "BETWEEN " + df.Date.ToShortDateString() + " AND " + dt.Date.ToShortDateString();
            lbCNT.Text = d.Rows.Count.ToString();
            Show(sc.dt);
        }

    }
}
