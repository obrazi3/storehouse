

using System;

namespace Model
{
    static class Test
    {
        static void Main()
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
            serviceDelivery.AddProduct(product);


            var prod = serviceClientOrder.GetProduct(1, 5);
            Console.WriteLine(prod.ProductName + " " + prod.ProductGroup + " " + prod.ProductCategory + " " + prod.ProduceCountry + " " + prod.Price + " " + prod.Measure.TypeMeasure + " " + prod.Lot.QuantityProduct + " " + prod.Lot.ProductionDate + " " + prod.ExpirationDate);
        }
    }
}
