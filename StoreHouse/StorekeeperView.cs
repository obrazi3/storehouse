using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class StorekeeperView : Form, IStorekeeperView
    {
        public event Action SearchPurchInvoice;
        public event Action SearchExprenseInvoice;
        public event Action ShowListClientPurch;
        public event Action ShowListCourierPurch;

        private readonly ApplicationContext _context;
        public StorekeeperView(ApplicationContext context)
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


        private void OnButtonSearchPurchInvoiceClick(object o, EventArgs e)
        {
            SearchPurchInvoice?.Invoke();
        }

        private void OnButtonSearchExprenseInvoiceClick(object o, EventArgs e)
        {
            SearchExprenseInvoice?.Invoke();
        }

        private void OnButtonShowListClientPurchClick(object o, EventArgs e)
        {
            ShowListClientPurch?.Invoke();
        }

        private void OnButtonShowListCourierPurchClick(object o, EventArgs e)
        {
            ShowListCourierPurch?.Invoke();
        }

      
    }
}
