using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class ClientManagerAddOrderFirstStepView : Form, IClientManagerAddOrderFirstStepView
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

        public void SetName(string name) => this.TextBoxName.Text = (string)name.Clone();

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

        public string GetEmailAddress()
        {
            if (TextBoxEmailAddress.Text.Length == 0)
                return "";
            return TextBoxEmailAddress.Text;
        }

        public void SetEmailAddress(string emailAddress) => this.TextBoxEmailAddress.Text = String.Copy(emailAddress);

        public string GetFloorNumber() => this.TextBoxFloor.Text;

        public void SetFloorNumber(string floorNumber) => this.TextBoxFloor.Text = floorNumber;

        public string GetPorchNumber() => this.TextBoxPorch.Text;

        public void SetPorchNumber(string porchNumber) => this.TextBoxPorch.Text = porchNumber;

        public bool IsDelivery()
        {
            return this.GroupBoxHomeAddress.Visible;
        }

        public void SetDelivery(bool isDelivery)
        {
            this.GroupBoxHomeAddress.Visible = isDelivery;
        }


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
        }
        private bool CheckRequiredFields()
        {
            if (TextBoxName.Text.Length == 0)
            {
                MessageBox.Show("Введите ваше имя.", "Имя");
                return false;
            }

            if (TextBoxSurname.Text.Length == 0)
            {
                MessageBox.Show("Введите вашу фамилию.", "Фамилия");
                return false;
            }

            if (TextBoxPatronymic.Text.Length == 0)
            {
                MessageBox.Show("Введите ваше отчество.", "Отчество");
                return false;
            }

            if (TextBoxPhoneNumber.Text.LastIndexOfAny(("0123456789".ToCharArray())) == -1)
            {
                MessageBox.Show("Введите ваш мобильный номер.", "Мобильный номер");
                return false;
            }
            if(TextBoxPhoneNumber.Text.Length!=14)
            {
                MessageBox.Show("Мобильный номер введён не полностью", "Мобильный номер");
                return false;
            }

            if(TextBoxEmailAddress.Text.Length!=0 && !TextBoxEmailAddress.Text.Contains("@"))
            {
                MessageBox.Show("Некорректный адрес электронной почты. Исправьте введённые данные и повторите попытку.", "Электронная почта");
                return false;
            }

            if (RadiobuttonDelivery.Checked)
            {
                if (TextBoxCity.Text.Length == 0)
                {
                    MessageBox.Show("Введите ваш город.", "Город");
                    return false;
                }

                if (TextBoxStreet.Text.Length == 0)
                {
                    MessageBox.Show("Введите вашу улицу.", "Улица");
                    return false;
                }

                if (TextBoxHouseNumber.Text.Length == 0)
                {
                    MessageBox.Show("Введите номер вашего дома.", "Номер дома");
                    return false;
                }
                if (TextBoxPavilion.Text.Length == 0)
                {
                    MessageBox.Show("Введите номер корпуса. Если в вашем доме отсутствует корпус, то введите 0.", "Корпус");
                    return false;
                }

                if (TextBoxPorch.Text.Length == 0)
                {
                    MessageBox.Show("Введите номер подъезда. Если в вашем доме отсутсвует номер подъезда, то введите 0.", "Номер подъезда");
                    return false;
                }

                if (TextBoxFloor.Text.Length == 0)
                {
                    MessageBox.Show("Введите номер этажа. Если в вашем доме один этаж, то введите 0.", "Номер этажа");
                    return false;
                }

                if (TextBoxFlat.Text.Length == 0)
                {
                    MessageBox.Show("Введите номер вашей квартиры.", "Номер квартиры");
                    return false;
                }
            }
            return true;
        }


    }
}
