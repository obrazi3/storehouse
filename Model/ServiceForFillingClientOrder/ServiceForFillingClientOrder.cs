using System;

namespace Model
{
    public class ServiceForFillingClientOrder : IServiceForFilingClientOrder
    {
        private ClientOrder order;

        public ServiceForFillingClientOrder(ClientOrder _order)
        {
            order = _order;
        }

        public void AddProduct(ProductFromLot prod)
        {
            order.AddProduct(prod);
            order.TotalCost += (prod.Lot.QuantityProduct * prod.Price);
        }

        public void RemoveProduct(int prodId)
        {
            var listProducts = order.GetListProducts();
            foreach (var prod in listProducts)
            {
                if (prod.ProductId == prodId)
                {
                    order.RemoveProduct(prod);
                    order.TotalCost -= (prod.Price * prod.Lot.QuantityProduct);
                    return;
                }
            }
        }

        public void InitializeOrder()
        {
            order.OrderDate = DateTime.Now;
            order.Status = StatusClientOrder.NotPaid;
        }

        public void AddClientInfo(ClientInformation info)
        {
            order.ClientInfo = info;
        }

        public ClientOrder GetClientOrder()
        {
            return order;
        }
    }
}
