namespace SRHF.UserControls
{
    partial class ucRSBY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRSBY));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPKG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRMK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cboSEL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grd);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.cboSEL);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(534, 282, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(832, 480);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 38);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(808, 430);
            this.grd.TabIndex = 7;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSNO,
            this.colMRD,
            this.colPNM,
            this.colADR,
            this.colFHD,
            this.colCNO,
            this.colWRD,
            this.colDOA,
            this.colDOD,
            this.colPKG,
            this.colTBL,
            this.colAMT,
            this.colHSH,
            this.colURN,
            this.colRMK});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsFind.AlwaysVisible = true;
            this.grv.OptionsFind.ShowCloseButton = false;
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
            // colSNO
            // 
            this.colSNO.Caption = "Sl. No";
            this.colSNO.FieldName = "SlNo";
            this.colSNO.Name = "colSNO";
            this.colSNO.OptionsColumn.AllowEdit = false;
            this.colSNO.OptionsColumn.AllowFocus = false;
            this.colSNO.OptionsColumn.ReadOnly = true;
            this.colSNO.Visible = true;
            this.colSNO.VisibleIndex = 0;
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
            // 
            // colCNO
            // 
            this.colCNO.Caption = "Contact No";
            this.colCNO.FieldName = "ContactNo";
            this.colCNO.Name = "colCNO";
            this.colCNO.OptionsColumn.AllowEdit = false;
            this.colCNO.OptionsColumn.AllowFocus = false;
            this.colCNO.OptionsColumn.ReadOnly = true;
            this.colCNO.Visible = true;
            this.colCNO.VisibleIndex = 5;
            // 
            // colWRD
            // 
            this.colWRD.Caption = "Ward";
            this.colWRD.FieldName = "Ward";
            this.colWRD.Name = "colWRD";
            this.colWRD.OptionsColumn.AllowEdit = false;
            this.colWRD.OptionsColumn.AllowFocus = false;
            this.colWRD.OptionsColumn.ReadOnly = true;
            this.colWRD.Visible = true;
            this.colWRD.VisibleIndex = 6;
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
            this.colDOA.VisibleIndex = 7;
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
            this.colDOD.VisibleIndex = 8;
            // 
            // colPKG
            // 
            this.colPKG.Caption = "Packages";
            this.colPKG.FieldName = "Packages";
            this.colPKG.Name = "colPKG";
            this.colPKG.OptionsColumn.AllowEdit = false;
            this.colPKG.OptionsColumn.AllowFocus = false;
            this.colPKG.OptionsColumn.ReadOnly = true;
            this.colPKG.Visible = true;
            this.colPKG.VisibleIndex = 9;
            // 
            // colTBL
            // 
            this.colTBL.Caption = "Total Bill";
            this.colTBL.FieldName = "TotalBill";
            this.colTBL.Name = "colTBL";
            this.colTBL.OptionsColumn.AllowEdit = false;
            this.colTBL.OptionsColumn.AllowFocus = false;
            this.colTBL.OptionsColumn.ReadOnly = true;
            this.colTBL.Visible = true;
            this.colTBL.VisibleIndex = 10;
            // 
            // colAMT
            // 
            this.colAMT.Caption = "Actual Amt.";
            this.colAMT.FieldName = "ActualAmount";
            this.colAMT.Name = "colAMT";
            this.colAMT.OptionsColumn.AllowEdit = false;
            this.colAMT.OptionsColumn.AllowFocus = false;
            this.colAMT.OptionsColumn.ReadOnly = true;
            this.colAMT.Visible = true;
            this.colAMT.VisibleIndex = 11;
            // 
            // colHSH
            // 
            this.colHSH.Caption = "Hosp. Share";
            this.colHSH.FieldName = "HospitalShare";
            this.colHSH.Name = "colHSH";
            this.colHSH.OptionsColumn.AllowEdit = false;
            this.colHSH.OptionsColumn.AllowFocus = false;
            this.colHSH.OptionsColumn.ReadOnly = true;
            this.colHSH.Visible = true;
            this.colHSH.VisibleIndex = 12;
            // 
            // colURN
            // 
            this.colURN.Caption = "URN";
            this.colURN.FieldName = "URN";
            this.colURN.Name = "colURN";
            this.colURN.OptionsColumn.AllowEdit = false;
            this.colURN.OptionsColumn.AllowFocus = false;
            this.colURN.OptionsColumn.ReadOnly = true;
            this.colURN.Visible = true;
            this.colURN.VisibleIndex = 13;
            // 
            // colRMK
            // 
            this.colRMK.Caption = "Remarks";
            this.colRMK.FieldName = "Remarks";
            this.colRMK.Name = "colRMK";
            this.colRMK.OptionsColumn.AllowEdit = false;
            this.colRMK.OptionsColumn.AllowFocus = false;
            this.colRMK.OptionsColumn.ReadOnly = true;
            this.colRMK.Visible = true;
            this.colRMK.VisibleIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(332, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSEL
            // 
            this.cboSEL.Location = new System.Drawing.Point(60, 12);
            this.cboSEL.Name = "cboSEL";
            this.cboSEL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSEL.Properties.Items.AddRange(new object[] {
            "All Records",
            "Received",
            "Not Received"});
            this.cboSEL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSEL.Size = new System.Drawing.Size(186, 20);
            this.cboSEL.StyleController = this.layoutControl1;
            this.cboSEL.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(832, 480);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboSEL;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(238, 26);
            this.layoutControlItem1.Text = "Remarks:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(238, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(402, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(410, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.grd;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(812, 434);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
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
            this.bDel});
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "E&dit Record";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 1;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDel
            // 
            this.bDel.Caption = "&Delete Record";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 2;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            this.bDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(832, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(832, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // ucRSBY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucRSBY";
            this.Size = new System.Drawing.Size(832, 511);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboSEL;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSNO;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colFHD;
        private DevExpress.XtraGrid.Columns.GridColumn colCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colWRD;
        private DevExpress.XtraGrid.Columns.GridColumn colDOA;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD;
        private DevExpress.XtraGrid.Columns.GridColumn colPKG;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colAMT;
        private DevExpress.XtraGrid.Columns.GridColumn colHSH;
        private DevExpress.XtraGrid.Columns.GridColumn colURN;
        private DevExpress.XtraGrid.Columns.GridColumn colRMK;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
