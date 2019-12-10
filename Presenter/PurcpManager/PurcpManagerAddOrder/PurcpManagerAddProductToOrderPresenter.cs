using Model;
using Ninject;
//using View;

namespace Presenter
{
    public class PurcpManagerAddProductToOrderPresenter : IPresenter
    {
        private readonly IPurcpManagerAddProductInOrderView _view;
        private readonly IKernel _kernel;
        private ProductProviderOrder _order;

        public PurcpManagerAddProductToOrderPresenter(IPurcpManagerAddProductInOrderView view, IKernel kernel,
            ProductProviderOrder order)
        {
            this._view = view;
            this._kernel = kernel;
            this._order = order;

            this._view.AddProduct += OnButtonAddProductClick;
            this._view.Back += OnButtonCancelClick;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonCancelClick()
        {
            new PurcpManagerAddOrderFirstStepPresenter(_kernel.Get<IPurcpManagerAddOrderFirstStepView>(), _kernel, _order)
                .Run();
            _view.Close();
            //TO-DO
            //Ninject
        }

        private void OnButtonAddProductClick()
        {
            ProductFromLot product = new ProductFromLot();
            product.Lot.ProductionDate = _view.ProductionDate;
            product.Lot.QuantityProduct = _view.QuantityProduct;
            product.Measure = _view.Measure;
            product.Price = _view.Price;
            product.ExpirationDate = _view.ExpirationDate;
            product.ProduceCountry = _view.ProduceCountry;
            product.ProductCategory = _view.ProductCategory;
            product.ProductGroup = _view.ProductGroup;
            product.ProductName = _view.ProductName;

            _order.AddProduct(product);

            new PurcpManagerAddOrderSecondStepPresenter(_kernel.Get<IPurcpManagerAddOrderSecondStepView>(),
                _kernel.Get<IDeliveryOrderServiceForPurcpManager>(), _kernel, _order).Run();
            _view.Close();
            //TO-DO
            //Ninject
        }
    }
}
