using System;

namespace Model
{
    public class ServiceForAddingProductsInClientOrder : IServiceForAddingProductsInClientOrder
    {
        private ClientOrder _order;
        private IStorehouseServiceForClientOrderService _model;

        public ServiceForAddingProductsInClientOrder(IStorehouseServiceForClientOrderService model)
        {
            this._model = model;
        }

        public bool AddProduct(int productId, int numberOfProduct)
        {
            if (_order != null)
            {
                bool isContains = IsContainsProduct(productId);
                var newProduct = _model.GetProduct(productId, numberOfProduct);
                if (isContains)
                {
                    var oldProduct = GetProductFromOrder(productId);
                    oldProduct.Lot.QuantityProduct += newProduct.Lot.QuantityProduct;
                }
                else
                    _order.AddProduct(newProduct);

                _order.TotalCost += (newProduct.Lot.QuantityProduct * newProduct.Price);
                return true;
            }

            return false;
        }

        public bool RemoveProduct(int prodId)
        {
            if (_order != null)
            {
                var listProducts = _order.GetListProducts();
                foreach (var prod in listProducts)
                {
                    if (prod.ProductId == prodId)
                    {
                        _model.AddProduct(prod);
                        _order.RemoveProduct(prod);
                        _order.TotalCost -= (prod.Price * prod.Lot.QuantityProduct);
                        return true;
                    }
                }
            }

            return false;
        }

        public void SetClientOrder(ClientOrder order)
        {
            if (order != null)
                this._order = order;
            else
                throw new NullReferenceException();
        }

        private bool IsContainsProduct(int productId)
        {
            var listProducts = _order.GetListProducts();
            foreach (var prod in listProducts)
            {
                if (prod.ProductId == productId)
                    return true;
            }

            return false;
        }

        private ProductFromLot GetProductFromOrder(int productId)
        {
            var listProducts = _order.GetListProducts();
            foreach (var prod in listProducts)
            {
                if (prod.ProductId == productId)
                    return prod;
            }

            return null;
        }
    }
}
