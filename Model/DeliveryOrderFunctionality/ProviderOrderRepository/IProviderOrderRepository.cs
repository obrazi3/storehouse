using System.Collections.Generic;

namespace Model
{
    public interface IProviderOrderRepository
    {
        void AddProductProviderOrder(ProductProviderOrder order);
        ProductProviderOrder GetProductProviderOrder(int orderId);
        void RemoveProductProviderOrder(int orderId);
        List<ProductProviderOrder> GetOrderSelectionByStatus(StatusProviderOrder status);
        List<ProductProviderOrder> GetListAllOrders();

        bool ContainsOrder(int orderId);
    }
}
