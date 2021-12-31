using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService.Service.Customer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProduct_Customer" in both code and config file together.
    [ServiceContract]
    public interface IProduct_Customer
    {
        [OperationContract]
        void DoWork();
    }
}
