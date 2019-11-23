

using System.Collections.Generic;

namespace Model
{
    public interface IStorehouseRepository
    {
        void AddProductFromLot(ProductFromLot prod);
        void AddStoreHouseProduct(StorehouseProduct prod);
        ProductFromLot GetProduct(int idProduct, int numberOfProduct);
        SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProductCatalog();
        bool ContainsProduct(ProductFromLot prod);
    }
}
