using System;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerProductCatalogPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private readonly IClientManagerProductCatalogView view;
        private readonly IClientOrderServiceForClientManager model;
        private ClientOrder order;

        public ClientManagerProductCatalogPresenter(IClientManagerProductCatalogView _view,
            IClientOrderServiceForClientManager _model, IKernel _kernel,
            ClientOrder _order)
        {
            model = _model;
            kernel = _kernel;
            view = _view;
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
            new ClientManagerAddOrderSecondStepPresenter(kernel, kernel.Get<IClientManagerAddOrderSecondStepView>(),
                kernel.Get<IClientOrderServiceForClientManager>(),
                kernel.Get<IServiceForControlProductMovementInClientOrder>(),
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
