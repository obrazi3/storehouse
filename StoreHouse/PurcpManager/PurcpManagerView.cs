using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerView : Form, IPurcpManagerView
    {
        public event Action ViewInfoOrderProd;
        public event Action AddOrder;
        public event Action ViewInfoProvider;
        public event Action AddProvider;
        public event Action RemoveProvider;
        public event Action ViewInfoEndedProd;
        public event Action Back;

        private readonly ApplicationContext _context;

        public PurcpManagerView(ApplicationContext context)
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

        private void OnButtonViewInfoOrderProdClick(object o, EventArgs e)
        {
            ViewInfoOrderProd?.Invoke();
        }

        private void OnButtonAddOrderClick(object o, EventArgs e)
        {
            AddOrder?.Invoke();
        }

        private void OnButtonViewInfoProviderClick(object o, EventArgs e)
        {
            ViewInfoProvider?.Invoke();
        }

        private void OnButtonAddProviderClick(object o, EventArgs e)
        {
            AddProvider?.Invoke();
        }

        private void OnButtonRemoveProviderClick(object o, EventArgs e)
        {
            RemoveProvider?.Invoke();
        }

        private void OnButtonViewInfoEndedProdClick(object o, EventArgs e)
        {
            ViewInfoEndedProd?.Invoke();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

    }
}
