using System;
using Model;

namespace Presenter
{
    public interface IClientManagerAddProductView : IView, IBack
    {
        event Action AddProduct;
        void SetProductCharacteristic(ProductCharacteristic characteristic);
        int GetNumberOfProduct();
        int MaximumProduct { get; set; }
    }
}
