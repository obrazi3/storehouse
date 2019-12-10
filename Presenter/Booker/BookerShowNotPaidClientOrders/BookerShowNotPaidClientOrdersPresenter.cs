using Model;
using Ninject;

namespace Presenter
{
    public class BookerShowNotPaidClientOrdersPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IBookerShowNotPaidClientOrdersView _view;
        private IClientOrderServiceForBooker _model;

        public BookerShowNotPaidClientOrdersPresenter(IKernel kernel, IBookerShowNotPaidClientOrdersView view,
            IClientOrderServiceForBooker model)
        {
            this._kernel = kernel;
            this._view = view;
            this._model = model;

            this._view.Back += OnButtonBackClick;
            this._view.ShowOrders(this._model.GetListNotPaidClientOrders());
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
