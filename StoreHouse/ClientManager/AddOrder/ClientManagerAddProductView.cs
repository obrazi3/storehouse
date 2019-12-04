using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class ClientManagerAddProductView : Form, IClientManagerAddProductView
    {
        public event Action Back;
        public event Action AddProduct;

        private readonly ApplicationContext context;
        private int maxNumberOfProducts;

        public ClientManagerAddProductView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            maxNumberOfProducts = 20;
            NumericUpDownNumberProduct.Value = 0;
        }

        public int MaximumProduct { get => maxNumberOfProducts; set => maxNumberOfProducts = value; }

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
            context.MainForm = this;
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
