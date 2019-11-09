using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
   public interface ICourierView:IView
    {
        //Получить информацию о заказе
        event Action GetInfoOrder;
    }
}
