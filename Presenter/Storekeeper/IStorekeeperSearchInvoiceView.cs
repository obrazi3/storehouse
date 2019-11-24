using System;

namespace Presenter
{
    public interface IStorekeeperSearchInvoiceView : IView, ISetInfoInvoiceForSearchInvoice, IBack
    {
        //Поиск накладной по номеру
        event Search Search;
        //Отображение содержимого накладной
        event Action ShowInvoiceContent;
        //Подтверждение приёма/передачи заказа от/к поставщика/клиенту
        event Action ConfirmAdmission;
        string GetNumberInvoice();
    }

    public delegate bool Search();
}
