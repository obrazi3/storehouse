using System;

namespace Presenter
{
    public interface IPurcpManagerRemoveProviderView: IView, IBack
    {
        event Action RemoveProvider;
        int GetProviderId();
    }
}
