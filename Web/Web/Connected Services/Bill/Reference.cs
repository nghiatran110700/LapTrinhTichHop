﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Bill {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="billDTO", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.DTO")]
    [System.SerializableAttribute()]
    public partial class billDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int totalField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idBill {
            get {
                return this.idBillField;
            }
            set {
                if ((this.idBillField.Equals(value) != true)) {
                    this.idBillField = value;
                    this.RaisePropertyChanged("idBill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="bill", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class bill : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.billDetail[] billDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.Bill.billDetail[] billDetails {
            get {
                return this.billDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.billDetailsField, value) != true)) {
                    this.billDetailsField = value;
                    this.RaisePropertyChanged("billDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idBill {
            get {
                return this.idBillField;
            }
            set {
                if ((this.idBillField.Equals(value) != true)) {
                    this.idBillField = value;
                    this.RaisePropertyChanged("idBill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="billDetail", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class billDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.bill billField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductField;
        
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
        public Web.Bill.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.Bill.bill bill {
            get {
                return this.billField;
            }
            set {
                if ((object.ReferenceEquals(this.billField, value) != true)) {
                    this.billField = value;
                    this.RaisePropertyChanged("bill");
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
        public int idBill {
            get {
                return this.idBillField;
            }
            set {
                if ((this.idBillField.Equals(value) != true)) {
                    this.idBillField = value;
                    this.RaisePropertyChanged("idBill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduct {
            get {
                return this.idProductField;
            }
            set {
                if ((this.idProductField.Equals(value) != true)) {
                    this.idProductField = value;
                    this.RaisePropertyChanged("idProduct");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amuontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.billDetail[] billDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.category categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> idCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string photoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
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
        public int amuont {
            get {
                return this.amuontField;
            }
            set {
                if ((this.amuontField.Equals(value) != true)) {
                    this.amuontField = value;
                    this.RaisePropertyChanged("amuont");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.Bill.billDetail[] billDetails {
            get {
                return this.billDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.billDetailsField, value) != true)) {
                    this.billDetailsField = value;
                    this.RaisePropertyChanged("billDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Web.Bill.category category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> idCategory {
            get {
                return this.idCategoryField;
            }
            set {
                if ((this.idCategoryField.Equals(value) != true)) {
                    this.idCategoryField = value;
                    this.RaisePropertyChanged("idCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduct {
            get {
                return this.idProductField;
            }
            set {
                if ((this.idProductField.Equals(value) != true)) {
                    this.idProductField = value;
                    this.RaisePropertyChanged("idProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameProduct {
            get {
                return this.nameProductField;
            }
            set {
                if ((object.ReferenceEquals(this.nameProductField, value) != true)) {
                    this.nameProductField = value;
                    this.RaisePropertyChanged("nameProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string photo {
            get {
                return this.photoField;
            }
            set {
                if ((object.ReferenceEquals(this.photoField, value) != true)) {
                    this.photoField = value;
                    this.RaisePropertyChanged("photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="category", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.Bill.Product[] ProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameCategoryField;
        
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
        public Web.Bill.Product[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idCategory {
            get {
                return this.idCategoryField;
            }
            set {
                if ((this.idCategoryField.Equals(value) != true)) {
                    this.idCategoryField = value;
                    this.RaisePropertyChanged("idCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameCategory {
            get {
                return this.nameCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.nameCategoryField, value) != true)) {
                    this.nameCategoryField = value;
                    this.RaisePropertyChanged("nameCategory");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailBillDTO", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.DTO")]
    [System.SerializableAttribute()]
    public partial class DetailBillDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int totalField;
        
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
        public System.Nullable<int> amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idBill {
            get {
                return this.idBillField;
            }
            set {
                if ((this.idBillField.Equals(value) != true)) {
                    this.idBillField = value;
                    this.RaisePropertyChanged("idBill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduct {
            get {
                return this.idProductField;
            }
            set {
                if ((this.idProductField.Equals(value) != true)) {
                    this.idProductField = value;
                    this.RaisePropertyChanged("idProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameProduct {
            get {
                return this.nameProductField;
            }
            set {
                if ((object.ReferenceEquals(this.nameProductField, value) != true)) {
                    this.nameProductField = value;
                    this.RaisePropertyChanged("nameProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Bill.IBill_Admin")]
    public interface IBill_Admin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/list_bill", ReplyAction="http://tempuri.org/IBill_Admin/list_billResponse")]
        Web.Bill.billDTO[] list_bill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/list_bill", ReplyAction="http://tempuri.org/IBill_Admin/list_billResponse")]
        System.Threading.Tasks.Task<Web.Bill.billDTO[]> list_billAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/add_bill", ReplyAction="http://tempuri.org/IBill_Admin/add_billResponse")]
        void add_bill(Web.Bill.bill bills);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/add_bill", ReplyAction="http://tempuri.org/IBill_Admin/add_billResponse")]
        System.Threading.Tasks.Task add_billAsync(Web.Bill.bill bills);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/add_billDetail", ReplyAction="http://tempuri.org/IBill_Admin/add_billDetailResponse")]
        void add_billDetail(Web.Bill.billDetail detail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/add_billDetail", ReplyAction="http://tempuri.org/IBill_Admin/add_billDetailResponse")]
        System.Threading.Tasks.Task add_billDetailAsync(Web.Bill.billDetail detail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/DetailBill", ReplyAction="http://tempuri.org/IBill_Admin/DetailBillResponse")]
        Web.Bill.DetailBillDTO[] DetailBill(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/DetailBill", ReplyAction="http://tempuri.org/IBill_Admin/DetailBillResponse")]
        System.Threading.Tasks.Task<Web.Bill.DetailBillDTO[]> DetailBillAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/top", ReplyAction="http://tempuri.org/IBill_Admin/topResponse")]
        int top();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/top", ReplyAction="http://tempuri.org/IBill_Admin/topResponse")]
        System.Threading.Tasks.Task<int> topAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/deleteBill", ReplyAction="http://tempuri.org/IBill_Admin/deleteBillResponse")]
        void deleteBill(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/deleteBill", ReplyAction="http://tempuri.org/IBill_Admin/deleteBillResponse")]
        System.Threading.Tasks.Task deleteBillAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/test", ReplyAction="http://tempuri.org/IBill_Admin/testResponse")]
        Web.Bill.billDetail[] test(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBill_Admin/test", ReplyAction="http://tempuri.org/IBill_Admin/testResponse")]
        System.Threading.Tasks.Task<Web.Bill.billDetail[]> testAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBill_AdminChannel : Web.Bill.IBill_Admin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Bill_AdminClient : System.ServiceModel.ClientBase<Web.Bill.IBill_Admin>, Web.Bill.IBill_Admin {
        
        public Bill_AdminClient() {
        }
        
        public Bill_AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Bill_AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bill_AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Bill_AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Web.Bill.billDTO[] list_bill() {
            return base.Channel.list_bill();
        }
        
        public System.Threading.Tasks.Task<Web.Bill.billDTO[]> list_billAsync() {
            return base.Channel.list_billAsync();
        }
        
        public void add_bill(Web.Bill.bill bills) {
            base.Channel.add_bill(bills);
        }
        
        public System.Threading.Tasks.Task add_billAsync(Web.Bill.bill bills) {
            return base.Channel.add_billAsync(bills);
        }
        
        public void add_billDetail(Web.Bill.billDetail detail) {
            base.Channel.add_billDetail(detail);
        }
        
        public System.Threading.Tasks.Task add_billDetailAsync(Web.Bill.billDetail detail) {
            return base.Channel.add_billDetailAsync(detail);
        }
        
        public Web.Bill.DetailBillDTO[] DetailBill(int id) {
            return base.Channel.DetailBill(id);
        }
        
        public System.Threading.Tasks.Task<Web.Bill.DetailBillDTO[]> DetailBillAsync(int id) {
            return base.Channel.DetailBillAsync(id);
        }
        
        public int top() {
            return base.Channel.top();
        }
        
        public System.Threading.Tasks.Task<int> topAsync() {
            return base.Channel.topAsync();
        }
        
        public void deleteBill(int id) {
            base.Channel.deleteBill(id);
        }
        
        public System.Threading.Tasks.Task deleteBillAsync(int id) {
            return base.Channel.deleteBillAsync(id);
        }
        
        public Web.Bill.billDetail[] test(int id) {
            return base.Channel.test(id);
        }
        
        public System.Threading.Tasks.Task<Web.Bill.billDetail[]> testAsync(int id) {
            return base.Channel.testAsync(id);
        }
    }
}