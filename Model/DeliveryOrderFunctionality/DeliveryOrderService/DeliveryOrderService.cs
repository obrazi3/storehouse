using System;
using System.Collections.Generic;

namespace Model
{
    public class DeliveryOrderService : IDeliveryOrderServiceForPurcpManager, IDeliveryOrderServiceForBooker,
        IDeliveryOrderServiceForStorekeeper
    {
        private static int _nextIdOrder;
        private static int _nextIdProvider;
        private IProductProviderRepository _providersRepository;
        private IProviderOrderRepository _ordersRepository;
        private IStorehouseServiceForDeliveryOrderService _storehouseService;
        private IBankForDeliveryOrderService _bank;


        public DeliveryOrderService(IProductProviderRepository providersRepository,
            IProviderOrderRepository ordersRepository, IStorehouseServiceForDeliveryOrderService storehouseService,
            IBankForDeliveryOrderService bank)
        {
            this._providersRepository = providersRepository;
            this._ordersRepository = ordersRepository;
            this._storehouseService = storehouseService;
            this._bank = bank;
            _nextIdOrder = 1;
            _nextIdProvider = 1;
        }


        public void AddProductProvider(ProductProvider prov)
        {
            prov.ProviderId = GetProviderId();
            _providersRepository.AddProductProvider(prov);
        }

        public ProductProvider GetProductProvider(int providerId)
        {
            return _providersRepository.GetProductProvider(providerId);
        }

        public void EditProductProvider(ProductProvider provider)
        {
            _providersRepository.RemoveProductProvider(provider.ProviderId);
            _providersRepository.AddProductProvider(provider);
        }

        public void RemoveProductProvider(int providerId)
        {
            _providersRepository.RemoveProductProvider(providerId);
        }

        public List<ProductProvider> GetListProductProviders()
        {
            return _providersRepository.GetListProductProviders();
        }

        public void AddNotPaidOrder(ProductProviderOrder order)
        {
            order.OrderId = GetOrderId();
            order.Status = StatusProviderOrder.NotPaid;
            _ordersRepository.AddProductProviderOrder(order);
        }

        public ProductProviderOrder GetNotPaidOrder(int orderId)
        {
            var order = _ordersRepository.GetProductProviderOrder(orderId);
            if (order.Status == StatusProviderOrder.NotPaid)
                return order;
            else
                return null;
        }

        public void EditNotPaidOrder(ProductProviderOrder order)
        {
            _ordersRepository.RemoveProductProviderOrder(order.OrderId);
            _ordersRepository.AddProductProviderOrder(order);
        }

        public void RemoveNotPaidOrder(int orderId)
        {
            _ordersRepository.RemoveProductProviderOrder(orderId);
        }

        public List<ProductProviderOrder> GetListNotPaidOrders()
        {
            return _ordersRepository.GetOrderSelectionByStatus(StatusProviderOrder.NotPaid);
        }

        public List<StorehouseProduct> GetListDificitProducts(int number)
        {
            return _storehouseService.GetListDificitProducts(number);
        }

        public List<ProductProviderOrder> GetListNotPaidProviderOrders()
        {
            return _ordersRepository.GetOrderSelectionByStatus(StatusProviderOrder.NotPaid);
        }

        public void ConfirmPaymentProviderOrder(int orderId)
        {
            var order = _ordersRepository.GetProductProviderOrder(orderId);
            _ordersRepository.RemoveProductProviderOrder(orderId);
            order.Status = StatusProviderOrder.Paid;
            _ordersRepository.AddProductProviderOrder(order);
        }

        public bool PayDeliveryFromProvider(int bankIdProvider, int sum)
        {
            bool result = _bank.PayDeliveryFromProvider(bankIdProvider, sum);
            if (result)
            {
                int orderId = FindPaidOrder(bankIdProvider, sum);
                if (orderId != -1)
                {
                    ConfirmPaymentProviderOrder(orderId);
                }
                else { result = false; }
            }

            return result;
        }

        public ProductProviderOrder GetProviderPaidOrder(int orderId)
        {
            var order = _ordersRepository.GetProductProviderOrder(orderId);
            if (order != null && order.Status == StatusProviderOrder.Paid)
                return order;
            else
                return null;
        }

        public void ConfirmProviderPaidOrder(int orderId)
        {
            var order = _ordersRepository.GetProductProviderOrder(orderId);
            _ordersRepository.RemoveProductProviderOrder(orderId);
            order.Status = StatusProviderOrder.Received;
            _ordersRepository.AddProductProviderOrder(order);
            foreach (var prod in order.GetListProducts())
            {
                _storehouseService.AddProductFromDelivery(prod);
            }
        }

        private static int GetOrderId()
        {
            return _nextIdOrder++;
        }

        private static int GetProviderId()
        {
            return _nextIdProvider++;
        }

        private int FindPaidOrder(int bankIdProvider, int sum)
        {
            var listNotPaidOrders = _ordersRepository.GetOrderSelectionByStatus(StatusProviderOrder.NotPaid);
            foreach (var order in listNotPaidOrders)
            {
                if (order.TotalSumOrder == sum && Int32.Parse(order.Provider.BankAccountNumber) == bankIdProvider)
                {
                    return order.OrderId;
                }
            }

            return -1;
        }
    }
}
