//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.CategoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="category", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.CategoryService.Product[] ProductsField;
        
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
        public Web.CategoryService.Product[] Products {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amuontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.CategoryService.billDetail[] billDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.CategoryService.category categoryField;
        
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
        public Web.CategoryService.billDetail[] billDetails {
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
        public Web.CategoryService.category category {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="billDetail", Namespace="http://schemas.datacontract.org/2004/07/ShopService.Model.Entity")]
    [System.SerializableAttribute()]
    public partial class billDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.CategoryService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.CategoryService.bill billField;
        
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
        public Web.CategoryService.Product Product {
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
        public Web.CategoryService.bill bill {
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
        private Web.CategoryService.billDetail[] billDetailsField;
        
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
        public Web.CategoryService.billDetail[] billDetails {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryService.ICategory_Admin")]
    public interface ICategory_Admin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/list_cate", ReplyAction="http://tempuri.org/ICategory_Admin/list_cateResponse")]
        Web.CategoryService.category[] list_cate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/list_cate", ReplyAction="http://tempuri.org/ICategory_Admin/list_cateResponse")]
        System.Threading.Tasks.Task<Web.CategoryService.category[]> list_cateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/add_cate", ReplyAction="http://tempuri.org/ICategory_Admin/add_cateResponse")]
        void add_cate(Web.CategoryService.category cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/add_cate", ReplyAction="http://tempuri.org/ICategory_Admin/add_cateResponse")]
        System.Threading.Tasks.Task add_cateAsync(Web.CategoryService.category cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/edit_cate", ReplyAction="http://tempuri.org/ICategory_Admin/edit_cateResponse")]
        void edit_cate(Web.CategoryService.category cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/edit_cate", ReplyAction="http://tempuri.org/ICategory_Admin/edit_cateResponse")]
        System.Threading.Tasks.Task edit_cateAsync(Web.CategoryService.category cate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/delete_cate", ReplyAction="http://tempuri.org/ICategory_Admin/delete_cateResponse")]
        void delete_cate(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/delete_cate", ReplyAction="http://tempuri.org/ICategory_Admin/delete_cateResponse")]
        System.Threading.Tasks.Task delete_cateAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/Find_cate", ReplyAction="http://tempuri.org/ICategory_Admin/Find_cateResponse")]
        Web.CategoryService.category Find_cate(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory_Admin/Find_cate", ReplyAction="http://tempuri.org/ICategory_Admin/Find_cateResponse")]
        System.Threading.Tasks.Task<Web.CategoryService.category> Find_cateAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategory_AdminChannel : Web.CategoryService.ICategory_Admin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Category_AdminClient : System.ServiceModel.ClientBase<Web.CategoryService.ICategory_Admin>, Web.CategoryService.ICategory_Admin {
        
        public Category_AdminClient() {
        }
        
        public Category_AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Category_AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Category_AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Category_AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Web.CategoryService.category[] list_cate() {
            return base.Channel.list_cate();
        }
        
        public System.Threading.Tasks.Task<Web.CategoryService.category[]> list_cateAsync() {
            return base.Channel.list_cateAsync();
        }
        
        public void add_cate(Web.CategoryService.category cate) {
            base.Channel.add_cate(cate);
        }
        
        public System.Threading.Tasks.Task add_cateAsync(Web.CategoryService.category cate) {
            return base.Channel.add_cateAsync(cate);
        }
        
        public void edit_cate(Web.CategoryService.category cate) {
            base.Channel.edit_cate(cate);
        }
        
        public System.Threading.Tasks.Task edit_cateAsync(Web.CategoryService.category cate) {
            return base.Channel.edit_cateAsync(cate);
        }
        
        public void delete_cate(int id) {
            base.Channel.delete_cate(id);
        }
        
        public System.Threading.Tasks.Task delete_cateAsync(int id) {
            return base.Channel.delete_cateAsync(id);
        }
        
        public Web.CategoryService.category Find_cate(int id) {
            return base.Channel.Find_cate(id);
        }
        
        public System.Threading.Tasks.Task<Web.CategoryService.category> Find_cateAsync(int id) {
            return base.Channel.Find_cateAsync(id);
        }
    }
}
