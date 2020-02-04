using System;

namespace Presenter
{
    public interface IStorekeeperView : IView, IBack
    {
        //Поиск заказа клиента
        event Action SearchClientOrder;
        //Поиск поставки от поставщика
        event Action SearchProviderOrder;
        //Просмотреть список несформированных заказов клиентов
        event Action ShowListClientPurch;
        //Просмотреть список несформированных заказов для курьеров
        event Action ShowListCourierPurch;
    }
}
