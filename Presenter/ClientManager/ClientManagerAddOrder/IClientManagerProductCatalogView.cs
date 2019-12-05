using System;
using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IClientManagerProductCatalogView : IBack, IView
    {
        event Action ProductChecked;
        void SetCatalog(SortedDictionary<string, SortedDictionary<string, List<ProductCharacteristic>>> productCatalog);
        ProductCharacteristic GetProductCharacteristic();
    }
}
