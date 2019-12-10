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
                bool isContains = IsContainsProduct(productId);
                var newProduct = model.GetProduct(productId, numberOfProduct);
                if (isContains)
                {
                    var oldProduct = GetProductFromOrder(productId);
                    oldProduct.Lot.QuantityProduct += newProduct.Lot.QuantityProduct;
                }
                else
                    order.AddProduct(newProduct);

                order.TotalCost += (newProduct.Lot.QuantityProduct * newProduct.Price);
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

        private bool IsContainsProduct(int productId)
        {
            var listProducts = order.GetListProducts();
            foreach (var prod in listProducts)
            {
                if (prod.ProductId == productId)
                    return true;
            }

            return false;
        }

        private ProductFromLot GetProductFromOrder(int productId)
        {
            var listProducts = order.GetListProducts();
            foreach (var prod in listProducts)
            {
                if (prod.ProductId == productId)
                    return prod;
            }

            return null;
        }
    }
}
