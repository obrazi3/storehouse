using System;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderSecondStepView _view;
        private ClientOrder _order;

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view,
            ClientOrder order)
        {
            _kernel = kernel;
            _view = view;
            _order = order;

            _view.AddProduct += AddProduct;
            _view.Back += Back;
            _view.SetProductBasket(_order.GetProductList());
            _view.SetOrderPrice(order.TotalCost);
            //_view.Cancel += () => Cancel();
        }

        private void Cancel()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        private void Back()
        {
            new ClientManagerAddOrderFirstStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderFirstStepView>(),
                _order).Run();
            _view.Close();
        }

        private void AddProduct()
        {
            new ClientManagerProductCatalogPresenter(_kernel.Get<IClientManagerProductCatalogView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(), _kernel, _order).Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
