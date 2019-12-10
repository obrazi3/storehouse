using System;
using Model;

namespace Test
{
    public class TestClientOrderRepository
    {
          public static void Main()
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
            
            IClientOrderRepository rep = new ClientOrderRepository();

            ClientOrder order1 = new ClientOrder();
            order1.Status = StatusClientOrder.Paid;
            order1.OrderDate = new DateTime(2010, 10, 11);
            order1.OrderId = 1;
            order1.ClientInfo = info;

            ClientOrder order2 = new ClientOrder();
            order2.Status = StatusClientOrder.NotPaid;
            order2.OrderDate = new DateTime(2011, 12, 13);
            order2.OrderId = 2;
            order2.ClientInfo = info;

            rep.AddClientOrder(order1);
            rep.AddClientOrder(order2);

            Console.WriteLine("Все заказы:");
            var allOrder = rep.GetListAllOrders();
            foreach (var order in allOrder)
            {
                Console.WriteLine(order.Status + " " + order.OrderDate.ToShortDateString() + " ID:" + order.OrderId);
                order.OrderId = -1;
            }
            
            Console.WriteLine();
            Console.WriteLine("Все заказы после изменения значения поля в копии заказа:");
            allOrder = rep.GetListAllOrders();
            foreach (var order in allOrder)
            {
                Console.WriteLine(order.Status + " " + order.OrderDate.ToShortDateString() + " ID:" + order.OrderId);
            }
            
            
            
            Console.WriteLine();
            Console.WriteLine("Неоплаченные заказы:");
            var notPaidOrders = rep.GetListOrdersByStatus(StatusClientOrder.NotPaid);
            foreach (var order in notPaidOrders)
            {
                Console.WriteLine(order.Status + " " + order.OrderDate.ToShortDateString() + " ID:" + order.OrderId);
            }
            
            Console.WriteLine();
            Console.WriteLine("Оплаченне заказы:");
            var paidOrders = rep.GetListOrdersByStatus(StatusClientOrder.Paid);
            foreach (var order in paidOrders)
            {
                Console.WriteLine(order.Status + " " + order.OrderDate.ToShortDateString() + " ID:" + order.OrderId);
            }
            
            Console.WriteLine();
            Console.WriteLine("Все заказы после удаления заказа с ID:1");
            rep.RemoveClientOrder(1);
            allOrder = rep.GetListAllOrders();
            foreach (var order in allOrder)
            {
                Console.WriteLine(order.Status + " " + order.OrderDate.ToShortDateString() + " ID:" + order.OrderId);
            }
        }
    }
}
