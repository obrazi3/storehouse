using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class PurcpManagerInfoOrdersProdView : Form, IPurcpManagerInfoOrderProdView
    {
        public event Action Back;
        public event Action RemoveOrders;

        private Dictionary<int, CheckBox> _dictionaryCheckBoxes;

        private readonly ApplicationContext _context;

        public PurcpManagerInfoOrdersProdView(ApplicationContext context)
        {
            InitializeComponent();
            this._context = context;
            StartPosition = FormStartPosition.CenterScreen;
            _dictionaryCheckBoxes = new Dictionary<int, CheckBox>();
        }

        public void AddOrder(FlowLayoutPanel order, int orderNumber, CheckBox box)
        {
            this.PanelOrdersInfo.Controls.Add(order);
            _dictionaryCheckBoxes.Add(orderNumber, box);
        }

        public void AddOrders(List<ProductProviderOrder> listNotPaidOrders)
        {
            PanelOrdersInfo.Controls.Clear();
            _dictionaryCheckBoxes.Clear();
            foreach (var order in listNotPaidOrders)
            {
                FlowLayoutPanel panelCurrentOrder = new FlowLayoutPanel();
                panelCurrentOrder.Size = new Size(800, 100);
                panelCurrentOrder.MaximumSize = panelCurrentOrder.Size;
                panelCurrentOrder.MinimumSize = panelCurrentOrder.Size;
                //panelCurrentOrder.TabIndex = 8;
                //panelCurrentOrder.ResumeLayout(false);

                Label labelOrganizationName = new Label();
                labelOrganizationName.Font =
                    new Font("Times New Roman", 11F, FontStyle.Bold);
                labelOrganizationName.Margin = new Padding(3, 3, 0, 3);
                labelOrganizationName.Size = new Size(178, 18);
                labelOrganizationName.Text = "Название организации:";
                panelCurrentOrder.Controls.Add(labelOrganizationName);

                Label labelCurrentOrganizationName = new Label();
                labelCurrentOrganizationName.Font = new Font("Times New Roman", 11F);
                labelCurrentOrganizationName.Margin = new Padding(0, 3, 3, 3);
                labelCurrentOrganizationName.Size = new Size(600, 18);
                labelCurrentOrganizationName.Text = order.Provider.Name;
                panelCurrentOrder.Controls.Add(labelCurrentOrganizationName);

                Label labelOrderNumber = new Label();
                labelOrderNumber.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
                labelOrderNumber.Margin = new Padding(3, 3, 0, 3);
                labelOrderNumber.Size = new Size(110, 18);
                labelOrderNumber.TabIndex = 2;
                labelOrderNumber.Text = "Номер заказа:";
                panelCurrentOrder.Controls.Add(labelOrderNumber);

                Label labelCurrentOrderNumber = new Label();
                labelCurrentOrderNumber.Font = new Font("Times New Roman", 11F);
                labelCurrentOrderNumber.Margin = new Padding(0, 3, 3, 3);
                labelCurrentOrderNumber.Size = new Size(70, 18);
                labelCurrentOrderNumber.TabIndex = 3;
                labelCurrentOrderNumber.Text = order.OrderId.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentOrderNumber);

                Label labelSum = new Label();
                labelSum.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
                labelSum.Margin = new Padding(3, 3, 0, 3);
                labelSum.Size = new Size(58, 18);
                labelSum.TabIndex = 4;
                labelSum.Text = "Сумма:";
                panelCurrentOrder.Controls.Add(labelSum);

                Label labelCurrentSum = new Label();
                labelCurrentSum.Font = new Font("Times New Roman", 11F);
                labelCurrentSum.Margin = new Padding(0, 3, 3, 3);
                labelCurrentSum.Size = new Size(117, 18);
                labelCurrentSum.TabIndex = 5;
                labelCurrentSum.Text = order.TotalSumOrder.ToString() + " рублей(-я)";
                panelCurrentOrder.Controls.Add(labelCurrentSum);

                Label labelDate = new Label();
                labelDate.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
                labelDate.Margin = new Padding(3, 3, 0, 3);
                labelDate.Size = new Size(92, 18);
                labelDate.TabIndex = 6;
                labelDate.Text = "Дата заказа:";
                panelCurrentOrder.Controls.Add(labelDate);

                Label labelCurrentDate = new Label();
                labelCurrentDate.Font = new Font("Times New Roman", 11F);
                labelCurrentDate.Margin = new Padding(0, 3, 3, 3);
                labelCurrentDate.Size = new Size(250, 18);
                labelCurrentDate.TabIndex = 7;
                labelCurrentDate.Text = order.OrderDate.ToShortDateString();
                panelCurrentOrder.Controls.Add(labelCurrentDate);

                Label labelContent = new Label();
                labelContent.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
                labelContent.Margin = new Padding(3, 3, 0, 3);
                labelContent.Size = new Size(110, 18);
                labelContent.TabIndex = 8;
                labelContent.Text = "Содержимое:";
                panelCurrentOrder.Controls.Add(labelContent);

                Label labelCurrentContent = new Label();
                labelCurrentContent.Font = new Font("Times New Roman", 11F);
                labelCurrentContent.Margin = new Padding(0, 3, 3, 3);
                labelCurrentContent.Size = new Size(680, 18);
                labelCurrentContent.TabIndex = 9;
                AddThreeProduct(labelCurrentContent, order);
                panelCurrentOrder.Controls.Add(labelCurrentContent);

                CheckBox checkBoxRemove = new CheckBox();
                checkBoxRemove.Size = new Size(82, 18);
                checkBoxRemove.TabIndex = 10;
                checkBoxRemove.Text = "Удалить";
                checkBoxRemove.UseVisualStyleBackColor = true;
                panelCurrentOrder.Controls.Add(checkBoxRemove);

                _dictionaryCheckBoxes.Add(order.OrderId, checkBoxRemove);

                PanelOrdersInfo.Controls.Add(panelCurrentOrder);
            }
        }

        public Dictionary<int, CheckBox> GetDictionaryBoxes()
        {
            return _dictionaryCheckBoxes;
        }

        public void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonRemoveOrdersClick(object o, EventArgs e)
        {
            RemoveOrders?.Invoke();
        }

        private void AddThreeProduct(Label label, ProductProviderOrder order)
        {
            int i = 0;
            var listProd = order.GetListProducts();
            while (i < 3 && i < listProd.Count)
            {
                label.Text += listProd[i].ProductName + " - " + listProd[i].Lot.QuantityProduct + " " +
                              listProd[i].Measure.TypeMeasure;
                if (i == 2 || i + 1 == listProd.Count)
                    label.Text += ".";
                else
                {
                    label.Text += ", ";
                }

                i++;
            }
        }
    }
}
