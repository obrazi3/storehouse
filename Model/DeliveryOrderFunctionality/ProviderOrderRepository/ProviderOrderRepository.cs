using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProviderOrderRepository : IProviderOrderRepository
    {
        private List<ProductProviderOrder> orders;


        public ProviderOrderRepository()
        {
            orders = new List<ProductProviderOrder>();
        }

        public void AddProductProviderOrder(ProductProviderOrder order)
        {
            orders.Add(order);
            orders.Sort(new ComparerProductProviderOrderForRepository());
        }

        public bool ContainsOrder(int orderId)
        {
            foreach (var order in orders)
            {
                if (order.OrderId == orderId)
                    return true;
            }

            return false;
        }

        public List<ProductProviderOrder> GetListAllOrders()
        {
            List<ProductProviderOrder> clone = new List<ProductProviderOrder>();
            foreach (var order in orders)
            {
                clone.Add((ProductProviderOrder)order.Clone());
            }

            return clone;
        }

        public List<ProductProviderOrder> GetOrderSelectionByStatus(StatusProviderOrder status)
        {
            List<ProductProviderOrder> cloneByStatus = new List<ProductProviderOrder>();

            foreach (var order in orders)
            {
                if (order.Status == status)
                    cloneByStatus.Add((ProductProviderOrder)order.Clone());
            }

            cloneByStatus.Sort(new ComparerProductProviderForSelectionByStatus());

            return cloneByStatus;
        }

        public ProductProviderOrder GetProductProviderOrder(int orderId)
        {
            foreach (var order in orders)
            {
                if (order.OrderId == orderId)
                    return (ProductProviderOrder)order.Clone();
            }

            return null;
        }

        public void RemoveProductProviderOrder(int orderId)
        {

            foreach (var order in orders)
            {
                if (order.OrderId == orderId)
                {
                    orders.Remove(order);
                    break;
                }
            }
        }
    }
}
