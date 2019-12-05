using System;

namespace Presenter
{
    public interface IClientManagerView : IView, IBack
    {
        event Action AddOrder;
        event Action LookOrder;
    }
}
