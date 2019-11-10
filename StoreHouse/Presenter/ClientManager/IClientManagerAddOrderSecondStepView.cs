using System;

namespace Presenter
{
    public interface IClientManagerAddOrderSecondStepView : IBack, IView
    {
        event Action AddProduct;
        event Action Cancel;
    }
}
