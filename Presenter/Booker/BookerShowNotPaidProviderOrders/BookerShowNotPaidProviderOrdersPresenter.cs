using Model;
using Ninject;

namespace Presenter
{
    public class BookerShowNotPaidProviderOrdersPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IDeliveryOrderServiceForBooker _model;
        private IBookerShowNotPaidProviderOrdersView _view;

        public BookerShowNotPaidProviderOrdersPresenter(IKernel kernel, IDeliveryOrderServiceForBooker model,
            IBookerShowNotPaidProviderOrdersView view)
        {
            this._kernel = kernel;
            this._model = model;
            this._view = view;

            this._view.Back += OnButtonBackClick;
            this._view.ShowOrders(this._model.GetListNotPaidProviderOrders());
        }


        public void Run()
        {
            _view.Show();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<BookerPresenter>().Run();
            _view.Close();
        }
    }
}
