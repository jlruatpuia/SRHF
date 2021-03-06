﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SRHF.wrMRD {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsMRDSoap", Namespace="http://tempuri.org/")]
    public partial class wsMRD : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetPatientMRDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMRDByDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMRDByDatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMRDByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMRDByEMROperationCompleted;
        
        private System.Threading.SendOrPostCallback AddMRDOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateMRDOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteMRDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSerialNoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsMRD() {
            this.Url = global::SRHF.Properties.Settings.Default.SRHF_wrMRD_wsMRD;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetPatientMRDCompletedEventHandler GetPatientMRDCompleted;
        
        /// <remarks/>
        public event GetMRDByDateCompletedEventHandler GetMRDByDateCompleted;
        
        /// <remarks/>
        public event GetMRDByDatesCompletedEventHandler GetMRDByDatesCompleted;
        
        /// <remarks/>
        public event GetMRDByIDCompletedEventHandler GetMRDByIDCompleted;
        
        /// <remarks/>
        public event GetMRDByEMRCompletedEventHandler GetMRDByEMRCompleted;
        
        /// <remarks/>
        public event AddMRDCompletedEventHandler AddMRDCompleted;
        
        /// <remarks/>
        public event UpdateMRDCompletedEventHandler UpdateMRDCompleted;
        
        /// <remarks/>
        public event DeleteMRDCompletedEventHandler DeleteMRDCompleted;
        
        /// <remarks/>
        public event GetSerialNoCompletedEventHandler GetSerialNoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPatientMRD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MRD GetPatientMRD(string query, string field) {
            object[] results = this.Invoke("GetPatientMRD", new object[] {
                        query,
                        field});
            return ((MRD)(results[0]));
        }
        
        /// <remarks/>
        public void GetPatientMRDAsync(string query, string field) {
            this.GetPatientMRDAsync(query, field, null);
        }
        
        /// <remarks/>
        public void GetPatientMRDAsync(string query, string field, object userState) {
            if ((this.GetPatientMRDOperationCompleted == null)) {
                this.GetPatientMRDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPatientMRDOperationCompleted);
            }
            this.InvokeAsync("GetPatientMRD", new object[] {
                        query,
                        field}, this.GetPatientMRDOperationCompleted, userState);
        }
        
        private void OnGetPatientMRDOperationCompleted(object arg) {
            if ((this.GetPatientMRDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPatientMRDCompleted(this, new GetPatientMRDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMRDByDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client GetMRDByDate(System.DateTime d, string DateQuery) {
            object[] results = this.Invoke("GetMRDByDate", new object[] {
                        d,
                        DateQuery});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void GetMRDByDateAsync(System.DateTime d, string DateQuery) {
            this.GetMRDByDateAsync(d, DateQuery, null);
        }
        
        /// <remarks/>
        public void GetMRDByDateAsync(System.DateTime d, string DateQuery, object userState) {
            if ((this.GetMRDByDateOperationCompleted == null)) {
                this.GetMRDByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMRDByDateOperationCompleted);
            }
            this.InvokeAsync("GetMRDByDate", new object[] {
                        d,
                        DateQuery}, this.GetMRDByDateOperationCompleted, userState);
        }
        
        private void OnGetMRDByDateOperationCompleted(object arg) {
            if ((this.GetMRDByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMRDByDateCompleted(this, new GetMRDByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMRDByDates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client GetMRDByDates(System.DateTime df, System.DateTime dt, string DateQuery) {
            object[] results = this.Invoke("GetMRDByDates", new object[] {
                        df,
                        dt,
                        DateQuery});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void GetMRDByDatesAsync(System.DateTime df, System.DateTime dt, string DateQuery) {
            this.GetMRDByDatesAsync(df, dt, DateQuery, null);
        }
        
        /// <remarks/>
        public void GetMRDByDatesAsync(System.DateTime df, System.DateTime dt, string DateQuery, object userState) {
            if ((this.GetMRDByDatesOperationCompleted == null)) {
                this.GetMRDByDatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMRDByDatesOperationCompleted);
            }
            this.InvokeAsync("GetMRDByDates", new object[] {
                        df,
                        dt,
                        DateQuery}, this.GetMRDByDatesOperationCompleted, userState);
        }
        
        private void OnGetMRDByDatesOperationCompleted(object arg) {
            if ((this.GetMRDByDatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMRDByDatesCompleted(this, new GetMRDByDatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMRDByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MRD GetMRDByID(int ID) {
            object[] results = this.Invoke("GetMRDByID", new object[] {
                        ID});
            return ((MRD)(results[0]));
        }
        
        /// <remarks/>
        public void GetMRDByIDAsync(int ID) {
            this.GetMRDByIDAsync(ID, null);
        }
        
        /// <remarks/>
        public void GetMRDByIDAsync(int ID, object userState) {
            if ((this.GetMRDByIDOperationCompleted == null)) {
                this.GetMRDByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMRDByIDOperationCompleted);
            }
            this.InvokeAsync("GetMRDByID", new object[] {
                        ID}, this.GetMRDByIDOperationCompleted, userState);
        }
        
        private void OnGetMRDByIDOperationCompleted(object arg) {
            if ((this.GetMRDByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMRDByIDCompleted(this, new GetMRDByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMRDByEMR", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client GetMRDByEMR(string EMRNo) {
            object[] results = this.Invoke("GetMRDByEMR", new object[] {
                        EMRNo});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void GetMRDByEMRAsync(string EMRNo) {
            this.GetMRDByEMRAsync(EMRNo, null);
        }
        
        /// <remarks/>
        public void GetMRDByEMRAsync(string EMRNo, object userState) {
            if ((this.GetMRDByEMROperationCompleted == null)) {
                this.GetMRDByEMROperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMRDByEMROperationCompleted);
            }
            this.InvokeAsync("GetMRDByEMR", new object[] {
                        EMRNo}, this.GetMRDByEMROperationCompleted, userState);
        }
        
        private void OnGetMRDByEMROperationCompleted(object arg) {
            if ((this.GetMRDByEMRCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMRDByEMRCompleted(this, new GetMRDByEMRCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddMRD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client AddMRD(MRD mrd) {
            object[] results = this.Invoke("AddMRD", new object[] {
                        mrd});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void AddMRDAsync(MRD mrd) {
            this.AddMRDAsync(mrd, null);
        }
        
        /// <remarks/>
        public void AddMRDAsync(MRD mrd, object userState) {
            if ((this.AddMRDOperationCompleted == null)) {
                this.AddMRDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddMRDOperationCompleted);
            }
            this.InvokeAsync("AddMRD", new object[] {
                        mrd}, this.AddMRDOperationCompleted, userState);
        }
        
        private void OnAddMRDOperationCompleted(object arg) {
            if ((this.AddMRDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddMRDCompleted(this, new AddMRDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateMRD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client UpdateMRD(MRD mrd) {
            object[] results = this.Invoke("UpdateMRD", new object[] {
                        mrd});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateMRDAsync(MRD mrd) {
            this.UpdateMRDAsync(mrd, null);
        }
        
        /// <remarks/>
        public void UpdateMRDAsync(MRD mrd, object userState) {
            if ((this.UpdateMRDOperationCompleted == null)) {
                this.UpdateMRDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateMRDOperationCompleted);
            }
            this.InvokeAsync("UpdateMRD", new object[] {
                        mrd}, this.UpdateMRDOperationCompleted, userState);
        }
        
        private void OnUpdateMRDOperationCompleted(object arg) {
            if ((this.UpdateMRDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateMRDCompleted(this, new UpdateMRDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteMRD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client DeleteMRD(MRD mrd) {
            object[] results = this.Invoke("DeleteMRD", new object[] {
                        mrd});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteMRDAsync(MRD mrd) {
            this.DeleteMRDAsync(mrd, null);
        }
        
        /// <remarks/>
        public void DeleteMRDAsync(MRD mrd, object userState) {
            if ((this.DeleteMRDOperationCompleted == null)) {
                this.DeleteMRDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteMRDOperationCompleted);
            }
            this.InvokeAsync("DeleteMRD", new object[] {
                        mrd}, this.DeleteMRDOperationCompleted, userState);
        }
        
        private void OnDeleteMRDOperationCompleted(object arg) {
            if ((this.DeleteMRDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteMRDCompleted(this, new DeleteMRDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSerialNo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetSerialNo() {
            object[] results = this.Invoke("GetSerialNo", new object[0]);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetSerialNoAsync() {
            this.GetSerialNoAsync(null);
        }
        
        /// <remarks/>
        public void GetSerialNoAsync(object userState) {
            if ((this.GetSerialNoOperationCompleted == null)) {
                this.GetSerialNoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSerialNoOperationCompleted);
            }
            this.InvokeAsync("GetSerialNo", new object[0], this.GetSerialNoOperationCompleted, userState);
        }
        
        private void OnGetSerialNoOperationCompleted(object arg) {
            if ((this.GetSerialNoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSerialNoCompleted(this, new GetSerialNoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MRD {
        
        private int idField;
        
        private int slNoField;
        
        private string eMRNoField;
        
        private string diagnosisField;
        
        private string mRDNoField;
        
        private string wardField;
        
        private string iCDCodeField;
        
        private System.DateTime admissionDateField;
        
        private System.DateTime dischargeDateField;
        
        private string remarksField;
        
        private int hospitalDaysField;
        
        private string resultField;
        
        private string dischargedField;
        
        private string dischargedAliveField;
        
        private string dischargedDeathField;
        
        private string causeOfDeathField;
        
        private string directCauseField;
        
        private string antecedentCauseField;
        
        private string otherCauseField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int SlNo {
            get {
                return this.slNoField;
            }
            set {
                this.slNoField = value;
            }
        }
        
        /// <remarks/>
        public string EMRNo {
            get {
                return this.eMRNoField;
            }
            set {
                this.eMRNoField = value;
            }
        }
        
        /// <remarks/>
        public string Diagnosis {
            get {
                return this.diagnosisField;
            }
            set {
                this.diagnosisField = value;
            }
        }
        
        /// <remarks/>
        public string MRDNo {
            get {
                return this.mRDNoField;
            }
            set {
                this.mRDNoField = value;
            }
        }
        
        /// <remarks/>
        public string Ward {
            get {
                return this.wardField;
            }
            set {
                this.wardField = value;
            }
        }
        
        /// <remarks/>
        public string ICDCode {
            get {
                return this.iCDCodeField;
            }
            set {
                this.iCDCodeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime AdmissionDate {
            get {
                return this.admissionDateField;
            }
            set {
                this.admissionDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DischargeDate {
            get {
                return this.dischargeDateField;
            }
            set {
                this.dischargeDateField = value;
            }
        }
        
        /// <remarks/>
        public string Remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        public int HospitalDays {
            get {
                return this.hospitalDaysField;
            }
            set {
                this.hospitalDaysField = value;
            }
        }
        
        /// <remarks/>
        public string Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public string Discharged {
            get {
                return this.dischargedField;
            }
            set {
                this.dischargedField = value;
            }
        }
        
        /// <remarks/>
        public string DischargedAlive {
            get {
                return this.dischargedAliveField;
            }
            set {
                this.dischargedAliveField = value;
            }
        }
        
        /// <remarks/>
        public string DischargedDeath {
            get {
                return this.dischargedDeathField;
            }
            set {
                this.dischargedDeathField = value;
            }
        }
        
        /// <remarks/>
        public string CauseOfDeath {
            get {
                return this.causeOfDeathField;
            }
            set {
                this.causeOfDeathField = value;
            }
        }
        
        /// <remarks/>
        public string DirectCause {
            get {
                return this.directCauseField;
            }
            set {
                this.directCauseField = value;
            }
        }
        
        /// <remarks/>
        public string AntecedentCause {
            get {
                return this.antecedentCauseField;
            }
            set {
                this.antecedentCauseField = value;
            }
        }
        
        /// <remarks/>
        public string OtherCause {
            get {
                return this.otherCauseField;
            }
            set {
                this.otherCauseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Server2Client {
        
        private int countField;
        
        private double valueField;
        
        private string messageField;
        
        private bool resultField;
        
        private System.Data.DataTable dtField;
        
        private System.Data.DataSet dsField;
        
        /// <remarks/>
        public int count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public bool result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public System.Data.DataTable dt {
            get {
                return this.dtField;
            }
            set {
                this.dtField = value;
            }
        }
        
        /// <remarks/>
        public System.Data.DataSet ds {
            get {
                return this.dsField;
            }
            set {
                this.dsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetPatientMRDCompletedEventHandler(object sender, GetPatientMRDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPatientMRDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPatientMRDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MRD Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MRD)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetMRDByDateCompletedEventHandler(object sender, GetMRDByDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMRDByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMRDByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetMRDByDatesCompletedEventHandler(object sender, GetMRDByDatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMRDByDatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMRDByDatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetMRDByIDCompletedEventHandler(object sender, GetMRDByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMRDByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMRDByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MRD Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MRD)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetMRDByEMRCompletedEventHandler(object sender, GetMRDByEMRCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMRDByEMRCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMRDByEMRCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void AddMRDCompletedEventHandler(object sender, AddMRDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddMRDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddMRDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void UpdateMRDCompletedEventHandler(object sender, UpdateMRDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateMRDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateMRDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void DeleteMRDCompletedEventHandler(object sender, DeleteMRDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteMRDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteMRDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetSerialNoCompletedEventHandler(object sender, GetSerialNoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSerialNoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSerialNoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591