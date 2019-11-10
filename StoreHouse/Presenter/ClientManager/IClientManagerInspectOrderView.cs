using System;

namespace Presenter
{
    interface IClientManagerInspectOrderView : IView, IBack
    {
        event Action CancelOrder;
        event Action EditOrder;
        event Action SearchOrder;
    }
}
