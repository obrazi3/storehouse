using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class StorekeeperView : Form, IStorekeeperView
    {
        public event Action SearchClientOrder;
        public event Action SearchProviderOrder;
        public event Action ShowListClientPurch;
        public event Action ShowListCourierPurch;
        public event Action Back;

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


        private void OnButtonSearchClientOrderClick(object o, EventArgs e)
        {
            SearchClientOrder?.Invoke();
        }

        private void OnButtonSearchProviderOrderClick(object o, EventArgs e)
        {
            SearchProviderOrder?.Invoke();
        }

        private void OnButtonShowListClientPurchClick(object o, EventArgs e)
        {
            ShowListClientPurch?.Invoke();
        }

        private void OnButtonShowListCourierPurchClick(object o, EventArgs e)
        {
            ShowListCourierPurch?.Invoke();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
