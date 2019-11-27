using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class PurcpManagerInfoProviderView : Form, IPurcpManagerInfoProviderView
    {
        public event Action Back;
        public event Action SearchProvider;

        private readonly ApplicationContext context;
        private List<Label> listProductLabels;

        public PurcpManagerInfoProviderView(ApplicationContext _context)
        {
            listProductLabels = new List<Label>();
            context = _context;
            InitializeComponent();
        }

        public void SetInfoProvider(ProductProvider provider)
        {
            LabelCurrentEmail.Text = provider.Email;
            LabelCurrentBankAccount.Text = provider.BankAccountNumber;
            LabelCurrentContactNumber.Text = provider.ContactNumber;
            LabelCurrentNameOrganization.Text = provider.Name;
            
            throw new System.NotImplementedException();
            foreach (var category in provider.GetListProductCategories())
            {
                Label label = new Label();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                label.Size = new System.Drawing.Size(892, 18);
                label.Text = category;
                
                PanelProductCategories.Controls.Add(label);
            }
        }

        public int GetProviderNumber()
        {
            return Int32.Parse(TextBoxIDProvider.Text);
        }

        public void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtuonSearchClick(object o, EventArgs e)
        {
            throw new System.NotImplementedException();
            if (TextBoxIDProvider.Text.Length != 0)
                SearchProvider?.Invoke();
            else
                LabelMesageInputID.Visible = true;
        }
    }
}
