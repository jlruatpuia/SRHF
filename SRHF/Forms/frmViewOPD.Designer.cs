namespace SRHF.Forms
{
    partial class frmViewOPD
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
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdt = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(775, 496);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 41);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdt,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(751, 443);
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
            this.colPNM,
            this.colADR,
            this.colAGE,
            this.colSEX,
            this.colOPD,
            this.colCSE,
            this.colEdt,
            this.colDel,
            this.colPID});
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
            this.colEMR.Width = 81;
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
            this.colPNM.VisibleIndex = 1;
            this.colPNM.Width = 166;
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
            this.colADR.VisibleIndex = 2;
            this.colADR.Width = 209;
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
            this.colAGE.VisibleIndex = 3;
            this.colAGE.Width = 40;
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
            this.colSEX.VisibleIndex = 4;
            this.colSEX.Width = 47;
            // 
            // colOPD
            // 
            this.colOPD.Caption = "OPD No";
            this.colOPD.FieldName = "OPDNo";
            this.colOPD.Name = "colOPD";
            this.colOPD.OptionsColumn.AllowEdit = false;
            this.colOPD.OptionsColumn.AllowFocus = false;
            this.colOPD.OptionsColumn.ReadOnly = true;
            this.colOPD.Visible = true;
            this.colOPD.VisibleIndex = 5;
            this.colOPD.Width = 46;
            // 
            // colCSE
            // 
            this.colCSE.Caption = "Case";
            this.colCSE.FieldName = "Cases";
            this.colCSE.Name = "colCSE";
            this.colCSE.OptionsColumn.AllowEdit = false;
            this.colCSE.OptionsColumn.AllowFocus = false;
            this.colCSE.OptionsColumn.ReadOnly = true;
            this.colCSE.Visible = true;
            this.colCSE.VisibleIndex = 6;
            this.colCSE.Width = 51;
            // 
            // colEdt
            // 
            this.colEdt.Caption = "Edit";
            this.colEdt.ColumnEdit = this.repEdt;
            this.colEdt.Name = "colEdt";
            this.colEdt.OptionsColumn.AllowEdit = false;
            this.colEdt.OptionsColumn.AllowFocus = false;
            this.colEdt.OptionsColumn.ReadOnly = true;
            this.colEdt.Visible = true;
            this.colEdt.VisibleIndex = 7;
            this.colEdt.Width = 44;
            // 
            // repEdt
            // 
            this.repEdt.AutoHeight = false;
            this.repEdt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEdt.Name = "repEdt";
            this.repEdt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colDel.VisibleIndex = 8;
            this.colDel.Width = 49;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colPID
            // 
            this.colPID.Caption = "gridColumn1";
            this.colPID.FieldName = "PID";
            this.colPID.Name = "colPID";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(565, 12);
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
            this.btnSearch.Location = new System.Drawing.Point(441, 12);
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
            this.dtpTo.Location = new System.Drawing.Point(336, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(101, 20);
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
            this.cboDuration.Size = new System.Drawing.Size(91, 21);
            this.cboDuration.TabIndex = 5;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // dtpFr
            // 
            this.dtpFr.Location = new System.Drawing.Point(169, 12);
            this.dtpFr.Name = "dtpFr";
            this.dtpFr.Size = new System.Drawing.Size(101, 20);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(775, 496);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpFr;
            this.layoutControlItem1.Location = new System.Drawing.Point(157, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(105, 29);
            this.layoutControlItem1.Text = "Select Date:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboDuration;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(157, 29);
            this.layoutControlItem2.Text = "Select Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lciDtpTo
            // 
            this.lciDtpTo.Control = this.dtpTo;
            this.lciDtpTo.Location = new System.Drawing.Point(262, 0);
            this.lciDtpTo.Name = "lciDtpTo";
            this.lciDtpTo.Size = new System.Drawing.Size(167, 29);
            this.lciDtpTo.Text = "And:";
            this.lciDtpTo.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(429, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(677, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(78, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(553, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(755, 447);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmViewOPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 496);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewOPD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Registered Patients";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colOPD;
        private DevExpress.XtraGrid.Columns.GridColumn colCSE;
        private DevExpress.XtraGrid.Columns.GridColumn colEdt;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEdt;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
    }
}