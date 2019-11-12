using System;

namespace Presenter
{
    public interface IClientManagerInspectOrderView : IView, IBack
    {
        event Action CancelOrder;
        event Action EditOrder;
        event Action SearchOrder;
    }
}
