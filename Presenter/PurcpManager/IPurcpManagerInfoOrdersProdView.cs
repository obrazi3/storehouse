using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace Presenter
{
    public interface IPurcpManagerInfoOrderProdView : IView, IBack
    {
        event Action RemoveOrders;

        void AddOrders(List<ProductProviderOrder> orders);
        Dictionary<int, CheckBox> GetDictionaryBoxes();
    }
}
