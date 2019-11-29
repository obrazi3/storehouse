using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class CourierGetClientOrderView : Form, ICourierGetOrderView
    {
        public event Action ConfirmDelivery;
        public event Action InspectOrder;
        public event Action Back;

        private readonly ApplicationContext _context;

        public CourierGetClientOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string Initials { set => LabelCurrentInitials.Text = value; }
        public string Address { set => LabelCurrentAddress.Text = value; }
        public string PhoneNumber { set => LabelCurrentMobilePhone.Text = value; }
        public string Sum { set => LabelCurrentSum.Text = value; }
        public string OrderNumber { get => LabelCurrentOrderNumber.Text; set => LabelCurrentOrderNumber.Text = value; }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonCancelOrderClick(object o, EventArgs e) { Back?.Invoke(); }
        private void OnButtonConfirmDeliveryClick(object o, EventArgs e) { ConfirmDelivery?.Invoke(); }
        private void OnButtonInspectOrderClick(object o, EventArgs e) { InspectOrder?.Invoke(); }
        
    }
}
