using Model;
using Ninject;

namespace Presenter
{
    public class StorekeeperSearchProviderOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStorekeeperSearchProviderOrderView _view;
        private readonly IDeliveryOrderServiceForStorekeeper _model;

        public StorekeeperSearchProviderOrderPresenter(IKernel kernel, IStorekeeperSearchProviderOrderView view,
            IDeliveryOrderServiceForStorekeeper model)
        {
            _kernel = kernel;
            _view = view;
            _model = model;

            _view.SearchOrder += SearchInvoice;
            _view.ConfirmGettingOrder += ConfirmGettingOrder;
            _view.Back += Back;
        }

        private void SearchInvoice()
        {
            var order = _model.GetProviderPaidOrder(_view.GetOrderNumberToSearch());
            _view.SetOrder(order);
        }

        private void ConfirmGettingOrder()
        {
            _model.ConfirmProviderPaidOrder(_view.GetOrderNumberToConfirm());
        }

        private void Back()
        {
            _kernel.Get<StorekeeperPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
