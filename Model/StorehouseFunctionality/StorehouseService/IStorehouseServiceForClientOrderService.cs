
using System.Collections.Generic;

namespace Model
{
    public interface IStorehouseServiceForClientOrderService : IStorehouseServiceForDeliveryOrderService
    {
        ProductFromLot GetProduct(int idProduct, int numberOfProduct);
        SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProdCatalog();
    }
}
