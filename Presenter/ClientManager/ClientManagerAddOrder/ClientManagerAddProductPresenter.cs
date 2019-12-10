using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddProductPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientManagerAddProductView _view;
        private IServiceForControlProductMovementInClientOrder _model;
        private ClientOrder _order;
        private ProductCharacteristic _characteristic;

        public ClientManagerAddProductPresenter(IKernel kernel, IServiceForControlProductMovementInClientOrder model,
            IClientManagerAddProductView view, ClientOrder order, ProductCharacteristic characteristic)
        {
            this._model = model;
            this._kernel = kernel;
            this._view = view;
            this._order = order;
            this._characteristic = characteristic;

            this._view.Back += OnButtonCancelClick;
            this._view.AddProduct += OnButtonAddProductClick;
            this._view.SetProductCharacteristic(this._characteristic);
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonAddProductClick()
        {
            int number = _view.GetNumberOfProduct();
            _model.AddProduct(_order.OrderId, _characteristic.ProductId, number);
            OnButtonCancelClick();
        }

        private void OnButtonCancelClick()
        {
            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(),
                _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _order).Run();
            _view.Close();
        }
    }
}
