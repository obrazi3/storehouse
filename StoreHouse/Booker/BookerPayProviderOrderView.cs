using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class BookerPayProviderOrderView : Form, IBookerPayProviderOrderView
    {
        public event PayOrder PayOrder;
        public event Action Back;

        private readonly ApplicationContext _context;

        public BookerPayProviderOrderView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public int BankAccount { get => Int32.Parse(TextBoxBankAccount.Text); }
        public int PaymentSum { get => Int32.Parse(TextBoxSumPayment.Text); }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonPayClick(object o, EventArgs e)
        {
            LabelMessage.Text = "";
            if (TextBoxBankAccount.Text.Length != 0 && TextBoxSumPayment.Text.Length != 0)
            {
                if (PayOrder.Invoke())
                {
                    LabelMessage.Text = "Оплата проведена успешно. Статус заказа изменён автоматически.";
                    TextBoxBankAccount.Clear();
                    TextBoxSumPayment.Clear();
                }
                else
                {
                    LabelMessage.Text =
                        "Не удалось осуществить оплату. Проверьте правильность данных или повторите попытку позже.";
                }
            }
            else
            {
                LabelMessage.Text = "Введите необходимые данные, а затем осуществите оплату.";
            }
        }
    }
}
