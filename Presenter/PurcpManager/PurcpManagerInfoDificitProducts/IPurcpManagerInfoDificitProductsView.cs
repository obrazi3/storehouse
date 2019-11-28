using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IPurcpManagerInfoDificitProductsView : IView, IBack
    {
        void SetInformation(List<StorehouseProduct> list);
    }
}
