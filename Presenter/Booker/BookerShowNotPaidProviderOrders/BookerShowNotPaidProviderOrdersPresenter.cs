using Model;
using Ninject;

namespace Presenter
{
    public class BookerShowNotPaidProviderOrdersPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IDeliveryOrderServiceForBooker model;
        private IBookerShowNotPaidProviderOrdersView view;

        public BookerShowNotPaidProviderOrdersPresenter(IKernel _kernel, IDeliveryOrderServiceForBooker _model,
            IBookerShowNotPaidProviderOrdersView _view)
        {
            kernel = _kernel;
            model = _model;
            view = _view;

            view.Back += OnButtonBackClick;
            view.ShowOrders(model.GetListNotPaidProviderOrders());
        }


        public void Run()
        {
            view.Show();
        }

        private void OnButtonBackClick()
        {
            kernel.Get<BookerPresenter>().Run();
            view.Close();
        }
    }
}
