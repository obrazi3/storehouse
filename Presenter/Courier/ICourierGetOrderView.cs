using System;
using Model;

namespace Presenter
{
    public interface ICourierGetOrderView : IView, IBack
    {
        event Action ConfirmDelivery;
        void SetOrderInfo(ClientOrder order);
        void ShowMessageSuccessConfirm();
    }
}
