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

        private readonly ApplicationContext _context;

        public PurcpManagerInfoDificitProductsView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void SetInformation(List<StorehouseProduct> list)
        {
            foreach (var prod in list)
            {
                Label labelCurrentProductNumber = new Label();
                labelCurrentProductNumber.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                labelCurrentProductNumber.Name = "LabelCurrentProductNumber";
                labelCurrentProductNumber.Size = new Size(30, 20);
                labelCurrentProductNumber.Text = prod.TotalQuantityProduct.ToString();

                Label labelCurrentProductPrice = new Label();
                labelCurrentProductPrice.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                labelCurrentProductPrice.Name = "LabelCurrentProductPrice";
                labelCurrentProductPrice.Size = new Size(100, 20);
                labelCurrentProductPrice.Text = prod.Price.ToString() + " рубля(-ей)";

                Label labelCurrentProductName = new Label();
                labelCurrentProductName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                labelCurrentProductName.Name = "LabelCurrentProductName";
                labelCurrentProductName.Size = new Size(400, 20);
                labelCurrentProductName.Text = prod.ProductGroup + " " + prod.ProductName;

                Label labelProductNumber = new Label();
                labelProductNumber.Font = new Font("Microsoft Sans Serif", 11F);
                labelProductNumber.Name = "LabelProductNumber";
                labelProductNumber.Size = new Size(180, 20);
                labelProductNumber.Text = "Количество продукта:";

                Label labelProductPrice = new Label();
                labelProductPrice.Font = new Font("Microsoft Sans Serif", 11F);
                labelProductPrice.Name = "LabelProductPrice";
                labelProductPrice.Size = new Size(185, 20);
                labelProductPrice.Text = "Стоимость продукта:";

                Label labelProductName = new Label();
                labelProductName.Font = new Font("Microsoft Sans Serif", 11F);
                labelProductName.Name = "LabelProductName";
                labelProductName.Size = new Size(180, 20);
                labelProductName.Text = "Название продукта:";

                FlowLayoutPanel panelCurrentDificitProduct = new FlowLayoutPanel();
                panelCurrentDificitProduct.Controls.Add(labelProductName);
                panelCurrentDificitProduct.Controls.Add(labelCurrentProductName);
                panelCurrentDificitProduct.Controls.Add(labelProductNumber);
                panelCurrentDificitProduct.Controls.Add(labelCurrentProductNumber);
                panelCurrentDificitProduct.Controls.Add(labelProductPrice);
                panelCurrentDificitProduct.Controls.Add(labelCurrentProductPrice);
                panelCurrentDificitProduct.Size = new Size(700, 50);

                PanelDificitProducts.Controls.Add(panelCurrentDificitProduct);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
