namespace Presenter
{
    //Интерфейс предназначен для задания базовой информации о накладаной на графическом интерфейсе. Поиск осуществляет кладовищик.
    public interface ISetInfoInvoiceForSearchInvoice
    {
        //Задание номера накладной
        void SetNumberInvoice(string number);
        //Задание ФИО_заказчика/Название_организации
        void SetName(string name);
        //Задание суммарной стоимости заказа
        void SetCost(string cost);

    }
}
