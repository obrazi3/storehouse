using System;

namespace Model
{
    public class ServiceForFillingPersonInfoInClientOrder : IServiceForFilingPersonInfoInClientOrder
    {
        private ClientOrder order;
        private IStorehouseServiceForClientOrderService model;

        public ServiceForFillingPersonInfoInClientOrder(IStorehouseServiceForClientOrderService _model)
        {
            model = _model;
        }

        public bool InitializeOrder()
        {
            if (order != null)
            {
                order.OrderDate = DateTime.Now;
                order.Status = StatusClientOrder.NotPaid;
                return true;
            }

            return false;
        }

        public bool AddClientInfo(ClientInformation info)
        {
            if (order != null)
            {
                order.ClientInfo = info;
                return true;
            }

            return false;
        }

        public ClientOrder GetClientOrder()
        {
            return order;
        }

        public bool SetClientOrder(ClientOrder _order)
        {
            if (_order != null)
            {
                order = _order;
                return true;
            }

            throw new NullReferenceException();
        }
    }
}
