using Model;
using Ninject;

namespace Presenter
{
    public class PurcpManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private readonly IPurcpManagerAddOrderSecondStepView view;
        private readonly IDeliveryOrderServiceForPurcpManager model;
        private ProductProviderOrder order;

        public PurcpManagerAddOrderSecondStepPresenter(IPurcpManagerAddOrderSecondStepView _view,
            IDeliveryOrderServiceForPurcpManager _model, IKernel _kernel,
            ProductProviderOrder _order)
        {
            kernel = _kernel;
            model = model;
            view = _view;
            order = _order;

            view.SetNumberProductsInOrder(order.GetListProducts().Count);
            view.Back += OnButtonBackClick;
            view.ConfirmOrder += OnButtonConfirmOrderClick;
            view.AddProduct += OnButtonAddProductClick;
        }

        public void Run()
        {
            view.Show();
        }

        private void OnButtonBackClick()
        {
            new PurcpManagerAddOrderFirstStepPresenter(kernel.Get<IPurcpManagerAddOrderFirstStepView>(), kernel, order)
                .Run();
            view.Close();
            //TO-DO
        }

        private void OnButtonConfirmOrderClick()
        {
            model.AddNotPaidOrder(order);
            kernel.Get<PurcpManagerPresenter>().Run();
            view.Close();
        }

        private void OnButtonAddProductClick()
        {
            //TO-DO
        }
    }
}
