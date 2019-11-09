using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    interface IClientManagerAddOrderSecondStepView : IBack, IView
    {
        event Action AddProduct;
        event Action Cancel;
    }
}
