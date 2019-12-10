namespace Model
{
    //Интерфейс, который предназначен для получения краткой информации о накладной, чтобы отобразить ее в окне
    //поиск накладной(StorekeeperSearchInvoiceView)
    public interface IBriefInvoiceInfo
    {
        //Номер накладной
        void SetNumber(string number);
        string GetNumber();
        //Имя заказчика/Название организации поставщика
        void SetName(string name);
        string GetName();
        //Стоимость
        void SetCost(string cost);
        string GetCost();

    }
}
