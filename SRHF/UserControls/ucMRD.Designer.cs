namespace SRHF.UserControls
{
    partial class ucMRD
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRMK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEDT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.cboDRN = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpDTO = new DevExpress.XtraEditors.DateEdit();
            this.dtpDFR = new DevExpress.XtraEditors.DateEdit();
            this.cboSDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDTO = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDRN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDTO.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDFR.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDFR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grd);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnShow);
            this.layoutControl1.Controls.Add(this.cboDRN);
            this.layoutControl1.Controls.Add(this.dtpDTO);
            this.layoutControl1.Controls.Add(this.dtpDFR);
            this.layoutControl1.Controls.Add(this.cboSDT);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1017, 209, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(840, 525);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 40);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEDT,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(816, 473);
            this.grd.TabIndex = 10;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMRD,
            this.colEMR,
            this.colPNM,
            this.colADR,
            this.colAGE,
            this.colDGN,
            this.colADT,
            this.colDDT,
            this.colRMK,
            this.colEDT,
            this.colDEL,
            this.colID});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.Click += new System.EventHandler(this.grv_Click);
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
            this.colMRD.VisibleIndex = 0;
            this.colMRD.Width = 68;
            // 
            // colEMR
            // 
            this.colEMR.Caption = "EMR No";
            this.colEMR.FieldName = "EMRNo";
            this.colEMR.Name = "colEMR";
            this.colEMR.OptionsColumn.AllowEdit = false;
            this.colEMR.OptionsColumn.AllowFocus = false;
            this.colEMR.OptionsColumn.ReadOnly = true;
            this.colEMR.Visible = true;
            this.colEMR.VisibleIndex = 1;
            this.colEMR.Width = 68;
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
            this.colPNM.Width = 107;
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
            this.colADR.Width = 125;
            // 
            // colAGE
            // 
            this.colAGE.Caption = "Age/Sex";
            this.colAGE.FieldName = "AgeSex";
            this.colAGE.Name = "colAGE";
            this.colAGE.OptionsColumn.AllowEdit = false;
            this.colAGE.OptionsColumn.AllowFocus = false;
            this.colAGE.OptionsColumn.ReadOnly = true;
            this.colAGE.Visible = true;
            this.colAGE.VisibleIndex = 4;
            this.colAGE.Width = 50;
            // 
            // colDGN
            // 
            this.colDGN.Caption = "Diagnosis";
            this.colDGN.FieldName = "ICDCode";
            this.colDGN.Name = "colDGN";
            this.colDGN.OptionsColumn.AllowEdit = false;
            this.colDGN.OptionsColumn.AllowFocus = false;
            this.colDGN.OptionsColumn.ReadOnly = true;
            this.colDGN.Visible = true;
            this.colDGN.VisibleIndex = 5;
            this.colDGN.Width = 73;
            // 
            // colADT
            // 
            this.colADT.Caption = "Admission Date";
            this.colADT.FieldName = "AdmissionDate";
            this.colADT.Name = "colADT";
            this.colADT.OptionsColumn.AllowEdit = false;
            this.colADT.OptionsColumn.AllowFocus = false;
            this.colADT.OptionsColumn.ReadOnly = true;
            this.colADT.Visible = true;
            this.colADT.VisibleIndex = 6;
            this.colADT.Width = 72;
            // 
            // colDDT
            // 
            this.colDDT.Caption = "Discharge Date";
            this.colDDT.FieldName = "DischargeDate";
            this.colDDT.Name = "colDDT";
            this.colDDT.OptionsColumn.AllowEdit = false;
            this.colDDT.OptionsColumn.AllowFocus = false;
            this.colDDT.OptionsColumn.ReadOnly = true;
            this.colDDT.Visible = true;
            this.colDDT.VisibleIndex = 7;
            this.colDDT.Width = 69;
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
            this.colRMK.VisibleIndex = 8;
            this.colRMK.Width = 81;
            // 
            // colEDT
            // 
            this.colEDT.Caption = "Edit";
            this.colEDT.ColumnEdit = this.repEDT;
            this.colEDT.Name = "colEDT";
            this.colEDT.OptionsColumn.AllowEdit = false;
            this.colEDT.OptionsColumn.AllowFocus = false;
            this.colEDT.OptionsColumn.ReadOnly = true;
            this.colEDT.Visible = true;
            this.colEDT.VisibleIndex = 9;
            this.colEDT.Width = 45;
            // 
            // repEDT
            // 
            this.repEDT.AutoHeight = false;
            this.repEDT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEDT.Name = "repEDT";
            this.repEDT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDEL
            // 
            this.colDEL.Caption = "Delete";
            this.colDEL.ColumnEdit = this.repDel;
            this.colDEL.Name = "colDEL";
            this.colDEL.OptionsColumn.AllowEdit = false;
            this.colDEL.OptionsColumn.AllowFocus = false;
            this.colDEL.OptionsColumn.ReadOnly = true;
            this.colDEL.Visible = true;
            this.colDEL.VisibleIndex = 10;
            this.colDEL.Width = 40;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(694, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(572, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(118, 22);
            this.btnShow.StyleController = this.layoutControl1;
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "&Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cboDRN
            // 
            this.cboDRN.Location = new System.Drawing.Point(218, 12);
            this.cboDRN.Name = "cboDRN";
            this.cboDRN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDRN.Properties.Items.AddRange(new object[] {
            "On",
            "Between"});
            this.cboDRN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDRN.Size = new System.Drawing.Size(79, 20);
            this.cboDRN.StyleController = this.layoutControl1;
            this.cboDRN.TabIndex = 7;
            this.cboDRN.SelectedIndexChanged += new System.EventHandler(this.cboDRN_SelectedIndexChanged);
            // 
            // dtpDTO
            // 
            this.dtpDTO.EditValue = null;
            this.dtpDTO.Location = new System.Drawing.Point(450, 12);
            this.dtpDTO.Name = "dtpDTO";
            this.dtpDTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDTO.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDTO.Size = new System.Drawing.Size(118, 20);
            this.dtpDTO.StyleController = this.layoutControl1;
            this.dtpDTO.TabIndex = 6;
            // 
            // dtpDFR
            // 
            this.dtpDFR.EditValue = null;
            this.dtpDFR.Location = new System.Drawing.Point(301, 12);
            this.dtpDFR.Name = "dtpDFR";
            this.dtpDFR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDFR.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDFR.Size = new System.Drawing.Size(124, 20);
            this.dtpDFR.StyleController = this.layoutControl1;
            this.dtpDFR.TabIndex = 5;
            // 
            // cboSDT
            // 
            this.cboSDT.Location = new System.Drawing.Point(74, 12);
            this.cboSDT.Name = "cboSDT";
            this.cboSDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSDT.Properties.Items.AddRange(new object[] {
            "Date of Admission",
            "Date of Discharge"});
            this.cboSDT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSDT.Size = new System.Drawing.Size(140, 20);
            this.cboSDT.StyleController = this.layoutControl1;
            this.cboSDT.TabIndex = 4;
            this.cboSDT.SelectedIndexChanged += new System.EventHandler(this.cboSDT_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciDTO,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.simpleSeparator1,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(840, 525);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboSDT;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(206, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(206, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(206, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Select Date:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpDFR;
            this.layoutControlItem2.Location = new System.Drawing.Point(289, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(128, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(128, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "From:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciDTO
            // 
            this.lciDTO.Control = this.dtpDTO;
            this.lciDTO.Location = new System.Drawing.Point(417, 0);
            this.lciDTO.MaxSize = new System.Drawing.Size(143, 24);
            this.lciDTO.MinSize = new System.Drawing.Size(143, 24);
            this.lciDTO.Name = "lciDTO";
            this.lciDTO.Size = new System.Drawing.Size(143, 26);
            this.lciDTO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDTO.Text = "To:";
            this.lciDTO.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciDTO.TextSize = new System.Drawing.Size(16, 13);
            this.lciDTO.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(795, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(25, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboDRN;
            this.layoutControlItem4.Location = new System.Drawing.Point(206, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(83, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(83, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(83, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnShow;
            this.layoutControlItem5.Location = new System.Drawing.Point(560, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(122, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(122, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnPrint;
            this.layoutControlItem6.Location = new System.Drawing.Point(682, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(113, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(113, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 26);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(820, 2);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.grd;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(820, 477);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ucMRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucMRD";
            this.Size = new System.Drawing.Size(840, 525);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDRN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDTO.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDFR.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDFR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboSDT;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cboDRN;
        private DevExpress.XtraEditors.DateEdit dtpDTO;
        private DevExpress.XtraEditors.DateEdit dtpDFR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciDTO;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colDGN;
        private DevExpress.XtraGrid.Columns.GridColumn colADT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDT;
        private DevExpress.XtraGrid.Columns.GridColumn colRMK;
        private DevExpress.XtraGrid.Columns.GridColumn colEDT;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}
