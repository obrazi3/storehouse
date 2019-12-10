using System;
using System.Collections.Generic;
using Ninject;

namespace Model
{
    public class StorehouseService : IStorehouseServiceForClientOrderService, IStorehouseServiceForDeliveryOrderService
    {
        private readonly IKernel _kernel;
        private static int _productId;
        private IStorehouseRepository _repository;
        private static int _initializeOnce;

        public StorehouseService(IStorehouseRepository repository, IKernel kernel)
        {
            this._kernel = kernel;
            this._repository = repository;
            if (_initializeOnce == 0)
            {
                TestCatalog();
                _initializeOnce++;
            }
        }

        public void AddProduct(ProductFromLot prod)
        {
            bool contains = _repository.ContainsProduct(prod);
            if (contains)
                _repository.AddProductFromLot(prod);
            else
            {
                StorehouseProduct storehouseProduct = new StorehouseProduct(prod);
                storehouseProduct.ProductId = GetProductId();
                IServiceForStorehouseProduct service = _kernel.Get<IServiceForStorehouseProduct>();
                service.SetStorehouseProduct(storehouseProduct);
                service.UpdateProductCharacteristic();
                _repository.AddStoreHouseProduct(storehouseProduct);
            }
        }

        public SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> GetProdCatalog()
        {
            return _repository.GetProductCatalog();
        }

        public ProductFromLot GetProduct(int idProduct, int numberOfProduct)
        {
            return _repository.GetProduct(idProduct, numberOfProduct);
        }


        public void AddProductFromDelivery(ProductFromLot prod)
        {
            AddProduct(prod);
        }

        public List<StorehouseProduct> GetListDificitProducts(int number)
        {
            List<StorehouseProduct> dificitProducts = new List<StorehouseProduct>();
            List<StorehouseProduct> products = _repository.GetListAllProducts();

            foreach (var product in products)
            {
                if (product.TotalQuantityProduct <= number)
                    dificitProducts.Add(product);
            }

            return dificitProducts;
        }

        private static int GetProductId()
        {
            _productId++;
            return _productId;
        }

        private void TestCatalog()
        {
            ProductFromLot prod = new ProductFromLot();
            prod.Measure = new MeasureKilogram();
            prod.Price = 3;
            prod.ExpirationDate = 30;
            prod.ProduceCountry = "Беларусь";
            prod.ProductCategory = "Мясные полуфабрикаты";
            prod.ProductGroup = "Пельмени";
            prod.ProductName = "Мясные подушечки";
            prod.Lot.QuantityProduct = 30;
            prod.Lot.ProductionDate = new DateTime(2010, 10, 10);

            AddProduct(prod);

            ProductFromLot prod1 = new ProductFromLot();
            prod1.Measure = new MeasureKilogram();
            prod1.Price = 4;
            prod1.ExpirationDate = 30;
            prod1.ProduceCountry = "Беларусь";
            prod1.ProductCategory = "Мясные полуфабрикаты";
            prod1.ProductGroup = "Пельмени";
            prod1.ProductName = "Бабушка Аня";
            prod1.Lot.ProductionDate = new DateTime(2010, 10, 10);
            prod1.Lot.QuantityProduct = 40;

            AddProduct(prod1);

            ProductFromLot prod2 = new ProductFromLot();
            prod2.Measure = new MeasureKilogram();
            prod2.Price = 9;
            prod2.ExpirationDate = 30;
            prod2.ProduceCountry = "Беларусь";
            prod2.ProductCategory = "Мясные полуфабрикаты";
            prod2.ProductGroup = "Разделка свинная";
            prod2.ProductName = "Хряк";
            prod2.Lot.ProductionDate = new DateTime(2010, 10, 10);
            prod2.Lot.QuantityProduct = 50;

            AddProduct(prod2);

            ProductFromLot prod3 = new ProductFromLot();
            prod3.Measure = new MeasureKilogram();
            prod3.Price = 1;
            prod3.ExpirationDate = 15;
            prod3.ProduceCountry = "Беларусь";
            prod3.ProductCategory = "Молочная продукция";
            prod3.ProductGroup = "Творожные изделия";
            prod3.ProductName = "101 зерно";
            prod3.Lot.ProductionDate = new DateTime(2010, 10, 10);
            prod3.Lot.QuantityProduct = 15;

            AddProduct(prod3);
        }
    }
}
