using System;

namespace Presenter
{
    public interface ICourierView : IView, IBack
    {
        //Получить информацию о заказе
        event Action GetInfoOrder;
    }
}
