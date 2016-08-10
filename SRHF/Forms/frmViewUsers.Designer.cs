namespace SRHF.Forms
{
    partial class frmViewUsers
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
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPWD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit,
            this.repDel});
            this.grd.Size = new System.Drawing.Size(663, 472);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUID,
            this.colUNM,
            this.colPWD,
            this.colUTP,
            this.colEdit,
            this.colDel});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUTP, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv.Click += new System.EventHandler(this.grv_Click);
            // 
            // colUID
            // 
            this.colUID.Caption = "gridColumn1";
            this.colUID.FieldName = "ID";
            this.colUID.Name = "colUID";
            this.colUID.OptionsColumn.AllowEdit = false;
            this.colUID.OptionsColumn.AllowFocus = false;
            this.colUID.OptionsColumn.ReadOnly = true;
            // 
            // colUNM
            // 
            this.colUNM.Caption = "Username";
            this.colUNM.FieldName = "UserName";
            this.colUNM.Name = "colUNM";
            this.colUNM.OptionsColumn.AllowEdit = false;
            this.colUNM.OptionsColumn.AllowFocus = false;
            this.colUNM.OptionsColumn.ReadOnly = true;
            this.colUNM.Visible = true;
            this.colUNM.VisibleIndex = 0;
            // 
            // colPWD
            // 
            this.colPWD.Caption = "Password";
            this.colPWD.FieldName = "Password";
            this.colPWD.Name = "colPWD";
            this.colPWD.OptionsColumn.AllowEdit = false;
            this.colPWD.OptionsColumn.AllowFocus = false;
            this.colPWD.OptionsColumn.ReadOnly = true;
            this.colPWD.Visible = true;
            this.colPWD.VisibleIndex = 1;
            // 
            // colUTP
            // 
            this.colUTP.Caption = "Department";
            this.colUTP.FieldName = "UserType";
            this.colUTP.Name = "colUTP";
            this.colUTP.OptionsColumn.AllowEdit = false;
            this.colUTP.OptionsColumn.AllowFocus = false;
            this.colUTP.OptionsColumn.ReadOnly = true;
            this.colUTP.Visible = true;
            this.colUTP.VisibleIndex = 2;
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
            this.colEdit.VisibleIndex = 2;
            this.colEdit.Width = 62;
            // 
            // colDel
            // 
            this.colDel.Caption = "Deactivate";
            this.colDel.ColumnEdit = this.repDel;
            this.colDel.Name = "colDel";
            this.colDel.OptionsColumn.AllowEdit = false;
            this.colDel.OptionsColumn.AllowFocus = false;
            this.colDel.OptionsColumn.ReadOnly = true;
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 3;
            this.colDel.Width = 65;
            // 
            // repEdit
            // 
            this.repEdit.AutoHeight = false;
            this.repEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repEdit.Name = "repEdit";
            this.repEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repDel
            // 
            this.repDel.AutoHeight = false;
            this.repDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDel.Name = "repDel";
            this.repDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 472);
            this.Controls.Add(this.grd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Users";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colUNM;
        private DevExpress.XtraGrid.Columns.GridColumn colPWD;
        private DevExpress.XtraGrid.Columns.GridColumn colUTP;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDel;
    }
}