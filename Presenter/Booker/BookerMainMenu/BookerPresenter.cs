using Ninject;

namespace Presenter
{
    public class BookerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IBookerView _view;

        public BookerPresenter(IKernel kernel, IBookerView view)
        {
            _kernel = kernel;
            _view = view;

            _view.Back += OnButtonBackClick;
            _view.ShowNotPaidDeliveriesFromProvider += OnButtonShowNotPaidDeliveriesFromProvidersClick;
            _view.PayOrderProvider += OnButtonPayProviderOrderClick;
            _view.ShowNotPaidClientOrders += OnButtonShowNotPaidClientOrdersClick;
        }


        public void Run()
        {
            _view.Show();
        }

        private void OnButtonBackClick()
        {
            _kernel.Get<SignInPresenter>().Run();
            _view.Close();
        }

        private void OnButtonShowNotPaidDeliveriesFromProvidersClick()
        {
            _kernel.Get<BookerShowNotPaidProviderOrdersPresenter>().Run();
            _view.Close();
        }

        private void OnButtonPayProviderOrderClick()
        {
            _kernel.Get<BookerPayProviderOrderPresenter>().Run();
            _view.Close();
        }

        private void OnButtonShowNotPaidClientOrdersClick()
        {
            _kernel.Get<BookerShowNotPaidClientOrdersPresenter>().Run();
            _view.Close();
        }
    }
}
