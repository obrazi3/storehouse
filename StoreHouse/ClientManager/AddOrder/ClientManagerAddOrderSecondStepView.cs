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

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonConfirmOrderClick(object o, EventArgs e)
        {
            ConfirmOrder?.Invoke();
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            AddProduct?.Invoke();
        }

        public void SetProductBasket(List<ProductFromLot> products)
        {
            PanelListProducts.Controls.Clear();

            foreach (var product in products)
            {

                FlowLayoutPanel PanelCurrentProduct = new FlowLayoutPanel();
                PanelCurrentProduct.Margin = new Padding(3, 4, 3, 4);
                PanelCurrentProduct.Name = "PanelCurrentProduct";
                PanelCurrentProduct.Size = new System.Drawing.Size(760, 100);

                Label LabelNameProduct = new Label();
                LabelNameProduct.AutoSize = true;
                LabelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNameProduct.Size = new System.Drawing.Size(743, 22);
                LabelNameProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNameProduct.Name = "LabelNameProduct";
                LabelNameProduct.Text = product.ProductName;
                PanelCurrentProduct.Controls.Add(LabelNameProduct);

                Label LabelNumberProduct = new Label();
                LabelNumberProduct.AutoSize = true;
                LabelNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNumberProduct.Size = new System.Drawing.Size(220, 22);
                LabelNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNumberProduct.Name = "LabelNumberProduct";
                LabelNumberProduct.Text = "Количество продукта:";
                PanelCurrentProduct.Controls.Add(LabelNumberProduct);

                Label LabelNumberCurrentProduct = new Label();
                LabelNumberCurrentProduct.AutoSize = true;
                LabelNumberCurrentProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelNumberCurrentProduct.Size = new System.Drawing.Size(517, 22);
                LabelNumberCurrentProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelNumberCurrentProduct.Name = "LabelCurrentProduct";
                LabelNumberCurrentProduct.Text = product.Lot.QuantityProduct.ToString();
                PanelCurrentProduct.Controls.Add(LabelNumberCurrentProduct);

                Label LabelCost = new Label();
                LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelCost.Name = "LabelCost";
                LabelCost.Size = new System.Drawing.Size(117, 22);
                LabelCost.Text = "Стоимость:";
                PanelCurrentProduct.Controls.Add(LabelCost);

                Label LabelCurrentCost = new Label();
                LabelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                LabelCurrentCost.Name = "LabelCurrentCost";
                LabelCurrentCost.Size = new System.Drawing.Size(620, 22);
                LabelCurrentCost.Text = (product.Lot.QuantityProduct * product.Price).ToString();
                PanelCurrentProduct.Controls.Add(LabelCurrentCost);

                PanelListProducts.Controls.Add(PanelCurrentProduct);

            }



            //throw new NotImplementedException();
        }

        public void SetOrderPrice(int price)
        {
            LabelCurrentOrderCost.Text = price.ToString() + " рублей";
        }
    }
}
