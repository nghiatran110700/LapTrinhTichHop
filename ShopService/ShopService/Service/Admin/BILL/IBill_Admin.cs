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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBill_Admin" in both code and config file together.
    [ServiceContract]
    public interface IBill_Admin
    {
        [OperationContract]
        IEnumerable<billDTO> list_bill();

        [OperationContract]
        void add_bill(bill bills);

        [OperationContract]
        void add_billDetail(billDetail detail);

        [OperationContract]
        IEnumerable<DetailBillDTO> DetailBill(int id);

        [OperationContract]
        int top();

        [OperationContract]
        void deleteBill(int id);

        [OperationContract]
        List<billDetail> test(int id);
    }
}
