﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Verifica4.WcfClient.OrdiniServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/Verifica4.Core2.Model")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodiceClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CognomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodiceCliente {
            get {
                return this.CodiceClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.CodiceClienteField, value) != true)) {
                    this.CodiceClienteField = value;
                    this.RaisePropertyChanged("CodiceCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cognome {
            get {
                return this.CognomeField;
            }
            set {
                if ((object.ReferenceEquals(this.CognomeField, value) != true)) {
                    this.CognomeField = value;
                    this.RaisePropertyChanged("Cognome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrdiniServiceReference.IOrdiniService")]
    public interface IOrdiniService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/GetClienti", ReplyAction="http://tempuri.org/IOrdiniService/GetClientiResponse")]
        Verifica4.WcfClient.OrdiniServiceReference.Cliente[] GetClienti();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/GetClienti", ReplyAction="http://tempuri.org/IOrdiniService/GetClientiResponse")]
        System.Threading.Tasks.Task<Verifica4.WcfClient.OrdiniServiceReference.Cliente[]> GetClientiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/GetClienteById", ReplyAction="http://tempuri.org/IOrdiniService/GetClienteByIdResponse")]
        Verifica4.WcfClient.OrdiniServiceReference.Cliente GetClienteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/GetClienteById", ReplyAction="http://tempuri.org/IOrdiniService/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<Verifica4.WcfClient.OrdiniServiceReference.Cliente> GetClienteByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/AddNewCliente", ReplyAction="http://tempuri.org/IOrdiniService/AddNewClienteResponse")]
        bool AddNewCliente(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/AddNewCliente", ReplyAction="http://tempuri.org/IOrdiniService/AddNewClienteResponse")]
        System.Threading.Tasks.Task<bool> AddNewClienteAsync(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/EditCliente", ReplyAction="http://tempuri.org/IOrdiniService/EditClienteResponse")]
        bool EditCliente(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/EditCliente", ReplyAction="http://tempuri.org/IOrdiniService/EditClienteResponse")]
        System.Threading.Tasks.Task<bool> EditClienteAsync(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/DeleteCliente", ReplyAction="http://tempuri.org/IOrdiniService/DeleteClienteResponse")]
        bool DeleteCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdiniService/DeleteCliente", ReplyAction="http://tempuri.org/IOrdiniService/DeleteClienteResponse")]
        System.Threading.Tasks.Task<bool> DeleteClienteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdiniServiceChannel : Verifica4.WcfClient.OrdiniServiceReference.IOrdiniService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdiniServiceClient : System.ServiceModel.ClientBase<Verifica4.WcfClient.OrdiniServiceReference.IOrdiniService>, Verifica4.WcfClient.OrdiniServiceReference.IOrdiniService {
        
        public OrdiniServiceClient() {
        }
        
        public OrdiniServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdiniServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdiniServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdiniServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Verifica4.WcfClient.OrdiniServiceReference.Cliente[] GetClienti() {
            return base.Channel.GetClienti();
        }
        
        public System.Threading.Tasks.Task<Verifica4.WcfClient.OrdiniServiceReference.Cliente[]> GetClientiAsync() {
            return base.Channel.GetClientiAsync();
        }
        
        public Verifica4.WcfClient.OrdiniServiceReference.Cliente GetClienteById(int id) {
            return base.Channel.GetClienteById(id);
        }
        
        public System.Threading.Tasks.Task<Verifica4.WcfClient.OrdiniServiceReference.Cliente> GetClienteByIdAsync(int id) {
            return base.Channel.GetClienteByIdAsync(id);
        }
        
        public bool AddNewCliente(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente) {
            return base.Channel.AddNewCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewClienteAsync(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente) {
            return base.Channel.AddNewClienteAsync(cliente);
        }
        
        public bool EditCliente(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente) {
            return base.Channel.EditCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<bool> EditClienteAsync(Verifica4.WcfClient.OrdiniServiceReference.Cliente cliente) {
            return base.Channel.EditClienteAsync(cliente);
        }
        
        public bool DeleteCliente(int id) {
            return base.Channel.DeleteCliente(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClienteAsync(int id) {
            return base.Channel.DeleteClienteAsync(id);
        }
    }
}
