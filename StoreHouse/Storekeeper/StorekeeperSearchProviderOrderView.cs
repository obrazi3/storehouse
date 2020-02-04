using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class StorekeeperSearchProviderOrderView : Form, IStorekeeperSearchProviderOrderView
    {
        public event Action Back;
        public event Action ConfirmGettingOrder;
        public event Action SearchOrder;

        private int _orderNumberToConfirm;
        private ApplicationContext _context;

        public StorekeeperSearchProviderOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _orderNumberToConfirm = -1;

            PanelOrderInfo.Visible = false;
            LabelOrderContent.Visible = false;
            PanelProductsInOrder.Visible = false;
        }


        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public int GetOrderNumberToSearch()
        {
            int number = Int32.Parse(TextBoxOrderNumber.Text);
            TextBoxOrderNumber.Clear();
            return number;
        }

        public int GetOrderNumberToConfirm()
        {
            int number = _orderNumberToConfirm;
            _orderNumberToConfirm = -1;
            return number;
        }

        public void SetOrder(ProductProviderOrder order)
        {
            if (order != null)
            {
                _orderNumberToConfirm = order.OrderId;
                LabelCurrentCost.Text = order.TotalSumOrder + "руб.";
                LabelCurrentNumberOrder.Text = order.OrderId.ToString();
                LabelNameCurrentOrganization.Text = order.Provider.Name;
                foreach (var prod in order.GetListProducts())
                {
                    FlowLayoutPanel panelCurrentProduct = new FlowLayoutPanel();
                    panelCurrentProduct.Margin = new Padding(3, 5, 3, 5);
                    panelCurrentProduct.Name = "PanelCurrentProduct";
                    panelCurrentProduct.Size = new Size(842, 50);

                    Label labelProductName = new Label();
                    labelProductName.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelProductName.Margin = new Padding(3, 5, 3, 0);
                    labelProductName.Name = "LabelProductName";
                    labelProductName.Size = new Size(166, 19);
                    labelProductName.Text = "Название продукта: ";
                    panelCurrentProduct.Controls.Add(labelProductName);

                    Label labelCurrentProductName = new Label();
                    labelCurrentProductName.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, 204);
                    labelCurrentProductName.Margin = new Padding(3, 5, 3, 0);
                    labelCurrentProductName.Name = "LabelCurrentProductName";
                    labelCurrentProductName.Size = new Size(656, 19);
                    labelCurrentProductName.Text = prod.ProductName;
                    panelCurrentProduct.Controls.Add(labelCurrentProductName);

                    Label labelNumberProduct = new Label();
                    labelNumberProduct.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelNumberProduct.Margin = new Padding(3, 5, 3, 0);
                    labelNumberProduct.Name = "LabelNumberProduct";
                    labelNumberProduct.Size = new Size(146, 19);
                    labelNumberProduct.Text = "Кол-во продукта:\r\n";
                    panelCurrentProduct.Controls.Add(labelNumberProduct);

                    Label labelCurrentNumberProduct = new Label();
                    labelCurrentNumberProduct.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, 204);
                    labelCurrentNumberProduct.Margin = new Padding(3, 5, 3, 0);
                    labelCurrentNumberProduct.Name = "LabelCurrentNumberProduct";
                    labelCurrentNumberProduct.Size = new Size(222, 19);
                    labelCurrentNumberProduct.Text =
                        prod.Lot.QuantityProduct + " " + prod.Measure.TypeMeasure;
                    panelCurrentProduct.Controls.Add(labelCurrentNumberProduct);

                    PanelProductsInOrder.Controls.Add(panelCurrentProduct);
                }

                PanelOrderInfo.Visible = true;
                LabelOrderContent.Visible = true;
                PanelProductsInOrder.Visible = true;
            }
            else
                MessageBox.Show(
                    "К сожалению, накладная с таким номером не найдена. Проверьте правильность ввода и повторите поиска ещё раз",
                    "Накладная отсутствует");
        }


        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonSearchClick(object o, EventArgs e)
        {
            _orderNumberToConfirm = -1;
            PanelOrderInfo.Visible = false;
            LabelOrderContent.Visible = false;
            PanelProductsInOrder.Visible = false;
            PanelProductsInOrder.Controls.Clear();
            if (TextBoxOrderNumber.Text.Length != 0)
            {
                SearchOrder?.Invoke();
            }
            else
                MessageBox.Show("Введите номер поставки, а затем осуществите поиск", "Отсутствует номер поставки");
        }

        private void OnButtonConfirmGettingOrderClick(object o, EventArgs e)
        {
            if (_orderNumberToConfirm != -1)
            {
                ConfirmGettingOrder?.Invoke();
                PanelOrderInfo.Visible = false;
                LabelOrderContent.Visible = false;
                PanelProductsInOrder.Visible = false;
                PanelProductsInOrder.Controls.Clear();
                MessageBox.Show("Приём заказа подтвержден.");
            }
        }
    }
}
