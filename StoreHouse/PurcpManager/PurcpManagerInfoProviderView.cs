using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class PurcpManagerInfoProviderView : Form, IPurcpManagerInfoProviderView
    {
        public event Action Back;
        public event Action SearchProvider;

        private readonly ApplicationContext _context;

        public PurcpManagerInfoProviderView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void SetInfoProvider(ProductProvider provider)
        {
            LabelMessageNotFoundProvider.Visible = false;
            //LabelMesageInputID.Visible = false;
            TextBoxIDProvider.ResetText();
            LabelCurrentEmail.ResetText();
            LabelCurrentBankAccount.ResetText();
            LabelCurrentContactNumber.ResetText();
            LabelCurrentNameOrganization.ResetText();
            PanelProductCategories.Controls.Clear();

            if (provider != null)
            {
                LabelCurrentEmail.Text = provider.Email;
                LabelCurrentBankAccount.Text = provider.BankAccountNumber;
                LabelCurrentContactNumber.Text = provider.ContactNumber;
                LabelCurrentNameOrganization.Text = provider.Name;

                foreach (var category in provider.GetListProductCategories())
                {
                    Label label = new Label();
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                    label.Margin = new Padding(3, 5, 3, 0);
                    label.Size = new System.Drawing.Size(600, 18);
                    label.Text = category;

                    PanelProductCategories.Controls.Add(label);
                }
            }
            else
                LabelMessageNotFoundProvider.Visible = true;
        }

        public int GetProviderNumber()
        {
            return Int32.Parse(TextBoxIDProvider.Text);
        }

        public void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonSearchClick(object o, EventArgs e)
        {
            if (TextBoxIDProvider.Text.Length != 0)
                SearchProvider?.Invoke();
            else
                LabelMessageNotFoundProvider.Visible = true;
        }
    }
}
