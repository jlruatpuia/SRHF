namespace SRHF.UserControls
{
    partial class ucHCare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHCare));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.bSearch = new DevExpress.XtraBars.BarCheckItem();
            this.bPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bNew,
            this.bEdit,
            this.bDel,
            this.bPrint,
            this.bSearch});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bSearch, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bNew
            // 
            this.bNew.Caption = "&New Record";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 0;
            this.bNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "&Edit Record";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 1;
            this.bEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDel
            // 
            this.bDel.Caption = "&Delete Record";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 2;
            this.bDel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            this.bDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDel_ItemClick);
            // 
            // bSearch
            // 
            this.bSearch.Caption = "&Search";
            this.bSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("bSearch.Glyph")));
            this.bSearch.Id = 5;
            this.bSearch.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.bSearch.Name = "bSearch";
            this.bSearch.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bSearch_CheckedChanged);
            // 
            // bPrint
            // 
            this.bPrint.Caption = "&Print";
            this.bPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrint.Glyph")));
            this.bPrint.Id = 4;
            this.bPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.bPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrint.LargeGlyph")));
            this.bPrint.Name = "bPrint";
            this.bPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPrint_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(869, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 487);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(869, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 487);
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 31);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.barManager1;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(869, 487);
            this.grd.TabIndex = 5;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colENO,
            this.colMRD,
            this.colPNM,
            this.colADR,
            this.colFHD,
            this.colAMC,
            this.colDOA,
            this.colDOD,
            this.colDGN});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colENO
            // 
            this.colENO.Caption = "Enrollment No";
            this.colENO.FieldName = "EnrollmentNo";
            this.colENO.Name = "colENO";
            this.colENO.OptionsColumn.AllowEdit = false;
            this.colENO.OptionsColumn.AllowFocus = false;
            this.colENO.OptionsColumn.ReadOnly = true;
            this.colENO.Visible = true;
            this.colENO.VisibleIndex = 0;
            this.colENO.Width = 78;
            // 
            // colMRD
            // 
            this.colMRD.Caption = "MRD No";
            this.colMRD.FieldName = "MRDNo";
            this.colMRD.Name = "colMRD";
            this.colMRD.OptionsColumn.AllowEdit = false;
            this.colMRD.OptionsColumn.AllowFocus = false;
            this.colMRD.OptionsColumn.ReadOnly = true;
            this.colMRD.Visible = true;
            this.colMRD.VisibleIndex = 1;
            this.colMRD.Width = 66;
            // 
            // colPNM
            // 
            this.colPNM.Caption = "Patient Name";
            this.colPNM.FieldName = "PName";
            this.colPNM.Name = "colPNM";
            this.colPNM.OptionsColumn.AllowEdit = false;
            this.colPNM.OptionsColumn.AllowFocus = false;
            this.colPNM.OptionsColumn.ReadOnly = true;
            this.colPNM.Visible = true;
            this.colPNM.VisibleIndex = 2;
            this.colPNM.Width = 138;
            // 
            // colADR
            // 
            this.colADR.Caption = "Address";
            this.colADR.FieldName = "Address";
            this.colADR.Name = "colADR";
            this.colADR.OptionsColumn.AllowEdit = false;
            this.colADR.OptionsColumn.AllowFocus = false;
            this.colADR.OptionsColumn.ReadOnly = true;
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 3;
            this.colADR.Width = 141;
            // 
            // colFHD
            // 
            this.colFHD.Caption = "Family Head";
            this.colFHD.FieldName = "FamilyHead";
            this.colFHD.Name = "colFHD";
            this.colFHD.OptionsColumn.AllowEdit = false;
            this.colFHD.OptionsColumn.AllowFocus = false;
            this.colFHD.OptionsColumn.ReadOnly = true;
            this.colFHD.Visible = true;
            this.colFHD.VisibleIndex = 4;
            this.colFHD.Width = 129;
            // 
            // colAMC
            // 
            this.colAMC.Caption = "Amount Claimed";
            this.colAMC.FieldName = "AmountClaimed";
            this.colAMC.Name = "colAMC";
            this.colAMC.OptionsColumn.AllowEdit = false;
            this.colAMC.OptionsColumn.AllowFocus = false;
            this.colAMC.OptionsColumn.ReadOnly = true;
            this.colAMC.Visible = true;
            this.colAMC.VisibleIndex = 5;
            this.colAMC.Width = 70;
            // 
            // colDOA
            // 
            this.colDOA.Caption = "Admission Date";
            this.colDOA.FieldName = "AdmissionDate";
            this.colDOA.Name = "colDOA";
            this.colDOA.OptionsColumn.AllowEdit = false;
            this.colDOA.OptionsColumn.AllowFocus = false;
            this.colDOA.OptionsColumn.ReadOnly = true;
            this.colDOA.Visible = true;
            this.colDOA.VisibleIndex = 6;
            this.colDOA.Width = 70;
            // 
            // colDOD
            // 
            this.colDOD.Caption = "Discharge Date";
            this.colDOD.FieldName = "DischargeDate";
            this.colDOD.Name = "colDOD";
            this.colDOD.OptionsColumn.AllowEdit = false;
            this.colDOD.OptionsColumn.AllowFocus = false;
            this.colDOD.OptionsColumn.ReadOnly = true;
            this.colDOD.Visible = true;
            this.colDOD.VisibleIndex = 7;
            this.colDOD.Width = 70;
            // 
            // colDGN
            // 
            this.colDGN.Caption = "Diagnosis";
            this.colDGN.FieldName = "Diagnosis";
            this.colDGN.Name = "colDGN";
            this.colDGN.OptionsColumn.AllowEdit = false;
            this.colDGN.OptionsColumn.AllowFocus = false;
            this.colDGN.OptionsColumn.ReadOnly = true;
            this.colDGN.Visible = true;
            this.colDGN.VisibleIndex = 8;
            this.colDGN.Width = 89;
            // 
            // ucHCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucHCare";
            this.Size = new System.Drawing.Size(869, 518);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        private DevExpress.XtraBars.BarButtonItem bPrint;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colENO;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colFHD;
        private DevExpress.XtraGrid.Columns.GridColumn colAMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDOA;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD;
        private DevExpress.XtraGrid.Columns.GridColumn colDGN;
        private DevExpress.XtraBars.BarCheckItem bSearch;
    }
}
