using System.Collections.Generic;
using Ninject;

namespace Model
{
    public class ServiceForControlProductMovementInClientOrder : IServiceForControlProductMovementInClientOrder
    {
        private readonly IKernel _kernel;
        private Dictionary<int, List<ProductFromLot>> _addedProducts;
        private Dictionary<int, List<ProductFromLot>> _removedProducts;
        private Dictionary<int, ClientOrder> _orders;

        public ServiceForControlProductMovementInClientOrder(IKernel kernel)
        {
            _addedProducts = new Dictionary<int, List<ProductFromLot>>();
            _removedProducts = new Dictionary<int, List<ProductFromLot>>();
            _orders = new Dictionary<int, ClientOrder>();
            this._kernel = kernel;
        }

        public void AddClientOrder(ClientOrder order)
        {
            if (!_orders.ContainsKey(order.OrderId))
            {
                _orders.Add(order.OrderId, order);
                _addedProducts.Add(order.OrderId, new List<ProductFromLot>());
                _removedProducts.Add(order.OrderId, new List<ProductFromLot>());
            }
        }

        public void ConfirmCompletionEditing(int orderId)
        {
            _orders.Remove(orderId);
            _addedProducts.Remove(orderId);
            _removedProducts.Remove(orderId);
        }

        public void CancelEditing(int orderId)
        {
            var serviceForAddingProductsInClientOrder = _kernel.Get<IServiceForAddingProductsInClientOrder>();

            var order = _orders[orderId];
            serviceForAddingProductsInClientOrder.SetClientOrder(order);

            var listRemoved = _removedProducts[orderId];
            foreach (var prod in listRemoved)
            {
                serviceForAddingProductsInClientOrder.AddProduct(prod.ProductId, prod.Lot.QuantityProduct);
            }

            var listAdded = _addedProducts[orderId];
            foreach (var prod in listAdded)
            {
                serviceForAddingProductsInClientOrder.RemoveProduct(prod.ProductId);
            }

            ConfirmCompletionEditing(orderId);
        }

        public void AddProduct(int orderId, int productId, int numberOfProduct)
        {
            ProductFromLot prod = new ProductFromLot();
            prod.ProductId = productId;
            prod.Lot.QuantityProduct = numberOfProduct;
            _addedProducts[orderId].Add(prod);

            var order = _orders[orderId];

            var serviceForAddingProductsInClientOrder = _kernel.Get<IServiceForAddingProductsInClientOrder>();
            serviceForAddingProductsInClientOrder.SetClientOrder(order);
            serviceForAddingProductsInClientOrder.AddProduct(productId, numberOfProduct);
        }

        public void RemoveProduct(int orderId, int productId)
        {
            var listProd = _orders[orderId].GetListProducts();
            ProductFromLot prod = null;
            foreach (var pr in listProd)
            {
                if (pr.ProductId == productId)
                    prod = (ProductFromLot)pr.Clone();
                break;
            }

            _removedProducts[orderId].Add(prod);

            var order = _orders[orderId];

            var serviceForAddingProductsInClientOrder = _kernel.Get<IServiceForAddingProductsInClientOrder>();
            serviceForAddingProductsInClientOrder.SetClientOrder(order);
            serviceForAddingProductsInClientOrder.RemoveProduct(productId);
        }
    }
}
