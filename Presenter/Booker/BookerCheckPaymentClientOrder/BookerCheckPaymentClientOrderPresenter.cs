using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class BookerCheckPaymentClientOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private IBankForClientOrderService _bank;
        private IBookerCheckPaymentClientOrderView _view;
        private IClientOrderServiceForBooker _model;

        public BookerCheckPaymentClientOrderPresenter(IKernel kernel, IBankForClientOrderService bank,
            IBookerCheckPaymentClientOrderView view, IClientOrderServiceForBooker model)
        {
            this._kernel = kernel;
            this._bank = bank;
            this._view = view;
            this._model = model;

            this._view.Back += OnButtonBackClick;
            this._view.CheckPayment += OnButtonCheckPayment;
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

        private void OnButtonCheckPayment()
        {
            if (_model.GetNotPaidClientOrder(_view.GetClientOrderNumber()) != null)
            {
                int cost = _view.GetClientOrderCost();
                if (cost == _model.GetNotPaidClientOrder(_view.GetClientOrderNumber()).TotalCost)
                {
                    bool isPaid = _bank.CheckPaymentByClient(_view.GetClientOrderNumber());
                    if (isPaid)
                    {
                        _model.ConfirmPaymentNotPaidClientOrder(_view.GetClientOrderNumber());
                        MessageBox.Show("Клиент совершил оплату заказа. Статус заказа изменён автоматически.",
                            "Оплата произведена");
                    }
                    else
                        MessageBox.Show("Заказ не был оплачен клиентом.", "Заказ не оплачен");
                }
                else
                    MessageBox.Show("Неправильно введена сумма заказа. Исправьте значение и повторите попытку.",
                        "Неверная сумма");
            }
            else
                MessageBox.Show(
                    "Заказ с таким номером отсутствует в базе заказов. Проверьте введенные данные и повторите попытку.",
                    "Неверный идентификатор заказа");
        }
    }
}
