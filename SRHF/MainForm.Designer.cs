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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.mLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.mExit = new DevExpress.XtraBars.BarButtonItem();
            this.mOPD = new DevExpress.XtraBars.BarSubItem();
            this.mOpdNew = new DevExpress.XtraBars.BarButtonItem();
            this.mOpdView = new DevExpress.XtraBars.BarButtonItem();
            this.mECG = new DevExpress.XtraBars.BarSubItem();
            this.mEcgNew = new DevExpress.XtraBars.BarButtonItem();
            this.mEcgView = new DevExpress.XtraBars.BarButtonItem();
            this.mUSG = new DevExpress.XtraBars.BarSubItem();
            this.mUsgNew = new DevExpress.XtraBars.BarButtonItem();
            this.mUsgView = new DevExpress.XtraBars.BarButtonItem();
            this.mXRAY = new DevExpress.XtraBars.BarSubItem();
            this.mXrayNew = new DevExpress.XtraBars.BarButtonItem();
            this.mXrayView = new DevExpress.XtraBars.BarButtonItem();
            this.mOT = new DevExpress.XtraBars.BarSubItem();
            this.mOtNew = new DevExpress.XtraBars.BarButtonItem();
            this.mOtView = new DevExpress.XtraBars.BarButtonItem();
            this.mLAB = new DevExpress.XtraBars.BarSubItem();
            this.mLabNew = new DevExpress.XtraBars.BarButtonItem();
            this.mLabView = new DevExpress.XtraBars.BarButtonItem();
            this.mCasualty = new DevExpress.XtraBars.BarSubItem();
            this.mCasNew = new DevExpress.XtraBars.BarButtonItem();
            this.mCasView = new DevExpress.XtraBars.BarButtonItem();
            this.mRSBY = new DevExpress.XtraBars.BarSubItem();
            this.mRsbyNew = new DevExpress.XtraBars.BarButtonItem();
            this.mRsbyView = new DevExpress.XtraBars.BarButtonItem();
            this.mHCARE = new DevExpress.XtraBars.BarSubItem();
            this.mHcareNew = new DevExpress.XtraBars.BarButtonItem();
            this.mHcareView = new DevExpress.XtraBars.BarButtonItem();
            this.mMRD = new DevExpress.XtraBars.BarSubItem();
            this.mMrdNew = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdView = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdPMRD = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdMsBNew = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdDwdNew = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdWwdNew = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdMsbView = new DevExpress.XtraBars.BarButtonItem();
            this.mMrdIcd = new DevExpress.XtraBars.BarButtonItem();
            this.mPatient = new DevExpress.XtraBars.BarSubItem();
            this.mPtnRView = new DevExpress.XtraBars.BarButtonItem();
            this.mPtnDView = new DevExpress.XtraBars.BarButtonItem();
            this.mSettings = new DevExpress.XtraBars.BarSubItem();
            this.mStgUsr = new DevExpress.XtraBars.BarSubItem();
            this.mUsrNew = new DevExpress.XtraBars.BarButtonItem();
            this.mUsrView = new DevExpress.XtraBars.BarButtonItem();
            this.mUsrChng = new DevExpress.XtraBars.BarButtonItem();
            this.mDB = new DevExpress.XtraBars.BarSubItem();
            this.mDbBackup = new DevExpress.XtraBars.BarButtonItem();
            this.mDbRestore = new DevExpress.XtraBars.BarButtonItem();
            this.mClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem35 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 445);
            this.panel1.TabIndex = 1;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            this.panel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlRemoved);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.mLogOut,
            this.mExit,
            this.mOPD,
            this.mOpdNew,
            this.mOpdView,
            this.mECG,
            this.mEcgNew,
            this.mEcgView,
            this.mUSG,
            this.mUsgNew,
            this.mUsgView,
            this.mXRAY,
            this.mXrayNew,
            this.mXrayView,
            this.mOT,
            this.mOtNew,
            this.mOtView,
            this.mLAB,
            this.mLabNew,
            this.mLabView,
            this.mCasualty,
            this.mCasNew,
            this.mCasView,
            this.mRSBY,
            this.mRsbyNew,
            this.mRsbyView,
            this.mHCARE,
            this.mHcareNew,
            this.mHcareView,
            this.mMRD,
            this.mMrdNew,
            this.mMrdView,
            this.mMrdPMRD,
            this.mMrdMsBNew,
            this.mMrdDwdNew,
            this.mMrdWwdNew,
            this.mMrdMsbView,
            this.mMrdIcd,
            this.mPatient,
            this.mPtnRView,
            this.mPtnDView,
            this.mSettings,
            this.mStgUsr,
            this.mUsrNew,
            this.mUsrView,
            this.barButtonItem35,
            this.mDB,
            this.mDbBackup,
            this.mDbRestore,
            this.mClose,
            this.mUsrChng});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 105;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOPD),
            new DevExpress.XtraBars.LinkPersistInfo(this.mECG),
            new DevExpress.XtraBars.LinkPersistInfo(this.mUSG),
            new DevExpress.XtraBars.LinkPersistInfo(this.mXRAY),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOT),
            new DevExpress.XtraBars.LinkPersistInfo(this.mLAB),
            new DevExpress.XtraBars.LinkPersistInfo(this.mCasualty),
            new DevExpress.XtraBars.LinkPersistInfo(this.mRSBY),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHCARE),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMRD),
            new DevExpress.XtraBars.LinkPersistInfo(this.mPatient),
            new DevExpress.XtraBars.LinkPersistInfo(this.mSettings),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // mFile
            // 
            this.mFile.Caption = "&File";
            this.mFile.Id = 53;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mLogOut),
            new DevExpress.XtraBars.LinkPersistInfo(this.mExit)});
            this.mFile.Name = "mFile";
            // 
            // mLogOut
            // 
            this.mLogOut.Caption = "Log Out";
            this.mLogOut.Id = 54;
            this.mLogOut.Name = "mLogOut";
            this.mLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mLogOut_ItemClick);
            // 
            // mExit
            // 
            this.mExit.Caption = "E&xit";
            this.mExit.Id = 55;
            this.mExit.Name = "mExit";
            this.mExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mExit_ItemClick);
            // 
            // mOPD
            // 
            this.mOPD.Caption = "&OPD";
            this.mOPD.Enabled = false;
            this.mOPD.Id = 56;
            this.mOPD.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mOpdNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOpdView)});
            this.mOPD.Name = "mOPD";
            // 
            // mOpdNew
            // 
            this.mOpdNew.Caption = "New Record";
            this.mOpdNew.Id = 57;
            this.mOpdNew.Name = "mOpdNew";
            this.mOpdNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOpdNew_ItemClick);
            // 
            // mOpdView
            // 
            this.mOpdView.Caption = "View Records";
            this.mOpdView.Id = 58;
            this.mOpdView.Name = "mOpdView";
            this.mOpdView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOpdView_ItemClick);
            // 
            // mECG
            // 
            this.mECG.Caption = "&ECG";
            this.mECG.Enabled = false;
            this.mECG.Id = 59;
            this.mECG.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mEcgNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mEcgView)});
            this.mECG.Name = "mECG";
            // 
            // mEcgNew
            // 
            this.mEcgNew.Caption = "New Record";
            this.mEcgNew.Id = 60;
            this.mEcgNew.Name = "mEcgNew";
            this.mEcgNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mEcgNew_ItemClick);
            // 
            // mEcgView
            // 
            this.mEcgView.Caption = "View Records";
            this.mEcgView.Id = 61;
            this.mEcgView.Name = "mEcgView";
            this.mEcgView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mEcgView_ItemClick);
            // 
            // mUSG
            // 
            this.mUSG.Caption = "&USG";
            this.mUSG.Enabled = false;
            this.mUSG.Id = 62;
            this.mUSG.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mUsgNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mUsgView)});
            this.mUSG.Name = "mUSG";
            // 
            // mUsgNew
            // 
            this.mUsgNew.Caption = "New Record";
            this.mUsgNew.Id = 63;
            this.mUsgNew.Name = "mUsgNew";
            this.mUsgNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mUsgNew_ItemClick);
            // 
            // mUsgView
            // 
            this.mUsgView.Caption = "View Records";
            this.mUsgView.Id = 64;
            this.mUsgView.Name = "mUsgView";
            this.mUsgView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mUsgView_ItemClick);
            // 
            // mXRAY
            // 
            this.mXRAY.Caption = "&X-RAY";
            this.mXRAY.Enabled = false;
            this.mXRAY.Id = 65;
            this.mXRAY.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mXrayNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mXrayView)});
            this.mXRAY.Name = "mXRAY";
            // 
            // mXrayNew
            // 
            this.mXrayNew.Caption = "New Record";
            this.mXrayNew.Id = 66;
            this.mXrayNew.Name = "mXrayNew";
            this.mXrayNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mXrayNew_ItemClick);
            // 
            // mXrayView
            // 
            this.mXrayView.Caption = "View Records";
            this.mXrayView.Id = 67;
            this.mXrayView.Name = "mXrayView";
            this.mXrayView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mXrayView_ItemClick);
            // 
            // mOT
            // 
            this.mOT.Caption = "Operation Theater";
            this.mOT.Enabled = false;
            this.mOT.Id = 68;
            this.mOT.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mOtNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mOtView)});
            this.mOT.Name = "mOT";
            // 
            // mOtNew
            // 
            this.mOtNew.Caption = "New Record";
            this.mOtNew.Id = 69;
            this.mOtNew.Name = "mOtNew";
            this.mOtNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOtNew_ItemClick);
            // 
            // mOtView
            // 
            this.mOtView.Caption = "View Records";
            this.mOtView.Id = 70;
            this.mOtView.Name = "mOtView";
            this.mOtView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mOtView_ItemClick);
            // 
            // mLAB
            // 
            this.mLAB.Caption = "&Laboratory";
            this.mLAB.Enabled = false;
            this.mLAB.Id = 71;
            this.mLAB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mLabNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mLabView)});
            this.mLAB.Name = "mLAB";
            // 
            // mLabNew
            // 
            this.mLabNew.Caption = "New Record";
            this.mLabNew.Id = 72;
            this.mLabNew.Name = "mLabNew";
            this.mLabNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mLabNew_ItemClick);
            // 
            // mLabView
            // 
            this.mLabView.Caption = "View Records";
            this.mLabView.Id = 73;
            this.mLabView.Name = "mLabView";
            this.mLabView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mLabView_ItemClick);
            // 
            // mCasualty
            // 
            this.mCasualty.Caption = "&Casualty";
            this.mCasualty.Enabled = false;
            this.mCasualty.Id = 74;
            this.mCasualty.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mCasNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mCasView)});
            this.mCasualty.Name = "mCasualty";
            // 
            // mCasNew
            // 
            this.mCasNew.Caption = "New Record";
            this.mCasNew.Id = 75;
            this.mCasNew.Name = "mCasNew";
            this.mCasNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mCasNew_ItemClick);
            // 
            // mCasView
            // 
            this.mCasView.Caption = "View Records";
            this.mCasView.Id = 76;
            this.mCasView.Name = "mCasView";
            this.mCasView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mCasView_ItemClick);
            // 
            // mRSBY
            // 
            this.mRSBY.Caption = "&RSBY";
            this.mRSBY.Enabled = false;
            this.mRSBY.Id = 77;
            this.mRSBY.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mRsbyNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mRsbyView)});
            this.mRSBY.Name = "mRSBY";
            // 
            // mRsbyNew
            // 
            this.mRsbyNew.Caption = "New Record";
            this.mRsbyNew.Id = 78;
            this.mRsbyNew.Name = "mRsbyNew";
            this.mRsbyNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mRsbyNew_ItemClick);
            // 
            // mRsbyView
            // 
            this.mRsbyView.Caption = "&View Records";
            this.mRsbyView.Id = 79;
            this.mRsbyView.Name = "mRsbyView";
            this.mRsbyView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mRsbyView_ItemClick);
            // 
            // mHCARE
            // 
            this.mHCARE.Caption = "&Health Care";
            this.mHCARE.Enabled = false;
            this.mHCARE.Id = 80;
            this.mHCARE.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mHcareNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHcareView)});
            this.mHCARE.Name = "mHCARE";
            // 
            // mHcareNew
            // 
            this.mHcareNew.Caption = "New Record";
            this.mHcareNew.Id = 81;
            this.mHcareNew.Name = "mHcareNew";
            this.mHcareNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mHcareNew_ItemClick);
            // 
            // mHcareView
            // 
            this.mHcareView.Caption = "View Records";
            this.mHcareView.Id = 82;
            this.mHcareView.Name = "mHcareView";
            this.mHcareView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mHcareView_ItemClick);
            // 
            // mMRD
            // 
            this.mMRD.Caption = "&MRD";
            this.mMRD.Enabled = false;
            this.mMRD.Id = 83;
            this.mMRD.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdView),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdPMRD),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdMsBNew, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdDwdNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdWwdNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdMsbView),
            new DevExpress.XtraBars.LinkPersistInfo(this.mMrdIcd, true)});
            this.mMRD.Name = "mMRD";
            // 
            // mMrdNew
            // 
            this.mMrdNew.Caption = "New Record";
            this.mMrdNew.Id = 84;
            this.mMrdNew.Name = "mMrdNew";
            this.mMrdNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdNew_ItemClick);
            // 
            // mMrdView
            // 
            this.mMrdView.Caption = "View Records";
            this.mMrdView.Id = 85;
            this.mMrdView.Name = "mMrdView";
            this.mMrdView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdView_ItemClick);
            // 
            // mMrdPMRD
            // 
            this.mMrdPMRD.Caption = "View Patient MRD";
            this.mMrdPMRD.Id = 86;
            this.mMrdPMRD.Name = "mMrdPMRD";
            this.mMrdPMRD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdPMRD_ItemClick);
            // 
            // mMrdMsBNew
            // 
            this.mMrdMsBNew.Caption = "MSB Data Entry";
            this.mMrdMsBNew.Id = 87;
            this.mMrdMsBNew.Name = "mMrdMsBNew";
            this.mMrdMsBNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdMsBNew_ItemClick);
            // 
            // mMrdDwdNew
            // 
            this.mMrdDwdNew.Caption = "Dept-Wise Data Entry";
            this.mMrdDwdNew.Id = 88;
            this.mMrdDwdNew.Name = "mMrdDwdNew";
            this.mMrdDwdNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdDwdNew_ItemClick);
            // 
            // mMrdWwdNew
            // 
            this.mMrdWwdNew.Caption = "Ward-Wise Data Entry";
            this.mMrdWwdNew.Id = 89;
            this.mMrdWwdNew.Name = "mMrdWwdNew";
            this.mMrdWwdNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdWwdNew_ItemClick);
            // 
            // mMrdMsbView
            // 
            this.mMrdMsbView.Caption = "View MSB Report";
            this.mMrdMsbView.Id = 90;
            this.mMrdMsbView.Name = "mMrdMsbView";
            this.mMrdMsbView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdMsbView_ItemClick);
            // 
            // mMrdIcd
            // 
            this.mMrdIcd.Caption = "View ICD";
            this.mMrdIcd.Id = 91;
            this.mMrdIcd.Name = "mMrdIcd";
            this.mMrdIcd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mMrdIcd_ItemClick);
            // 
            // mPatient
            // 
            this.mPatient.Caption = "&Patient";
            this.mPatient.Id = 92;
            this.mPatient.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mPtnRView),
            new DevExpress.XtraBars.LinkPersistInfo(this.mPtnDView)});
            this.mPatient.Name = "mPatient";
            // 
            // mPtnRView
            // 
            this.mPtnRView.Caption = "View Registered Patients";
            this.mPtnRView.Id = 93;
            this.mPtnRView.Name = "mPtnRView";
            this.mPtnRView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mPtnRView_ItemClick);
            // 
            // mPtnDView
            // 
            this.mPtnDView.Caption = "View Patient Detail Report";
            this.mPtnDView.Id = 94;
            this.mPtnDView.Name = "mPtnDView";
            this.mPtnDView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mPtnDView_ItemClick);
            // 
            // mSettings
            // 
            this.mSettings.Caption = "&Settings";
            this.mSettings.Id = 95;
            this.mSettings.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mStgUsr),
            new DevExpress.XtraBars.LinkPersistInfo(this.mDB)});
            this.mSettings.Name = "mSettings";
            // 
            // mStgUsr
            // 
            this.mStgUsr.Caption = "&Users";
            this.mStgUsr.Id = 96;
            this.mStgUsr.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mUsrNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mUsrView),
            new DevExpress.XtraBars.LinkPersistInfo(this.mUsrChng, true)});
            this.mStgUsr.Name = "mStgUsr";
            // 
            // mUsrNew
            // 
            this.mUsrNew.Caption = "Add New";
            this.mUsrNew.Enabled = false;
            this.mUsrNew.Id = 97;
            this.mUsrNew.Name = "mUsrNew";
            this.mUsrNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mUsrNew_ItemClick);
            // 
            // mUsrView
            // 
            this.mUsrView.Caption = "View Users";
            this.mUsrView.Enabled = false;
            this.mUsrView.Id = 98;
            this.mUsrView.Name = "mUsrView";
            this.mUsrView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mUsrView_ItemClick);
            // 
            // mUsrChng
            // 
            this.mUsrChng.Caption = "Change Password";
            this.mUsrChng.Id = 104;
            this.mUsrChng.Name = "mUsrChng";
            this.mUsrChng.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mUsrChng_ItemClick);
            // 
            // mDB
            // 
            this.mDB.Caption = "Database";
            this.mDB.Id = 100;
            this.mDB.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mDbBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.mDbRestore)});
            this.mDB.Name = "mDB";
            // 
            // mDbBackup
            // 
            this.mDbBackup.Caption = "&Backup";
            this.mDbBackup.Enabled = false;
            this.mDbBackup.Id = 101;
            this.mDbBackup.Name = "mDbBackup";
            this.mDbBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mDbBackup_ItemClick);
            // 
            // mDbRestore
            // 
            this.mDbRestore.Caption = "Restore";
            this.mDbRestore.Enabled = false;
            this.mDbRestore.Id = 102;
            this.mDbRestore.Name = "mDbRestore";
            this.mDbRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mDbRestore_ItemClick);
            // 
            // mClose
            // 
            this.mClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.mClose.Caption = "Close";
            this.mClose.Glyph = ((System.Drawing.Image)(resources.GetObject("mClose.Glyph")));
            this.mClose.Id = 103;
            this.mClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mClose.LargeGlyph")));
            this.mClose.Name = "mClose";
            this.mClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(810, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 445);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 44);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 445);
            // 
            // barButtonItem35
            // 
            this.barButtonItem35.Caption = "Database";
            this.barButtonItem35.Id = 99;
            this.barButtonItem35.Name = "barButtonItem35";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Referral Hospital, Falkawn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarButtonItem mLogOut;
        private DevExpress.XtraBars.BarButtonItem mExit;
        private DevExpress.XtraBars.BarSubItem mOPD;
        private DevExpress.XtraBars.BarButtonItem mOpdNew;
        private DevExpress.XtraBars.BarButtonItem mOpdView;
        private DevExpress.XtraBars.BarSubItem mECG;
        private DevExpress.XtraBars.BarButtonItem mEcgNew;
        private DevExpress.XtraBars.BarButtonItem mEcgView;
        private DevExpress.XtraBars.BarSubItem mUSG;
        private DevExpress.XtraBars.BarButtonItem mUsgNew;
        private DevExpress.XtraBars.BarButtonItem mUsgView;
        private DevExpress.XtraBars.BarSubItem mXRAY;
        private DevExpress.XtraBars.BarButtonItem mXrayNew;
        private DevExpress.XtraBars.BarButtonItem mXrayView;
        private DevExpress.XtraBars.BarSubItem mOT;
        private DevExpress.XtraBars.BarButtonItem mOtNew;
        private DevExpress.XtraBars.BarButtonItem mOtView;
        private DevExpress.XtraBars.BarSubItem mLAB;
        private DevExpress.XtraBars.BarButtonItem mLabNew;
        private DevExpress.XtraBars.BarButtonItem mLabView;
        private DevExpress.XtraBars.BarSubItem mCasualty;
        private DevExpress.XtraBars.BarButtonItem mCasNew;
        private DevExpress.XtraBars.BarButtonItem mCasView;
        private DevExpress.XtraBars.BarSubItem mRSBY;
        private DevExpress.XtraBars.BarButtonItem mRsbyNew;
        private DevExpress.XtraBars.BarButtonItem mRsbyView;
        private DevExpress.XtraBars.BarSubItem mHCARE;
        private DevExpress.XtraBars.BarButtonItem mHcareNew;
        private DevExpress.XtraBars.BarButtonItem mHcareView;
        private DevExpress.XtraBars.BarSubItem mMRD;
        private DevExpress.XtraBars.BarButtonItem mMrdNew;
        private DevExpress.XtraBars.BarButtonItem mMrdView;
        private DevExpress.XtraBars.BarButtonItem mMrdPMRD;
        private DevExpress.XtraBars.BarButtonItem mMrdMsBNew;
        private DevExpress.XtraBars.BarButtonItem mMrdDwdNew;
        private DevExpress.XtraBars.BarButtonItem mMrdWwdNew;
        private DevExpress.XtraBars.BarButtonItem mMrdMsbView;
        private DevExpress.XtraBars.BarButtonItem mMrdIcd;
        private DevExpress.XtraBars.BarSubItem mPatient;
        private DevExpress.XtraBars.BarButtonItem mPtnRView;
        private DevExpress.XtraBars.BarButtonItem mPtnDView;
        private DevExpress.XtraBars.BarSubItem mSettings;
        private DevExpress.XtraBars.BarSubItem mStgUsr;
        private DevExpress.XtraBars.BarButtonItem mUsrNew;
        private DevExpress.XtraBars.BarButtonItem mUsrView;
        private DevExpress.XtraBars.BarSubItem mDB;
        private DevExpress.XtraBars.BarButtonItem mDbBackup;
        private DevExpress.XtraBars.BarButtonItem mDbRestore;
        private DevExpress.XtraBars.BarButtonItem barButtonItem35;
        private DevExpress.XtraBars.BarButtonItem mClose;
        private DevExpress.XtraBars.BarButtonItem mUsrChng;
    }
}

