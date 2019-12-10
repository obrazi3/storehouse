using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderProductCatalogPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientOrderServiceForClientManager _model;
        private IClientManagerProductCatalogView _view;
        private ClientOrder _order;

        public ClientManagerEditOrderProductCatalogPresenter(IKernel kernel, IClientManagerProductCatalogView view,
            IClientOrderServiceForClientManager model, ClientOrder order)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;
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
            new ClientManagerEditOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(), _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
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
