﻿namespace Test
{
   /* public class TestClientOrderService
    {
        public static void Main()
        {
            //TestClientOrderManager();
            //TestBooker();
            //TestStorekeeper();
            TestCourier();
        }

        public static void TestClientOrderManager()
        {
            HomeAddress address = new HomeAddress();
            address.City = "Минск";
            address.Street = "Голубева";
            address.FlatNumber = "66";
            address.FloorNumber = "7";
            address.HomeNumber = "21";
            address.PavilionNumber = "-";
            address.PorchNumber = "2";

            ClientInformation info = new ClientInformation();
            info.Address = address;
            info.Name = "Павел";
            info.Patronymic = "Викторович";
            info.Surname = "Сайков";
            info.EmailAddress = "1999pav@gmail.com";
            info.PhoneNumber = "+375333502637";

            ClientOrder order1 = new ClientOrder();
            order1.OrderDate = new DateTime(2010, 10, 11);
            order1.ClientInfo = info;

            ClientOrder order2 = new ClientOrder();
            order2.OrderDate = new DateTime(2011, 12, 13);
            order2.ClientInfo = info;

            // StandardKernel kernel = new StandardKernel(new NinjectConfiguration());

            IClientOrderServiceForClientManager serviceForClientManager =
                new ClientOrderService(new StorehouseService(new StorehouseRepository()), new ClientOrderRepository());
            //IClientOrderServiceForClientManager serviceForClientManager =kernel.Get<IClientOrderServiceForClientManager>();

            serviceForClientManager.AddNotPaidOrder(order1);
            serviceForClientManager.AddNotPaidOrder(order2);

            Console.WriteLine("Заказ с ID:1");
            var ord1 = serviceForClientManager.GetNotPaidOrder(1);
            Console.WriteLine(ord1.OrderId + " " + ord1.OrderDate.ToShortDateString());

            Console.WriteLine();
            ord1.OrderDate = new DateTime(2012, 5, 5);
            serviceForClientManager.EditNotPaidOrder(ord1);
            Console.WriteLine("Заказ с ID:1 после внесения корректив:");
            ord1 = serviceForClientManager.GetNotPaidOrder(1);
            Console.WriteLine(ord1.OrderId + " " + ord1.OrderDate.ToShortDateString());

            Console.WriteLine();
            serviceForClientManager.RemoveNotPaidOrder(1);
            ord1 = serviceForClientManager.GetNotPaidOrder(1);
            Console.WriteLine("Заказ с ID:1 после удаления из базы:");
            if (ord1 == null)
                Console.WriteLine("Заказ не найден");
            else
                Console.WriteLine(ord1.OrderId + " " + ord1.OrderDate.ToShortDateString());
        }

        public static void TestBooker()
        {
            HomeAddress address = new HomeAddress();
            address.City = "Минск";
            address.Street = "Голубева";
            address.FlatNumber = "66";
            address.FloorNumber = "7";
            address.HomeNumber = "21";
            address.PavilionNumber = "-";
            address.PorchNumber = "2";

            ClientInformation info = new ClientInformation();
            info.Address = address;
            info.Name = "Павел";
            info.Patronymic = "Викторович";
            info.Surname = "Сайков";
            info.EmailAddress = "1999pav@gmail.com";
            info.PhoneNumber = "+375333502637";

            ClientOrder order1 = new ClientOrder();
            order1.OrderDate = new DateTime(2010, 10, 11);
            order1.ClientInfo = info;

            ClientOrder order2 = new ClientOrder();
            order2.OrderDate = new DateTime(2011, 12, 13);
            order2.ClientInfo = info;

            IClientOrderServiceForClientManager serviceForClientManager =
                new ClientOrderService(new StorehouseService(new StorehouseRepository()), new ClientOrderRepository());

            IClientOrderServiceForBooker serviceForBooker = (IClientOrderServiceForBooker)serviceForClientManager;

            serviceForClientManager.AddNotPaidOrder(order1);
            serviceForClientManager.AddNotPaidOrder(order2);

            Console.WriteLine("Список неоплаченных заказов");
            var listNotPaidClientOrders = serviceForBooker.GetListNotPaidClientOrders();
            foreach (var order in listNotPaidClientOrders)
            {
                Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            }

            Console.WriteLine();

            Console.WriteLine("Список неоплаченных заказов после оплаты заказа с ID:1");
            serviceForBooker.ConfirmPaymentNotPaidClientOrder(1);
            listNotPaidClientOrders = serviceForBooker.GetListNotPaidClientOrders();
            foreach (var order in listNotPaidClientOrders)
            {
                Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            }

            Console.WriteLine();
        }


        public static void TestStorekeeper()
        {
            HomeAddress address = new HomeAddress();
            address.City = "Минск";
            address.Street = "Голубева";
            address.FlatNumber = "66";
            address.FloorNumber = "7";
            address.HomeNumber = "21";
            address.PavilionNumber = "-";
            address.PorchNumber = "2";

            ClientInformation info = new ClientInformation();
            info.Address = address;
            info.Name = "Павел";
            info.Patronymic = "Викторович";
            info.Surname = "Сайков";
            info.EmailAddress = "1999pav@gmail.com";
            info.PhoneNumber = "+375333502637";

            ClientOrder order1 = new ClientOrder();
            order1.OrderDate = new DateTime(2010, 10, 11);
            order1.ClientInfo = info;

            ClientOrder order2 = new ClientOrder();
            order2.OrderDate = new DateTime(2011, 12, 13);
            order2.ClientInfo = info;

            IClientOrderServiceForClientManager serviceForClientManager =
                new ClientOrderService(new StorehouseService(new StorehouseRepository()), new ClientOrderRepository());

            IClientOrderServiceForBooker serviceForBooker = (IClientOrderServiceForBooker)serviceForClientManager;

            serviceForClientManager.AddNotPaidOrder(order1);
            serviceForClientManager.AddNotPaidOrder(order2);

            serviceForBooker.ConfirmPaymentNotPaidClientOrder(1);
            serviceForBooker.ConfirmPaymentNotPaidClientOrder(2);

            IClientOrderServiceForStorekeeper serviceForStorekeeper =
                (IClientOrderServiceForStorekeeper)serviceForBooker;

            var order = serviceForStorekeeper.GetGiveOutClientOrder(1);
            Console.WriteLine("Заказ с ID:1 на выдачу");
            Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            Console.WriteLine();

            serviceForStorekeeper.ConfirmGiveOutClientOrder(1);
            Console.WriteLine("Заказ с ID:1 после подтверждения выдачи");
            order = serviceForStorekeeper.GetGiveOutClientOrder(1);
            if (order == null)
                Console.WriteLine("Заказ не найден");
            else
                Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            Console.WriteLine();
        }

        public static void TestCourier()
        {
            HomeAddress address = new HomeAddress();
            address.City = "Минск";
            address.Street = "Голубева";
            address.FlatNumber = "66";
            address.FloorNumber = "7";
            address.HomeNumber = "21";
            address.PavilionNumber = "-";
            address.PorchNumber = "2";

            ClientInformation info = new ClientInformation();
            //info.Address = address;
            info.Name = "Павел";
            info.Patronymic = "Викторович";
            info.Surname = "Сайков";
            info.EmailAddress = "1999pav@gmail.com";
            info.PhoneNumber = "+375333502637";

            ClientOrder order1 = new ClientOrder();
            order1.OrderDate = new DateTime(2010, 10, 11);
            order1.ClientInfo = info;
            order1.isDelivery = true;

            ClientOrder order2 = new ClientOrder();
            order2.OrderDate = new DateTime(2011, 12, 13);
            order2.ClientInfo = info;
            order2.isDelivery = true;

            IClientOrderServiceForClientManager serviceForClientManager =
                new ClientOrderService(new StorehouseService(new StorehouseRepository()), new ClientOrderRepository());

            IClientOrderServiceForBooker serviceForBooker = (IClientOrderServiceForBooker)serviceForClientManager;

            serviceForClientManager.AddNotPaidOrder(order1);
            serviceForClientManager.AddNotPaidOrder(order2);

            serviceForBooker.ConfirmPaymentNotPaidClientOrder(1);
            serviceForBooker.ConfirmPaymentNotPaidClientOrder(2);

            IClientOrderServiceForCourier serviceForCourier = (IClientOrderServiceForCourier)serviceForClientManager;

            var order = serviceForCourier.GetForDeliveryClientOrder();
            Console.WriteLine("Информация о заказе");
            Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("Информация о 2-ом заказе:");
            order = serviceForCourier.GetForDeliveryClientOrder();
            Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            Console.WriteLine("Информация о 3-ом заказе:");
            order = serviceForCourier.GetForDeliveryClientOrder();
            if (order != null)
                Console.WriteLine(order.OrderId + " " + order.Status + " " + order.OrderDate.ToShortDateString());
            else
                Console.WriteLine("Заказ отсутствует");
        }
    }*/
}
