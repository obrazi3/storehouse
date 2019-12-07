using System;

namespace Model
{
    public class ServiceForAddingProductsInClientOrder : IServiceForAddingProductsInClientOrder
    {
        private ClientOrder order;
        private IStorehouseServiceForClientOrderService model;

        public ServiceForAddingProductsInClientOrder(IStorehouseServiceForClientOrderService _model)
        {
            model = _model;
        }

        public bool AddProduct(int productId, int numberOfProduct)
        {
            if (order != null)
            {
                var prod = model.GetProduct(productId, numberOfProduct);
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
                        model.AddProduct(prod);
                        order.RemoveProduct(prod);
                        order.TotalCost -= (prod.Price * prod.Lot.QuantityProduct);
                        return true;
                    }
                }
            }

            return false;
        }

        public void SetClientOrder(ClientOrder _order)
        {
            if (_order != null)
                order = _order;
            else
                throw new NullReferenceException();
        }
    }
}
