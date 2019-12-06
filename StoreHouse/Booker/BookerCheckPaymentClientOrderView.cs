using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class BookerCheckPaymentClientOrderView : Form, IBookerCheckPaymentClientOrderView
    {
        public event Action Back;
        public event Action CheckPayment;


        private readonly ApplicationContext context;

        public BookerCheckPaymentClientOrderView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public int GetClientOrderNumber()
        {
            return Int32.Parse(TextBoxClientOrderNumber.Text);
        }

        public int GetClientOrderCost()
        {
            return Int32.Parse(TextBoxSumPayment.Text);
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonCheckOrderClick(object o, EventArgs e)
        {
            if (TextBoxClientOrderNumber.Text.Length != 0 && TextBoxSumPayment.Text.Length != 0)
            {
                CheckPayment?.Invoke();
                return;
            }

            if (TextBoxClientOrderNumber.Text.Length == 0)
            {
                MessageBox.Show("Введите номер заказа клиента и повторите попытку.", "Номер заказа");
                return;
            }

            if (TextBoxSumPayment.Text.Length == 0)
                MessageBox.Show("Введите стоимость заказа и повторите попытку.", "Стоимость ");
        }
    }
}
