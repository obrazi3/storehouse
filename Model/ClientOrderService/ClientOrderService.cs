using System.Collections.Generic;

namespace Model
{
    public class ClientOrderService : IClientOrderServiceForBooker, IClientOrderServiceForCourier,
        IClientOrderServiceForStorekeeper, IClientOrderServiceForClientManager
    {
        private static int _nextIdOrder;
        private IStorehouseServiceForClientOrderService _storehouseService;
        private IClientOrderRepository _repository;


        public ClientOrderService(IStorehouseServiceForClientOrderService storehouseService,
            IClientOrderRepository repository)
        {
            this._storehouseService = storehouseService;
            this._repository = repository;
            _nextIdOrder = 0;
        }

        public List<ClientOrder> GetListNotPaidClientOrders()
        {
            List<ClientOrder> orders = _repository.GetListOrdersByStatus(StatusClientOrder.NotPaid);
            return orders;
        }

        public bool ConfirmPaymentNotPaidClientOrder(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                _repository.RemoveClientOrder(orderId);
                if (order.IsDelivery)
                    order.Status = StatusClientOrder.PaidForDelivery;
                else
                    order.Status = StatusClientOrder.Paid;
                _repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public ClientOrder GetNotPaidClientOrder(int order)
        {
            return GetNotPaidOrder(order);
        }

        public ClientOrder GetForDeliveryClientOrder()
        {
            var order = _repository.GetOrderByStatus(StatusClientOrder.PaidForDelivery);
            if (order != null)
            {
                _repository.RemoveClientOrder(order.OrderId);
                var ord = (ClientOrder)order.Clone();
                ord.Status = StatusClientOrder.OnDelivery;
                _repository.AddClientOrder(ord);
                return order;
            }

            return null;
        }

        public bool ConfirmDelivery(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.OnDelivery)
            {
                _repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.GiveOut;
                _repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool CancelDelivery(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.OnDelivery)
            {
                _repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.PaidForDelivery;
                _repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public ClientOrder GetGiveOutClientOrder(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.Paid )
            {
                return order;
            }

            return null;
        }

        public bool ConfirmGiveOutClientOrder(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.Paid )
            {
                _repository.RemoveClientOrder(order.OrderId);
                order.Status = StatusClientOrder.GiveOut;
                _repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool AddNotPaidOrder(ClientOrder order)
        {
            order.Status = StatusClientOrder.NotPaid;
            if (order.OrderId == -1)
                order.OrderId = GetOrderId();
            _repository.AddClientOrder(order);
            return true;
        }

        public ClientOrder GetNotPaidOrder(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                return order;
            }

            return null;
        }

        public bool EditNotPaidOrder(ClientOrder order)
        {
            var ord = _repository.GetClientOrder(order.OrderId);
            if (ord != null && ord.Status == StatusClientOrder.NotPaid)
            {
                _repository.RemoveClientOrder(ord.OrderId);
                _repository.AddClientOrder(order);
                return true;
            }

            return false;
        }

        public bool RemoveNotPaidOrder(int orderId)
        {
            var order = _repository.GetClientOrder(orderId);
            if (order != null && order.Status == StatusClientOrder.NotPaid)
            {
                _repository.RemoveClientOrder(orderId);
                return true;
            }

            return false;
        }

        public ProductFromLot GetProductFromLot(int productId, int numberOfProd)
        {
            return _storehouseService.GetProduct(productId, numberOfProd);
        }

        public SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProductCatalog()
        {
            return _storehouseService.GetProdCatalog();
        }

        private static int GetOrderId()
        {
            _nextIdOrder++;
            return _nextIdOrder;
        }
    }
}
