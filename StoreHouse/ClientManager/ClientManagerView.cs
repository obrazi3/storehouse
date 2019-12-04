using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class ClientManagerView : Form, IClientManagerView
    {
        public event Action addOrder;
        public event Action lookOrder;
        public event Action Back;

        private readonly ApplicationContext _context;
        public ClientManagerView(ApplicationContext context)
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

        private void OnButtonAddOrderClick(object sender, EventArgs e)
        {
            addOrder?.Invoke();
        }

        private void OnButtonLookOrderClick(object sender, EventArgs e)
        {
            lookOrder?.Invoke();
        }

        private void OnButtonExitClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
