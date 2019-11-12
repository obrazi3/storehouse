using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class ClientManagerAddOrderSecondStepView : Form, IClientManagerAddOrderSecondStepView
    {
        public event Action AddProduct;
        public event Action Cancel;
        public event Action Back;

        private readonly ApplicationContext _context;
        public ClientManagerAddOrderSecondStepView(ApplicationContext context)
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

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonCancelClick(object o, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            AddProduct?.Invoke();
        }

    }
}
