using System;

namespace Presenter
{
    public interface ISignInView : IView
    {
        event Action OpenClientManager;
        event Action OpenBooker;
        event Action OpentStorekeeper;
        event Action OpenPurcрManager;
        event Action OpenCourier;
    }
}
