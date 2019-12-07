using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderProductCatalogPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IClientOrderServiceForClientManager model;
        private IClientManagerProductCatalogView view;
        private ClientOrder order;

        public ClientManagerEditOrderProductCatalogPresenter(IKernel _kernel, IClientManagerProductCatalogView _view,
            IClientOrderServiceForClientManager _model, ClientOrder _order)
        {
            kernel = _kernel;
            view = _view;
            model = _model;
            order = _order;
            
            view.Back += OnButtonAddProducts;
            view.ProductChecked += CheckedProduct;

            view.SetCatalog(model.GetProductCatalog());
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonAddProducts()
        {
            new ClientManagerEditOrderSecondStepPresenter(kernel, kernel.Get<IClientManagerAddOrderSecondStepView>(),
                kernel.Get<IClientOrderServiceForClientManager>(), kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                order).Run();
            view.Close();
        }

        private void CheckedProduct()
        {
            var characteristic = view.GetProductCharacteristic();
            new ClientManagerAddProductPresenter(kernel, kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                kernel.Get<IClientManagerAddProductView>(), order,
                characteristic).Run();
            view.Close();
        }
    }
}
