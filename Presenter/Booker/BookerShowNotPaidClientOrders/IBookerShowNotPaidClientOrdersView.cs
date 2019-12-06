using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IBookerShowNotPaidClientOrdersView : IBack, IView
    {
        void ShowOrders(List<ClientOrder> orders);
    }
}
