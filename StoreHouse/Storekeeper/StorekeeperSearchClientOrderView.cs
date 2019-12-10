using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class StorekeeperSearchClientOrderView : Form, IStorekeeperSearchClientOrderView
    {
        public event Action Back;

        public event Action Search;
        public event Action ConfirmGiveOut;

        private readonly ApplicationContext _context;

        public StorekeeperSearchClientOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }


        public int GetOrderNumber()
        {
            return Int32.Parse(TextBoxOrderNumber.Text);
        }

        public void SetOrderInfo(ClientOrder order)
        {
            if (order != null)
            {
                var clientInfo = order.ClientInfo;
                LabelCurrentSurname.Text = clientInfo.Surname;
                LabelCurrentName.Text = clientInfo.Name;
                LabelCurrentPatronymic.Text = clientInfo.Patronymic;
                LabelCurrentPhoneNumber.Text = clientInfo.PhoneNumber;
                LabelCurrentOrderDate.Text = order.OrderDate.ToShortDateString();
                LabelCurrentOrderCost.Text = order.TotalCost + " рубля(-ей)";

                var products = order.GetCloneProductList();
                foreach (var product in products)
                {
                    FlowLayoutPanel panelCurrentProduct = new FlowLayoutPanel();
                    panelCurrentProduct.Name = "PanelCurrentProduct";
                    panelCurrentProduct.Size = new Size(732, 127);

                    Label labelProductGroup = new Label();
                    labelProductGroup.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, 204);
                    labelProductGroup.Margin = new Padding(4, 10, 4, 0);
                    labelProductGroup.Name = "LabelProductGroup";
                    labelProductGroup.Size = new Size(339, 24);
                    labelProductGroup.Text = "Продуктовая группа";
                    panelCurrentProduct.Controls.Add(labelProductGroup);

                    Label labelProductName = new Label();
                    labelProductName.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, 204);
                    labelProductName.Margin = new Padding(4, 10, 4, 0);
                    labelProductName.Name = "LabelProductName";
                    labelProductName.Size = new Size(373, 24);
                    labelProductName.Text = "Название продукта";
                    panelCurrentProduct.Controls.Add(labelProductName);

                    Label labelCurrentProductGroup = new Label();
                    labelCurrentProductGroup.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelCurrentProductGroup.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductGroup.Name = "LabelCurrentProductGroup";
                    labelCurrentProductGroup.Size = new Size(339, 24);
                    labelCurrentProductGroup.Text = product.ProductGroup;
                    panelCurrentProduct.Controls.Add(labelCurrentProductGroup);

                    Label labelCurrentProductName = new Label();
                    labelCurrentProductName.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelCurrentProductName.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductName.Name = "LabelCurrentProductName";
                    labelCurrentProductName.Size = new Size(372, 24);
                    labelCurrentProductName.Text = product.ProductName;
                    panelCurrentProduct.Controls.Add(labelCurrentProductName);

                    Label labelProductPrice = new Label();
                    labelProductPrice.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, ((204)));
                    labelProductPrice.Margin = new Padding(4, 10, 4, 0);
                    labelProductPrice.Name = "LabelProductPrice";
                    labelProductPrice.Size = new Size(339, 24);
                    labelProductPrice.Text = "Стоимость единицы продукта";
                    panelCurrentProduct.Controls.Add(labelProductPrice);

                    Label labelNumberOfProductInOrder = new Label();
                    labelNumberOfProductInOrder.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Regular, GraphicsUnit.Point, 204);
                    labelNumberOfProductInOrder.Margin = new Padding(4, 10, 4, 0);
                    labelNumberOfProductInOrder.Name = "LabelNumberOfProductInOrder";
                    labelNumberOfProductInOrder.Size = new Size(372, 24);
                    labelNumberOfProductInOrder.Text = "Количество продукта в заказе";
                    panelCurrentProduct.Controls.Add(labelNumberOfProductInOrder);

                    Label labelCurrentProductPrice = new Label();
                    labelCurrentProductPrice.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelCurrentProductPrice.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductPrice.Name = "LabelCurrentProductPrice";
                    labelCurrentProductPrice.Size = new Size(339, 24);
                    labelCurrentProductPrice.Text = product.Price + " рубля(-ей)";
                    panelCurrentProduct.Controls.Add(labelCurrentProductPrice);

                    Label labelCurrentNumberOfProductInOrder = new Label();
                    labelCurrentNumberOfProductInOrder.Font = new Font("Microsoft Sans Serif", 11F,
                        FontStyle.Bold, GraphicsUnit.Point, 204);
                    labelCurrentNumberOfProductInOrder.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentNumberOfProductInOrder.Name = "LabelCurrentNumberOfProductInOrder";
                    labelCurrentNumberOfProductInOrder.Size = new Size(339, 24);
                    labelCurrentNumberOfProductInOrder.Text = product.Lot.QuantityProduct.ToString();
                    panelCurrentProduct.Controls.Add(labelCurrentNumberOfProductInOrder);

                    PanelOfProducts.Controls.Add(panelCurrentProduct);
                }

                GroupBoxClientInfo.Visible = true;
                LabelListProductsInOrder.Visible = true;
                PanelOfProducts.Visible = true;
                GroupBoxGeneralOrderInfo.Visible = true;
            }
            else
                MessageBox.Show(
                    "Заказ с таким номером не был найден в базе. Проверьте правильность введённых данных повторите попытку.",
                    "Заказ не найден");
        }


        public void ClearView()
        {
            GroupBoxClientInfo.Visible = false;
            LabelListProductsInOrder.Visible = false;
            PanelOfProducts.Visible = false;
            GroupBoxGeneralOrderInfo.Visible = false;
            PanelOfProducts.Controls.Clear();
            TextBoxOrderNumber.Text="";
            MessageBox.Show("Выдача заказа подтверждена.", "Заказ выдан");
        }
        private void OnButtonSearchClientOrderClick(object o, EventArgs e)
        {
            GroupBoxClientInfo.Visible = false;
            LabelListProductsInOrder.Visible = false;
            PanelOfProducts.Visible = false;
            GroupBoxGeneralOrderInfo.Visible = false;
            PanelOfProducts.Controls.Clear();
            if (TextBoxOrderNumber.Text.Length != 0)
                Search?.Invoke();
            else
                MessageBox.Show("Введите номер заказа и осуществите поиск", "Номер заказа");
        }

        private void OnButtonConfirmGiveOutOrderClick(object o, EventArgs e)
        {
            ConfirmGiveOut?.Invoke();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
