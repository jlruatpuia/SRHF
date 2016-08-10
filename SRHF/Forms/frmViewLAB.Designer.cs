namespace SRHF.Forms
{
    partial class frmViewLAB
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.dtpFr = new System.Windows.Forms.DateTimePicker();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDtpTo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRMK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEDIT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEDIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.layoutControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd);
            this.splitContainer1.Size = new System.Drawing.Size(860, 486);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.dtpTo);
            this.layoutControl1.Controls.Add(this.cboDuration);
            this.layoutControl1.Controls.Add(this.dtpFr);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(266, 152, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(860, 49);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(614, 12);
            this.btnPrint.MaximumSize = new System.Drawing.Size(120, 25);
            this.btnPrint.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 25);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(490, 12);
            this.btnSearch.MaximumSize = new System.Drawing.Size(120, 25);
            this.btnSearch.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(366, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // cboDuration
            // 
            this.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Items.AddRange(new object[] {
            "On",
            "Between"});
            this.cboDuration.Location = new System.Drawing.Point(74, 12);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(109, 21);
            this.cboDuration.TabIndex = 5;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // dtpFr
            // 
            this.dtpFr.Location = new System.Drawing.Point(187, 12);
            this.dtpFr.Name = "dtpFr";
            this.dtpFr.Size = new System.Drawing.Size(113, 20);
            this.dtpFr.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciDtpTo,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(860, 49);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpFr;
            this.layoutControlItem1.Location = new System.Drawing.Point(175, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(117, 29);
            this.layoutControlItem1.Text = "Select Date:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboDuration;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(175, 29);
            this.layoutControlItem2.Text = "Select Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lciDtpTo
            // 
            this.lciDtpTo.Control = this.dtpTo;
            this.lciDtpTo.Location = new System.Drawing.Point(292, 0);
            this.lciDtpTo.Name = "lciDtpTo";
            this.lciDtpTo.Size = new System.Drawing.Size(186, 29);
            this.lciDtpTo.Text = "And:";
            this.lciDtpTo.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(478, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(726, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(114, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(602, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEDIT,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(860, 433);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLID,
            this.colIDT,
            this.colSNO,
            this.colDNO,
            this.colEMR,
            this.colPTP,
            this.colWRD,
            this.colMRD,
            this.colTPF,
            this.colCRG,
            this.colRNO,
            this.colRMK,
            this.colEDT,
            this.colDEL});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsBehavior.AutoExpandAllGroups = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv.Click += new System.EventHandler(this.grv_Click);
            // 
            // colLID
            // 
            this.colLID.Caption = "gridColumn1";
            this.colLID.FieldName = "ID";
            this.colLID.Name = "colLID";
            this.colLID.OptionsColumn.AllowEdit = false;
            this.colLID.OptionsColumn.AllowFocus = false;
            this.colLID.OptionsColumn.ReadOnly = true;
            // 
            // colIDT
            // 
            this.colIDT.Caption = "Date";
            this.colIDT.FieldName = "I_Date";
            this.colIDT.Name = "colIDT";
            this.colIDT.OptionsColumn.AllowEdit = false;
            this.colIDT.OptionsColumn.AllowFocus = false;
            this.colIDT.OptionsColumn.ReadOnly = true;
            this.colIDT.Visible = true;
            this.colIDT.VisibleIndex = 0;
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
            this.colSNO.Width = 70;
            // 
            // colDNO
            // 
            this.colDNO.Caption = "Daily No";
            this.colDNO.FieldName = "DailyNo";
            this.colDNO.Name = "colDNO";
            this.colDNO.OptionsColumn.AllowEdit = false;
            this.colDNO.OptionsColumn.AllowFocus = false;
            this.colDNO.OptionsColumn.ReadOnly = true;
            this.colDNO.Visible = true;
            this.colDNO.VisibleIndex = 1;
            this.colDNO.Width = 70;
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
            this.colEMR.VisibleIndex = 2;
            this.colEMR.Width = 70;
            // 
            // colPTP
            // 
            this.colPTP.Caption = "IPD/OPD";
            this.colPTP.FieldName = "PatientType";
            this.colPTP.Name = "colPTP";
            this.colPTP.OptionsColumn.AllowEdit = false;
            this.colPTP.OptionsColumn.AllowFocus = false;
            this.colPTP.OptionsColumn.ReadOnly = true;
            this.colPTP.Visible = true;
            this.colPTP.VisibleIndex = 3;
            this.colPTP.Width = 70;
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
            this.colWRD.VisibleIndex = 4;
            this.colWRD.Width = 70;
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
            this.colMRD.VisibleIndex = 5;
            this.colMRD.Width = 70;
            // 
            // colTPF
            // 
            this.colTPF.Caption = "Tests Performed";
            this.colTPF.FieldName = "TestPerformed";
            this.colTPF.Name = "colTPF";
            this.colTPF.OptionsColumn.AllowEdit = false;
            this.colTPF.OptionsColumn.AllowFocus = false;
            this.colTPF.OptionsColumn.ReadOnly = true;
            this.colTPF.Visible = true;
            this.colTPF.VisibleIndex = 6;
            this.colTPF.Width = 119;
            // 
            // colCRG
            // 
            this.colCRG.Caption = "User Charge";
            this.colCRG.FieldName = "Charge";
            this.colCRG.Name = "colCRG";
            this.colCRG.OptionsColumn.AllowEdit = false;
            this.colCRG.OptionsColumn.AllowFocus = false;
            this.colCRG.OptionsColumn.ReadOnly = true;
            this.colCRG.Visible = true;
            this.colCRG.VisibleIndex = 7;
            this.colCRG.Width = 68;
            // 
            // colRNO
            // 
            this.colRNO.Caption = "Receipt No";
            this.colRNO.FieldName = "Receipt No";
            this.colRNO.Name = "colRNO";
            this.colRNO.OptionsColumn.AllowEdit = false;
            this.colRNO.OptionsColumn.AllowFocus = false;
            this.colRNO.OptionsColumn.ReadOnly = true;
            this.colRNO.Visible = true;
            this.colRNO.VisibleIndex = 8;
            this.colRNO.Width = 92;
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
            this.colRMK.VisibleIndex = 9;
            this.colRMK.Width = 65;
            // 
            // colEDT
            // 
            this.colEDT.Caption = "Edit";
            this.colEDT.ColumnEdit = this.repEDIT;
            this.colEDT.Name = "colEDT";
            this.colEDT.OptionsColumn.AllowEdit = false;
            this.colEDT.OptionsColumn.AllowFocus = false;
            this.colEDT.OptionsColumn.ReadOnly = true;
            this.colEDT.Visible = true;
            this.colEDT.VisibleIndex = 10;
            this.colEDT.Width = 35;
            // 
            // repEDIT
            // 
            this.repEDIT.AutoHeight = false;
            this.repEDIT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEDIT.Name = "repEDIT";
            this.repEDIT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colDEL.VisibleIndex = 11;
            this.colDEL.Width = 43;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmViewLAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 486);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "frmViewLAB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Laboratory Records";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEDIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.DateTimePicker dtpFr;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciDtpTo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colLID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDT;
        private DevExpress.XtraGrid.Columns.GridColumn colSNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colPTP;
        private DevExpress.XtraGrid.Columns.GridColumn colWRD;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD;
        private DevExpress.XtraGrid.Columns.GridColumn colTPF;
        private DevExpress.XtraGrid.Columns.GridColumn colCRG;
        private DevExpress.XtraGrid.Columns.GridColumn colRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colRMK;
        private DevExpress.XtraGrid.Columns.GridColumn colEDT;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEDIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
    }
}