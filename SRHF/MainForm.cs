using SRHF.Codes;
using SRHF.Forms;
using SRHF.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRHF
{
    public partial class MainForm : Form
    {
        wrUsers.wsUsers usr = new wrUsers.wsUsers();
        wrUsers.Server2Client sc = new wrUsers.Server2Client();
        string title = "State Referral Hospital, Falkawn";
        public int UID { get; set; }
        public string UNM { get; set; }
        public string PWD { get; set; }
        public string DPT { get; set; }
        public MainForm()
        {
            InitializeComponent();
            WindowSettings.GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
            mClose.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.WindowTheme = dlaf.LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.WindowGeometry = WindowSettings.GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UID = frm.UID;
                UNM = frm.UNM;
                PWD = frm.PWD;
                DPT = frm.DPT;
                switch (frm.DPT)
                {
                    case "ADMIN":
                        mOPD.Enabled = true;
                        mECG.Enabled = true;
                        mUSG.Enabled = true;
                        mXRAY.Enabled = true;
                        mOT.Enabled = true;
                        mLAB.Enabled = true;
                        mCasualty.Enabled = true;
                        mMRD.Enabled = true;
                        mRSBY.Enabled = true;
                        mHCARE.Enabled = true;
                        mUsrNew.Enabled = true;
                        mUsrView.Enabled = true;
                        mDbBackup.Enabled = true;
                        mDbRestore.Enabled = true;
                        break;
                    case "OPD":
                        mOPD.Enabled = true;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "ECG":
                        mOPD.Enabled = false;
                        mECG.Enabled = true;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "USG":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = true;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "X-RAY":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = true;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "OT":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = true;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "LABORATORY":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = true;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "CASUALTY":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = true;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "RSBY":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = true;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "HEALTH CARE":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = false;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = true;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                    case "MRD":
                        mOPD.Enabled = false;
                        mECG.Enabled = false;
                        mUSG.Enabled = false;
                        mXRAY.Enabled = false;
                        mOT.Enabled = false;
                        mLAB.Enabled = false;
                        mCasualty.Enabled = false;
                        mMRD.Enabled = true;
                        mRSBY.Enabled = false;
                        mHCARE.Enabled = false;
                        mUsrNew.Enabled = false;
                        mUsrView.Enabled = false;
                        mDbBackup.Enabled = false;
                        mDbRestore.Enabled = false;
                        break;
                }
            }
        }

         private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            mClose.Enabled = true;
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            mClose.Enabled = false;
        }

        //-----------------------------NEW MENU ----------------------------------//
        private void mLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Text = title;
            MainForm_Load(null, null);
        }

        private void mExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void mOpdNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOPD frm = new frmOPD();
            frm.ShowDialog();
        }

        private void mOpdView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucOPD uc = new ucOPD() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Out-Patient Department]";
        }

        private void mEcgNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmECG frm = new frmECG();
            frm.ShowDialog();
        }

        private void mEcgView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucECG uc = new ucECG() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [ECG Department]";
        }

        private void mUsgNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUSG frm = new frmUSG();
            frm.ShowDialog();
        }

        private void mUsgView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucUSG uc = new ucUSG() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [USG Department]";
        }

        private void mXrayNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXRAY frm = new frmXRAY();
            frm.ShowDialog();
        }

        private void mXrayView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucXRAY uc = new ucXRAY() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [X-RAY Department]";
        }

        private void mOtNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOTH frm = new frmOTH();
            frm.ShowDialog();
        }

        private void mOtView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucOTH uc = new ucOTH() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [OT Department]";
        }

        private void mLabNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLAB frm = new frmLAB();
            frm.ShowDialog();
        }

        private void mLabView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucLAB uc = new ucLAB() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Laboratory]";
        }

        private void mCasNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCasualty frm = new frmCasualty();
            frm.ShowDialog();
        }

        private void mCasView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucCasualty uc = new ucCasualty() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Casualty Department]";
        }

        private void mRsbyNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRSBY frm = new frmRSBY();
            frm.ShowDialog();
        }

        private void mRsbyView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucRSBY uc = new ucRSBY() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [RSBY]";
        }

        private void mHcareNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHCare frm = new frmHCare();
            frm.ShowDialog();
        }

        private void mHcareView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucHCare uc = new ucHCare() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Health Care]";
        }

        private void mMrdNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMRD frm = new frmMRD();
            frm.ShowDialog();
        }

        private void mMrdView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucMRD uc = new ucMRD() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [MRD]";
        }

        private void mMrdPMRD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucPMR uc = new ucPMR() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Patient MRD]";
        }

        private void mMrdMsBNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMSB frm = new frmMSB();
            frm.ShowDialog();
        }

        private void mMrdDwdNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDWD frm = new frmDWD();
            frm.ShowDialog();
        }

        private void mMrdWwdNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmWWD frm = new frmWWD();
            frm.ShowDialog();
        }

        private void mMrdMsbView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewMSB frm = new frmViewMSB();
            frm.ShowDialog();
        }

        private void mMrdIcd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewICD frm = new frmViewICD();
            frm.ShowDialog();
        }

        private void mPtnRView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucPatients uc = new ucPatients() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Registered Patients]";
        }

        private void mPtnDView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucPDT uc = new ucPDT() { Dock = DockStyle.Fill };
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            Text = title + " [Patient Detail]";
        }

        private void mUsrNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
        }

        private void mUsrView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewUsers frm = new frmViewUsers();
            frm.ShowDialog();
        }

        private void mUsrChng_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrUsers.Users u = new wrUsers.Users();
            u.ID = UID;
            u.UserName = UNM;
            u.Password = PWD;
            u.UserType = DPT;
            frmEditUser frm = new frmEditUser(u);
            frm.ShowDialog();
        }

        private void mDbBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.Desktop };
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string dt = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00");
                string path = fbd.SelectedPath + @"\BACKUP_SRHF_" + dt + ".sql";
                wrSettings.wsSettings ws = new wrSettings.wsSettings();
                ws.BackUpDatabase(path);
            }
        }

        private void mDbRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Database Backup File (*.sql)|*.sql" };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                wrSettings.wsSettings ws = new wrSettings.wsSettings();
                ws.RestoreDatabase(ofd.FileName);
            }
        }

        private void mClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Text = title;
        }
    }
}
