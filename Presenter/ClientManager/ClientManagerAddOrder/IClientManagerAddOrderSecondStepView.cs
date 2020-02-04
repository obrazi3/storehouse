using System;
using System.Collections.Generic;
using Model;

namespace Presenter
{
    public interface IClientManagerAddOrderSecondStepView : IBack, IView
    {
        event Action AddProduct;
        event Action ConfirmOrder;
        event Action RemoveProducts;
        void SetFromName(string name);
        void SetProductBasket(List<ProductFromLot> products);
        void SetOrderPrice(int cost);
        List<int> GetIdProductsForDelete();
    }
}
