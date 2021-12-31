using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Model.Entity;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategory_Admin" in both code and config file together.
    [ServiceContract]
    public interface ICategory_Admin
    {
        [OperationContract]
        List<category> list_cate();

        [OperationContract]
        void add_cate(category cate);

        [OperationContract]
        void edit_cate(category cate);

        [OperationContract]
        void delete_cate(int id);

        [OperationContract]
        category Find_cate(int id);
    }
}
