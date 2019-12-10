using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerEditOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IClientOrderServiceForClientManager model;
        private IServiceForControlProductMovementInClientOrder editor;
        private IClientManagerAddOrderSecondStepView view;
        private ClientOrder order;

        public ClientManagerEditOrderSecondStepPresenter(IKernel _kernel, IClientManagerAddOrderSecondStepView _view,
            IClientOrderServiceForClientManager _model, IServiceForControlProductMovementInClientOrder _editor, ClientOrder _order)
        {
            kernel = _kernel;
            view = _view;
            model = _model;
            order = _order;
            editor = _editor;

            view.SetProductBasket(order.GetCloneProductList());

            view.Back += Back;
            view.RemoveProducts += RemoveProducts;
            view.ConfirmOrder += ConfirmOrder;
            view.AddProduct += AddProduct;
        }

        public void Run()
        {
            view.Show();
        }

        private void Back()
        {
            new ClientManagerEditOrderFirstStepPresenter(kernel, kernel.Get<IClientManagerAddOrderFirstStepView>(),
                kernel.Get<IServiceForControlProductMovementInClientOrder>(),
                order).Run();
            view.Close();
        }

        private void AddProduct()
        {
            new ClientManagerEditOrderProductCatalogPresenter(kernel, kernel.Get<IClientManagerProductCatalogView>(),
                    kernel.Get<IClientOrderServiceForClientManager>(),
                    order)
                .Run();
            view.Close();
        }

        private void RemoveProducts()
        {
            var productsId = view.GetIdProductsForDelete();
            foreach (var prod in productsId)
            {
                editor.RemoveProduct(order.OrderId, prod);
            }

            view.SetProductBasket(order.GetCloneProductList());
            view.SetOrderPrice(order.TotalCost);
        }

        private void ConfirmOrder()
        {
            model.RemoveNotPaidOrder(order.OrderId);
            model.AddNotPaidOrder(order);
            editor.ConfirmCompletionEditing(order.OrderId);
            MessageBox.Show("Заказ успешно отредактирован.", "Заказ отредактирован");
            new ClientManagerInspectOrderPresenter(kernel, kernel.Get<IClientManagerInspectOrderView>(),
                kernel.Get<IClientOrderServiceForClientManager>(), order).Run();
            view.Close();
        }
    }
}
