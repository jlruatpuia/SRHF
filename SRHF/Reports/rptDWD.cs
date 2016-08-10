using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SRHF.Reports
{
    public partial class rptDWD : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDWD()
        {
            InitializeComponent();
        }

        public rptDWD(int month, int year)
        {
            InitializeComponent();
            
        }
    }
}
