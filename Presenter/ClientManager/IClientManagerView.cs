using System;

namespace Presenter
{
    public interface IClientManagerView : IView, IBack
    {
        event Action addOrder;
        event Action lookOrder;
    }
}
