using System;
using System.Collections;
using System.Collections.Generic;
using Model;
namespace Test
{
    class TestStorehouseRepository
    {
        static void Main(string[] args)
        {

            IStorehouseServiceForClientOrderService serviceClientOrder = new StorehouseService(new StorehouseRepository());
            IStorehouseServiceForDeliveryOrderService serviceDelivery = serviceClientOrder;
            ProductFromLot product = new ProductFromLot();
            product.ProductName = "Берёзка";
            product.ProductGroup = "Конфеты";
            product.ProductCategory = "Кондитерские изделия";
            product.ProduceCountry = "Беларусь";
            product.Price = 15;
            product.Measure = new MeasureKilogram();
            product.ExpirationDate = 30;
            LotInformation lot = new LotInformation();
            lot.ProductionDate = new DateTime(2019, 11, 6);
            lot.QuantityProduct = 25;
            product.Lot = lot;
            serviceDelivery.AddProduct(product);


            // var prod = serviceClientOrder.GetProduct(1, 5);
            //Console.WriteLine(prod.ProductName + " " + prod.ProductGroup + " " + prod.ProductCategory + " " + prod.ProduceCountry + " " + prod.Price + " " + prod.Measure.TypeMeasure + " " + prod.Lot.QuantityProduct + " " + prod.Lot.ProductionDate + " " + prod.ExpirationDate);


            ProductFromLot product2 = new ProductFromLot();
            product2.ProductName = "Берёзка";
            product2.ProductGroup = "Конфеты";
            product2.ProductCategory = "Кондитерские изделия";
            product2.ProduceCountry = "Беларусь";
            product2.Price = 15;
            product2.Measure = new MeasureKilogram();
            product2.ExpirationDate = 30;
            LotInformation lot2 = new LotInformation();
            lot2.ProductionDate = new DateTime(2019, 11, 7);
            lot2.QuantityProduct = 10;
            product2.Lot = lot2;

            serviceClientOrder.AddProduct(product2);

            // var prod2 = serviceClientOrder.GetProduct(1, 30);
            //Console.WriteLine(prod2.ProductName + " " + prod2.ProductGroup + " " + prod2.ProductCategory + " " + prod2.ProduceCountry + " " + prod2.Price + " " + prod2.Measure.TypeMeasure + " " + prod2.Lot.QuantityProduct + " " + prod2.Lot.ProductionDate + " " + prod2.ExpirationDate);

            ProductFromLot product3 = new ProductFromLot();
            product3.ProductName = "101 зерно";
            product3.ProductGroup = "Творог";
            product3.ProductCategory = "Молочные изделия";
            product3.ProduceCountry = "Беларусь";
            product3.Price = 1;
            product3.Measure = new MeasurePiece();
            product3.ExpirationDate = 30;
            LotInformation lot3 = new LotInformation();
            lot3.ProductionDate = new DateTime(2019, 11, 8);
            lot3.QuantityProduct = 40;
            product3.Lot = lot2;

            serviceClientOrder.AddProduct(product3);

            var catalog = serviceClientOrder.GetProdCatalog();
            foreach( var cat1 in catalog)
            {
                foreach( var cat2 in cat1.Value)
                {
                    foreach( var prod in cat2.Value)
                    {
                        Console.WriteLine(prod.ProductName + " " + prod.Price + " " + prod.Measure.TypeMeasure + " "+ prod.Price+ " "+ prod.TotalQuantityProduct);
                    }
                }
            }


            var prod2 = serviceClientOrder.GetProduct(1, 30);
            Console.WriteLine();
            catalog = serviceClientOrder.GetProdCatalog();
            foreach (var cat1 in catalog)
            {
                foreach (var cat2 in cat1.Value)
                {
                    foreach (var prod in cat2.Value)
                    {
                        Console.WriteLine(prod.ProductName + " " + prod.Price + " " + prod.Measure.TypeMeasure + " " + prod.Price + " " + prod.TotalQuantityProduct);
                    }
                }
            }
            
        }
    }
}
