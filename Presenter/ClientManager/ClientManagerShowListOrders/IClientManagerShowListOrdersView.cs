using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IClientManagerShowListOrdersView : IView, IBack
    {
        void SetInformation(List<ClientOrder> orders);
    }
}
