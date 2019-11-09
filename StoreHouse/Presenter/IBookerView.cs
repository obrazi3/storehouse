﻿using System;

namespace Presenter
{
    public interface IBookerView : IView
    {
        //Проверка платежей клиентов
        event Action CheckClientPayment;
        //Оплата заказа у поставщиков
        event Action PayOrderProvider;
        //Формирование расходной накладной
    }
}
