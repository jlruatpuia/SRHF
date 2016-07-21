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
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
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
            this.colUTP});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUTP, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colUNM;
        private DevExpress.XtraGrid.Columns.GridColumn colPWD;
        private DevExpress.XtraGrid.Columns.GridColumn colUTP;
    }
}