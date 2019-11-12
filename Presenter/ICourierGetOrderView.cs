using System;

namespace Presenter
{
    public interface ICourierGetOrderView : IView, IBack
    {
        event Action ConfirmDelivery;
        event Action InspectOrder;
    }
}
