using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IBookerShowNotPaidProviderOrdersView : IBack, IView
    {
        void ShowOrders(List<ProductProviderOrder> list);
    }
}
