using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerAddProviderView : Form, IPurcpManagerAddProviderView
    {
        public event Action Back;
        public event Action AddProvider;

        private List<string> productCategories;
        private readonly ApplicationContext context;

        public PurcpManagerAddProviderView(ApplicationContext _context)
        {
            productCategories = new List<string>();
            InitializeComponent();
            context = _context;
        }

        public List<string> GetListProductCategories()
        {
            return productCategories;
        }

        public string ProviderName { get => TextBoxOrganizationName.Text; }
        public string Email { get => TextBoxEmail.Text; }
        public string BankAccount { get => TextBoxBankAccount.Text; }
        public string PhoneNumber { get => TextBoxPhoneNumber.Text; }

        public new void Show()
        {
            context.MainForm = this;
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonAddCategoryClick(object o, EventArgs e)
        {
            LabelMessageRequiredFields.Visible = false;
            if (TextBoxCategory.Text.Length != 0)
            {
                productCategories.Add((string)TextBoxCategory.Text.Clone());
                TextBoxCategory.Clear();
            }
            else
                LabelMessageRequiredFields.Visible = true;
        }

        private void OnButtonAddProviderClick(object o, EventArgs e)
        {
            LabelMessageRequiredFields.Visible = false;
            if (CheckFields())
            {
                AddProvider?.Invoke();
            }

            LabelMessageRequiredFields.Visible = false;
        }

        private bool CheckFields()
        {
            if (TextBoxEmail.Text.Length == 0)
                return false;
            if (TextBoxBankAccount.Text.Length == 0)
                return false;
            if (TextBoxOrganizationName.Text.Length == 0)
                return false;
            if (TextBoxPhoneNumber.Text.Length == 0)
                return false;
            if (productCategories.Count == 0)
                return false;

            return true;
        }
    }
}
