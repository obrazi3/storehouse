using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class ClientManagerAddOrderFirstStepView : Form, IClientManagerAddOrderView
    {
        public event Action Back;
        public event Action NextStep;

        private readonly ApplicationContext _context;

        public ClientManagerAddOrderFirstStepView(ApplicationContext context)
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
        public string GetName() => this.TextBoxName.Text;
        public void SetName(string name) => this.TextBoxName.Text = String.Copy(name);
        public string GetSurname() => this.TextBoxSurname.Text;
        public void SetSurname(string surname) => this.TextBoxSurname.Text = String.Copy(surname);
        public string GetPatronymic() => this.TextBoxPatronymic.Text;
        public void SetPatronymic(string patronymic) => this.TextBoxPatronymic.Text = String.Copy(patronymic);
        public string GetCity() => this.TextBoxCity.Text;
        public void SetCity(string city) => this.TextBoxCity.Text = String.Copy(city);
        public string GetStreet() => this.TextBoxStreet.Text;
        public void SetStreet(string street) => this.TextBoxStreet.Text = String.Copy(street);
        public string GetPavilion() => this.TextBoxPavilion.Text;
        public void SetPavilion(string pavilion) => this.TextBoxPavilion.Text = String.Copy(pavilion);
        public string GetHouseNumber() => this.TextBoxHouseNumber.Text;
        public void SetHouseNumber(string houseNumber) => this.TextBoxHouseNumber.Text = String.Copy(houseNumber);
        public string GetFlat() => this.TextBoxFlat.Text;
        public void SetFlat(string flat) => this.TextBoxFlat.Text = String.Copy(flat);
        public string GetPhoneNumber() => this.TextBoxPhoneNumber.Text;
        public void SetPhoneNumber(string phoneNumber) => this.TextBoxPhoneNumber.Text = String.Copy(phoneNumber);
        public string GetEmailAddress() => this.TextBoxEmailAddress.Text;
        public void SetEmailAddress(string emailAddress) => this.TextBoxEmailAddress.Text = String.Copy(emailAddress);

        private void OnRadioButtonDeliveryClick(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = true;
        }

        private void OnRadioButtonPickupClick(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = false;
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonNextStepClick(object o, EventArgs e)
        {
            if (CheckRequiredFields())
                NextStep?.Invoke();
            else
                this.LabelMessageRequiredFields.Visible = true;
        }
        private bool CheckRequiredFields()
        {
            if (TextBoxName.Text.Length == 0) return false;
            if (TextBoxSurname.Text.Length == 0) return false;
            if (TextBoxPatronymic.Text.Length == 0) return false;
            if (TextBoxPhoneNumber.Text.LastIndexOfAny(("0123456789".ToCharArray())) == -1) return false;
            if (RadiobuttonDelivery.Checked)
            {
                if (TextBoxCity.Text.Length == 0) return false;
                if (TextBoxStreet.Text.Length == 0) return false;
                if (TextBoxHouseNumber.Text.Length == 0) return false;
                if (TextBoxPavilion.Text.Length == 0) return false;
                if (TextBoxFlat.Text.Length == 0) return false;
            }
            return true;
        }
    }
}
