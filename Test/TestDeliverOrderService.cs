using System;
using Model;
//using Ninject;
//using View;

namespace Test
{
    public class TestDeliverOrderService
    {
       /* public static void Main()
        {
            var kernel = new StandardKernel(new NinjectConfiguration());
            IDeliveryOrderServiceForBooker booker = kernel.Get<IDeliveryOrderServiceForBooker>();
            IDeliveryOrderServiceForPurcpManager purcpManager = kernel.Get<IDeliveryOrderServiceForPurcpManager>();
            IDeliveryOrderServiceForStorekeeper storekeeper = kernel.Get<IDeliveryOrderServiceForStorekeeper>();

            //Test purcpManager
            TestPurcpManager(purcpManager);


            //Test booker
            //TestBooker(booker,purcpManager);


            //Test storekeeper
            //TestStorekeeper(storekeeper, booker, purcpManager);
        }

        private static void TestPurcpManager(IDeliveryOrderServiceForPurcpManager purcpManager)
        {
            ProductProvider provider1 = new ProductProvider();
            provider1.BankAccountNumber = "12345";
            provider1.ContactNumber = "+375 29 350-27-49";
            provider1.Email = "1999pavel@gmail.com";
            provider1.Name = "ООО Брестский мясокомбинат";
            provider1.AddProductCategory("Мясные изделия");
            provider1.AddProductCategory("Полуфабрикаты");

            ProductProvider provider2 = new ProductProvider();
            provider2.BankAccountNumber = "54321";
            provider2.ContactNumber = "+375 29 503-20-49";
            provider2.Email = "1998pavel@gmail.com";
            provider2.Name = "ОАО Савушкин Продукт";
            provider2.AddProductCategory("Молочные изделия");

            purcpManager.AddProductProvider(provider1);
            purcpManager.AddProductProvider(provider2);

            Console.WriteLine("Список поставщиков");
            var listProviders = purcpManager.GetListProductProviders();
            foreach (var prov in listProviders)
            {
                Console.WriteLine(prov.Name + " " + prov.GetListProductCategories()[0] + " " + prov.Email + " " +
                                  prov.ContactNumber + " " + prov.BankAccountNumber + " ID:" + prov.ProviderId);
            }

            Console.WriteLine();

            Console.WriteLine("Список поставщиков после редактирования второго");
            var provider2Edit = purcpManager.GetProductProvider(2);
            provider2Edit.Email = "2000pavel@gmail.com";
            purcpManager.EditProductProvider(provider2Edit);

            listProviders = purcpManager.GetListProductProviders();
            foreach (var prov in listProviders)
            {
                Console.WriteLine(prov.Name + " " + prov.GetListProductCategories()[0] + " " + prov.Email + " " +
                                  prov.ContactNumber + " " + prov.BankAccountNumber + " ID:" + prov.ProviderId);
            }

            Console.WriteLine();

            Console.WriteLine("Список поставщиков после удаления поставщика с ID:2");
            purcpManager.RemoveProductProvider(2);
            listProviders = purcpManager.GetListProductProviders();
            foreach (var prov in listProviders)
            {
                Console.WriteLine(prov.Name + " " + prov.GetListProductCategories()[0] + " " + prov.Email + " " +
                                  prov.ContactNumber + " " + prov.BankAccountNumber);
            }

            Console.WriteLine();

            ProductProviderOrder order1 = new ProductProviderOrder();
            order1.OrderDate = new DateTime(2019, 1, 1);
            order1.OrderId = 1;
            order1.Provider = provider1;
            //order1.Status = StatusProviderOrder.NotPaid;

            ProductProviderOrder order2 = new ProductProviderOrder();
            order2.OrderDate = new DateTime(2019, 1, 2);
            order2.OrderId = 2;
            order2.Provider = provider1;
            //order2.Status = StatusProviderOrder.NotPaid;

            purcpManager.AddNotPaidOrder(order1);
            purcpManager.AddNotPaidOrder(order2);

            Console.WriteLine("Список неоплаченных заказов");
            var listNotPaidOrders = purcpManager.GetListNotPaidOrders();
            foreach (var order in listNotPaidOrders)
            {
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            }

            Console.WriteLine();

            Console.WriteLine("Список неоплаченных заказов после редактирования заказа с ID:1");
            var order2Edit = purcpManager.GetNotPaidOrder(1);
            order2Edit.OrderDate = new DateTime(2020, 1, 2);
            purcpManager.EditNotPaidOrder(order2Edit);
            listNotPaidOrders = purcpManager.GetListNotPaidOrders();
            foreach (var order in listNotPaidOrders)
            {
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            }

            Console.WriteLine();

            Console.WriteLine("Список неоплаченных заказов после удаления заказа с ID:2");
            purcpManager.RemoveNotPaidOrder(2);
            listNotPaidOrders = purcpManager.GetListNotPaidOrders();
            foreach (var order in listNotPaidOrders)
            {
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            }

            Console.WriteLine();
        }

        private static void TestBooker(IDeliveryOrderServiceForBooker booker,
            IDeliveryOrderServiceForPurcpManager purcpManager)
        {
            ProductProvider provider1 = new ProductProvider();
            provider1.BankAccountNumber = "12345";
            provider1.ContactNumber = "+375 29 350-27-49";
            provider1.Email = "1999pavel@gmail.com";
            provider1.Name = "ООО Брестский мясокомбинат";
            provider1.AddProductCategory("Мясные изделия");
            provider1.AddProductCategory("Полуфабрикаты");

            ProductProviderOrder order1 = new ProductProviderOrder();
            order1.OrderDate = new DateTime(2019, 1, 1);
            order1.OrderId = 1;
            order1.Provider = provider1;

            ProductProviderOrder order2 = new ProductProviderOrder();
            order2.OrderDate = new DateTime(2019, 1, 2);
            order2.OrderId = 2;
            order2.Provider = provider1;

            purcpManager.AddNotPaidOrder(order1);
            purcpManager.AddNotPaidOrder(order2);

            Console.WriteLine("Список неоплаченных заказов ");
            var listNotPaidOrders = booker.GetListNotPaidProviderOrders();
            foreach (var order in listNotPaidOrders)
            {
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            }

            Console.WriteLine();

            Console.WriteLine("Список неоплаченных заказов после подтверждения оплаты заказа с ID:1");
            booker.ConfirmPaymentProviderOrder(1);
            listNotPaidOrders = booker.GetListNotPaidProviderOrders();
            foreach (var order in listNotPaidOrders)
            {
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            }

            Console.WriteLine();
        }

        private static void TestStorekeeper(IDeliveryOrderServiceForStorekeeper storekeeper,
            IDeliveryOrderServiceForBooker booker,
            IDeliveryOrderServiceForPurcpManager manager)
        {
            TestBooker(booker, manager);

            Console.WriteLine("Оплаченный заказ с ID:1");
            var order = storekeeper.GetProviderPaidOrder(1);
            Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            Console.WriteLine();

            Console.WriteLine("Есть ли заказ с ID:1 в списке для получения после подтверждения о получении?");
            storekeeper.ConfirmProviderPaidOrder(1);
            order = storekeeper.GetProviderPaidOrder(1);
            if (order == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(order.OrderDate + " ID:" + order.OrderId + " " + order.TotalSumOrder);
            Console.WriteLine();
        }*/
    }
}
