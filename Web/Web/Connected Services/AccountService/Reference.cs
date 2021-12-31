﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.AccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public string fullname {
            get {
                return this.fullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.fullnameField, value) != true)) {
                    this.fullnameField = value;
                    this.RaisePropertyChanged("fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountService.IAccount_Admin")]
    public interface IAccount_Admin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/list_acc", ReplyAction="http://tempuri.org/IAccount_Admin/list_accResponse")]
        Web.AccountService.Account[] list_acc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/list_acc", ReplyAction="http://tempuri.org/IAccount_Admin/list_accResponse")]
        System.Threading.Tasks.Task<Web.AccountService.Account[]> list_accAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/add_acc", ReplyAction="http://tempuri.org/IAccount_Admin/add_accResponse")]
        void add_acc(Web.AccountService.Account cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/add_acc", ReplyAction="http://tempuri.org/IAccount_Admin/add_accResponse")]
        System.Threading.Tasks.Task add_accAsync(Web.AccountService.Account cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/edit_cate", ReplyAction="http://tempuri.org/IAccount_Admin/edit_cateResponse")]
        void edit_cate(Web.AccountService.Account cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/edit_cate", ReplyAction="http://tempuri.org/IAccount_Admin/edit_cateResponse")]
        System.Threading.Tasks.Task edit_cateAsync(Web.AccountService.Account cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/delete_acc", ReplyAction="http://tempuri.org/IAccount_Admin/delete_accResponse")]
        void delete_acc(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/delete_acc", ReplyAction="http://tempuri.org/IAccount_Admin/delete_accResponse")]
        System.Threading.Tasks.Task delete_accAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/Find_acc", ReplyAction="http://tempuri.org/IAccount_Admin/Find_accResponse")]
        Web.AccountService.Account Find_acc(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount_Admin/Find_acc", ReplyAction="http://tempuri.org/IAccount_Admin/Find_accResponse")]
        System.Threading.Tasks.Task<Web.AccountService.Account> Find_accAsync(System.Nullable<int> id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccount_AdminChannel : Web.AccountService.IAccount_Admin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Account_AdminClient : System.ServiceModel.ClientBase<Web.AccountService.IAccount_Admin>, Web.AccountService.IAccount_Admin {
        
        public Account_AdminClient() {
        }
        
        public Account_AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Account_AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Account_AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Account_AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Web.AccountService.Account[] list_acc() {
            return base.Channel.list_acc();
        }
        
        public System.Threading.Tasks.Task<Web.AccountService.Account[]> list_accAsync() {
            return base.Channel.list_accAsync();
        }
        
        public void add_acc(Web.AccountService.Account cate) {
            base.Channel.add_acc(cate);
        }
        
        public System.Threading.Tasks.Task add_accAsync(Web.AccountService.Account cate) {
            return base.Channel.add_accAsync(cate);
        }
        
        public void edit_cate(Web.AccountService.Account cate) {
            base.Channel.edit_cate(cate);
        }
        
        public System.Threading.Tasks.Task edit_cateAsync(Web.AccountService.Account cate) {
            return base.Channel.edit_cateAsync(cate);
        }
        
        public void delete_acc(int id) {
            base.Channel.delete_acc(id);
        }
        
        public System.Threading.Tasks.Task delete_accAsync(int id) {
            return base.Channel.delete_accAsync(id);
        }
        
        public Web.AccountService.Account Find_acc(System.Nullable<int> id) {
            return base.Channel.Find_acc(id);
        }
        
        public System.Threading.Tasks.Task<Web.AccountService.Account> Find_accAsync(System.Nullable<int> id) {
            return base.Channel.Find_accAsync(id);
        }
    }
}