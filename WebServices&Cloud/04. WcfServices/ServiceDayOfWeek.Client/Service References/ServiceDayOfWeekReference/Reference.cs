﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDayOfWeek.Client.ServiceDayOfWeekReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDayOfWeekReference.IServiceDayOfWeek")]
    public interface IServiceDayOfWeek {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDayOfWeek/GetDayOfWeek", ReplyAction="http://tempuri.org/IServiceDayOfWeek/GetDayOfWeekResponse")]
        string GetDayOfWeek(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDayOfWeek/GetDayOfWeek", ReplyAction="http://tempuri.org/IServiceDayOfWeek/GetDayOfWeekResponse")]
        System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDayOfWeekChannel : ServiceDayOfWeek.Client.ServiceDayOfWeekReference.IServiceDayOfWeek, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDayOfWeekClient : System.ServiceModel.ClientBase<ServiceDayOfWeek.Client.ServiceDayOfWeekReference.IServiceDayOfWeek>, ServiceDayOfWeek.Client.ServiceDayOfWeekReference.IServiceDayOfWeek {
        
        public ServiceDayOfWeekClient() {
        }
        
        public ServiceDayOfWeekClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDayOfWeekClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDayOfWeekClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDayOfWeekClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDayOfWeek(System.DateTime date) {
            return base.Channel.GetDayOfWeek(date);
        }
        
        public System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime date) {
            return base.Channel.GetDayOfWeekAsync(date);
        }
    }
}
