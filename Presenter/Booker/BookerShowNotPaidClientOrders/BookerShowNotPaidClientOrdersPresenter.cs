using Model;
using Ninject;

namespace Presenter
{
    public class BookerShowNotPaidClientOrdersPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IBookerShowNotPaidClientOrdersView view;
        private IClientOrderServiceForBooker model;

        public BookerShowNotPaidClientOrdersPresenter(IKernel _kernel, IBookerShowNotPaidClientOrdersView _view,
            IClientOrderServiceForBooker _model)
        {
            kernel = _kernel;
            view = _view;
            model = _model;

            view.Back += OnButtonBackClick;
            view.ShowOrders(model.GetListNotPaidClientOrders());
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
