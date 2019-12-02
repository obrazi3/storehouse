using System.Collections.Generic;

namespace Model
{
    public class ClientOrderService : IClientOrderServiceForBooker, IClientOrderServiceForCourier,
        IClientOrderServiceForStorekeeper, IClientOrderServiceForClientManager
    {
        private static int nextIdOrder;
        private IStorehouseServiceForClientOrderService storehouseService;
        private IClientOrderRepository repository;


        public ClientOrderService(IStorehouseServiceForClientOrderService _storehouseService,
            IClientOrderRepository _repository)
        {
            storehouseService = _storehouseService;
            repository = _repository;
            nextIdOrder = 0;
        }

        public List<ClientOrder> GetListNotPaidClientOrders()
        {
            List<ClientOrder> orders = repository.GetListOrdersByStatus(StatusClientOrder.NotPaid);
            return orders;
        }

        public bool ConfirmPaymentNotPaidClientOrder(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                repository.RemoveClientOrder(orderId);
                if (order.isDelivery)
                    order.Status = StatusClientOrder.PaidForDelivery;
                else
                    order.Status = StatusClientOrder.Paid;
                repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public ClientOrder GetForDeliveryClientOrder()
        {
            var order = repository.GetOrderByStatus(StatusClientOrder.PaidForDelivery);
            if (order != null)
            {
                repository.RemoveClientOrder(order.OrderId);
                var ord = (ClientOrder)order.Clone();
                ord.Status = StatusClientOrder.OnDelivery;
                repository.AddClientOrder(ord);
                return order;
            }

            return null;
        }

        public bool ConfirmDelivery(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.OnDelivery)
            {
                repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.GiveOut;
                repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool CancelDelivery(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.OnDelivery)
            {
                repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.Paid;
                repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public ClientOrder GetGiveOutClientOrder(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.Paid)
            {
                return order;
            }

            return null;
        }

        public bool ConfirmGiveOutClientOrder(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.Paid)
            {
                repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.GiveOut;
                repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool AddNotPaidOrder(ClientOrder order)
        {
            order.Status = StatusClientOrder.NotPaid;
            order.OrderId = GetOrderId();
            repository.AddClientOrder(order);
            return true;
        }

        public ClientOrder GetNotPaidOrder(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                return order;
            }

            return null;
        }

        public bool EditNotPaidOrder(ClientOrder order)
        {
            var ord = repository.GetClientOrder(order.OrderId);
            if (ord != null && ord.Status == StatusClientOrder.NotPaid)
            {
                repository.RemoveClientOrder(ord.OrderId);
                repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool RemoveNotPaidOrder(int orderId)
        {
            var order = repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                repository.RemoveClientOrder(orderId);
                return true;
            }

            return false;
        }

        public ProductFromLot GetProductFromLot(int productId, int numberOfProd)
        {
            return storehouseService.GetProduct(productId, numberOfProd);
        }

        public SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProductCatalog()
        {
            return storehouseService.GetProdCatalog();
        }

        private static int GetOrderId()
        {
            nextIdOrder++;
            return nextIdOrder;
        }
    }
}
