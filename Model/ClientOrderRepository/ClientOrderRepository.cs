using System.Collections.Generic;

namespace Model
{
    public class ClientOrderRepository : IClientOrderRepository
    {
        private List<ClientOrder> orders;

        public ClientOrderRepository()
        {
            orders = new List<ClientOrder>();
        }

        public void AddClientOrder(ClientOrder order)
        {
            orders.Add(order);
        }

        public ClientOrder GetClientOrder(int orderId)
        {
            foreach (var order in orders)
            {
                if (order.OrderId == orderId)
                    return (ClientOrder)order.Clone();
            }

            return null;
        }

        public void RemoveClientOrder(int orderId)
        {
            foreach (var order in orders)
            {
                if (order.OrderId == orderId)
                    orders.Remove(order);
                return;
            }
        }

        public List<ClientOrder> GetListOrdersByStatus(StatusClientOrder status)
        {
            List<ClientOrder> ordrs = new List<ClientOrder>();

            foreach (var order in orders)
            {
                if (order.Status == status)
                    ordrs.Add((ClientOrder)order.Clone());
            }

            return ordrs;
        }

        public List<ClientOrder> GetListAllOrders()
        {
            List<ClientOrder> ordrs = new List<ClientOrder>();

            foreach (var order in orders)
            {
                ordrs.Add((ClientOrder)order.Clone());
            }

            return ordrs;
        }
    }
}
