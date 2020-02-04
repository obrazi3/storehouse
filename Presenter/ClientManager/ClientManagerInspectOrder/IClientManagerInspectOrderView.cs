using System;
using Model;

namespace Presenter
{
    public interface IClientManagerInspectOrderView : IView, IBack
    {
        event Action RemoveOrder;
        event Action EditOrder;
        event Action SearchOrder;
        void ClearView();
        int GetOrderNumber();
        void SetOrderInfo(ClientOrder order);
    }
}
