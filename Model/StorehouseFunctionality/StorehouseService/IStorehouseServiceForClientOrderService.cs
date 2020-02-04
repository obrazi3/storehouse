
using System.Collections.Generic;

namespace Model
{
    public interface IStorehouseServiceForClientOrderService 
    {
        void AddProduct(ProductFromLot prod);
        ProductFromLot GetProduct(int idProduct, int numberOfProduct);
        SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProdCatalog();
    }
}
