using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDeliverOrderServiceForPurcpManager
    {
        void AddProductProvider(ProductProvider prov);
        ProductProvider GetProductProvider(int providerId);
        void EditProductProvider(ProductProvider provider);
        void RemoveProductProvider(int providerId);
        List<ProductProvider> GetListProductProviders();

        void AddNotPaidOrder(ProductProviderOrder order);
        ProductProviderOrder GetNotPaidOrder(int orderId);
        void EditNotPaidOrder(ProductProviderOrder order);
        List<ProductProviderOrder> GetListNotPaidOrders();
        List<StorehouseProduct> GetListDificitProducts(int number);
    }
}
