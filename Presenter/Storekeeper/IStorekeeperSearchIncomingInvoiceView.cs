using System;
using Model;

namespace Presenter
{
    public interface IStorekeeperSearchIncomingInvoiceView :IBack,IView
    {
        event Action ConfirmGettingOrder;
        event Action SearchOrder;
        int GetOrderNumber();
        void SetOrder(ProductProviderOrder order);
    }
}
