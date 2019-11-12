using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class CourierView : Form, ICourierView
    {
        public event Action GetInfoOrder;

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
    }
}
