namespace SRHF.Forms
{
    partial class frmViewCasualty
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpFR = new DevExpress.XtraEditors.DateEdit();
            this.cboSEL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpTO = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDTFR = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDTFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.grd);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.dtpFR);
            this.layoutControl1.Controls.Add(this.cboSEL);
            this.layoutControl1.Controls.Add(this.dtpTO);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(241, 152, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(949, 499);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(722, 12);
            this.btnPrint.MaximumSize = new System.Drawing.Size(150, 22);
            this.btnPrint.MinimumSize = new System.Drawing.Size(150, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 38);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(925, 449);
            this.grd.TabIndex = 8;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRNO,
            this.colSNO,
            this.colRDT,
            this.colRTM,
            this.colPNM,
            this.colADR,
            this.colAGE,
            this.colSEX,
            this.colDGN,
            this.colTRM,
            this.colEdit,
            this.colDel});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.Click += new System.EventHandler(this.grv_Click);
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
            // colRNO
            // 
            this.colRNO.Caption = "Regd. No";
            this.colRNO.FieldName = "RegNo";
            this.colRNO.Name = "colRNO";
            this.colRNO.OptionsColumn.AllowEdit = false;
            this.colRNO.OptionsColumn.AllowFocus = false;
            this.colRNO.OptionsColumn.ReadOnly = true;
            this.colRNO.Visible = true;
            this.colRNO.VisibleIndex = 0;
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
            this.colSNO.VisibleIndex = 1;
            this.colSNO.Width = 46;
            // 
            // colRDT
            // 
            this.colRDT.Caption = "Date";
            this.colRDT.FieldName = "RegDate";
            this.colRDT.Name = "colRDT";
            this.colRDT.OptionsColumn.AllowEdit = false;
            this.colRDT.OptionsColumn.AllowFocus = false;
            this.colRDT.OptionsColumn.ReadOnly = true;
            this.colRDT.Visible = true;
            this.colRDT.VisibleIndex = 2;
            this.colRDT.Width = 77;
            // 
            // colRTM
            // 
            this.colRTM.Caption = "Time";
            this.colRTM.DisplayFormat.FormatString = "t";
            this.colRTM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRTM.FieldName = "RegTime";
            this.colRTM.Name = "colRTM";
            this.colRTM.OptionsColumn.AllowEdit = false;
            this.colRTM.OptionsColumn.AllowFocus = false;
            this.colRTM.OptionsColumn.ReadOnly = true;
            this.colRTM.Visible = true;
            this.colRTM.VisibleIndex = 3;
            this.colRTM.Width = 77;
            // 
            // colPNM
            // 
            this.colPNM.Caption = "Name";
            this.colPNM.FieldName = "PName";
            this.colPNM.Name = "colPNM";
            this.colPNM.OptionsColumn.AllowEdit = false;
            this.colPNM.OptionsColumn.AllowFocus = false;
            this.colPNM.OptionsColumn.ReadOnly = true;
            this.colPNM.Visible = true;
            this.colPNM.VisibleIndex = 4;
            this.colPNM.Width = 119;
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
            this.colADR.VisibleIndex = 5;
            this.colADR.Width = 132;
            // 
            // colAGE
            // 
            this.colAGE.Caption = "Age";
            this.colAGE.FieldName = "Age";
            this.colAGE.Name = "colAGE";
            this.colAGE.OptionsColumn.AllowEdit = false;
            this.colAGE.OptionsColumn.AllowFocus = false;
            this.colAGE.OptionsColumn.ReadOnly = true;
            this.colAGE.Visible = true;
            this.colAGE.VisibleIndex = 6;
            this.colAGE.Width = 37;
            // 
            // colSEX
            // 
            this.colSEX.Caption = "Sex";
            this.colSEX.FieldName = "Sex";
            this.colSEX.Name = "colSEX";
            this.colSEX.OptionsColumn.AllowEdit = false;
            this.colSEX.OptionsColumn.AllowFocus = false;
            this.colSEX.OptionsColumn.ReadOnly = true;
            this.colSEX.Visible = true;
            this.colSEX.VisibleIndex = 7;
            this.colSEX.Width = 53;
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
            this.colDGN.Width = 101;
            // 
            // colTRM
            // 
            this.colTRM.Caption = "Treatment";
            this.colTRM.FieldName = "Treatment";
            this.colTRM.Name = "colTRM";
            this.colTRM.OptionsColumn.AllowEdit = false;
            this.colTRM.OptionsColumn.AllowFocus = false;
            this.colTRM.OptionsColumn.ReadOnly = true;
            this.colTRM.Visible = true;
            this.colTRM.VisibleIndex = 9;
            this.colTRM.Width = 111;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Edit";
            this.colEdit.ColumnEdit = this.repEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.OptionsColumn.AllowEdit = false;
            this.colEdit.OptionsColumn.AllowFocus = false;
            this.colEdit.OptionsColumn.ReadOnly = true;
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 10;
            this.colEdit.Width = 40;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEdit.Name = "repEdit";
            this.repEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDel
            // 
            this.colDel.Caption = "Delete";
            this.colDel.ColumnEdit = this.repDel;
            this.colDel.Name = "colDel";
            this.colDel.OptionsColumn.AllowEdit = false;
            this.colDel.OptionsColumn.AllowFocus = false;
            this.colDel.OptionsColumn.ReadOnly = true;
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 11;
            this.colDel.Width = 39;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(568, 12);
            this.btnSearch.MaximumSize = new System.Drawing.Size(150, 22);
            this.btnSearch.MinimumSize = new System.Drawing.Size(150, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFR
            // 
            this.dtpFR.EditValue = null;
            this.dtpFR.Location = new System.Drawing.Point(191, 12);
            this.dtpFR.Name = "dtpFR";
            this.dtpFR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFR.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFR.Size = new System.Drawing.Size(150, 20);
            this.dtpFR.StyleController = this.layoutControl1;
            this.dtpFR.TabIndex = 6;
            // 
            // cboSEL
            // 
            this.cboSEL.Location = new System.Drawing.Point(74, 12);
            this.cboSEL.Name = "cboSEL";
            this.cboSEL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSEL.Properties.Items.AddRange(new object[] {
            "On",
            "Between"});
            this.cboSEL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSEL.Size = new System.Drawing.Size(113, 20);
            this.cboSEL.StyleController = this.layoutControl1;
            this.cboSEL.TabIndex = 5;
            this.cboSEL.SelectedIndexChanged += new System.EventHandler(this.cboSEL_SelectedIndexChanged);
            // 
            // dtpTO
            // 
            this.dtpTO.EditValue = null;
            this.dtpTO.Location = new System.Drawing.Point(407, 12);
            this.dtpTO.Name = "dtpTO";
            this.dtpTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTO.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTO.Size = new System.Drawing.Size(157, 20);
            this.dtpTO.StyleController = this.layoutControl1;
            this.dtpTO.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDTFR,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 499);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciDTFR
            // 
            this.lciDTFR.Control = this.dtpTO;
            this.lciDTFR.Location = new System.Drawing.Point(333, 0);
            this.lciDTFR.Name = "lciDTFR";
            this.lciDTFR.Size = new System.Drawing.Size(223, 26);
            this.lciDTFR.Text = "And";
            this.lciDTFR.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboSEL;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 26);
            this.layoutControlItem2.Text = "Select Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtpFR;
            this.layoutControlItem3.Location = new System.Drawing.Point(179, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(556, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(864, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(65, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(929, 453);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(710, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmViewCasualty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 499);
            this.Controls.Add(this.layoutControl1);
            this.MinimizeBox = false;
            this.Name = "frmViewCasualty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Casualty Report";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDTFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dtpFR;
        private DevExpress.XtraEditors.ComboBoxEdit cboSEL;
        private DevExpress.XtraEditors.DateEdit dtpTO;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciDTFR;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSNO;
        private DevExpress.XtraGrid.Columns.GridColumn colRDT;
        private DevExpress.XtraGrid.Columns.GridColumn colRTM;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colDGN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRM;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}