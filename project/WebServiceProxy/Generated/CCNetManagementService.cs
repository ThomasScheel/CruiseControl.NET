﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.573.
// 
namespace ThoughtWorks.CruiseControl.WebServiceProxy.Generated {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CCNetManagementServiceSoap", Namespace="http://tempuri.org/")]
    public class CCNetManagementService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public CCNetManagementService() {
            this.Url = "http://localhost/ccnetwebservice/CCNetManagementService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StopCruiseControl", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopCruiseControl() {
            this.Invoke("StopCruiseControl", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStopCruiseControl(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StopCruiseControl", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndStopCruiseControl(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetConfiguration", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetConfiguration() {
            object[] results = this.Invoke("GetConfiguration", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetConfiguration(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetConfiguration", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetConfiguration(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetConfiguration", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetConfiguration(string configuration) {
            this.Invoke("SetConfiguration", new object[] {
                        configuration});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetConfiguration(string configuration, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetConfiguration", new object[] {
                        configuration}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSetConfiguration(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProjectStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProjectStatus GetProjectStatus() {
            object[] results = this.Invoke("GetProjectStatus", new object[0]);
            return ((ProjectStatus)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetProjectStatus(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetProjectStatus", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public ProjectStatus EndGetProjectStatus(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ProjectStatus)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ForceBuild", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ForceBuild(string projectName) {
            this.Invoke("ForceBuild", new object[] {
                        projectName});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginForceBuild(string projectName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ForceBuild", new object[] {
                        projectName}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndForceBuild(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StartCruiseControl", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StartCruiseControl() {
            this.Invoke("StartCruiseControl", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStartCruiseControl(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StartCruiseControl", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndStartCruiseControl(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CruiseControlStatus GetStatus() {
            object[] results = this.Invoke("GetStatus", new object[0]);
            return ((CruiseControlStatus)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetStatus(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetStatus", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public CruiseControlStatus EndGetStatus(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CruiseControlStatus)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StopCruiseControlNow", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopCruiseControlNow() {
            this.Invoke("StopCruiseControlNow", new object[0]);
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStopCruiseControlNow(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StopCruiseControlNow", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public void EndStopCruiseControlNow(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public class ProjectStatus {
        
        /// <remarks/>
        public CruiseControlStatus Status;
        
        /// <remarks/>
        public IntegrationStatus BuildStatus;
        
        /// <remarks/>
        public ProjectActivity Activity;
        
        /// <remarks/>
        public string Name;
        
        /// <remarks/>
        public string WebURL;
        
        /// <remarks/>
        public System.DateTime LastBuildDate;
        
        /// <remarks/>
        public string LastBuildLabel;

    	public DateTime NextBuildTime;
    	
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum CruiseControlStatus {
        
        /// <remarks/>
        Stopped,
        
        /// <remarks/>
        Running,
        
        /// <remarks/>
        WillBeStopped,
        
        /// <remarks/>
        Unknown,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum IntegrationStatus {
        
        /// <remarks/>
        Success,
        
        /// <remarks/>
        Failure,
        
        /// <remarks/>
        Exception,
        
        /// <remarks/>
        Unknown,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum ProjectActivity {
        
        /// <remarks/>
        CheckingModifications,
        
        /// <remarks/>
        Building,
        
        /// <remarks/>
        Sleeping,
        
        /// <remarks/>
        Unknown,
    }
}
