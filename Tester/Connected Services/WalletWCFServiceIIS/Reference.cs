﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KMA.APZRP2019.WalletSimulator.DBModels;

namespace Tester.WalletWCFServiceIIS {
    using System.Runtime.Serialization;
    using System;
    
    
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    //[System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/KMA.APZRP2019.WalletSimulator.DBModels")]
    //[System.SerializableAttribute()]
    //public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
    //    [System.NonSerializedAttribute()]
    //    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
    //    [System.Runtime.Serialization.OptionalFieldAttribute()]
    //    private string _emailField;
        
    //    [System.Runtime.Serialization.OptionalFieldAttribute()]
    //    private string _firstNameField;
        
    //    [System.Runtime.Serialization.OptionalFieldAttribute()]
    //    private System.Guid _guidField;
        
    //    [System.Runtime.Serialization.OptionalFieldAttribute()]
    //    private string _lastNameField;
        
    //    [System.Runtime.Serialization.OptionalFieldAttribute()]
    //    private string _passwordField;
        
    //    [global::System.ComponentModel.BrowsableAttribute(false)]
    //    public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
    //        get {
    //            return this.extensionDataField;
    //        }
    //        set {
    //            this.extensionDataField = value;
    //        }
    //    }
        
    //    [System.Runtime.Serialization.DataMemberAttribute()]
    //    public string _email {
    //        get {
    //            return this._emailField;
    //        }
    //        set {
    //            if ((object.ReferenceEquals(this._emailField, value) != true)) {
    //                this._emailField = value;
    //                this.RaisePropertyChanged("_email");
    //            }
    //        }
    //    }
        
    //    [System.Runtime.Serialization.DataMemberAttribute()]
    //    public string _firstName {
    //        get {
    //            return this._firstNameField;
    //        }
    //        set {
    //            if ((object.ReferenceEquals(this._firstNameField, value) != true)) {
    //                this._firstNameField = value;
    //                this.RaisePropertyChanged("_firstName");
    //            }
    //        }
    //    }
        
    //    [System.Runtime.Serialization.DataMemberAttribute()]
    //    public System.Guid _guid {
    //        get {
    //            return this._guidField;
    //        }
    //        set {
    //            if ((this._guidField.Equals(value) != true)) {
    //                this._guidField = value;
    //                this.RaisePropertyChanged("_guid");
    //            }
    //        }
    //    }
        
    //    [System.Runtime.Serialization.DataMemberAttribute()]
    //    public string _lastName {
    //        get {
    //            return this._lastNameField;
    //        }
    //        set {
    //            if ((object.ReferenceEquals(this._lastNameField, value) != true)) {
    //                this._lastNameField = value;
    //                this.RaisePropertyChanged("_lastName");
    //            }
    //        }
    //    }
        
    //    [System.Runtime.Serialization.DataMemberAttribute()]
    //    public string _password {
    //        get {
    //            return this._passwordField;
    //        }
    //        set {
    //            if ((object.ReferenceEquals(this._passwordField, value) != true)) {
    //                this._passwordField = value;
    //                this.RaisePropertyChanged("_password");
    //            }
    //        }
    //    }
        
    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
    //    protected void RaisePropertyChanged(string propertyName) {
    //        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    //        if ((propertyChanged != null)) {
    //            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WalletWCFServiceIIS.IWalletSimulator")]
    public interface IWalletSimulator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWalletSimulator/GetAllUsers", ReplyAction="http://tempuri.org/IWalletSimulator/GetAllUsersResponse")]
        User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWalletSimulator/GetAllUsers", ReplyAction="http://tempuri.org/IWalletSimulator/GetAllUsersResponse")]
        System.Threading.Tasks.Task<User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWalletSimulator/AddUser", ReplyAction="http://tempuri.org/IWalletSimulator/AddUserResponse")]
        void AddUser(User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWalletSimulator/AddUser", ReplyAction="http://tempuri.org/IWalletSimulator/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWalletSimulatorChannel : Tester.WalletWCFServiceIIS.IWalletSimulator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WalletSimulatorClient : System.ServiceModel.ClientBase<Tester.WalletWCFServiceIIS.IWalletSimulator>, Tester.WalletWCFServiceIIS.IWalletSimulator {
        
        public WalletSimulatorClient() {
        }
        
        public WalletSimulatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WalletSimulatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WalletSimulatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WalletSimulatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public void AddUser(User user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(User user) {
            return base.Channel.AddUserAsync(user);
        }
    }
}
