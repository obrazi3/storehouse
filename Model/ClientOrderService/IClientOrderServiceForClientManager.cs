using System.Collections.Generic;

namespace Model
{
    public interface IClientOrderServiceForClientManager
    {
        bool AddNotPaidOrder(ClientOrder order);
        ClientOrder GetNotPaidOrder(int orderId);
        bool EditNotPaidOrder(ClientOrder order);
        bool RemoveNotPaidOrder(int orderId);
        ProductFromLot GetProductFromLot(int productId, int numberOfProd);
        SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProductCatalog();
    }
}
