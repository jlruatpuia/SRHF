namespace SRHF.Forms
{
    partial class frmViewUSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUSG));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.colIDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRMK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Size = new System.Drawing.Size(889, 484);
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
            this.layoutControl1.Size = new System.Drawing.Size(889, 49);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(630, 12);
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
            this.btnSearch.Location = new System.Drawing.Point(506, 12);
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
            this.dtpTo.Location = new System.Drawing.Point(376, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(126, 20);
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
            this.cboDuration.Size = new System.Drawing.Size(115, 21);
            this.cboDuration.TabIndex = 5;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // dtpFr
            // 
            this.dtpFr.Location = new System.Drawing.Point(193, 12);
            this.dtpFr.Name = "dtpFr";
            this.dtpFr.Size = new System.Drawing.Size(117, 20);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(889, 49);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpFr;
            this.layoutControlItem1.Location = new System.Drawing.Point(181, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(121, 29);
            this.layoutControlItem1.Text = "Select Date:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboDuration;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 29);
            this.layoutControlItem2.Text = "Select Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lciDtpTo
            // 
            this.lciDtpTo.Control = this.dtpTo;
            this.lciDtpTo.Location = new System.Drawing.Point(302, 0);
            this.lciDtpTo.Name = "lciDtpTo";
            this.lciDtpTo.Size = new System.Drawing.Size(192, 29);
            this.lciDtpTo.Text = "And:";
            this.lciDtpTo.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSearch;
            this.layoutControlItem4.Location = new System.Drawing.Point(494, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(742, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(127, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(618, 0);
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
            this.btnEdit,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(889, 431);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDT,
            this.colDNO,
            this.colMNO,
            this.colEMR,
            this.colPNM,
            this.colADR,
            this.colAGE,
            this.colSEX,
            this.colDGN,
            this.colRMK,
            this.colRCP,
            this.colCRG,
            this.colEdit,
            this.colID,
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
            // colDNO
            // 
            this.colDNO.Caption = "Daily No";
            this.colDNO.FieldName = "DailyNo";
            this.colDNO.Name = "colDNO";
            this.colDNO.OptionsColumn.AllowEdit = false;
            this.colDNO.OptionsColumn.AllowFocus = false;
            this.colDNO.OptionsColumn.ReadOnly = true;
            this.colDNO.Visible = true;
            this.colDNO.VisibleIndex = 0;
            this.colDNO.Width = 44;
            // 
            // colMNO
            // 
            this.colMNO.Caption = "Monthly No";
            this.colMNO.FieldName = "MonthlyNo";
            this.colMNO.Name = "colMNO";
            this.colMNO.OptionsColumn.AllowEdit = false;
            this.colMNO.OptionsColumn.AllowFocus = false;
            this.colMNO.OptionsColumn.ReadOnly = true;
            this.colMNO.Visible = true;
            this.colMNO.VisibleIndex = 1;
            this.colMNO.Width = 57;
            // 
            // colEMR
            // 
            this.colEMR.Caption = "gridColumn4";
            this.colEMR.FieldName = "EMRNo";
            this.colEMR.Name = "colEMR";
            this.colEMR.OptionsColumn.AllowEdit = false;
            this.colEMR.OptionsColumn.AllowFocus = false;
            this.colEMR.OptionsColumn.ReadOnly = true;
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
            this.colPNM.Width = 116;
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
            this.colADR.Width = 136;
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
            this.colAGE.VisibleIndex = 4;
            this.colAGE.Width = 33;
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
            this.colSEX.VisibleIndex = 5;
            this.colSEX.Width = 33;
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
            this.colDGN.VisibleIndex = 6;
            this.colDGN.Width = 115;
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
            this.colRMK.VisibleIndex = 7;
            this.colRMK.Width = 99;
            // 
            // colRCP
            // 
            this.colRCP.Caption = "Receipt No";
            this.colRCP.FieldName = "ReceiptNo";
            this.colRCP.Name = "colRCP";
            this.colRCP.OptionsColumn.AllowEdit = false;
            this.colRCP.OptionsColumn.AllowFocus = false;
            this.colRCP.OptionsColumn.ReadOnly = true;
            this.colRCP.Visible = true;
            this.colRCP.VisibleIndex = 8;
            this.colRCP.Width = 69;
            // 
            // colCRG
            // 
            this.colCRG.Caption = "Charge";
            this.colCRG.FieldName = "Charge";
            this.colCRG.Name = "colCRG";
            this.colCRG.OptionsColumn.AllowEdit = false;
            this.colCRG.OptionsColumn.AllowFocus = false;
            this.colCRG.OptionsColumn.ReadOnly = true;
            this.colCRG.Visible = true;
            this.colCRG.VisibleIndex = 9;
            this.colCRG.Width = 69;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Edit";
            this.colEdit.ColumnEdit = this.btnEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.OptionsColumn.AllowEdit = false;
            this.colEdit.OptionsColumn.AllowFocus = false;
            this.colEdit.OptionsColumn.ReadOnly = true;
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 10;
            this.colEdit.Width = 52;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
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
            this.colDel.Width = 48;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmViewUSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 484);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewUSG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View USG";
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
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
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
        private System.Windows.Forms.Button btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colIDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colMNO;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colDGN;
        private DevExpress.XtraGrid.Columns.GridColumn colRMK;
        private DevExpress.XtraGrid.Columns.GridColumn colRCP;
        private DevExpress.XtraGrid.Columns.GridColumn colCRG;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
    }
}