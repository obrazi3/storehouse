using System;
using System.Windows.Forms;
using Presenter;

namespace View.Storekeeper
{
    public partial class StorekeeperSearchSalesInvoiceView : Form, IBack, IStorekeeperSearchSalesInvoiceView
    {
        public event Action Back;
        public event Search Search;
        public event Action ShowInvoiceContent;
        public event Action ConfirmAdmission;

        private readonly ApplicationContext _context;

        public StorekeeperSearchSalesInvoiceView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public string GetNumberInvoice()
        {
            return TextBoxNumberInvoice.Text;
        }

        public void SetCost(string cost)
        {
            this.LabelCostSet.Text = cost;
        }

        public void SetName(string name)
        {
            this.LabelNameOrganizSet.Text = name;
        }

        public void SetNumberInvoice(string number)
        {
            this.LabelNumberSet.Text = number;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonSearchClick(object o, EventArgs e)
        {
            this.PanelNotFoundInvoice.Visible = false;
            this.PanelFoundInvoice.Visible = false;
            this.LabelNameOrganizSet.Text = " ";
            this.LabelNumberSet.Text = " ";
            this.LabelCostSet.Text = " ";
            if (Search != null && Search.Invoke())
                this.PanelFoundInvoice.Visible = true;
            else
                this.PanelNotFoundInvoice.Visible = true;
        }

        private void OnButtonShowInvcContClick(object o, EventArgs e)
        {
            ShowInvoiceContent?.Invoke();
        }

        private void OnButtonIssuanceAdmissionClick(object o, EventArgs e)
        {
            ConfirmAdmission?.Invoke();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

     
    }
}
