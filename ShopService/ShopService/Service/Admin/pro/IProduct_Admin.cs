using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShopService.Model.DTO;
using ShopService.Model.Entity;

namespace ShopService.Service.Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProduct_Admin" in both code and config file together.
    [ServiceContract]
    public interface IProduct_Admin
    {
        [OperationContract]
        List<ProductDTO> list_Pro();

        [OperationContract]
        void add_pro(Product pro);

        [OperationContract]
        void update_pro(Product pro);

        [OperationContract]
        void delete_pro(int id);

        [OperationContract]
        List<ProductDTO> search_pro(string name);

        [OperationContract]
        Product findById(int id);

        [OperationContract]
        List<ProductDTO> List_cate(int? id);
    }
}
