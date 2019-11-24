using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryOrderService : IDeliveryOrderServiceForPurcpManager, IDeliveryOrderServiceForBooker,
        IDeliveryOrderServiceForStorekeeper
    {
        private static int nextIdOrder;
        private static int nextIdProvider;
        private IProductProviderRepository providersRepository;
        private IProviderOrderRepository ordersRepository;
        private IStorehouseServiceForDeliveryOrderService storehouseService;


        public DeliveryOrderService(IProductProviderRepository _providersRepository,
            IProviderOrderRepository _ordersRepository, IStorehouseServiceForDeliveryOrderService _storehouseService)
        {
            providersRepository = _providersRepository;
            ordersRepository = _ordersRepository;
            storehouseService = _storehouseService;
            nextIdOrder = 1;
            nextIdProvider = 1;
        }


        public void AddProductProvider(ProductProvider prov)
        {
            prov.ProviderId = GetProviderId();
            providersRepository.AddProductProvider(prov);
        }

        public ProductProvider GetProductProvider(int providerId)
        {
            return providersRepository.GetProductProvider(providerId);
        }

        public void EditProductProvider(ProductProvider provider)
        {
            providersRepository.RemoveProductProvider(provider.ProviderId);
            providersRepository.AddProductProvider(provider);
        }

        public void RemoveProductProvider(int providerId)
        {
            providersRepository.RemoveProductProvider(providerId);
        }

        public List<ProductProvider> GetListProductProviders()
        {
            return providersRepository.GetListProductProviders();
        }

        public void AddNotPaidOrder(ProductProviderOrder order)
        {
            order.OrderId = GetOrderId();
            order.Status = StatusProviderOrder.NotPaid;
            ordersRepository.AddProductProviderOrder(order);
        }

        public ProductProviderOrder GetNotPaidOrder(int orderId)
        {
            var order = ordersRepository.GetProductProviderOrder(orderId);
            if (order.Status == StatusProviderOrder.NotPaid)
                return order;
            else
                return null;
        }

        public void EditNotPaidOrder(ProductProviderOrder order)
        {
            ordersRepository.RemoveProductProviderOrder(order.OrderId);
            ordersRepository.AddProductProviderOrder(order);
        }

        public void RemoveNotPaidOrder(int orderId)
        {
            ordersRepository.RemoveProductProviderOrder(orderId);
        }

        public List<ProductProviderOrder> GetListNotPaidOrders()
        {
            return ordersRepository.GetOrderSelectionByStatus(StatusProviderOrder.NotPaid);
        }

        public List<StorehouseProduct> GetListDificitProducts(int number)
        {
            return storehouseService.GetListDificitProducts(number);
        }

        public List<ProductProviderOrder> GetListNotPaidProviderOrders()
        {
            return ordersRepository.GetOrderSelectionByStatus(StatusProviderOrder.NotPaid);
        }

        public void ConfirmPaymentProviderOrder(int orderId)
        {
            var order = ordersRepository.GetProductProviderOrder(orderId);
            ordersRepository.RemoveProductProviderOrder(orderId);
            order.Status = StatusProviderOrder.Paid;
            ordersRepository.AddProductProviderOrder(order);
        }

        public ProductProviderOrder GetProviderPaidOrder(int orderId)
        {
            var order = ordersRepository.GetProductProviderOrder(orderId);
            if (order.Status == StatusProviderOrder.Paid)
                return order;
            else
                return null;
        }

        public void ConfirmProviderPaidOrder(int orderId)
        {
            var order = ordersRepository.GetProductProviderOrder(orderId);
            ordersRepository.RemoveProductProviderOrder(orderId);
            order.Status = StatusProviderOrder.Received;
            ordersRepository.AddProductProviderOrder(order);
        }

        private static int GetOrderId()
        {
            return nextIdOrder++;
        }

        private static int GetProviderId()
        {
            return nextIdProvider++;
        }
    }
}
