﻿using System;
using System.Collections.Generic;
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
                LabelCurrentProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentProductNumber.Name = "LabelCurrentProductNumber";
                LabelCurrentProductNumber.Size = new System.Drawing.Size(675, 18);
                LabelCurrentProductNumber.Text = prod.TotalQuantityProduct.ToString();

                Label LabelCurrentProductPrice = new Label();
                LabelCurrentProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentProductPrice.Name = "LabelCurrentProviderName";
                LabelCurrentProductPrice.Size = new System.Drawing.Size(675, 18);
                LabelCurrentProductPrice.Text = prod.Price.ToString();

                Label LabelCurrentProductName = new Label();
                LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentProductName.Name = "LabelCurrentProductName";
                LabelCurrentProductName.Size = new System.Drawing.Size(675, 18);
                LabelCurrentProductName.Text = prod.ProductName;

                Label LabelProductNumber = new Label();
                LabelProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProductNumber.Name = "LabelProductNumber";
                LabelProductNumber.Size = new System.Drawing.Size(178, 20);
                LabelProductNumber.Text = "Количество продукта:";

                Label LabelProviderName = new Label();
                LabelProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProviderName.Name = "LabelProductPrice";
                LabelProviderName.Size = new System.Drawing.Size(185, 20);
                LabelProviderName.Text = "Стоимость продукта:";

                Label LabelProductName = new Label();
                LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelProductName.Name = "LabelProductName";
                LabelProductName.Size = new System.Drawing.Size(148, 20);
                LabelProductName.Text = "Название продукта:";

                FlowLayoutPanel PanelCurrentDificitProduct = new FlowLayoutPanel();
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductNumber);
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductPrice);
                PanelCurrentDificitProduct.Controls.Add(LabelCurrentProductName);
                PanelCurrentDificitProduct.Controls.Add(LabelProductNumber);
                PanelCurrentDificitProduct.Controls.Add(LabelProviderName);
                PanelCurrentDificitProduct.Controls.Add(LabelProductName);
                PanelCurrentDificitProduct.SuspendLayout();
                PanelCurrentDificitProduct.Size = new System.Drawing.Size(892, 90);

                PanelDificitProducts.Controls.Add(PanelCurrentDificitProduct);
                
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}