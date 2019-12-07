using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class PurcpManagerInfoDificitProductsView : Form, IPurcpManagerInfoDificitProductsView
    {
        public event Action Back;

        private readonly ApplicationContext context;

        public PurcpManagerInfoDificitProductsView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public void SetInformation(List<StorehouseProduct> list)
        {
            foreach (var prod in list)
            {
                Label LabelCurrentProductNumber = new Label();
                LabelCurrentProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                LabelCurrentProductNumber.Name = "LabelCurrentProductNumber";
                LabelCurrentProductNumber.Size = new System.Drawing.Size(30, 20);
                LabelCurrentProductNumber.Text = prod.TotalQuantityProduct.ToString();

                Label LabelCurrentProductPrice = new Label();
                LabelCurrentProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                LabelCurrentProductPrice.Name = "LabelCurrentProductPrice";
                LabelCurrentProductPrice.Size = new System.Drawing.Size(100, 20);
                LabelCurrentProductPrice.Text = prod.Price.ToString() + " рубля(-ей)";

                Label LabelCurrentProductName = new Label();
                LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                LabelCurrentProductName.Name = "LabelCurrentProductName";
                LabelCurrentProductName.Size = new System.Drawing.Size(400, 20);
                LabelCurrentProductName.Text = prod.ProductGroup + " " + prod.ProductName;

                Label LabelProductNumber = new Label();
                LabelProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProductNumber.Name = "LabelProductNumber";
                LabelProductNumber.Size = new System.Drawing.Size(180, 20);
                LabelProductNumber.Text = "Количество продукта:";

                Label LabelProductPrice = new Label();
                LabelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProductPrice.Name = "LabelProductPrice";
                LabelProductPrice.Size = new System.Drawing.Size(185, 20);
                LabelProductPrice.Text = "Стоимость продукта:";

                Label LabelProductName = new Label();
                LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProductName.Name = "LabelProductName";
                LabelProductName.Size = new System.Drawing.Size(180, 20);
                LabelProductName.Text = "Название продукта:";

                FlowLayoutPanel PanelCurrentDificitProduct = new FlowLayoutPanel();
                PanelCurrentDificitProduct.Controls.Add(LabelProductName);
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductName);
                PanelCurrentDificitProduct.Controls.Add(LabelProductNumber);
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductNumber);
                PanelCurrentDificitProduct.Controls.Add(LabelProductPrice);
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductPrice);
                PanelCurrentDificitProduct.Size = new System.Drawing.Size(700, 50);

                PanelDificitProducts.Controls.Add(PanelCurrentDificitProduct);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
