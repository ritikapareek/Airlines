﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineClient.cs.AirlineService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AirlineService.IAirlineService")]
    public interface IAirlineService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirlineService/GetRoutes", ReplyAction="http://tempuri.org/IAirlineService/GetRoutesResponse")]
        string[] GetRoutes(string source, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirlineService/GetRoutes", ReplyAction="http://tempuri.org/IAirlineService/GetRoutesResponse")]
        System.Threading.Tasks.Task<string[]> GetRoutesAsync(string source, string destination);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAirlineServiceChannel : AirlineClient.cs.AirlineService.IAirlineService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AirlineServiceClient : System.ServiceModel.ClientBase<AirlineClient.cs.AirlineService.IAirlineService>, AirlineClient.cs.AirlineService.IAirlineService {
        
        public AirlineServiceClient() {
        }
        
        public AirlineServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AirlineServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirlineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirlineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetRoutes(string source, string destination) {
            return base.Channel.GetRoutes(source, destination);
        }
        
        public System.Threading.Tasks.Task<string[]> GetRoutesAsync(string source, string destination) {
            return base.Channel.GetRoutesAsync(source, destination);
        }
    }
}