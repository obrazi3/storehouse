using System.Collections.Generic;

namespace Model
{
    public class ProviderOrderRepository : IProviderOrderRepository
    {
        private List<ProductProviderOrder> _orders;


        public ProviderOrderRepository()
        {
            _orders = new List<ProductProviderOrder>();
        }

        public void AddProductProviderOrder(ProductProviderOrder order)
        {
            _orders.Add(order);
            _orders.Sort(new ComparerProductProviderOrderForRepository());
        }

        public bool ContainsOrder(int orderId)
        {
            foreach (var order in _orders)
            {
                if (order.OrderId == orderId)
                    return true;
            }

            return false;
        }

        public List<ProductProviderOrder> GetListAllOrders()
        {
            List<ProductProviderOrder> clone = new List<ProductProviderOrder>();
            foreach (var order in _orders)
            {
                clone.Add((ProductProviderOrder)order.Clone());
            }

            return clone;
        }

        public List<ProductProviderOrder> GetOrderSelectionByStatus(StatusProviderOrder status)
        {
            List<ProductProviderOrder> cloneByStatus = new List<ProductProviderOrder>();

            foreach (var order in _orders)
            {
                if (order.Status == status)
                    cloneByStatus.Add((ProductProviderOrder)order.Clone());
            }

            cloneByStatus.Sort(new ComparerProductProviderForSelectionByStatus());

            return cloneByStatus;
        }

        public ProductProviderOrder GetProductProviderOrder(int orderId)
        {
            foreach (var order in _orders)
            {
                if (order.OrderId == orderId)
                    return (ProductProviderOrder)order.Clone();
            }

            return null;
        }

        public void RemoveProductProviderOrder(int orderId)
        {

            foreach (var order in _orders)
            {
                if (order.OrderId == orderId)
                {
                    _orders.Remove(order);
                    break;
                }
            }
        }
    }
}
