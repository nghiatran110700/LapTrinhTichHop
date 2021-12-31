using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Model.Entity;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAccount_Admin" in both code and config file together.
    [ServiceContract]
    public interface IAccount_Admin
    {
        [OperationContract]
        List<Account> list_acc();

        [OperationContract]
        void add_acc(Account cate);

        [OperationContract]
        void edit_cate(Account cate);

        [OperationContract]
        void delete_acc(int id);

        [OperationContract]
        Account Find_acc(int? id);
    }
}
