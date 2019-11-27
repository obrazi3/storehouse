using System;
using Model;

namespace Presenter
{
    public interface IPurcpManagerInfoProviderView : IView, IBack
    {
        event Action SearchProvider;
        void SetInfoProvider(ProductProvider provider);
        int GetProviderNumber();
    }
}
