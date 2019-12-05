using System;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class ClientManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderSecondStepView _view;
        private readonly IClientOrderServiceForClientManager _model;
        private ClientOrder _order;

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view,IClientOrderServiceForClientManager model,
            ClientOrder order)
        {
            _kernel = kernel;
            _view = view;
            _order = order;
            _model = model;
            

            _view.AddProduct += AddProduct;
            _view.Back += Back;
            _view.RemoveProducts += RemoveProducts;
            _view.ConfirmOrder += ConfirmOrder;
            
            _view.SetProductBasket(_order.GetProductList());
            _view.SetOrderPrice(order.TotalCost);
        }

        public void Run()
        {
            _view.Show();
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

        private void RemoveProducts()
        {
            var productsId = _view.GetIdProductsForDelete();
            var service = _kernel.Get<IServiceForFilingClientOrder>();
            service.SetClientOrder(_order);
            foreach (var prod in productsId)
            {
                service.RemoveProduct(prod);
            }

            _view.SetProductBasket(_order.GetProductList());
            _view.SetOrderPrice(_order.TotalCost);

        }

        private void ConfirmOrder()
        {
            _model.AddNotPaidOrder(_order);
            MessageBox.Show("Заказ успешно добавлен в складскую систему.", "Заказ добавлен");
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

    }
}
