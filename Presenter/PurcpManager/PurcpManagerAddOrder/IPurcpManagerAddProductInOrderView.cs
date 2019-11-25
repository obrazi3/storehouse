using System;

namespace Presenter
{
    public interface IPurcpManagerAddProductInOrderView:IView, IBack
    {
        event Action AddProduct;
    }
}
