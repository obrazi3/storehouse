using System;

namespace Presenter
{
    public interface ICourierView : IView
    {
        //Получить информацию о заказе
        event Action GetInfoOrder;
    }
}
