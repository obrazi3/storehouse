
using System.Collections.Generic;

namespace Model
{
    public class StorehouseService : IStorehouseServiceForClientOrderService, IStorehouseServiceForDeliveryOrderService
    {
        private static int productId;
        private IStorehouseRepository repository;

        public StorehouseService(IStorehouseRepository _repository)
        {
            repository = _repository;
        }

        public void AddProduct(ProductFromLot prod)
        {
            bool contains = repository.ContainsProduct(prod);
            if (contains)
                repository.AddProductFromLot(prod);
            else
            {
                StorehouseProduct storehouseProduct = new StorehouseProduct(prod);
                storehouseProduct.ProductId = GetProductId();
                repository.AddStoreHouseProduct(storehouseProduct);
            }
        }

        public SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProdCatalog()
        {
            return repository.GetProductCatalog();
        }

        public ProductFromLot GetProduct(int idProduct, int numberOfProduct)
        {
            return repository.GetProduct(idProduct, numberOfProduct);
        }



        public void AddProductFromDelivery(ProductFromLot prod)
        {
            AddProduct(prod);
        }

        public List<StorehouseProduct> GetListDificitProducts(int number)
        {
            List<StorehouseProduct> dificitProducts = new List<StorehouseProduct>();
            List<StorehouseProduct> products = repository.GetListAllProducts();
            
            foreach(var product in products)
            {
                if (product.TotalQuantityProduct <= number)
                    dificitProducts.Add(product);
            }

            return dificitProducts;
        }

        private static int GetProductId()
        {
            productId++;
            return productId;
        }


    }
}
