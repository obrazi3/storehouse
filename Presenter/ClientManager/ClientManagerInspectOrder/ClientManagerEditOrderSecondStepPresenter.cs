using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IClientOrderServiceForClientManager _model;
        private IServiceForControlProductMovementInClientOrder _editor;
        private IClientManagerAddOrderSecondStepView _view;
        private ClientOrder _order;

        public ClientManagerEditOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view,
            IClientOrderServiceForClientManager model, IServiceForControlProductMovementInClientOrder editor, ClientOrder order)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;
            this._order = order;
            this._editor = editor;

            this._view.SetProductBasket(this._order.GetCloneProductList());

            this._view.Back += Back;
            this._view.RemoveProducts += RemoveProducts;
            this._view.ConfirmOrder += ConfirmOrder;
            this._view.AddProduct += AddProduct;
        }

        public void Run()
        {
            _view.Show();
        }

        private void Back()
        {
            new ClientManagerEditOrderFirstStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderFirstStepView>(),
                _kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                _order).Run();
            _view.Close();
        }

        private void AddProduct()
        {
            new ClientManagerEditOrderProductCatalogPresenter(_kernel, _kernel.Get<IClientManagerProductCatalogView>(),
                    _kernel.Get<IClientOrderServiceForClientManager>(),
                    _order)
                .Run();
            _view.Close();
        }

        private void RemoveProducts()
        {
            var productsId = _view.GetIdProductsForDelete();
            foreach (var prod in productsId)
            {
                _editor.RemoveProduct(_order.OrderId, prod);
            }

            _view.SetProductBasket(_order.GetCloneProductList());
            _view.SetOrderPrice(_order.TotalCost);
        }

        private void ConfirmOrder()
        {
            _editor.ConfirmCompletionEditing(_order.OrderId);
            _model.RemoveNotPaidOrder(_order.OrderId);
            _model.AddNotPaidOrder(_order);
            MessageBox.Show("Заказ успешно отредактирован.", "Заказ отредактирован");
            new ClientManagerInspectOrderPresenter(_kernel, _kernel.Get<IClientManagerInspectOrderView>(),
                _kernel.Get<IClientOrderServiceForClientManager>(), _order).Run();
            _view.Close();
        }
    }
}
