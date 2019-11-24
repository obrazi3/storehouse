using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryOrderService
    {
        private static int nextIdOrder;
        private static int nextIdProvider;
        private IProductProviderRepository providersRepository;
        private IProviderOrderRepository ordersRepository;
        private IStorehouseServiceForDeliveryOrderService storehouseService;


        public DeliveryOrderService(IProductProviderRepository _providersRepository, IProviderOrderRepository _ordersRepository, IStorehouseServiceForDeliveryOrderService _storehouseService) 
        {
            providersRepository = _providersRepository;
            ordersRepository = _ordersRepository;
            storehouseService = _storehouseService;
        }

        
    }
}
