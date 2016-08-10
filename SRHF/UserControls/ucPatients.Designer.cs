namespace SRHF.UserControls
{
    partial class ucPatients
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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtSRC = new DevExpress.XtraEditors.SearchControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSRC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grd);
            this.layoutControl1.Controls.Add(this.txtSRC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(521, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(845, 530);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 36);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDel,
            this.repEdit});
            this.grd.Size = new System.Drawing.Size(821, 482);
            this.grd.TabIndex = 5;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEMR,
            this.colPNM,
            this.colADR,
            this.colAGE,
            this.colSEX,
            this.colEdit,
            this.colDel});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.Click += new System.EventHandler(this.grv_Click);
            // 
            // colID
            // 
            this.colID.Caption = "id";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
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
            this.colEMR.Width = 64;
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
            this.colPNM.VisibleIndex = 1;
            this.colPNM.Width = 206;
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
            this.colADR.Width = 282;
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
            this.colAGE.Width = 61;
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
            this.colSEX.Width = 61;
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
            this.colEdit.VisibleIndex = 5;
            this.colEdit.Width = 61;
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
            this.colDel.VisibleIndex = 6;
            this.colDel.Width = 68;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txtSRC
            // 
            this.txtSRC.Location = new System.Drawing.Point(122, 12);
            this.txtSRC.Name = "txtSRC";
            this.txtSRC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSRC.Size = new System.Drawing.Size(298, 20);
            this.txtSRC.StyleController = this.layoutControl1;
            this.txtSRC.TabIndex = 4;
            this.txtSRC.EditValueChanged += new System.EventHandler(this.txtSRC_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(845, 530);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSRC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(412, 24);
            this.layoutControlItem1.Text = "Search By EMR/Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(107, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(412, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(413, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grd;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(825, 486);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucPatients";
            this.Size = new System.Drawing.Size(845, 530);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSRC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SearchControl txtSRC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMR;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn colAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
    }
}
