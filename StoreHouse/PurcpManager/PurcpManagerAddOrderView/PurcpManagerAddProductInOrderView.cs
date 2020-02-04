using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class PurcpManagerAddProductInOrderView : Form, IPurcpManagerAddProductInOrderView
    {
        public event Action Back;
        public event Action AddProduct;
        private readonly ApplicationContext _context;


        public PurcpManagerAddProductInOrderView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public string ProductName { get => TextBoxProductName.Text; }
        public string ProductCategory { get => TextBoxProductCategory.Text; }
        public string ProductGroup { get => TextBoxProductGroup.Text; }
        public Measure Measure { get => GetMeasure(); }
        public int ExpirationDate { get => Int32.Parse(TextBoxExpirationDate.Text); }
        public int Price { get => Int32.Parse(TextBoxProductCost.Text); }
        public string ProduceCountry { get => TextBoxCountryProduction.Text; }
        public DateTime ProductionDate { get => GetProductionDate(); }
        public int QuantityProduct { get => Int32.Parse(TextBoxNumberOfProduct.Text); }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            LabelMessageRequiredFields.Visible = false;
            if (CheckFields())
                AddProduct?.Invoke();
            LabelMessageRequiredFields.Visible = true;
        }

        private Measure GetMeasure()
        {
            int idItem = CheckBoxMeasure.SelectedIndex;
            string measure = (string)CheckBoxMeasure.Items[idItem];
            switch (measure)
            {
                case "Литры":
                    return new MeasureLiter();
                case "Килограммы":
                    return new MeasureKilogram();
                case "Штуки":
                    return new MeasurePiece();
                default:
                    return new MeasurePiece();
            }
        }

        private DateTime GetProductionDate()
        {
            string date = TextBoxProductionDate.Text;
            string[] digits = date.Split('.');
            int day = Int32.Parse(digits[0]);
            int month = Int32.Parse(digits[1]);
            int year = Int32.Parse(digits[2]);
            return new DateTime(year, month, day);
        }

        private bool CheckFields()
        {
            if (TextBoxProductionDate.Text.Length == 0)
                return false;
            if (TextBoxCountryProduction.Text.Length == 0)
                return false;
            if (TextBoxExpirationDate.Text.Length == 0)
                return false;
            if (TextBoxProductCategory.Text.Length == 0)
                return false;
            if (TextBoxProductCost.Text.Length == 0)
                return false;
            if (TextBoxProductGroup.Text.Length == 0)
                return false;
            if (TextBoxProductName.Text.Length == 0)
                return false;
            if (TextBoxNumberOfProduct.Text.Length == 0)
                return false;
            if (CheckBoxMeasure.SelectedIndex == -1)
                return false; 

            return true;
        }
    }
}
