using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddProductEditingPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private ClientOrder order;
        private IClientManagerAddProductView view;
        private IServiceForControlProductMovementInClientOrder editor;
        private ProductCharacteristic characteristic;

        public ClientManagerAddProductEditingPresenter(IKernel _kernel, IClientManagerAddProductView _view,
            IServiceForControlProductMovementInClientOrder _editor, ClientOrder _order, ProductCharacteristic _characteristic)
        {
            kernel = _kernel;
            order = _order;
            editor = _editor;
            view = _view;
            characteristic = _characteristic;

            view.SetProductCharacteristic(characteristic);
            view.AddProduct += OnButtonAddProductClick;
            view.Back += OnButtonCancelClick;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonAddProductClick()
        {
            int number = view.GetNumberOfProduct();
            editor.AddProduct(order.OrderId, characteristic.ProductId, number);
            OnButtonCancelClick();
        }

        private void OnButtonCancelClick()
        {
            new ClientManagerEditOrderSecondStepPresenter(kernel, kernel.Get<IClientManagerAddOrderSecondStepView>(),
                kernel.Get<IClientOrderServiceForClientManager>(), kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                order).Run();
        }
    }
}
