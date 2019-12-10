using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddProductEditingPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private ClientOrder _order;
        private IClientManagerAddProductView _view;
        private IServiceForControlProductMovementInClientOrder _editor;
        private ProductCharacteristic _characteristic;

        public ClientManagerAddProductEditingPresenter(IKernel kernel, IClientManagerAddProductView view,
            IServiceForControlProductMovementInClientOrder editor, ClientOrder order, ProductCharacteristic characteristic)
        {
            this._kernel = kernel;
            this._order = order;
            this._editor = editor;
            this._view = view;
            this._characteristic = characteristic;

            this._view.SetProductCharacteristic(this._characteristic);
            this._view.AddProduct += OnButtonAddProductClick;
            this._view.Back += OnButtonCancelClick;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonAddProductClick()
        {
            int number = _view.GetNumberOfProduct();
            _editor.AddProduct(_order.OrderId, _characteristic.ProductId, number);
            OnButtonCancelClick();
        }

        private void OnButtonCancelClick()
        {
            new ClientManagerEditOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(), _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _order).Run();
        }
    }
}
