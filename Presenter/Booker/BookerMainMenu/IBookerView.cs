using System;

namespace Presenter
{
    public interface IBookerView : IView, IBack
    {
        //Проверка платежей клиентов
        event Action CheckClientPayment;

        //Оплата заказа у поставщиков
        event Action PayOrderProvider;
        event Action ShowNotPaidClientOrders;
        event Action ShowNotPaidDeliveriesFromProvider;
    }
}
