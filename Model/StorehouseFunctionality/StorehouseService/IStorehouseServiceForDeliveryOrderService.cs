
using System.Collections.Generic;

namespace Model
{
    public interface IStorehouseServiceForDeliveryOrderService
    {
        void AddProduct(ProductFromLot prod);
        void AddProductFromDelivery(ProductFromLot prod);
        List<StorehouseProduct> GetListDificitProducts(int number);
    }
}
