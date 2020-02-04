using System;

namespace Presenter
{
    public interface IPurcpManagerAddOrderSecondStepView : IView, IBack
    {
        event Action ConfirmOrder;
        event Action AddProduct;
        void SetNumberProductsInOrder(int number);
    }
}
