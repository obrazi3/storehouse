using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    interface IClientManagerInspectOrderView : IView, IBack
    {
        event Action CancelOrder;
        event Action EditOrder;
        event Action SearchOrder;
    }
}
