using System;
using Model;

namespace Presenter
{
    public interface IStorekeeperSearchClientOrderView : IBack, IView
    {
        event Action Search;
        event Action ConfirmGiveOut;

        int GetOrderNumber();
        void SetOrderInfo(ClientOrder order);
        void ClearView();
    }
}
