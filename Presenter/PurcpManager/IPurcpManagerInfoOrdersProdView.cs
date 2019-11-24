using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presenter
{
    public interface IPurcpManagerInfoOrderProdView : IView, IBack
    {
        event Action RemoveOrders;

        void AddOrder(FlowLayoutPanel order, int orderNumber, CheckBox box);
        Dictionary<int, CheckBox> GetDictionaryBoxes();
    }
}
