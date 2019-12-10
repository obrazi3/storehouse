using System;

namespace Model
{
    public class ServiceForFillingPersonInfoInClientOrder : IServiceForFilingPersonInfoInClientOrder
    {
        private ClientOrder _order;
        private IStorehouseServiceForClientOrderService _model;

        public ServiceForFillingPersonInfoInClientOrder(IStorehouseServiceForClientOrderService model)
        {
            this._model = model;
        }

        public bool InitializeOrder()
        {
            if (_order != null)
            {
                _order.OrderDate = DateTime.Now;
                _order.Status = StatusClientOrder.NotPaid;
                return true;
            }

            return false;
        }

        public bool AddClientInfo(ClientInformation info)
        {
            if (_order != null)
            {
                _order.ClientInfo = info;
                return true;
            }

            return false;
        }

        public ClientOrder GetClientOrder()
        {
            return _order;
        }

        public bool SetClientOrder(ClientOrder order)
        {
            if (order != null)
            {
                this._order = order;
                return true;
            }

            throw new NullReferenceException();
        }
    }
}
