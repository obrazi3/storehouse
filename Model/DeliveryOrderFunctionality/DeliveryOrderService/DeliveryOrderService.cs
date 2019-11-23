using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryOrderService
    {
        private IProductProviderRepository providersRepository;


        public DeliveryOrderService(IProductProviderRepository _providersRepository) 
        {
            providersRepository = _providersRepository;
        }
    }
}
