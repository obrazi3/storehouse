
using System.Collections.Generic;

namespace Model
{
    public interface IDeliveryOrderServiceForPurcpManager
    {
        void AddProductProvider(ProductProvider prov);
        ProductProvider GetProductProvider(int providerId);
        void EditProductProvider(ProductProvider provider);
        void RemoveProductProvider(int providerId);
        List<ProductProvider> GetListProductProviders();

        void AddNotPaidOrder(ProductProviderOrder order);
        ProductProviderOrder GetNotPaidOrder(int orderId);
        void EditNotPaidOrder(ProductProviderOrder order);
        void RemoveNotPaidOrder(int orderId);
        List<ProductProviderOrder> GetListNotPaidOrders();
        List<StorehouseProduct> GetListDificitProducts(int number);
    }
}
