using System.Collections.Generic;

namespace Model
{
    public interface IClientOrderRepository
    {
        void AddClientOrder(ClientOrder order);
        ClientOrder GetClientOrder(int orderId);
        void RemoveClientOrder(int orderId);
        List<ClientOrder> GetListOrdersByStatus(StatusClientOrder status);
        List<ClientOrder> GetListAllOrders();
    }
}
