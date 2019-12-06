using System;

namespace Presenter
{
    public interface IBookerCheckPaymentClientOrderView : IView, IBack
    {
        int GetClientOrderNumber();
        int GetClientOrderCost();
        event Action CheckPayment;
    }
}
