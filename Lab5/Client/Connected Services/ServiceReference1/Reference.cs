﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConnectionInfo", ReplyAction="http://tempuri.org/IService1/ConnectionInfoResponse")]
        void ConnectionInfo(string name, string port, string localPath, string uri, string scheme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConnectionInfo", ReplyAction="http://tempuri.org/IService1/ConnectionInfoResponse")]
        System.Threading.Tasks.Task ConnectionInfoAsync(string name, string port, string localPath, string uri, string scheme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOfDBRows", ReplyAction="http://tempuri.org/IService1/CountOfDBRowsResponse")]
        void CountOfDBRows(string count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOfDBRows", ReplyAction="http://tempuri.org/IService1/CountOfDBRowsResponse")]
        System.Threading.Tasks.Task CountOfDBRowsAsync(string count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Data.DataTable GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientSelectData", ReplyAction="http://tempuri.org/IService1/GetClientSelectDataResponse")]
        System.Data.DataTable GetClientSelectData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientSelectData", ReplyAction="http://tempuri.org/IService1/GetClientSelectDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetClientSelectDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusSelectData", ReplyAction="http://tempuri.org/IService1/GetBusSelectDataResponse")]
        System.Data.DataTable GetBusSelectData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusSelectData", ReplyAction="http://tempuri.org/IService1/GetBusSelectDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetBusSelectDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertMethod", ReplyAction="http://tempuri.org/IService1/InsertMethodResponse")]
        string InsertMethod(string id_Client, string id_Bus, string date, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertMethod", ReplyAction="http://tempuri.org/IService1/InsertMethodResponse")]
        System.Threading.Tasks.Task<string> InsertMethodAsync(string id_Client, string id_Bus, string date, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RecCheck", ReplyAction="http://tempuri.org/IService1/RecCheckResponse")]
        string RecCheck(string id_Client, string id_Bus, string date, string cost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RecCheck", ReplyAction="http://tempuri.org/IService1/RecCheckResponse")]
        System.Threading.Tasks.Task<string> RecCheckAsync(string id_Client, string id_Bus, string date, string cost);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public void ConnectionInfo(string name, string port, string localPath, string uri, string scheme) {
            base.Channel.ConnectionInfo(name, port, localPath, uri, scheme);
        }
        
        public System.Threading.Tasks.Task ConnectionInfoAsync(string name, string port, string localPath, string uri, string scheme) {
            return base.Channel.ConnectionInfoAsync(name, port, localPath, uri, scheme);
        }
        
        public void CountOfDBRows(string count) {
            base.Channel.CountOfDBRows(count);
        }
        
        public System.Threading.Tasks.Task CountOfDBRowsAsync(string count) {
            return base.Channel.CountOfDBRowsAsync(count);
        }
        
        public System.Data.DataTable GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public System.Data.DataTable GetClientSelectData() {
            return base.Channel.GetClientSelectData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetClientSelectDataAsync() {
            return base.Channel.GetClientSelectDataAsync();
        }
        
        public System.Data.DataTable GetBusSelectData() {
            return base.Channel.GetBusSelectData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetBusSelectDataAsync() {
            return base.Channel.GetBusSelectDataAsync();
        }
        
        public string InsertMethod(string id_Client, string id_Bus, string date, string cost) {
            return base.Channel.InsertMethod(id_Client, id_Bus, date, cost);
        }
        
        public System.Threading.Tasks.Task<string> InsertMethodAsync(string id_Client, string id_Bus, string date, string cost) {
            return base.Channel.InsertMethodAsync(id_Client, id_Bus, date, cost);
        }
        
        public string RecCheck(string id_Client, string id_Bus, string date, string cost) {
            return base.Channel.RecCheck(id_Client, id_Bus, date, cost);
        }
        
        public System.Threading.Tasks.Task<string> RecCheckAsync(string id_Client, string id_Bus, string date, string cost) {
            return base.Channel.RecCheckAsync(id_Client, id_Bus, date, cost);
        }
    }
}
