using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface ICourierGetOrderView : IView, IBack
    {
        event Action ConfirmDelivery;
        event Action InspectOrder;
    }
}
