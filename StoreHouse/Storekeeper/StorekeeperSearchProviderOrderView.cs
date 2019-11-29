using System;
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

        private int orderNumberToConfirm;
        private ApplicationContext _context;

        public StorekeeperSearchProviderOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            orderNumberToConfirm = -1;

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
            int number = orderNumberToConfirm;
            orderNumberToConfirm = -1;
            return number;
        }

        public void SetOrder(ProductProviderOrder order)
        {
            if (order != null)
            {
                orderNumberToConfirm = order.OrderId;
                LabelCurrentCost.Text = order.TotalSumOrder.ToString() + "руб.";
                LabelCurrentNumberOrder.Text = order.OrderId.ToString();
                LabelNameCurrentOrganization.Text = order.Provider.Name;
                foreach (var prod in order.GetListProducts())
                {
                    FlowLayoutPanel PanelCurrentProduct = new FlowLayoutPanel();
                    PanelCurrentProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
                    PanelCurrentProduct.Name = "PanelCurrentProduct";
                    PanelCurrentProduct.Size = new System.Drawing.Size(842, 50);

                    Label LabelProductName = new Label();
                    LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                    LabelProductName.Name = "LabelProductName";
                    LabelProductName.Size = new System.Drawing.Size(166, 19);
                    LabelProductName.Text = "Название продукта: ";
                    PanelCurrentProduct.Controls.Add(LabelProductName);

                    Label LabelCurrentProductName = new Label();
                    LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                    LabelCurrentProductName.Name = "LabelCurrentProductName";
                    LabelCurrentProductName.Size = new System.Drawing.Size(656, 19);
                    LabelCurrentProductName.Text = prod.ProductName;
                    PanelCurrentProduct.Controls.Add(LabelCurrentProductName);

                    Label LabelNumberProduct = new Label();
                    LabelNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                    LabelNumberProduct.Name = "LabelNumberProduct";
                    LabelNumberProduct.Size = new System.Drawing.Size(146, 19);
                    LabelNumberProduct.Text = "Кол-во продукта:\r\n";
                    PanelCurrentProduct.Controls.Add(LabelNumberProduct);

                    Label LabelCurrentNumberProduct = new Label();
                    LabelCurrentNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
                    LabelCurrentNumberProduct.Name = "LabelCurrentNumberProduct";
                    LabelCurrentNumberProduct.Size = new System.Drawing.Size(222, 19);
                    LabelCurrentNumberProduct.Text =
                        prod.Lot.QuantityProduct.ToString() + " " + prod.Measure.TypeMeasure;
                    PanelCurrentProduct.Controls.Add(LabelCurrentNumberProduct);

                    PanelProductsInOrder.Controls.Add(PanelCurrentProduct);
                }

                PanelOrderInfo.Visible = true;
                LabelOrderContent.Visible = true;
                PanelProductsInOrder.Visible = true;
            }
            else
            {
                LabelMessage.Visible = true;
                LabelMessage.Text =
                    "К сожалению, накладная с таким номером не найдена. Проверьте правильность ввода и повторите поиска ещё раз";
            }
        }


        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonSearchClick(object o, EventArgs e)
        {
            orderNumberToConfirm = -1;
            PanelOrderInfo.Visible = false;
            LabelOrderContent.Visible = false;
            PanelProductsInOrder.Visible = false;
            PanelProductsInOrder.Controls.Clear();
            LabelMessage.Visible = false;
            if (TextBoxOrderNumber.Text.Length != 0)
            {
                SearchOrder?.Invoke();
            }
            else
            {
                LabelMessage.Text = "Введите номер поставки, а затем осуществите поиск";
                LabelMessage.Visible = true;
            }
        }

        private void OnButtonConfirmGettingOrderClick(object o, EventArgs e)
        {
            if (orderNumberToConfirm != -1)
            {
                ConfirmGettingOrder?.Invoke();
                PanelOrderInfo.Visible = false;
                LabelOrderContent.Visible = false;
                PanelProductsInOrder.Visible = false;
                PanelProductsInOrder.Controls.Clear();
                LabelMessage.Visible = false;
            }
            else
            {
                LabelMessage.Text = "Отсутствует заказ для подтверждения";
                LabelMessage.Visible = true;
            }
        }
    }
}
