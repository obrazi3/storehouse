using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerRemoveProviderView : Form, IPurcpManagerRemoveProviderView
    {
        public event Action Back;
        public event Action RemoveProvider;

        private readonly ApplicationContext _context;

        public PurcpManagerRemoveProviderView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        public int GetProviderId()
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

        private void OnButtonRemoveProviderClick(object o, EventArgs e)
        {
            LabelMessageRequiredFields.Visible = false;

            if (TextBoxIDProvider.Text.Length != 0)
                RemoveProvider?.Invoke();
            else
                LabelMessageRequiredFields.Visible = true;
        }
    }
}
