using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Test
{
    class TestProductProviderRepository
    {

        /*public static void Main()
        {
            IProductProviderRepository provRep = new ProductProviderRepository();

            ProductProvider provider1 = new ProductProvider();
            provider1.BankAccountNumber = "12345";
            provider1.ContactNumber = "+375 29 350-27-49";
            provider1.Email = "1999pavel@gmail.com";
            provider1.Name = "ООО Брестский мясокомбинат";
            provider1.ProviderId = 1;
            provider1.AddProductCategory("Мясные изделия");
            provider1.AddProductCategory("Полуфабрикаты");

            provRep.AddProductProvider(provider1);

            ProductProvider provider2 = new ProductProvider();
            provider2.BankAccountNumber = "54321";
            provider2.ContactNumber = "+375 29 503-20-49";
            provider2.Email = "1998pavel@gmail.com";
            provider2.Name = "ОАО Савушкин Продукт";
            provider2.ProviderId = 2;
            provider2.AddProductCategory("Молочные изделия");

            provRep.AddProductProvider(provider2);

            var provider = provRep.GetProductProvider(1);
            Console.WriteLine(provider.Name + " " + provider.GetListProductCategories()[0] + " " + provider.GetListProductCategories()[1]);

            var listProv = provRep.GetListProductProviders();
            foreach(var prov in listProv)
            {
                Console.WriteLine(prov.Name);
            }
        }*/
    }
}
