﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_demo_client.WCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.IWCF_DemoService")]
    public interface IWCF_DemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCF_DemoService/GetHeader", ReplyAction="http://tempuri.org/IWCF_DemoService/GetHeaderResponse")]
        string GetHeader();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCF_DemoService/GetHeader", ReplyAction="http://tempuri.org/IWCF_DemoService/GetHeaderResponse")]
        System.Threading.Tasks.Task<string> GetHeaderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCF_DemoService/CsAdd", ReplyAction="http://tempuri.org/IWCF_DemoService/CsAddResponse")]
        int CsAdd(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCF_DemoService/CsAdd", ReplyAction="http://tempuri.org/IWCF_DemoService/CsAddResponse")]
        System.Threading.Tasks.Task<int> CsAddAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCF_DemoServiceChannel : WCF_demo_client.WCFService.IWCF_DemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCF_DemoServiceClient : System.ServiceModel.ClientBase<WCF_demo_client.WCFService.IWCF_DemoService>, WCF_demo_client.WCFService.IWCF_DemoService {
        
        public WCF_DemoServiceClient() {
        }
        
        public WCF_DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCF_DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCF_DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCF_DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHeader() {
            return base.Channel.GetHeader();
        }
        
        public System.Threading.Tasks.Task<string> GetHeaderAsync() {
            return base.Channel.GetHeaderAsync();
        }
        
        public int CsAdd(int a, int b) {
            return base.Channel.CsAdd(a, b);
        }
        
        public System.Threading.Tasks.Task<int> CsAddAsync(int a, int b) {
            return base.Channel.CsAddAsync(a, b);
        }
    }
}
