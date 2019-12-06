using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class BookerCheckPaymentClientOrderPresenter : IPresenter
    {
        private readonly IKernel kernel;
        private IBankForClientOrderService bank;
        private IBookerCheckPaymentClientOrderView view;
        private IClientOrderServiceForBooker model;

        public BookerCheckPaymentClientOrderPresenter(IKernel _kernel, IBankForClientOrderService _bank,
            IBookerCheckPaymentClientOrderView _view, IClientOrderServiceForBooker _model)
        {
            kernel = _kernel;
            bank = _bank;
            view = _view;
            model = _model;

            view.Back += OnButtonBackClick;
            view.CheckPayment += OnButtonCheckPayment;
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

        private void OnButtonCheckPayment()
        {
            if (model.GetNotPaidClientOrder(view.GetClientOrderNumber()) != null)
            {
                int cost = view.GetClientOrderCost();
                if (cost == model.GetNotPaidClientOrder(view.GetClientOrderNumber()).TotalCost)
                {
                    bool isPaid = bank.CheckPaymentByClient(view.GetClientOrderNumber());
                    if (isPaid)
                    {
                        model.ConfirmPaymentNotPaidClientOrder(view.GetClientOrderNumber());
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
