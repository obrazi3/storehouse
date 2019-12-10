using Model;
using Ninject;

namespace Presenter
{
    public class BookerPayProviderOrderPresenter : IPresenter
    {
        private IBookerPayProviderOrderView _view;
        private IDeliveryOrderServiceForBooker _model;
        private readonly IKernel _kernel;

        public BookerPayProviderOrderPresenter(IBookerPayProviderOrderView view, IDeliveryOrderServiceForBooker model,
            IKernel kernel)
        {
            this._view = view;
            this._model = model;
            this._kernel = kernel;

            this._view.PayOrder += OnButtonPayOrderClick;
            this._view.Back += OnButtonBackClick;
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

        private bool OnButtonPayOrderClick()
        {
            int bankAccount = _view.BankAccount;
            int sum = _view.PaymentSum;
            return _model.PayDeliveryFromProvider(bankAccount, sum);
        }
    }
}
