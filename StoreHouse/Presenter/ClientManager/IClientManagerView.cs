using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IClientManagerView : IView
    {
        event Action addOrder;
        event Action lookOrder;
    }
}
