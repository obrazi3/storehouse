namespace Test
{
    public class TestServiceForFilingClientOrder
    {
       /* public static void Main()
        {
            IServiceForFilingClientOrder service = new ServiceForFillingClientOrder(new ClientOrder());

            service.InitializeOrder();

            ProductFromLot product = new ProductFromLot();
            product.ProductName = "Берёзка";
            product.ProductGroup = "Конфеты";
            product.ProductCategory = "Кондитерские изделия";
            product.ProduceCountry = "Беларусь";
            product.Price = 15;
            product.Measure = new MeasureKilogram();
            product.ExpirationDate = 30;
            product.Lot.ProductionDate = new DateTime(2019, 11, 6);
            product.Lot.QuantityProduct = 25;
            product.ProductId = 1;

            ProductFromLot product2 = new ProductFromLot();
            product2.ProductName = "Аннушка";
            product2.ProductGroup = "Конфеты";
            product2.ProductCategory = "Кондитерские изделия";
            product2.ProduceCountry = "Беларусь";
            product2.Price = 15;
            product2.Measure = new MeasureKilogram();
            product2.ExpirationDate = 30;
            LotInformation lot2 = new LotInformation();
            product2.Lot.ProductionDate = new DateTime(2019, 11, 7);
            product2.Lot.QuantityProduct = 10;
            product2.ProductId = 2;

            service.AddProduct(product);
            service.AddProduct(product2);

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

            service.AddClientInfo(info);

            var order = service.GetClientOrder();
            System.Console.WriteLine("Содержимое заказа:");
            System.Console.WriteLine("Дата заказа: " + order.OrderDate.ToShortDateString());
            System.Console.WriteLine("Статус заказа: " + order.Status);
            System.Console.WriteLine("Стоимость заказа: " + order.TotalCost);

            var inf = order.ClientInfo;
            System.Console.WriteLine("Информация о клиенте:");
            System.Console.WriteLine("Фамилия: " + inf.Surname + " Имя: " + inf.Name + " Отчество: " + inf.Patronymic);

            var addr = order.ClientInfo.Address;
            System.Console.WriteLine("Адрес:");
            System.Console.WriteLine(addr.City + " " + addr.Street + " " + addr.HomeNumber + " " + addr.PavilionNumber +
                                     " " + addr.FlatNumber + " " + addr.PorchNumber + " " + addr.FloorNumber);

            var products = order.GetProductList();
            System.Console.WriteLine("Список покупок:");
            foreach (var prod in products)
            {
                System.Console.WriteLine(prod.ProductName + " " + prod.ProductId);
            }

            service.RemoveProduct(1);
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("После удаления продукта с ID:1");
            products = order.GetProductList();
            System.Console.WriteLine("Список покупок:");
            foreach (var prod in products)
            {
                System.Console.WriteLine(prod.ProductName + " " + prod.ProductId);
            }
        }*/
    }
}
