using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IPurcpManagerAddOrderSecondStepView _view;
        private readonly IDeliveryOrderServiceForPurcpManager _model;
        private ProductProviderOrder _order;

        public PurcpManagerAddOrderSecondStepPresenter(IPurcpManagerAddOrderSecondStepView view,
            IDeliveryOrderServiceForPurcpManager model, IKernel kernel,
            ProductProviderOrder order)
        {
            this._kernel = kernel;
            this._model = model;
            this._view = view;
            this._order = order;

            this._view.SetNumberProductsInOrder(this._order.GetListProducts().Count);
            this._view.Back += OnButtonBackClick;
            this._view.ConfirmOrder += OnButtonConfirmOrderClick;
            this._view.AddProduct += OnButtonAddProductClick;
        }

        public void Run()
        {
            _view.Show();
        }

        private void OnButtonBackClick()
        {
            new PurcpManagerAddOrderFirstStepPresenter(_kernel.Get<IPurcpManagerAddOrderFirstStepView>(), _kernel, _order)
                .Run();
            _view.Close();
            //TO-DO
            //Ninject
        }

        private void OnButtonConfirmOrderClick()
        {
            _model.AddNotPaidOrder(_order);
            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }

        private void OnButtonAddProductClick()
        {
            new PurcpManagerAddProductToOrderPresenter(_kernel.Get<IPurcpManagerAddProductInOrderView>(),_kernel,_order).Run();
            _view.Close();
            //TO-DO
            //Ninject
        }
    }
}
