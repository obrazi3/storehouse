using System.Collections.Generic;

namespace Model
{
    public interface IClientOrderServiceForBooker
    {
        List<ClientOrder> GetListNotPaidClientOrders();
        bool ConfirmPaymentNotPaidClientOrder(int orderId);
        ClientOrder GetNotPaidClientOrder(int orderId);
    }
}
