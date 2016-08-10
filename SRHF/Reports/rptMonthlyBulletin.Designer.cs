namespace SRHF.Reports
{
    partial class rptMonthlyBulletin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.srWWD = new DevExpress.XtraReports.UI.XRSubreport();
            this.srDWD = new DevExpress.XtraReports.UI.XRSubreport();
            this.srMSB = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srWWD,
            this.srDWD,
            this.xrPageBreak1,
            this.srMSB});
            this.Detail.HeightF = 73.00003F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 60F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 60F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // srWWD
            // 
            this.srWWD.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.00003F);
            this.srWWD.Name = "srWWD";
            this.srWWD.SizeF = new System.Drawing.SizeF(727F, 23F);
            // 
            // srDWD
            // 
            this.srDWD.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.srDWD.Name = "srDWD";
            this.srDWD.SizeF = new System.Drawing.SizeF(727.0001F, 23F);
            // 
            // srMSB
            // 
            this.srMSB.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.srMSB.Name = "srMSB";
            this.srMSB.SizeF = new System.Drawing.SizeF(727.0001F, 23F);
            // 
            // rptMonthlyBulletin
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 60, 60);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;
        public DevExpress.XtraReports.UI.XRSubreport srWWD;
        public DevExpress.XtraReports.UI.XRSubreport srMSB;
        public DevExpress.XtraReports.UI.XRSubreport srDWD;
    }
}
