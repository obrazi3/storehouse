using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryOrderService
    {
        private IProductProvidersRepository providersRepository;


        public DeliveryOrderService(IProductProvidersRepository _providersRepository) 
        {
            providersRepository = _providersRepository;
        }
    }
}
