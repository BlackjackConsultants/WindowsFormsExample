﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsExample.SimpleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleService.ISimpleService")]
    public interface ISimpleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/GetUserName", ReplyAction="http://tempuri.org/ISimpleService/GetUserNameResponse")]
        string GetUserName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleService/GetUserName", ReplyAction="http://tempuri.org/ISimpleService/GetUserNameResponse")]
        System.Threading.Tasks.Task<string> GetUserNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleServiceChannel : WindowsFormsExample.SimpleService.ISimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleServiceClient : System.ServiceModel.ClientBase<WindowsFormsExample.SimpleService.ISimpleService>, WindowsFormsExample.SimpleService.ISimpleService {
        
        public SimpleServiceClient() {
        }
        
        public SimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetUserName() {
            return base.Channel.GetUserName();
        }
        
        public System.Threading.Tasks.Task<string> GetUserNameAsync() {
            return base.Channel.GetUserNameAsync();
        }
    }
}
