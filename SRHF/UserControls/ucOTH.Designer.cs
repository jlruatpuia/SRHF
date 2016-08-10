namespace SRHF.UserControls
{
    partial class ucOTH
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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSRG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRMK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEDIT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDEL = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.repDEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grd);
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
            this.layoutControl1.Size = new System.Drawing.Size(835, 506);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(600, 12);
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
            this.btnSearch.Location = new System.Drawing.Point(476, 12);
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
            this.dtpTo.Location = new System.Drawing.Point(358, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(114, 20);
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
            this.cboDuration.Size = new System.Drawing.Size(104, 21);
            this.cboDuration.TabIndex = 5;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // dtpFr
            // 
            this.dtpFr.Location = new System.Drawing.Point(182, 12);
            this.dtpFr.Name = "dtpFr";
            this.dtpFr.Size = new System.Drawing.Size(110, 20);
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
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(835, 506);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpFr;
            this.layoutControlItem1.Location = new System.Drawing.Point(170, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(114, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(114, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(114, 29);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Select Date:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboDuration;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(170, 25);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(170, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 29);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Select Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lciDtpTo
            // 
            this.lciDtpTo.Control = this.dtpTo;
            this.lciDtpTo.Location = new System.Drawing.Point(284, 0);
            this.lciDtpTo.MaxSize = new System.Drawing.Size(180, 24);
            this.lciDtpTo.MinSize = new System.Drawing.Size(180, 24);
            this.lciDtpTo.Name = "lciDtpTo";
            this.lciDtpTo.Size = new System.Drawing.Size(180, 29);
            this.lciDtpTo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDtpTo.Text = "And:";
            this.lciDtpTo.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(464, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(712, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(103, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(588, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 41);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDEL,
            this.repEDIT});
            this.grd.Size = new System.Drawing.Size(811, 453);
            this.grd.TabIndex = 9;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDT,
            this.colEMR,
            this.colOPN,
            this.colPTP,
            this.colANE,
            this.colOPT,
            this.colANT,
            this.colSRG,
            this.colAST,
            this.colRMK,
            this.colEdit,
            this.colDel});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsBehavior.AutoExpandAllGroups = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDT, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colEMR
            // 
            this.colEMR.Caption = "EMR No";
            this.colEMR.FieldName = "EMRNo";
            this.colEMR.Name = "colEMR";
            this.colEMR.OptionsColumn.AllowEdit = false;
            this.colEMR.OptionsColumn.AllowFocus = false;
            this.colEMR.OptionsColumn.ReadOnly = true;
            this.colEMR.Visible = true;
            this.colEMR.VisibleIndex = 0;
            this.colEMR.Width = 76;
            // 
            // colOPN
            // 
            this.colOPN.Caption = "Operation Name";
            this.colOPN.FieldName = "OpName";
            this.colOPN.Name = "colOPN";
            this.colOPN.OptionsColumn.AllowEdit = false;
            this.colOPN.OptionsColumn.AllowFocus = false;
            this.colOPN.OptionsColumn.ReadOnly = true;
            this.colOPN.Visible = true;
            this.colOPN.VisibleIndex = 1;
            this.colOPN.Width = 93;
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
            this.colPTP.VisibleIndex = 2;
            this.colPTP.Width = 74;
            // 
            // colANE
            // 
            this.colANE.Caption = "Anaesthesia";
            this.colANE.FieldName = "Anaesthesia";
            this.colANE.Name = "colANE";
            this.colANE.OptionsColumn.AllowEdit = false;
            this.colANE.OptionsColumn.AllowFocus = false;
            this.colANE.OptionsColumn.ReadOnly = true;
            this.colANE.Visible = true;
            this.colANE.VisibleIndex = 3;
            this.colANE.Width = 77;
            // 
            // colOPT
            // 
            this.colOPT.Caption = "Major/Minor";
            this.colOPT.FieldName = "OpType";
            this.colOPT.Name = "colOPT";
            this.colOPT.OptionsColumn.AllowEdit = false;
            this.colOPT.OptionsColumn.AllowFocus = false;
            this.colOPT.OptionsColumn.ReadOnly = true;
            this.colOPT.Visible = true;
            this.colOPT.VisibleIndex = 4;
            this.colOPT.Width = 63;
            // 
            // colANT
            // 
            this.colANT.Caption = "Anaesthetist";
            this.colANT.FieldName = "Anaesthetist";
            this.colANT.Name = "colANT";
            this.colANT.OptionsColumn.AllowEdit = false;
            this.colANT.OptionsColumn.AllowFocus = false;
            this.colANT.OptionsColumn.ReadOnly = true;
            this.colANT.Visible = true;
            this.colANT.VisibleIndex = 5;
            this.colANT.Width = 87;
            // 
            // colSRG
            // 
            this.colSRG.Caption = "Surgeon";
            this.colSRG.FieldName = "Surgeon";
            this.colSRG.Name = "colSRG";
            this.colSRG.OptionsColumn.AllowEdit = false;
            this.colSRG.OptionsColumn.AllowFocus = false;
            this.colSRG.OptionsColumn.ReadOnly = true;
            this.colSRG.Visible = true;
            this.colSRG.VisibleIndex = 6;
            this.colSRG.Width = 92;
            // 
            // colAST
            // 
            this.colAST.Caption = "Assistant";
            this.colAST.FieldName = "Assistant";
            this.colAST.Name = "colAST";
            this.colAST.OptionsColumn.AllowEdit = false;
            this.colAST.OptionsColumn.AllowFocus = false;
            this.colAST.OptionsColumn.ReadOnly = true;
            this.colAST.Visible = true;
            this.colAST.VisibleIndex = 7;
            this.colAST.Width = 88;
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
            this.colRMK.Width = 105;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Edit";
            this.colEdit.ColumnEdit = this.repEDIT;
            this.colEdit.Name = "colEdit";
            this.colEdit.OptionsColumn.AllowEdit = false;
            this.colEdit.OptionsColumn.AllowFocus = false;
            this.colEdit.OptionsColumn.ReadOnly = true;
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 9;
            this.colEdit.Width = 47;
            // 
            // repEDIT
            // 
            this.repEDIT.AutoHeight = false;
            this.repEDIT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEDIT.Name = "repEDIT";
            this.repEDIT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDel
            // 
            this.colDel.Caption = "Delete";
            this.colDel.ColumnEdit = this.repDEL;
            this.colDel.Name = "colDel";
            this.colDel.OptionsColumn.AllowEdit = false;
            this.colDel.OptionsColumn.AllowFocus = false;
            this.colDel.OptionsColumn.ReadOnly = true;
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 10;
            this.colDel.Width = 39;
            // 
            // repDEL
            // 
            this.repDEL.AutoHeight = false;
            this.repDEL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDEL.Name = "repDEL";
            this.repDEL.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(815, 457);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucOTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucOTH";
            this.Size = new System.Drawing.Size(835, 506);
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
            ((System.ComponentModel.ISupportInitialize)(this.repDEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colOPN;
        private DevExpress.XtraGrid.Columns.GridColumn colPTP;
        private DevExpress.XtraGrid.Columns.GridColumn colANE;
        private DevExpress.XtraGrid.Columns.GridColumn colOPT;
        private DevExpress.XtraGrid.Columns.GridColumn colANT;
        private DevExpress.XtraGrid.Columns.GridColumn colSRG;
        private DevExpress.XtraGrid.Columns.GridColumn colAST;
        private DevExpress.XtraGrid.Columns.GridColumn colRMK;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEDIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDEL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
