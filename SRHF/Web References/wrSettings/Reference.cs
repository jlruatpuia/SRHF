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

namespace SRHF.wrSettings {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="wsSettingsSoap", Namespace="http://tempuri.org/")]
    public partial class wsSettings : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDepartmentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetDepartmentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateDepartmentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetWardsOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddWardOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateWardOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteWardOperationCompleted;
        
        private System.Threading.SendOrPostCallback BackUpDatabaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback RestoreDatabaseOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsSettings() {
            this.Url = global::SRHF.Properties.Settings.Default.SRHF_wrSettings_wsSettings;
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
        public event GetDepartmentsCompletedEventHandler GetDepartmentsCompleted;
        
        /// <remarks/>
        public event SetDepartmentsCompletedEventHandler SetDepartmentsCompleted;
        
        /// <remarks/>
        public event UpdateDepartmentsCompletedEventHandler UpdateDepartmentsCompleted;
        
        /// <remarks/>
        public event GetWardsCompletedEventHandler GetWardsCompleted;
        
        /// <remarks/>
        public event AddWardCompletedEventHandler AddWardCompleted;
        
        /// <remarks/>
        public event UpdateWardCompletedEventHandler UpdateWardCompleted;
        
        /// <remarks/>
        public event DeleteWardCompletedEventHandler DeleteWardCompleted;
        
        /// <remarks/>
        public event BackUpDatabaseCompletedEventHandler BackUpDatabaseCompleted;
        
        /// <remarks/>
        public event RestoreDatabaseCompletedEventHandler RestoreDatabaseCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client GetDepartments() {
            object[] results = this.Invoke("GetDepartments", new object[0]);
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync() {
            this.GetDepartmentsAsync(null);
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync(object userState) {
            if ((this.GetDepartmentsOperationCompleted == null)) {
                this.GetDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDepartmentsOperationCompleted);
            }
            this.InvokeAsync("GetDepartments", new object[0], this.GetDepartmentsOperationCompleted, userState);
        }
        
        private void OnGetDepartmentsOperationCompleted(object arg) {
            if ((this.GetDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDepartmentsCompleted(this, new GetDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client SetDepartments(Dept dept) {
            object[] results = this.Invoke("SetDepartments", new object[] {
                        dept});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void SetDepartmentsAsync(Dept dept) {
            this.SetDepartmentsAsync(dept, null);
        }
        
        /// <remarks/>
        public void SetDepartmentsAsync(Dept dept, object userState) {
            if ((this.SetDepartmentsOperationCompleted == null)) {
                this.SetDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDepartmentsOperationCompleted);
            }
            this.InvokeAsync("SetDepartments", new object[] {
                        dept}, this.SetDepartmentsOperationCompleted, userState);
        }
        
        private void OnSetDepartmentsOperationCompleted(object arg) {
            if ((this.SetDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDepartmentsCompleted(this, new SetDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client UpdateDepartments(Dept dept) {
            object[] results = this.Invoke("UpdateDepartments", new object[] {
                        dept});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateDepartmentsAsync(Dept dept) {
            this.UpdateDepartmentsAsync(dept, null);
        }
        
        /// <remarks/>
        public void UpdateDepartmentsAsync(Dept dept, object userState) {
            if ((this.UpdateDepartmentsOperationCompleted == null)) {
                this.UpdateDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateDepartmentsOperationCompleted);
            }
            this.InvokeAsync("UpdateDepartments", new object[] {
                        dept}, this.UpdateDepartmentsOperationCompleted, userState);
        }
        
        private void OnUpdateDepartmentsOperationCompleted(object arg) {
            if ((this.UpdateDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateDepartmentsCompleted(this, new UpdateDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetWards", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client GetWards() {
            object[] results = this.Invoke("GetWards", new object[0]);
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void GetWardsAsync() {
            this.GetWardsAsync(null);
        }
        
        /// <remarks/>
        public void GetWardsAsync(object userState) {
            if ((this.GetWardsOperationCompleted == null)) {
                this.GetWardsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWardsOperationCompleted);
            }
            this.InvokeAsync("GetWards", new object[0], this.GetWardsOperationCompleted, userState);
        }
        
        private void OnGetWardsOperationCompleted(object arg) {
            if ((this.GetWardsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWardsCompleted(this, new GetWardsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddWard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client AddWard(Wards w) {
            object[] results = this.Invoke("AddWard", new object[] {
                        w});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void AddWardAsync(Wards w) {
            this.AddWardAsync(w, null);
        }
        
        /// <remarks/>
        public void AddWardAsync(Wards w, object userState) {
            if ((this.AddWardOperationCompleted == null)) {
                this.AddWardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddWardOperationCompleted);
            }
            this.InvokeAsync("AddWard", new object[] {
                        w}, this.AddWardOperationCompleted, userState);
        }
        
        private void OnAddWardOperationCompleted(object arg) {
            if ((this.AddWardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddWardCompleted(this, new AddWardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateWard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client UpdateWard(Wards w) {
            object[] results = this.Invoke("UpdateWard", new object[] {
                        w});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateWardAsync(Wards w) {
            this.UpdateWardAsync(w, null);
        }
        
        /// <remarks/>
        public void UpdateWardAsync(Wards w, object userState) {
            if ((this.UpdateWardOperationCompleted == null)) {
                this.UpdateWardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateWardOperationCompleted);
            }
            this.InvokeAsync("UpdateWard", new object[] {
                        w}, this.UpdateWardOperationCompleted, userState);
        }
        
        private void OnUpdateWardOperationCompleted(object arg) {
            if ((this.UpdateWardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateWardCompleted(this, new UpdateWardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteWard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client DeleteWard(Wards w) {
            object[] results = this.Invoke("DeleteWard", new object[] {
                        w});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteWardAsync(Wards w) {
            this.DeleteWardAsync(w, null);
        }
        
        /// <remarks/>
        public void DeleteWardAsync(Wards w, object userState) {
            if ((this.DeleteWardOperationCompleted == null)) {
                this.DeleteWardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteWardOperationCompleted);
            }
            this.InvokeAsync("DeleteWard", new object[] {
                        w}, this.DeleteWardOperationCompleted, userState);
        }
        
        private void OnDeleteWardOperationCompleted(object arg) {
            if ((this.DeleteWardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteWardCompleted(this, new DeleteWardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BackUpDatabase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void BackUpDatabase(string Path) {
            this.Invoke("BackUpDatabase", new object[] {
                        Path});
        }
        
        /// <remarks/>
        public void BackUpDatabaseAsync(string Path) {
            this.BackUpDatabaseAsync(Path, null);
        }
        
        /// <remarks/>
        public void BackUpDatabaseAsync(string Path, object userState) {
            if ((this.BackUpDatabaseOperationCompleted == null)) {
                this.BackUpDatabaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBackUpDatabaseOperationCompleted);
            }
            this.InvokeAsync("BackUpDatabase", new object[] {
                        Path}, this.BackUpDatabaseOperationCompleted, userState);
        }
        
        private void OnBackUpDatabaseOperationCompleted(object arg) {
            if ((this.BackUpDatabaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BackUpDatabaseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RestoreDatabase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RestoreDatabase(string path) {
            this.Invoke("RestoreDatabase", new object[] {
                        path});
        }
        
        /// <remarks/>
        public void RestoreDatabaseAsync(string path) {
            this.RestoreDatabaseAsync(path, null);
        }
        
        /// <remarks/>
        public void RestoreDatabaseAsync(string path, object userState) {
            if ((this.RestoreDatabaseOperationCompleted == null)) {
                this.RestoreDatabaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRestoreDatabaseOperationCompleted);
            }
            this.InvokeAsync("RestoreDatabase", new object[] {
                        path}, this.RestoreDatabaseOperationCompleted, userState);
        }
        
        private void OnRestoreDatabaseOperationCompleted(object arg) {
            if ((this.RestoreDatabaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RestoreDatabaseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Wards {
        
        private int idField;
        
        private int wardNoField;
        
        private string wardNameField;
        
        private string wardFullNameField;
        
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
        public int WardNo {
            get {
                return this.wardNoField;
            }
            set {
                this.wardNoField = value;
            }
        }
        
        /// <remarks/>
        public string WardName {
            get {
                return this.wardNameField;
            }
            set {
                this.wardNameField = value;
            }
        }
        
        /// <remarks/>
        public string WardFullName {
            get {
                return this.wardFullNameField;
            }
            set {
                this.wardFullNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Dept {
        
        private int idField;
        
        private int deptNoField;
        
        private string deptShortNameField;
        
        private string deptFullNameField;
        
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
        public int DeptNo {
            get {
                return this.deptNoField;
            }
            set {
                this.deptNoField = value;
            }
        }
        
        /// <remarks/>
        public string DeptShortName {
            get {
                return this.deptShortNameField;
            }
            set {
                this.deptShortNameField = value;
            }
        }
        
        /// <remarks/>
        public string DeptFullName {
            get {
                return this.deptFullNameField;
            }
            set {
                this.deptFullNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetDepartmentsCompletedEventHandler(object sender, GetDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void SetDepartmentsCompletedEventHandler(object sender, SetDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateDepartmentsCompletedEventHandler(object sender, UpdateDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetWardsCompletedEventHandler(object sender, GetWardsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWardsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWardsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void AddWardCompletedEventHandler(object sender, AddWardCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddWardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddWardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateWardCompletedEventHandler(object sender, UpdateWardCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateWardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateWardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteWardCompletedEventHandler(object sender, DeleteWardCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteWardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteWardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void BackUpDatabaseCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void RestoreDatabaseCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591