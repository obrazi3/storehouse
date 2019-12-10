using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class ClientManagerAddProductView : Form, IClientManagerAddProductView
    {
        public event Action Back;
        public event Action AddProduct;

        private readonly ApplicationContext _context;
        private int _maxNumberOfProducts;

        public ClientManagerAddProductView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _maxNumberOfProducts = 20;
            NumericUpDownNumberProduct.Value = 0;
        }

        public int MaximumProduct { get => _maxNumberOfProducts; set => _maxNumberOfProducts = value; }

        public void SetProductCharacteristic(ProductCharacteristic characteristic)
        {
            LabelCurrentCost.Text = characteristic.Price.ToString();
            LabelCurrentMeasure.Text = characteristic.Measure.TypeMeasure;
            LabelCurrentCountryProduction.Text = characteristic.ProduceCountry;
            LabelCurrentProductCategory.Text = characteristic.ProductCategory;
            LabelCurrentProductGroup.Text = characteristic.ProductGroup;
            LabelCurrentProductName.Text = characteristic.ProductName;
            NumericUpDownNumberProduct.Maximum = (characteristic.TotalQuantityProduct > MaximumProduct)
                ? MaximumProduct
                : characteristic.TotalQuantityProduct;
            NumericUpDownNumberProduct.Minimum = 0;
        }

        public int GetNumberOfProduct()
        {
            return (int)NumericUpDownNumberProduct.Value;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonCancelClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            if (NumericUpDownNumberProduct.Value != 0)
                AddProduct?.Invoke();
            else
                MessageBox.Show(
                    "Необходимо добавить хотя бы один продукт. Если вы не хотите добавлять продукт в заказ, нажмите кнопку \"Отмена\"" +
                    ".", "Кол-во товара не выбрано.");
        }
    }
}
