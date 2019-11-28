using Model;
using Ninject;

namespace Presenter
{
    public class BookerPayProviderOrderPresenter : IPresenter
    {
        private IBookerPayProviderOrderView view;
        private IDeliveryOrderServiceForBooker model;
        private readonly IKernel kernel;

        public BookerPayProviderOrderPresenter(IBookerPayProviderOrderView _view, IDeliveryOrderServiceForBooker _model,
            IKernel _kernel)
        {
            view = _view;
            model = _model;
            kernel = _kernel;

            view.PayOrder += OnButtonPayOrderClick;
            view.Back += OnButtonBackClick;
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

        private bool OnButtonPayOrderClick()
        {
            int bankAccount = view.BankAccount;
            int sum = view.PaymentSum;
            return model.PayDeliveryFromProvider(bankAccount, sum);
        }
    }
}
