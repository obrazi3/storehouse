using System.Collections.Generic;

namespace Model
{
    public interface IDeliveryOrderServiceForBooker
    {
        List<ProductProviderOrder> GetListNotPaidProviderOrders();
        void ConfirmPaymentProviderOrder(int orderId);
        bool PayDeliveryFromProvider(int bankIdProvider, int sum);
    }
}
