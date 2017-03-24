﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace actionAPP.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IRecordService")]
    public interface IRecordService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/UserLogin", ReplyAction="http://tempuri.org/IRecordService/UserLoginResponse")]
        string UserLogin(string uid, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/UserLogin", ReplyAction="http://tempuri.org/IRecordService/UserLoginResponse")]
        System.Threading.Tasks.Task<string> UserLoginAsync(string uid, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/SignIn", ReplyAction="http://tempuri.org/IRecordService/SignInResponse")]
        string SignIn(string uid, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/SignIn", ReplyAction="http://tempuri.org/IRecordService/SignInResponse")]
        System.Threading.Tasks.Task<string> SignInAsync(string uid, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/AddKeys", ReplyAction="http://tempuri.org/IRecordService/AddKeysResponse")]
        string AddKeys(int count, string prefix, double days, string createSouse, System.DateTime effectiveDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/AddKeys", ReplyAction="http://tempuri.org/IRecordService/AddKeysResponse")]
        System.Threading.Tasks.Task<string> AddKeysAsync(int count, string prefix, double days, string createSouse, System.DateTime effectiveDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/ActivationMenber", ReplyAction="http://tempuri.org/IRecordService/ActivationMenberResponse")]
        string ActivationMenber(string uid, string createSouse, double days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordService/ActivationMenber", ReplyAction="http://tempuri.org/IRecordService/ActivationMenberResponse")]
        System.Threading.Tasks.Task<string> ActivationMenberAsync(string uid, string createSouse, double days);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecordServiceChannel : actionAPP.ServiceReference.IRecordService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecordServiceClient : System.ServiceModel.ClientBase<actionAPP.ServiceReference.IRecordService>, actionAPP.ServiceReference.IRecordService {
        
        public RecordServiceClient() {
        }
        
        public RecordServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecordServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string UserLogin(string uid, string pwd) {
            return base.Channel.UserLogin(uid, pwd);
        }
        
        public System.Threading.Tasks.Task<string> UserLoginAsync(string uid, string pwd) {
            return base.Channel.UserLoginAsync(uid, pwd);
        }
        
        public string SignIn(string uid, string pwd) {
            return base.Channel.SignIn(uid, pwd);
        }
        
        public System.Threading.Tasks.Task<string> SignInAsync(string uid, string pwd) {
            return base.Channel.SignInAsync(uid, pwd);
        }
        
        public string AddKeys(int count, string prefix, double days, string createSouse, System.DateTime effectiveDate) {
            return base.Channel.AddKeys(count, prefix, days, createSouse, effectiveDate);
        }
        
        public System.Threading.Tasks.Task<string> AddKeysAsync(int count, string prefix, double days, string createSouse, System.DateTime effectiveDate) {
            return base.Channel.AddKeysAsync(count, prefix, days, createSouse, effectiveDate);
        }
        
        public string ActivationMenber(string uid, string createSouse, double days) {
            return base.Channel.ActivationMenber(uid, createSouse, days);
        }
        
        public System.Threading.Tasks.Task<string> ActivationMenberAsync(string uid, string createSouse, double days) {
            return base.Channel.ActivationMenberAsync(uid, createSouse, days);
        }
    }
}
