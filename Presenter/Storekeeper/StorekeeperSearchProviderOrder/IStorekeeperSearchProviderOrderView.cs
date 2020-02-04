using System;
using Model;

namespace Presenter
{
    public interface IStorekeeperSearchProviderOrderView :IBack,IView
    {
        event Action ConfirmGettingOrder;
        event Action SearchOrder;
        int GetOrderNumberToSearch();
        int GetOrderNumberToConfirm();
        void SetOrder(ProductProviderOrder order);
    }
}
