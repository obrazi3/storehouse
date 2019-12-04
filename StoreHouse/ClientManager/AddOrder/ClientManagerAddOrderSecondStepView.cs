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

        private Dictionary<int, CheckBox> deleteCheckBoxes;
        private List<int> idProductsForDelete;

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


        public void SetProductBasket(List<ProductFromLot> products)
        {
            PanelListProducts.Controls.Clear();
            idProductsForDelete = new List<int>();
            deleteCheckBoxes = new Dictionary<int, CheckBox>();

            foreach (var product in products)
            {
                FlowLayoutPanel PanelCurrentProduct = new FlowLayoutPanel();
                PanelCurrentProduct.Margin = new Padding(3, 4, 3, 4);
                PanelCurrentProduct.Name = "PanelCurrentProduct";
                PanelCurrentProduct.Size = new System.Drawing.Size(760, 30);

                Label LabelNameProduct = new Label();
                LabelNameProduct.AutoSize = true;
                LabelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNameProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNameProduct.Name = "LabelNameProduct";
                LabelNameProduct.Text = "Название продукта:";
                PanelCurrentProduct.Controls.Add(LabelNameProduct);

                Label LabelNameCurrentProduct = new Label();
                LabelNameCurrentProduct.AutoSize = true;
                LabelNameCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNameCurrentProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNameCurrentProduct.Name = "LabelNameProduct";
                LabelNameCurrentProduct.Text = product.ProductName;
                PanelCurrentProduct.Controls.Add(LabelNameCurrentProduct);

                Label LabelNumberProduct = new Label();
                LabelNumberProduct.AutoSize = true;
                LabelNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNumberProduct.Name = "LabelNumberProduct";
                LabelNumberProduct.Text = "Количество продукта:";
                PanelCurrentProduct.Controls.Add(LabelNumberProduct);

                Label LabelNumberCurrentProduct = new Label();
                LabelNumberCurrentProduct.AutoSize = true;
                LabelNumberCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNumberCurrentProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNumberCurrentProduct.Name = "LabelCurrentProduct";
                LabelNumberCurrentProduct.Text = product.Lot.QuantityProduct.ToString();
                PanelCurrentProduct.Controls.Add(LabelNumberCurrentProduct);

                Label LabelCost = new Label();
                LabelCost.AutoSize = true;
                LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelCost.Name = "LabelCost";
                LabelCost.Text = "Стоимость:";
                PanelCurrentProduct.Controls.Add(LabelCost);

                Label LabelCurrentCost = new Label();
                LabelCurrentCost.AutoSize = true;
                LabelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelCurrentCost.Name = "LabelCurrentCost";
                LabelCurrentCost.Text = (product.Lot.QuantityProduct * product.Price).ToString();
                PanelCurrentProduct.Controls.Add(LabelCurrentCost);

                CheckBox checkBoxDelete = new CheckBox();
                checkBoxDelete.Text = "Удалить";
                PanelCurrentProduct.Controls.Add(checkBoxDelete);

                deleteCheckBoxes.Add(product.ProductId, checkBoxDelete);

                PanelListProducts.Controls.Add(PanelCurrentProduct);
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
            if (deleteCheckBoxes.Count != 0)

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
            return idProductsForDelete;
        }

        private void OnButtonDeleteProductsClick(object o, EventArgs e)
        {
            bool isRemoveSomething = false;
            foreach (var box in deleteCheckBoxes)
            {
                if (box.Value.Checked)
                {
                    isRemoveSomething = true;
                    idProductsForDelete.Add(box.Key);
                }
            }

            if (isRemoveSomething)
                RemoveProducts?.Invoke();
        }
    }
}
