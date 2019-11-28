using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerAddOrderFirstStepView : Form, IPurcpManagerAddOrderFirstStepView
    {
        private ApplicationContext context;
        public event Action Back;
        public event Action NextStep;

        public PurcpManagerAddOrderFirstStepView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public string OrganizationName { get => TextBoxOrganizationName.Text; set => TextBoxOrganizationName.Text = value; }
        public string BankAccount { get => TextBoxBankAccount.Text; set => TextBoxBankAccount.Text = value; }
        public string ContactNumber { get => TextBoxPhoneNumber.Text; set => TextBoxPhoneNumber.Text = value; }
        public string Email { get => TextBoxEmail.Text; set => TextBoxEmail.Text = value; }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        private void OnButtonClickBack(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonClickNextStep(object o, EventArgs e)
        {
            LabelMessageRequiredFields.Visible = false;
            if (CheckRequiredFields())
                NextStep?.Invoke();
            else
                LabelMessageRequiredFields.Visible = true;
        }

        private bool CheckRequiredFields()
        {
            if (TextBoxEmail.Text.Length != 0 && TextBoxBankAccount.Text.Length != 0 &&
                TextBoxOrganizationName.Text.Length != 0 && TextBoxPhoneNumber.Text.Length != 0)
                return true;

            return false;
        }


    }
}
