﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.ProductService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDTO", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.DTO")]
    [System.SerializableAttribute()]
    public partial class ProductDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amuontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameCategoryField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amuontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ProductService.billDetail[] billDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ProductService.category categoryField;
        
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
        public Web.ProductService.billDetail[] billDetails {
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
        public Web.ProductService.category category {
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
        private Web.ProductService.Product[] ProductsField;
        
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
        public Web.ProductService.Product[] Products {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="billDetail", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class billDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ProductService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ProductService.bill billField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> totalField;
        
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
        public Web.ProductService.Product Product {
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
        public Web.ProductService.bill bill {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> total {
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
        private Web.ProductService.billDetail[] billDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idBillField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> total_billField;
        
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
        public Web.ProductService.billDetail[] billDetails {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> total_bill {
            get {
                return this.total_billField;
            }
            set {
                if ((this.total_billField.Equals(value) != true)) {
                    this.total_billField = value;
                    this.RaisePropertyChanged("total_bill");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.IProduct_Admin")]
    public interface IProduct_Admin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/list_Pro", ReplyAction="http://tempuri.org/IProduct_Admin/list_ProResponse")]
        Web.ProductService.ProductDTO[] list_Pro();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/list_Pro", ReplyAction="http://tempuri.org/IProduct_Admin/list_ProResponse")]
        System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> list_ProAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/add_pro", ReplyAction="http://tempuri.org/IProduct_Admin/add_proResponse")]
        void add_pro(Web.ProductService.Product pro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/add_pro", ReplyAction="http://tempuri.org/IProduct_Admin/add_proResponse")]
        System.Threading.Tasks.Task add_proAsync(Web.ProductService.Product pro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/update_pro", ReplyAction="http://tempuri.org/IProduct_Admin/update_proResponse")]
        void update_pro(Web.ProductService.Product pro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/update_pro", ReplyAction="http://tempuri.org/IProduct_Admin/update_proResponse")]
        System.Threading.Tasks.Task update_proAsync(Web.ProductService.Product pro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/delete_pro", ReplyAction="http://tempuri.org/IProduct_Admin/delete_proResponse")]
        void delete_pro(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/delete_pro", ReplyAction="http://tempuri.org/IProduct_Admin/delete_proResponse")]
        System.Threading.Tasks.Task delete_proAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/search_pro", ReplyAction="http://tempuri.org/IProduct_Admin/search_proResponse")]
        Web.ProductService.ProductDTO[] search_pro(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/search_pro", ReplyAction="http://tempuri.org/IProduct_Admin/search_proResponse")]
        System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> search_proAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/findById", ReplyAction="http://tempuri.org/IProduct_Admin/findByIdResponse")]
        Web.ProductService.Product findById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/findById", ReplyAction="http://tempuri.org/IProduct_Admin/findByIdResponse")]
        System.Threading.Tasks.Task<Web.ProductService.Product> findByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/List_cate", ReplyAction="http://tempuri.org/IProduct_Admin/List_cateResponse")]
        Web.ProductService.ProductDTO[] List_cate(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct_Admin/List_cate", ReplyAction="http://tempuri.org/IProduct_Admin/List_cateResponse")]
        System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> List_cateAsync(System.Nullable<int> id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProduct_AdminChannel : Web.ProductService.IProduct_Admin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Product_AdminClient : System.ServiceModel.ClientBase<Web.ProductService.IProduct_Admin>, Web.ProductService.IProduct_Admin {
        
        public Product_AdminClient() {
        }
        
        public Product_AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Product_AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Product_AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Product_AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Web.ProductService.ProductDTO[] list_Pro() {
            return base.Channel.list_Pro();
        }
        
        public System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> list_ProAsync() {
            return base.Channel.list_ProAsync();
        }
        
        public void add_pro(Web.ProductService.Product pro) {
            base.Channel.add_pro(pro);
        }
        
        public System.Threading.Tasks.Task add_proAsync(Web.ProductService.Product pro) {
            return base.Channel.add_proAsync(pro);
        }
        
        public void update_pro(Web.ProductService.Product pro) {
            base.Channel.update_pro(pro);
        }
        
        public System.Threading.Tasks.Task update_proAsync(Web.ProductService.Product pro) {
            return base.Channel.update_proAsync(pro);
        }
        
        public void delete_pro(int id) {
            base.Channel.delete_pro(id);
        }
        
        public System.Threading.Tasks.Task delete_proAsync(int id) {
            return base.Channel.delete_proAsync(id);
        }
        
        public Web.ProductService.ProductDTO[] search_pro(string name) {
            return base.Channel.search_pro(name);
        }
        
        public System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> search_proAsync(string name) {
            return base.Channel.search_proAsync(name);
        }
        
        public Web.ProductService.Product findById(int id) {
            return base.Channel.findById(id);
        }
        
        public System.Threading.Tasks.Task<Web.ProductService.Product> findByIdAsync(int id) {
            return base.Channel.findByIdAsync(id);
        }
        
        public Web.ProductService.ProductDTO[] List_cate(System.Nullable<int> id) {
            return base.Channel.List_cate(id);
        }
        
        public System.Threading.Tasks.Task<Web.ProductService.ProductDTO[]> List_cateAsync(System.Nullable<int> id) {
            return base.Channel.List_cateAsync(id);
        }
    }
}