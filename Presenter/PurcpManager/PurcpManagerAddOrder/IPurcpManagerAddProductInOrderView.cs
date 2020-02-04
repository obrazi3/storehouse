using System;
using Model;

namespace Presenter
{
    public interface IPurcpManagerAddProductInOrderView:IView, IBack
    {
        event Action AddProduct;
        
        string ProductName { get;  }
        string ProductCategory { get; }
        string ProductGroup { get; }
        Measure Measure { get; }
        int ExpirationDate { get; }
        int Price { get; }
        string ProduceCountry { get; }
        DateTime ProductionDate { get; }
        int QuantityProduct { get; }
    }
}
