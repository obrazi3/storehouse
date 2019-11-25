using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class SignInView : Form, ISignInView
    {
        public event Action OpenClientManager;
        public event Action OpenBooker;
        public event Action OpentStorekeeper;
        public event Action OpenPurcрManager;
        public event Action OpenCourier;

        private readonly ApplicationContext _context;

        public SignInView(ApplicationContext context)
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


        private void OnButtonBookerClick(object sender, EventArgs e)
        {
            OpenBooker?.Invoke();
        }

        private void OnButtonStorekeeperClick(object sender, EventArgs e)
        {
            OpentStorekeeper?.Invoke();
        }

        private void OnButtonPurcpManagerClick(object sender, EventArgs e)
        {
            OpenPurcрManager?.Invoke();
        }

        private void OnButtonClientManagerClick(object sender, EventArgs e)
        {
            OpenClientManager?.Invoke();
        }

        private void OnButtonCourierClick(object sender, EventArgs e)
        {
            OpenCourier?.Invoke();
        }
    }
}
