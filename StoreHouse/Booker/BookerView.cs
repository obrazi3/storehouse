using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class BookerView : Form, IBookerView
    {
        public event Action CheckClientPayment;
        public event Action PayOrderProvider;
        public event Action ShowNotPaidClientOrders;
        public event Action ShowNotPaidDeliveriesFromProvider;
        public event Action Back;

        private readonly ApplicationContext _context;

        public BookerView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonExitClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonShowNotPaidDeliveriesFromProviderClick(object sender, EventArgs e)
        {
            ShowNotPaidDeliveriesFromProvider?.Invoke();
        }

        private void OnButtonPayOrderProviderClick(object sender, EventArgs e)
        {
            PayOrderProvider?.Invoke();
        }
    }
}
