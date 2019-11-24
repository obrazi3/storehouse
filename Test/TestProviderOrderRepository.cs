using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Test
{
    class TestProviderOrderRepository
    {
        /*public static void Main()
        {
            IProviderOrderRepository rep = new ProviderOrderRepository();

            ProductProvider provider1 = new ProductProvider();
            provider1.BankAccountNumber = "12345";
            provider1.ContactNumber = "+375 29 350-27-49";
            provider1.Email = "1999pavel@gmail.com";
            provider1.Name = "ООО Брестский мясокомбинат";
            provider1.ProviderId = 1;
            provider1.AddProductCategory("Мясные изделия");
            provider1.AddProductCategory("Полуфабрикаты");


            ProductProviderOrder order1 = new ProductProviderOrder();
            order1.OrderDate = new DateTime(2019, 1, 1);
            order1.OrderId = 1;
            order1.Provider = provider1;
            order1.Status = StatusProviderOrder.NotPaid;

            ProductProviderOrder order2 = new ProductProviderOrder();
            order2.OrderDate = new DateTime(2019, 1, 2);
            order2.OrderId = 2;
            order2.Provider = provider1;
            order2.Status = StatusProviderOrder.Paid;

            rep.AddProductProviderOrder(order1);
            rep.AddProductProviderOrder(order2);

            Console.WriteLine("Contains order with ID:1?");
            Console.WriteLine(rep.ContainsOrder(1));
            Console.WriteLine();

            Console.WriteLine("Order 1:");
            var order = rep.GetProductProviderOrder(1);
            Console.WriteLine(order.OrderDate + " " + order.Status);
            Console.WriteLine();

            Console.WriteLine("All orders:");
            var allOrders = rep.GetListAllOrders();
            foreach(var ord in allOrders)
            {
                Console.WriteLine(ord.OrderDate + " " + ord.Status);
            }
            Console.WriteLine();
            Console.WriteLine("Orders with status 'paid'");
            var ordersByStatus = rep.GetOrderSelectionByStatus(StatusProviderOrder.Paid);
            foreach(var ord in ordersByStatus)
            {
                Console.WriteLine(ord.OrderDate + " " + ord.Status);
            }
            Console.WriteLine();

            Console.WriteLine("All orders before removing");
            allOrders = rep.GetListAllOrders();
            foreach (var ord in allOrders)
            {
                Console.WriteLine(ord.OrderDate + " " + ord.Status);
            }
            Console.WriteLine();

            Console.WriteLine("All order after removing order with ID:2");
            rep.RemoveProductProviderOrder(2);
            allOrders = rep.GetListAllOrders();
            foreach (var ord in allOrders)
            {
                Console.WriteLine(ord.OrderDate + " " + ord.Status);
            }
            Console.WriteLine();

            Console.WriteLine("Contains order with ID:2?");
            Console.WriteLine(rep.ContainsOrder(2));
            Console.WriteLine();
            
        }*/
    }
}
