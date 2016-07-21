namespace SRHF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOPD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPtnReg = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRegisteredPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.eCGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuOPD,
            this.userToolStripMenuItem,
            this.eCGToolStripMenuItem,
            this.mRDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // mnuOPD
            // 
            this.mnuOPD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPtnReg,
            this.viewRegisteredPatientsToolStripMenuItem});
            this.mnuOPD.Name = "mnuOPD";
            this.mnuOPD.Size = new System.Drawing.Size(43, 20);
            this.mnuOPD.Text = "OPD";
            // 
            // mnuPtnReg
            // 
            this.mnuPtnReg.Name = "mnuPtnReg";
            this.mnuPtnReg.Size = new System.Drawing.Size(137, 22);
            this.mnuPtnReg.Text = "Registration";
            this.mnuPtnReg.Click += new System.EventHandler(this.mnuPtnReg_Click);
            // 
            // viewRegisteredPatientsToolStripMenuItem
            // 
            this.viewRegisteredPatientsToolStripMenuItem.Name = "viewRegisteredPatientsToolStripMenuItem";
            this.viewRegisteredPatientsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewRegisteredPatientsToolStripMenuItem.Text = "View Data";
            this.viewRegisteredPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewRegisteredPatientsToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddUser,
            this.mnuViewUser,
            this.toolStripSeparator2,
            this.mnuChangePwd});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.Name = "mnuAddUser";
            this.mnuAddUser.Size = new System.Drawing.Size(168, 22);
            this.mnuAddUser.Text = "Add User";
            this.mnuAddUser.Click += new System.EventHandler(this.mnuAddUser_Click);
            // 
            // mnuViewUser
            // 
            this.mnuViewUser.Name = "mnuViewUser";
            this.mnuViewUser.Size = new System.Drawing.Size(168, 22);
            this.mnuViewUser.Text = "View User";
            this.mnuViewUser.Click += new System.EventHandler(this.mnuViewUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuChangePwd
            // 
            this.mnuChangePwd.Name = "mnuChangePwd";
            this.mnuChangePwd.Size = new System.Drawing.Size(168, 22);
            this.mnuChangePwd.Text = "Change Password";
            // 
            // eCGToolStripMenuItem
            // 
            this.eCGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.viewDataToolStripMenuItem});
            this.eCGToolStripMenuItem.Name = "eCGToolStripMenuItem";
            this.eCGToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eCGToolStripMenuItem.Text = "&ECG";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // mRDToolStripMenuItem
            // 
            this.mRDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.mRDToolStripMenuItem.Name = "mRDToolStripMenuItem";
            this.mRDToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.mRDToolStripMenuItem.Text = "&MRD";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 489);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Referral Hospital, Falkawn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOPD;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddUser;
        private System.Windows.Forms.ToolStripMenuItem mnuViewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePwd;
        private System.Windows.Forms.ToolStripMenuItem mnuPtnReg;
        private System.Windows.Forms.ToolStripMenuItem viewRegisteredPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

