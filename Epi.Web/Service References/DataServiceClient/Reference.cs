﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Epi.Web.MVC.DataServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataServiceClient.IEWEDataService")]
    public interface IEWEDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetSurveyInfo", ReplyAction="http://tempuri.org/IEWEDataService/GetSurveyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetSurveyInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetSurveyAnswer", ReplyAction="http://tempuri.org/IEWEDataService/GetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/SetSurveyAnswer", ReplyAction="http://tempuri.org/IEWEDataService/SetSurveyAnswerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/SetSurveyAnswerCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/PassCodeLogin", ReplyAction="http://tempuri.org/IEWEDataService/PassCodeLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/PassCodeLoginCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse PassCodeLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/SetPassCode", ReplyAction="http://tempuri.org/IEWEDataService/SetPassCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/SetPassCodeCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse SetPassCode(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetAuthenticationResponse", ReplyAction="http://tempuri.org/IEWEDataService/GetAuthenticationResponseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetAuthenticationResponseCustomFaultExceptionF" +
            "ault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse GetAuthenticationResponse(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormsInfo", ReplyAction="http://tempuri.org/IEWEDataService/GetFormsInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormsInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormsInfoResponse GetFormsInfo(Epi.Web.Common.Message.FormsInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormResponseInfo", ReplyAction="http://tempuri.org/IEWEDataService/GetFormResponseInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormResponseInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormResponseInfoResponse GetFormResponseInfo(Epi.Web.Common.Message.FormResponseInfoRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormResponseList", ReplyAction="http://tempuri.org/IEWEDataService/GetFormResponseListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormResponseListCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetFormResponseList(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormSettings", ReplyAction="http://tempuri.org/IEWEDataService/GetFormSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormSettingsCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormSettingResponse GetFormSettings(Epi.Web.Common.Message.FormSettingRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/DeleteResponse", ReplyAction="http://tempuri.org/IEWEDataService/DeleteResponseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/DeleteResponseCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse DeleteResponse(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/UserLogin", ReplyAction="http://tempuri.org/IEWEDataService/UserLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/UserLoginCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse UserLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetUser", ReplyAction="http://tempuri.org/IEWEDataService/GetUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetUserCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.UserAuthenticationResponse GetUser(Epi.Web.Common.Message.UserAuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/UpdateUser", ReplyAction="http://tempuri.org/IEWEDataService/UpdateUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/UpdateUserCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        bool UpdateUser(Epi.Web.Common.Message.UserAuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/SaveSettings", ReplyAction="http://tempuri.org/IEWEDataService/SaveSettingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/SaveSettingsCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormSettingResponse SaveSettings(Epi.Web.Common.Message.FormSettingRequest FormSettingReq);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormChildInfo", ReplyAction="http://tempuri.org/IEWEDataService/GetFormChildInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormChildInfoCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyInfoResponse GetFormChildInfo(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetFormsHierarchy", ReplyAction="http://tempuri.org/IEWEDataService/GetFormsHierarchyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetFormsHierarchyCustomFaultExceptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.FormsHierarchyResponse GetFormsHierarchy(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetSurveyAnswerHierarchy", ReplyAction="http://tempuri.org/IEWEDataService/GetSurveyAnswerHierarchyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetSurveyAnswerHierarchyCustomFaultExceptionFa" +
            "ult", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswerHierarchy(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetAncestorResponseIdsByChildId", ReplyAction="http://tempuri.org/IEWEDataService/GetAncestorResponseIdsByChildIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetAncestorResponseIdsByChildIdCustomFaultExce" +
            "ptionFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetAncestorResponseIdsByChildId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEWEDataService/GetResponsesByRelatedFormId", ReplyAction="http://tempuri.org/IEWEDataService/GetResponsesByRelatedFormIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Epi.Web.Common.Exception.CustomFaultException), Action="http://tempuri.org/IEWEDataService/GetResponsesByRelatedFormIdCustomFaultExceptio" +
            "nFault", Name="CustomFaultException", Namespace="http://www.yourcompany.com/types/")]
        Epi.Web.Common.Message.SurveyAnswerResponse GetResponsesByRelatedFormId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEWEDataServiceChannel : Epi.Web.MVC.DataServiceClient.IEWEDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EWEDataServiceClient : System.ServiceModel.ClientBase<Epi.Web.MVC.DataServiceClient.IEWEDataService>, Epi.Web.MVC.DataServiceClient.IEWEDataService {
        
        public EWEDataServiceClient() {
        }
        
        public EWEDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EWEDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EWEDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EWEDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetSurveyInfo(Epi.Web.Common.Message.SurveyInfoRequest pRequest) {
            return base.Channel.GetSurveyInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswer(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse SetSurveyAnswer(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.SetSurveyAnswer(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse PassCodeLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.PassCodeLogin(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse SetPassCode(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.SetPassCode(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse GetAuthenticationResponse(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.GetAuthenticationResponse(pRequest);
        }
        
        public Epi.Web.Common.Message.FormsInfoResponse GetFormsInfo(Epi.Web.Common.Message.FormsInfoRequest pRequest) {
            return base.Channel.GetFormsInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.FormResponseInfoResponse GetFormResponseInfo(Epi.Web.Common.Message.FormResponseInfoRequest pRequest) {
            return base.Channel.GetFormResponseInfo(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetFormResponseList(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetFormResponseList(pRequest);
        }
        
        public Epi.Web.Common.Message.FormSettingResponse GetFormSettings(Epi.Web.Common.Message.FormSettingRequest pRequest) {
            return base.Channel.GetFormSettings(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse DeleteResponse(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.DeleteResponse(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse UserLogin(Epi.Web.Common.Message.UserAuthenticationRequest pRequest) {
            return base.Channel.UserLogin(pRequest);
        }
        
        public Epi.Web.Common.Message.UserAuthenticationResponse GetUser(Epi.Web.Common.Message.UserAuthenticationRequest request) {
            return base.Channel.GetUser(request);
        }
        
        public bool UpdateUser(Epi.Web.Common.Message.UserAuthenticationRequest request) {
            return base.Channel.UpdateUser(request);
        }
        
        public Epi.Web.Common.Message.FormSettingResponse SaveSettings(Epi.Web.Common.Message.FormSettingRequest FormSettingReq) {
            return base.Channel.SaveSettings(FormSettingReq);
        }
        
        public Epi.Web.Common.Message.SurveyInfoResponse GetFormChildInfo(Epi.Web.Common.Message.SurveyInfoRequest SurveyInfoRequest) {
            return base.Channel.GetFormChildInfo(SurveyInfoRequest);
        }
        
        public Epi.Web.Common.Message.FormsHierarchyResponse GetFormsHierarchy(Epi.Web.Common.Message.FormsHierarchyRequest FormsHierarchyRequest) {
            return base.Channel.GetFormsHierarchy(FormsHierarchyRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetSurveyAnswerHierarchy(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetSurveyAnswerHierarchy(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetAncestorResponseIdsByChildId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetAncestorResponseIdsByChildId(pRequest);
        }
        
        public Epi.Web.Common.Message.SurveyAnswerResponse GetResponsesByRelatedFormId(Epi.Web.Common.Message.SurveyAnswerRequest pRequest) {
            return base.Channel.GetResponsesByRelatedFormId(pRequest);
        }
    }
}
