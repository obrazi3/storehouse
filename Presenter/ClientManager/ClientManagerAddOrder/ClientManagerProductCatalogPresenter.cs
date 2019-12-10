using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerProductCatalogPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerProductCatalogView _view;
        private readonly IClientOrderServiceForClientManager _model;
        private ClientOrder _order;

        public ClientManagerProductCatalogPresenter(IClientManagerProductCatalogView view,
            IClientOrderServiceForClientManager model, IKernel kernel,
            ClientOrder order)
        {
            this._model = model;
            this._kernel = kernel;
            this._view = view;
            this._order = order;

            this._view.Back += OnButtonAddProducts;
            this._view.ProductChecked += CheckedProduct;
            this._view.SetCatalog(this._model.GetProductCatalog());
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonAddProducts()
        {
            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(),
                _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _order).Run();
            _view.Close();
        }

        private void CheckedProduct()
        {
            var characteristic = _view.GetProductCharacteristic();
            new ClientManagerAddProductPresenter(_kernel, _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _kernel.Get<IClientManagerAddProductView>(), _order,
                characteristic).Run();
            _view.Close();
        }
    }
}
