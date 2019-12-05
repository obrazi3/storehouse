using System;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddProductPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IClientManagerAddProductView view;
        private IServiceForFilingClientOrder model;
        private ClientOrder order;
        private ProductCharacteristic characteristic;

        public ClientManagerAddProductPresenter(IKernel _kernel, IServiceForFilingClientOrder _model,
            IClientManagerAddProductView _view, ClientOrder _order, ProductCharacteristic _characteristic)
        {
            model = _model;
            model.SetClientOrder(_order);
            kernel = _kernel;
            view = _view;
            order = _order;
            characteristic = _characteristic;

            view.Back += OnButtonCancelClick;
            view.AddProduct += OnButtonAddProductClick;
            view.SetProductCharacteristic(characteristic);
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonAddProductClick()
        {
            int number = view.GetNumberOfProduct();
            model.AddProduct(characteristic.ProductId, number);
            OnButtonCancelClick();
        }

        private void OnButtonCancelClick()
        {
            new ClientManagerAddOrderSecondStepPresenter(kernel, kernel.Get<IClientManagerAddOrderSecondStepView>(),
                kernel.Get<IClientOrderServiceForClientManager>(),
                order).Run();
            view.Close();
        }
    }
}
