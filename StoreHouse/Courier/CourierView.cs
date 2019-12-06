using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class CourierView : Form, ICourierView
    {
        public event Action GetInfoOrder;
        public event Action Back;

        private readonly ApplicationContext _context;

        public CourierView(ApplicationContext context)
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

        private void OnButtonGetOrderInfoClick(object o, EventArgs e)
        {
            GetInfoOrder?.Invoke();
        }

        private void OnButtonExitCourierClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
