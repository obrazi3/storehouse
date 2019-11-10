using System;

namespace Presenter
{
    public interface IClientManagerView : IView
    {
        event Action addOrder;
        event Action lookOrder;
    }
}
