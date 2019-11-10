using System;

namespace Presenter
{
    public interface IClientManagerAddOrderView : IView, IBack
    {
        event Action NextStep;

        string GetName();
        void SetName(string name);
        string GetSurname();
        void SetSurname(string surname);
        string GetPatronymic();
        void SetPatronymic(string patronymic);
        string GetCity();
        void SetCity(string city);
        string GetStreet();
        void SetStreet(string street);
        string GetPavilion();
        void SetPavilion(string pavilion);
        string GetHouseNumber();
        void SetHouseNumber(string houseNumber);
        string GetFlat();
        void SetFlat(string flat);
        string GetPhoneNumber();
        void SetPhoneNumber(string phoneNumber);
        string GetEmailAddress();
        void SetEmailAddress(string emailAddress);
    }
}
