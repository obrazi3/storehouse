using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class StorekeeperSearchIncomingInvoiceView : Form, IStorekeeperSearchIncomingInvoiceView
    {
        public event Action Back;
        
        public event Action ConfirmGettingOrder;
        public event Action SearchOrder;

        private ApplicationContext _context;
        public StorekeeperSearchIncomingInvoiceView(ApplicationContext context)
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
        
        public int GetOrderNumber()
        {
            throw new NotImplementedException();
        }

        public void SetOrder(ProductProviderOrder order)
        {
            throw new NotImplementedException();
        }
        
        private void OnButtonBackClick(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnButtonSearchClick(object o, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void OnButtonConfirmGettingOrderClick(object o, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

    }
}
