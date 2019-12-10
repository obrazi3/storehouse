using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class ClientManagerAddOrderSecondStepView : Form, IClientManagerAddOrderSecondStepView
    {
        public event Action AddProduct;
        public event Action ConfirmOrder;
        public event Action Back;
        public event Action RemoveProducts;

        private Dictionary<int, CheckBox> _deleteCheckBoxes;
        private List<int> _idProductsForDelete;

        private readonly ApplicationContext _context;

        public ClientManagerAddOrderSecondStepView(ApplicationContext context)
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


        public void SetFromName(string name)
        {
            this.Text = name;
        }

        public void SetProductBasket(List<ProductFromLot> products)
        {
            PanelListProducts.Controls.Clear();
            _idProductsForDelete = new List<int>();
            _deleteCheckBoxes = new Dictionary<int, CheckBox>();

            foreach (var product in products)
            {
                FlowLayoutPanel panelCurrentProduct = new FlowLayoutPanel();
                panelCurrentProduct.Margin = new Padding(3, 4, 3, 4);
                panelCurrentProduct.Name = "PanelCurrentProduct";
                panelCurrentProduct.Size = new System.Drawing.Size(760, 30);

                Label labelNameProduct = new Label();
                labelNameProduct.AutoSize = true;
                labelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelNameProduct.Margin = new Padding(3, 5, 3, 0);
                labelNameProduct.Name = "LabelNameProduct";
                labelNameProduct.Text = "Название продукта:";
                panelCurrentProduct.Controls.Add(labelNameProduct);

                Label labelNameCurrentProduct = new Label();
                labelNameCurrentProduct.AutoSize = true;
                labelNameCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelNameCurrentProduct.Margin = new Padding(3, 5, 3, 0);
                labelNameCurrentProduct.Name = "LabelNameProduct";
                labelNameCurrentProduct.Text = product.ProductName;
                panelCurrentProduct.Controls.Add(labelNameCurrentProduct);

                Label labelNumberProduct = new Label();
                labelNumberProduct.AutoSize = true;
                labelNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelNumberProduct.Margin = new Padding(3, 5, 3, 0);
                labelNumberProduct.Name = "LabelNumberProduct";
                labelNumberProduct.Text = "Количество продукта:";
                panelCurrentProduct.Controls.Add(labelNumberProduct);

                Label labelNumberCurrentProduct = new Label();
                labelNumberCurrentProduct.AutoSize = true;
                labelNumberCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelNumberCurrentProduct.Margin = new Padding(3, 5, 3, 0);
                labelNumberCurrentProduct.Name = "LabelCurrentProduct";
                labelNumberCurrentProduct.Text = product.Lot.QuantityProduct.ToString();
                panelCurrentProduct.Controls.Add(labelNumberCurrentProduct);

                Label labelCost = new Label();
                labelCost.AutoSize = true;
                labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204);
                labelCost.Margin = new Padding(3, 5, 3, 0);
                labelCost.Name = "LabelCost";
                labelCost.Text = "Стоимость:";
                panelCurrentProduct.Controls.Add(labelCost);

                Label labelCurrentCost = new Label();
                labelCurrentCost.AutoSize = true;
                labelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelCurrentCost.Margin = new Padding(3, 5, 3, 0);
                labelCurrentCost.Name = "LabelCurrentCost";
                labelCurrentCost.Text = (product.Lot.QuantityProduct * product.Price).ToString();
                panelCurrentProduct.Controls.Add(labelCurrentCost);

                CheckBox checkBoxDelete = new CheckBox();
                checkBoxDelete.Text = "Удалить";
                panelCurrentProduct.Controls.Add(checkBoxDelete);

                _deleteCheckBoxes.Add(product.ProductId, checkBoxDelete);

                PanelListProducts.Controls.Add(panelCurrentProduct);
            }
        }

        public void SetOrderPrice(int price)
        {
            LabelCurrentOrderCost.Text = price.ToString() + " рублей";
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonConfirmOrderClick(object o, EventArgs e)
        {
            if (_deleteCheckBoxes.Count != 0)

                ConfirmOrder?.Invoke();
            else
                MessageBox.Show("Нельзя оформить заказ без товара. Добавьте хотя бы один товар, а затем продолжите.",
                    "Добавьте товар");
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            AddProduct?.Invoke();
        }

        public List<int> GetIdProductsForDelete()
        {
            return _idProductsForDelete;
        }

        private void OnButtonDeleteProductsClick(object o, EventArgs e)
        {
            bool isRemoveSomething = false;
            foreach (var box in _deleteCheckBoxes)
            {
                if (box.Value.Checked)
                {
                    isRemoveSomething = true;
                    _idProductsForDelete.Add(box.Key);
                }
            }

            if (isRemoveSomething)
                RemoveProducts?.Invoke();
        }
    }
}
