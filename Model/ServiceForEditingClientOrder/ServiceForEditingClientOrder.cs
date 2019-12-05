using System.Collections.Generic;
using Ninject;

namespace Model
{
    public class ServiceForEditingClientOrder : IServiceForEditingClientOrder
    {
        private readonly IKernel kernel;
        private Dictionary<int, List<ProductFromLot>> AddedProducts;
        private Dictionary<int, List<ProductFromLot>> RemovedProducts;
        private Dictionary<int, ClientOrder> orders;

        public ServiceForEditingClientOrder(IKernel _kernel)
        {
            AddedProducts = new Dictionary<int, List<ProductFromLot>>();
            RemovedProducts = new Dictionary<int, List<ProductFromLot>>();
            orders = new Dictionary<int, ClientOrder>();
            kernel = _kernel;
        }

        public void AddClientOrder(ClientOrder order)
        {
            if (!orders.ContainsKey(order.OrderId))
            {
                orders.Add(order.OrderId, order);
                AddedProducts.Add(order.OrderId, new List<ProductFromLot>());
                RemovedProducts.Add(order.OrderId, new List<ProductFromLot>());
            }
        }

        public void ConfirmCompletionEditing(int orderId)
        {
            orders.Remove(orderId);
            AddedProducts.Remove(orderId);
            RemovedProducts.Remove(orderId);
        }

        public void CancelEditing(int orderId)
        {
            var productService = kernel.Get<IServiceForFilingClientOrder>();

            var order = orders[orderId];
            productService.SetClientOrder(order);

            var listRemoved = RemovedProducts[orderId];
            foreach (var prod in listRemoved)
            {
                productService.AddProduct(prod.ProductId, prod.Lot.QuantityProduct);
            }

            var listAdded = AddedProducts[orderId];
            foreach (var prod in listAdded)
            {
                productService.RemoveProduct(prod.ProductId);
            }
        }

        public void AddProduct(int orderId, int productId, int numberOfProduct)
        {
            ProductFromLot prod = new ProductFromLot();
            prod.ProductId = productId;
            prod.Lot.QuantityProduct = numberOfProduct;
            AddedProducts[orderId].Add(prod);

            var productService = kernel.Get<IServiceForFilingClientOrder>();

            var order = orders[orderId];
            productService.SetClientOrder(order);
            productService.AddProduct(productId, numberOfProduct);
        }

        public void RemoveProduct(int orderId, int productId)
        {
            var listProd = orders[orderId].GetListProducts();
            ProductFromLot prod = null;
            foreach (var pr in listProd)
            {
                if (pr.ProductId == productId)
                    prod = (ProductFromLot)pr.Clone();
                break;
            }

            RemovedProducts[orderId].Add(prod);

            var productService = kernel.Get<IServiceForFilingClientOrder>();

            var order = orders[orderId];
            productService.SetClientOrder(order);
            productService.RemoveProduct(productId);
        }
    }
}
