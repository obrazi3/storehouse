using System;

namespace Model
{
    public class ServiceForFillingClientOrder : IServiceForFilingClientOrder
    {
        private ClientOrder order;

        public ServiceForFillingClientOrder() { }

        public bool AddProduct(ProductFromLot prod)
        {
            if (order != null)
            {
                order.AddProduct(prod);
                order.TotalCost += (prod.Lot.QuantityProduct * prod.Price);
                return true;
            }

            return false;
        }

        public bool RemoveProduct(int prodId)
        {
            if (order != null)
            {
                var listProducts = order.GetListProducts();
                foreach (var prod in listProducts)
                {
                    if (prod.ProductId == prodId)
                    {
                        order.RemoveProduct(prod);
                        order.TotalCost -= (prod.Price * prod.Lot.QuantityProduct);
                        return true;
                    }
                }

                return false;
            }

            return false;
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

            return false;
        }
    }
}
